using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Invoices;
using BusinessLogic.Validation;
using BusinessLogic.Warehouses;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Properties;

namespace SIMS.WinForms.Invoices
{
    public partial class frmBaseIssueInvoice : Form
    {
        private enInvoiceType _InvoiceType;
        protected int ErrorColumnIndex;
        protected BindingList<clsInvoiceLine> InvoiceLinesDataSource;
        protected clsInvoiceLine CurrentLine => dgvInvoiceLines.CurrentRow.DataBoundItem as clsInvoiceLine;

        private frmBaseIssueInvoice()
        {
            InitializeComponent();
        }

        public frmBaseIssueInvoice(enInvoiceType invoiceType) : this()
        {
            _InvoiceType = invoiceType;
            InvoiceLinesDataSource = new BindingList<clsInvoiceLine>();
            InvoiceLinesDataSource.ListChanged += _InvoiceLinesDataSource_ListChanged;
        }

        private void frmBaseIssueInvoice_Load(object sender, EventArgs e)
        {
            dgvInvoiceLines.ColumnHeadersDefaultCellStyle.Font =
                new Font("Tahoma", 7, FontStyle.Bold);
            dgvInvoiceLines.DefaultCellStyle.Font =
                new Font("Tahoma", 8);

            if (!DesignMode)
            {
                cbWarehouse.DataSource = clsWarehouseService.GetActiveWarehousesList();
                cbWarehouse.DisplayMember = "WarehouseName";
                cbWarehouse.ValueMember = "WarehouseID";
                cbWarehouse.SelectedValue = 1;
            }

            dgvInvoiceLines.AutoGenerateColumns = false;
            dgvInvoiceLines.DataSource = InvoiceLinesDataSource;

            _SetupDGVColumns();

            dtpInvoiceIssueDate.MaxDate = DateTime.Today;
            dtpInvoiceIssueDate.MinDate = DateTime.Today.AddYears(-1);
            dtpInvoiceIssueDate.Value = DateTime.Today;

            if (_InvoiceType == enInvoiceType.PurchaseReturn || _InvoiceType == enInvoiceType.SalesReturn)
            {
                colUnitPrice.Width = colQuantity.Width = 100;
                colSubTotal.Width = colGrandTotal.Width = 120;
                colUnit.Width = 150;

                colDiscountAmount.Visible = colDiscountRate.Visible = colTaxAmount.Visible =
                    colTaxRate.Visible = colFinalUnitPrice.Visible = false;
            }
        }

        private void _SetupDGVColumns()
        {
            dgvInvoiceLines.Columns[colLineNa.Name].DataPropertyName = null;
            dgvInvoiceLines.Columns[colDelete.Name].DataPropertyName = null;

            dgvInvoiceLines.Columns[colProduct.Name].DataPropertyName = "ProductID";
            dgvInvoiceLines.Columns[colUnit.Name].DataPropertyName = "UnitID";
            dgvInvoiceLines.Columns[colQuantity.Name].DataPropertyName = "Quantity";
            dgvInvoiceLines.Columns[colConversionFactor.Name].DataPropertyName = "ConversionFactor";
            dgvInvoiceLines.Columns[colUnitPrice.Name].DataPropertyName = "UnitPrice";
            dgvInvoiceLines.Columns[colFinalUnitPrice.Name].DataPropertyName = "FinalUnitPrice";
            dgvInvoiceLines.Columns[colDiscountRate.Name].DataPropertyName = "DiscountRate";
            dgvInvoiceLines.Columns[colDiscountAmount.Name].DataPropertyName = "DiscountAmount";
            dgvInvoiceLines.Columns[colTaxRate.Name].DataPropertyName = "TaxRate";
            dgvInvoiceLines.Columns[colTaxAmount.Name].DataPropertyName = "TaxAmount";
            dgvInvoiceLines.Columns[colSubTotal.Name].DataPropertyName = "LineSubTotal";
            dgvInvoiceLines.Columns[colGrandTotal.Name].DataPropertyName = "LineGrandTotal";
        }


