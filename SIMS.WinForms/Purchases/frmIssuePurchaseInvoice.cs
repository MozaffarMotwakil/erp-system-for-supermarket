using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using BusinessLogic.Interfaces;
using BusinessLogic.Invoices;
using BusinessLogic.Products;
using BusinessLogic.Suppliers;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Invoices;
using SIMS.WinForms.Suppliers;

namespace SIMS.WinForms.Inventory
{
    public partial class frmIssuePurchaseInvoice : frmBaseIssueInvoice
    {
        public frmIssuePurchaseInvoice() : base(enInvoiceType.Purchase)
        {
            InitializeComponent();
        }

        private void frmIssuePurchaseInvoice_Load_Local(object sender, EventArgs e)
        {
            clsSupplierService.CreateInstance().EntitySaved += clsSupplier_SupplierSaved;

            cbParty.DataSource = clsSupplierService.GetActiveSuppliersList();
            cbParty.DisplayMember = "SupplierName";
            cbParty.ValueMember = "SupplierID";
            cbParty.SelectedItem = null;
            cbParty.Text = "إختار المورد";

            txtInvoiceNo.Validating += txtInvoiceNo_Validating;
            cbParty.Validating += cbSupplier_Validating;
            cbParty.Enter += cbSupplier_Enter;
            cbParty.Leave += cbSupplier_Leave;
        }

        protected override clsInvoice GetInvoiceInctance()
        {
            return new clsPurchaseInvoice(
                txtInvoiceNo.Text,
                dtpInvoiceIssueDate.Value,
                base.GetInvoiceStatus(),
                base.GetInvoiceLinesFromDGV(),
                (int)cbParty.SelectedValue,
                (int)cbWarehouse.SelectedValue,
                base.GetPaymentMethod(),
                base.GetPaymentAmount()
            );
        }

        private void cbSupplier_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsFormValidation.ValidatingRequiredField(cbParty, errorProvider, "يجب تعيين مورد للفاتورة");
        }

