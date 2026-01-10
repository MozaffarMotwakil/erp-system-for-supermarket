using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using BusinessLogic.Invoices;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Invoices;

namespace SIMS.WinForms.Sales
{
    public partial class frmIssueSaleReturnInvoice : frmBaseIssueInvoice
    {
        private clsSaleInvoice _OrginalInvoice;

        public frmIssueSaleReturnInvoice(clsSaleInvoice orginilInvoice) : base(enInvoiceType.SalesReturn)
        {
            InitializeComponent();
            _OrginalInvoice = orginilInvoice;
        }

        private void frmIssueSaleReturnInvoice_Load(object sender, EventArgs e)
        {
            if (_OrginalInvoice == null)
            {
                clsFormMessages.ShowError("لم يتم العثور على الفاتورة الأصلية");
                this.Close();
                return;
            }

            txtInvoiceNo.Text = _OrginalInvoice.InvoiceNo;
            cbWarehouse.SelectedValue = _OrginalInvoice.WarehouseInfo.WarehouseID;
        }

        protected override clsInvoice GetInvoiceInctance()
        {
            return new clsSaleReturnInvoice(
                _OrginalInvoice.InvoiceID.Value,
                dtpInvoiceIssueDate.Value,
                GetInvoiceStatus(),
                GetInvoiceLinesFromDGV(),
                (int)cbWarehouse.SelectedValue,
                GetPaymentMethod(),
                GetPaymentAmount()
                );
        }

        protected override void dgvInvoiceLines_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            base.dgvInvoiceLines_CellBeginEdit(sender, e);

            if (e.ColumnIndex == colProduct.Index)
            {
                DataGridViewComboBoxCell boxCell = dgvInvoiceLines.CurrentCell as DataGridViewComboBoxCell;

                List<int> selectedProductIDs = InvoiceLinesDataSource
                    .Where(line => line != CurrentLine && line.ProductID != null)
                    .Select(line => line.ProductID.GetValueOrDefault())
                    .ToList();

                boxCell.DataSource = _OrginalInvoice.Lines
                    .Where(line => line.GetRemainingQuantity() > 0)
                    .GroupBy(line => line.ProductInfo.ProductID)
                    .Select(group => group.First().ProductInfo)
                    .Where(
                        product => product.ProductID != null &&
                        !SelectedProductIDsWithoutUnit.Contains(product.ProductID.Value) &&
                        (!selectedProductIDs.Contains(product.ProductID.Value) ||
                        GetSelectedProductUnitIDs(product.ProductID.Value).Count <
                        _OrginalInvoice.Lines.Count(line => line.ProductID == product.ProductID)))
                    .OrderBy(product => product.ProductName)
                    .ToList();

                colProduct.DisplayMember = "ProductName";
                colProduct.ValueMember = "ProductID";
            }

            if (e.ColumnIndex == colUnit.Index && CurrentLine != null && CurrentLine.ProductID != null)
            {
                DataGridViewComboBoxCell boxCell = dgvInvoiceLines.CurrentCell as DataGridViewComboBoxCell;

                boxCell.DataSource = _OrginalInvoice.Lines
                    .Where(line => line.ProductID == CurrentLine.ProductID && line.GetRemainingQuantity() > 0)
                    .Select(line => line.UnitInfo)
                    .Where(unit => !GetSelectedProductUnitIDs(CurrentLine.ProductID.GetValueOrDefault()).Contains(unit.UnitID))
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

            if (CurrentLine.ProductID != null && CurrentLine.UnitID != null)
            {
                clsInvoiceLine originalLine = _OrginalInvoice.Lines
                    .FirstOrDefault(line => line.ProductID == CurrentLine.ProductID && line.UnitID == CurrentLine.UnitID);

                if (originalLine == null) return;

                CurrentLine.UnitPrice = originalLine.FinalUnitPrice;

                if (CurrentLine.Quantity != null)
                {
                    int remainingQuantity = originalLine.GetRemainingQuantity();

                    if (CurrentLine.Quantity > remainingQuantity)
                    {
                        CurrentLine.Quantity = remainingQuantity;
                    }

                }
            }

            ApplyEditOnDGV(e.RowIndex);
            base.UpdateInvoiceSummary();
        }

        protected override void dgvInvoiceLines_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            base.ErrorColumnIndex = e.ColumnIndex;

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
                else if ((!int.TryParse(GetEditedValue()?.ToString(), out int quantity) || quantity < 1) && (!IsCurrentCellEmpty()))
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
        }

    }
}