        private void _InvoiceLinesDataSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded ||
                e.ListChangedType == ListChangedType.ItemDeleted)
            {
                if (e.ListChangedType == ListChangedType.ItemAdded)
                {
                    InvoiceLinesDataSource[e.NewIndex].BaseInvoiceType = _InvoiceType;
                }

                UpdateInvoiceSummary();
            }
        }


        protected virtual void dgvInvoiceLines_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            _UpdateRowsDetails();
        }

        protected virtual void dgvInvoiceLines_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            _UpdateRowsDetails();
        }

        private void _UpdateRowsDetails()
        {
            for (int i = 0; i < dgvInvoiceLines.Rows.Count; i++)
            {
                dgvInvoiceLines.Rows[i].Cells[colLineNa.Index].Value = i + 1;
                dgvInvoiceLines.Rows[i].Cells[colDelete.Index].Value = Resources.delete;
            }
        }

        private void dgvInvoiceLines_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1 && e.RowIndex != dgvInvoiceLines.NewRowIndex &&
                e.ColumnIndex == dgvInvoiceLines.Columns[colDelete.Index].Index)
            {
                DialogResult result = MessageBox.Show("هل أنت متأكد من أنك تريد حذف هذا السطر ؟", "تأكيد",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    if (dgvInvoiceLines.Rows[e.RowIndex].DataBoundItem is clsInvoiceLine lineToDelete)
                    {
                        dgvInvoiceLines.CellValidating -= dgvInvoiceLines_CellValidating;
                        InvoiceLinesDataSource.RemoveAt(e.RowIndex);
                        dgvInvoiceLines.CellValidating += dgvInvoiceLines_CellValidating;
                    }
                }

                dgvInvoiceLines.ClearSelection();
            }
        }

        protected virtual void dgvInvoiceLines_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dgvInvoiceLines.CurrentCell.Tag = dgvInvoiceLines.CurrentCell.Value;
        }

        protected virtual void dgvInvoiceLines_CellEndEdit(object sender, DataGridViewCellEventArgs e) { }
     
        protected virtual void dgvInvoiceLines_CellValidating(object sender, DataGridViewCellValidatingEventArgs e) { }

        protected object GetLastValueOfCell()
        {
            return dgvInvoiceLines.CurrentCell.Tag;
        }

        protected List<int> GetSelectedProductUnitIDs(int productID)
        {
            return InvoiceLinesDataSource
                .Where(
                    line =>
                    line != dgvInvoiceLines.CurrentRow.DataBoundItem as clsInvoiceLine &&
                    line.UnitID != null && line.ProductID == productID
                )
                .Select(line => line.UnitID.GetValueOrDefault())
                .ToList();
        }

        protected object GetLastValueOfCell(int columnIndex)
        {
            return dgvInvoiceLines.CurrentRow.Cells[columnIndex].Tag;
        }

        protected object GetCellValue()
        {
            return dgvInvoiceLines.CurrentCell.Value;
        }

        protected object GetCellValue(int columnIndex)
        {
            return dgvInvoiceLines.CurrentRow.Cells[columnIndex].Value;
        }

        protected object GetEditedValue()
        {
            return dgvInvoiceLines.CurrentCell.EditedFormattedValue;
        }

        protected bool IsCellValueChanged()
        {
            if (GetCellValue() == null)
            {
                return !(GetCellValue() == GetLastValueOfCell());
            }

            return !(GetCellValue().Equals(GetLastValueOfCell()));
        }

        protected bool IsCurrentCellEmpty()
        {
            return IsEmptyCell(dgvInvoiceLines.CurrentCell.RowIndex, dgvInvoiceLines.CurrentCell.ColumnIndex);
        }

        protected bool IsCurrentRowHasData()
        {
            for (int i = 1; i < dgvInvoiceLines.ColumnCount - 3; i++)
            {
                if (!IsEmptyCell(dgvInvoiceLines.CurrentCell.RowIndex, i) && i != dgvInvoiceLines.CurrentCell.ColumnIndex)
                {
                    return true;
                }
            }

            return false;
        }

        protected bool IsEmptyCell(int rowIndex, int colIndex)
        {
            return string.IsNullOrWhiteSpace(dgvInvoiceLines.Rows[rowIndex].Cells[colIndex].EditedFormattedValue?.ToString());
        }

        protected void ApplyEditOnDGV(int rowIndex)
        {
            dgvInvoiceLines.RefreshEdit();
            dgvInvoiceLines.InvalidateRow(rowIndex);
            dgvInvoiceLines.EndEdit();
            dgvInvoiceLines.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        protected enPaymentStatus GetInvoiceStatus()
        {
            return rbPaid.Checked ? enPaymentStatus.Paid : rbPartiallyPaid.Checked ? enPaymentStatus.PartiallyPaid : enPaymentStatus.Unpaid;
        }

        protected enPaymentMethod? GetPaymentMethod()
        {
            return rbCash.Checked ? enPaymentMethod.Cash : rbBankTransfer.Checked ? enPaymentMethod.BankTransfer : (enPaymentMethod?)null;
        }

        protected decimal? GetPaymentAmount()
        {
            if (rbPaid.Checked)
            {
                return InvoiceLinesDataSource
                    .Where(line => !line.IsNewRow)
                    .Sum(line => line.LineGrandTotal.GetValueOrDefault());
            }
            else if (rbPartiallyPaid.Checked)
            {
                return Convert.ToDecimal(txtPaidAmount.Text);
            }

            return null;
        }

        protected virtual clsInvoice GetInvoiceInctance()
        {
            throw new NotImplementedException("يجب تعيين كائن  من نوع الفاتورة");
        }

        protected List<clsInvoiceLine> GetInvoiceLinesFromDGV()
        {
            dgvInvoiceLines.EndEdit();
            return InvoiceLinesDataSource.Where(line => !line.IsNewRow).ToList();
        }

        protected void UpdateInvoiceSummary()
        {
            dgvInvoiceLines.EndEdit();

            lblTotalSubTotal.Text = InvoiceLinesDataSource
                .Where(line => !line.IsNewRow)
                .Sum(line => line.LineSubTotal.GetValueOrDefault()).ToString();

            lblTotalDiscount.Text = _InvoiceType == enInvoiceType.Sales ?
                InvoiceLinesDataSource
                    .Where(line => !line.IsNewRow)
                    .Sum(line => line.CalculateFinalDiscountAmount().GetValueOrDefault()).ToString() :
                InvoiceLinesDataSource
                    .Where(line => !line.IsNewRow)
                    .Sum(line => line.DiscountAmount).ToString();

            lblTotalTax.Text = InvoiceLinesDataSource
                .Where(line => !line.IsNewRow)
                .Sum(line => line.TaxAmount.GetValueOrDefault()).ToString();

            lblTotalGrandTotal.Text = InvoiceLinesDataSource
                .Where(line => !line.IsNewRow)
                .Sum(line => line.LineGrandTotal.GetValueOrDefault()).ToString();
        }

        private void txtPaidAmount_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!rbPartiallyPaid.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtPaidAmount.Text))
                {
                    errorProvider.SetError(txtPaidAmount, "يتم تعيين مبلغ مدفوع في حالة كانت حالة الفاتورة مدفوعة جزئيا فقط");
                }

                return;
            }

            if (string.IsNullOrWhiteSpace(txtPaidAmount.Text))
            {
                errorProvider.SetError(txtPaidAmount, "لا يمكن أن يكون حقل المبلغ المدفوع فارغا فارغاً");
            }
            else if (!decimal.TryParse(txtPaidAmount.Text, out decimal sellingPrice))
            {
                errorProvider.SetError(txtPaidAmount, "يجب أن يكون المبلغ المدفوع قيمة رقمية صحيحة أو عشرية");
            }
            else if (sellingPrice < 1)
            {
                errorProvider.SetError(txtPaidAmount, "يجب أن يكون المبلغ المدفوع أكبر من صفر");
            }
            else
            {
                errorProvider.SetError(txtPaidAmount, string.Empty);
            }
        }

        private void rbPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPaid.Checked)
            {
                rbCash.Enabled = rbBankTransfer.Enabled = true;
                rbCash.Checked = true;
                errorProvider.SetError(txtPaidAmount, string.Empty);
                txtPaidAmount.Text = string.Empty;
                txtPaidAmount.Enabled = false;
            }
        }

        private void rbPartiallyPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPartiallyPaid.Checked)
            {
                rbCash.Enabled = rbBankTransfer.Enabled = true;
                rbCash.Checked = true;
                txtPaidAmount.Enabled = true;
            }
        }

        private void rbUnpaid_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUnpaid.Checked)
            {
                rbCash.Checked = rbBankTransfer.Checked = false;
                rbCash.Enabled = rbBankTransfer.Enabled = false;
                errorProvider.SetError(txtPaidAmount, string.Empty);
                txtPaidAmount.Text = string.Empty;
                txtPaidAmount.Enabled = false;
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgvInvoiceLines.EndEdit();

            if (!clsFormValidation.IsDataValid(this, errorProvider))
            {
                clsFormMessages.ShowInvalidDataError();
                return;
            }

            if (clsFormHelper.IsDataGridViewCellsHasError(dgvInvoiceLines, ErrorColumnIndex))
            {
                clsFormMessages.ShowError("يجب إدخال جميع البيانات بصورة صحيحة قبل الحفظ");
                return;
            }

            if (!clsFormMessages.Confirm("هل أنت متأكد من أنك تريد الحفظ ؟"))
            {
                return;
            }

            clsInvoice invoice = GetInvoiceInctance();

            clsValidationResult validationResult = invoice.Issue();

            if (validationResult.IsValid)
            {
                clsFormMessages.ShowSuccess("تم إصدار الفاتورة بنجاح");
                this.Close();
            }
            else
            {
                clsFormMessages.ShowValidationErrors(validationResult);
            }
        }

    }
}