using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using BusinessLogic.Invoices;
using BusinessLogic.Products;
using BusinessLogic.Warehouses;
using SIMS.WinForms.Invoices;

namespace SIMS.WinForms.Sales
{
    public partial class frmIssueSaleInvoice : frmBaseIssueInvoice
    {
        private List<clsInventory> _WarehouseAvailableInventories;

        public frmIssueSaleInvoice() : base(enInvoiceType.Sales)
        {
            InitializeComponent();
        }

        private void frmIssueSaleInvoice_Load(object sender, EventArgs e)
        {
            colUnitPrice.ReadOnly = colDiscountRate.ReadOnly = colDiscountAmount.ReadOnly =
                colTaxRate.ReadOnly = colTaxAmount.ReadOnly = true;

            _WarehouseAvailableInventories = clsWarehouseService
                .CreateInstance()
                .Find((int)cbWarehouse.SelectedValue)
                .GetAvailableInventories();

            cbWarehouse.SelectedIndexChanged += cbWarehouse_SelectedIndexChanged;
            dgvInvoiceLines.CellToolTipTextNeeded += dgvInvoiceLines_CellToolTipTextNeeded;
        }

        private void cbWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            _WarehouseAvailableInventories = clsWarehouseService
                .CreateInstance()
                .Find((int)cbWarehouse.SelectedValue)
                .GetAvailableInventories();
        }

        protected override void dgvInvoiceLines_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            base.dgvInvoiceLines_RowsAdded(sender, e);

            if (dgvInvoiceLines.Rows.Count != 1)
            {
                cbWarehouse.Enabled = false;
            }
        }

        protected override void dgvInvoiceLines_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            base.dgvInvoiceLines_RowsRemoved(sender, e);

            if (dgvInvoiceLines.Rows.Count == 1)
            {
                cbWarehouse.Enabled = true;
            }
        }

        private void dgvInvoiceLines_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= InvoiceLinesDataSource.Count)
            {
                return;
            }

            var line = InvoiceLinesDataSource[e.RowIndex];

            if (line == null)
            {
                return;
            }

            if (e.ColumnIndex == colDiscountAmount.Index && line.SaleDiscounts.Any())
            {
                var amountDiscounts = line.SaleDiscounts
                    .Where(d => d.DiscountValueType == clsDiscount.enValueType.Amount)
                    .Select(d => $"{d.DiscountName}: {d.DiscountValue:N2}");

                if (amountDiscounts.Any())
                    e.ToolTipText = "تفاصيل الخصومات المقطوعة:" + Environment.NewLine + string.Join(Environment.NewLine, amountDiscounts);
            }

            else if (e.ColumnIndex == colDiscountRate.Index && line.SaleDiscounts.Any())
            {
                var percentDiscounts = line.SaleDiscounts
                    .Where(d => d.DiscountValueType == clsDiscount.enValueType.Percentage)
                    .Select(d => $"{d.DiscountName}: {d.DiscountValue}%");

                if (percentDiscounts.Any())
                    e.ToolTipText = "تفاصيل نسب الخصم:" + Environment.NewLine + string.Join(Environment.NewLine, percentDiscounts);
            }

            else if ((e.ColumnIndex == colTaxAmount.Index || e.ColumnIndex == colTaxRate.Index) && line.SaleTaxes.Any())
            {
                var taxes = line.SaleTaxes
                    .Select(t => $"{t.TaxName}: {t.TaxRate}%");

                e.ToolTipText = "تفاصيل الضرائب المطبقة:" + Environment.NewLine + string.Join(Environment.NewLine, taxes);
            }
        }

        protected override clsInvoice GetInvoiceInctance()
        {
            return new clsSaleInvoice(
                dtpInvoiceIssueDate.Value,
                base.GetInvoiceStatus(),
                base.GetInvoiceLinesFromDGV(),
                (int?)cbParty.SelectedValue,
                (int)cbWarehouse.SelectedValue,
                base.GetPaymentMethod(),
                base.GetPaymentAmount()
            );
        }

        protected override void dgvInvoiceLines_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            base.dgvInvoiceLines_CellBeginEdit(sender, e);

            if (e.ColumnIndex == colProduct.Index)
            {
                DataGridViewComboBoxCell boxCell = dgvInvoiceLines.CurrentCell as DataGridViewComboBoxCell;

                boxCell.DataSource = _WarehouseAvailableInventories
                    .GroupBy(inventory => inventory.ProductInfo.ProductID)
                    .Select(group => group.First().ProductInfo)
                    .Where(
                        product =>
                        !SelectedProductIDsWithoutUnit.Contains(product.ProductID.Value) &&
                        (!SelectedProductIDs.Contains(product.ProductID.Value) ||
                        GetSelectedProductUnitIDs(product.ProductID.Value).Count !=_WarehouseAvailableInventories
                            .Where(inventory => inventory.ProductInfo.ProductID == product.ProductID)
                            .Count())
                    )
                    .OrderBy(product => product.ProductName)
                    .ToList();

                colProduct.DisplayMember = "ProductName";
                colProduct.ValueMember = "ProductID";
            }

            if (e.ColumnIndex == colUnit.Index && CurrentLine != null && CurrentLine.ProductID.HasValue)
            {
                DataGridViewComboBoxCell boxCell = dgvInvoiceLines.CurrentCell as DataGridViewComboBoxCell;

                boxCell.DataSource = _WarehouseAvailableInventories
                    .Where(inventory => inventory.ProductInfo.ProductID == CurrentLine.ProductID)
                    .Select(inventory => inventory.UnitInfo)
                    .Where(
                        unit => 
                        !GetSelectedProductUnitIDs(CurrentLine.ProductID.Value)
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