        private void txtInvoiceNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsFormValidation.ValidatingRequiredField(txtInvoiceNo, errorProvider, "لا يمكن أن يكون حقل رقم الفاتورة فارغا");
        }

        private void cbSupplier_Enter(object sender, EventArgs e)
        {
            if (cbParty.SelectedIndex == -1)
            {
                cbParty.Text = string.Empty;
            }
        }

        private void cbSupplier_Leave(object sender, EventArgs e)
        {
            if (cbParty.SelectedIndex == -1)
            {
                cbParty.Text = "إختار المورد";
            }
        }

        private void llAddPersonSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditSupplier addPersonSupplier = new frmAddEditSupplier(BusinessLogic.Parties.clsParty.enPartyCategory.Person);
            addPersonSupplier.ShowDialog();
            cbParty.Focus();
            llAddPersonSupplier.Focus();
        }

        private void llAddOrganizationSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditSupplier addEditOrganizationSupplier = new frmAddEditSupplier(BusinessLogic.Parties.clsParty.enPartyCategory.Organization);
            addEditOrganizationSupplier.ShowDialog();
            cbParty.Focus();
            llAddOrganizationSupplier.Focus();
        }

        private void clsSupplier_SupplierSaved(object sender, EntitySavedEventArgs e)
        {
            cbParty.DataSource = clsSupplierService.GetSuppliersList();
            cbParty.DisplayMember = "SupplierName";
            cbParty.ValueMember = "SupplierID";
            cbParty.SelectedItem = e.EntityName;
        }

        protected override void dgvInvoiceLines_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            base.dgvInvoiceLines_CellBeginEdit(sender, e);
            DataTable activeProducts = clsProductService.GetActiveProductsList();

            if (e.ColumnIndex == colProduct.Index)
            {
                DataGridViewComboBoxCell boxCell = dgvInvoiceLines.CurrentCell as DataGridViewComboBoxCell;

                boxCell.DataSource = activeProducts
                    .AsEnumerable()
                    .Where(
                        product =>
                        !SelectedProductIDsWithoutUnit.Contains(product.Field<int>("ProductID")) &&
                        (!SelectedProductIDs.Contains(product.Field<int>("ProductID")) ||
                        GetSelectedProductUnitIDs(product.Field<int>("ProductID")).Count !=
                        clsProductService.CreateInstance().Find(product.Field<int>("ProductID")).AllUnits.Count)
                    )
                    .OrderBy(product => product.Field<string>("ProductName"))
                    .CopyToDataTable();

                colProduct.DisplayMember = "ProductName";
                colProduct.ValueMember = "ProductID";
            }

            if (e.ColumnIndex == colUnit.Index && CurrentLine != null && CurrentLine.ProductID.HasValue)
            {
                DataGridViewComboBoxCell boxCell = dgvInvoiceLines.CurrentCell as DataGridViewComboBoxCell;

                List<clsUnit> productUnits = new List<clsUnit>();

                boxCell.DataSource = CurrentLine.ProductInfo.AllUnits
                    .Where(
                        unit =>
                        !GetSelectedProductUnitIDs(CurrentLine.ProductID.GetValueOrDefault())
                            .Contains(unit.UnitID)
                    )
                    .ToList();

                colUnit.DisplayMember = "UnitName";
                colUnit.ValueMember = "UnitID";
            }
        }

        protected override void dgvInvoiceLines_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (CurrentLine == null)
            {
                return;
            }

            ApplyEditOnDGV(e.RowIndex);
            base.UpdateInvoiceSummary();
        }

        protected override void dgvInvoiceLines_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            ErrorColumnIndex = e.ColumnIndex;

            if (e.ColumnIndex == colProduct.Index)
            {
                if (IsCurrentCellEmpty() && IsCurrentRowHasData())
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = "يجب إختيار منتج";
                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = string.Empty;
                }
            }

            if (e.ColumnIndex == colUnit.Index)
            {
                if (IsCurrentCellEmpty() && IsCurrentRowHasData())
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = "يجب إختيار وحدة";
                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = string.Empty;
                }
            }

            if (e.ColumnIndex == colQuantity.Index)
            {
                if (IsCurrentCellEmpty() && IsCurrentRowHasData())
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = "لا يمكن أن يكون حقل الكمية فارغاً";
                    SystemSounds.Asterisk.Play();
                }
                else if ((!IsCurrentCellEmpty()) && (!int.TryParse(GetEditedValue()?.ToString(), out int quantity) || quantity < 1))
                {
                    e.Cancel = true;
                    dgvInvoiceLines.CurrentRow.ErrorText = "يجب أن تكون الكمية رقماً صحيحاً أكبر من صفر";
                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = string.Empty;
                }
            }

            if (e.ColumnIndex == colUnitPrice.Index)
            {
                if (IsCurrentCellEmpty() && IsCurrentRowHasData())
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = "لا يمكن أن يكون حقل سعر شراء الوحدة فارغاً";
                    SystemSounds.Asterisk.Play();
                }
                else if (!decimal.TryParse(GetEditedValue()?.ToString(), out decimal unitPrice) && !IsCurrentCellEmpty())
                {
                    e.Cancel = true;
                    dgvInvoiceLines.CurrentRow.ErrorText = "يجب إدخال قيمة رقمية صحيحة أو عشرية لسعر شراء الوحدة";
                    SystemSounds.Asterisk.Play();
                }
                else if (unitPrice < 1 && !IsCurrentCellEmpty())
                {
                    e.Cancel = true;
                    dgvInvoiceLines.CurrentRow.ErrorText = "يجب أن يكون سعر شراء الوحدة أكبر من صفر";
                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = string.Empty;
                }
            }

            if (e.ColumnIndex == colDiscountRate.Index || e.ColumnIndex == colDiscountAmount.Index)
            {
                if (IsCurrentCellEmpty() && IsCurrentRowHasData())
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = "لا يمكن أن يكون حقل قيمة الخصم أو نسبة الخصم فارغاً";
                    SystemSounds.Asterisk.Play();
                }
                else if ((!(decimal.TryParse(GetEditedValue()?.ToString(), out decimal discount) && discount >= 0)) && !IsCurrentCellEmpty())
                {
                    e.Cancel = true;
                    dgvInvoiceLines.CurrentRow.ErrorText = "يجب أن تكون نسبة الخصم أو مبلغ الخصم رقم موجب صحيح";
                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = string.Empty;
                }
            }

            if (e.ColumnIndex == colTaxRate.Index || e.ColumnIndex == colTaxAmount.Index)
            {
                if (IsCurrentCellEmpty() && IsCurrentRowHasData())
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = "لا يمكن أن يكون حقل قيمة الضريبة أو نسبة الضريبة فارغاً";
                    SystemSounds.Asterisk.Play();
                }
                else if (!IsCurrentCellEmpty() && (!(decimal.TryParse(GetEditedValue()?.ToString(), out decimal tax) && tax >= 0)))
                {
                    e.Cancel = true;
                    dgvInvoiceLines.CurrentRow.ErrorText = "يجب أن تكون نسبة الضريبة أو مبلغ الضريبة رقم موجب صحيح";
                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    dgvInvoiceLines.CurrentRow.ErrorText = string.Empty;
                }
            }
        }

    }
}