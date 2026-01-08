using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Invoices;
using BusinessLogic.Products;
using BusinessLogic.Suppliers;
using BusinessLogic.Warehouses;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Interfaces;
using SIMS.WinForms.Invoices;
using SIMS.WinForms.Properties;
using SIMS.WinForms.Suppliers;
using SIMS.WinForms.Warehouses;

namespace SIMS.WinForms.Products
{
    public partial class ctrProductInfo : UserControl, IEntityView<clsProduct>
    {
        private clsProduct _Product;

        public clsProduct Entity
        {
            get => _Product;

            set
            {
                if (value is null)
                {
                    return;
                }

                _Product = value;
                lblProductName.Text = _Product.ProductName;
                lblCategory.Text = _Product.CategoryInfo.CategoryName;
                lblMainUnit.Text = _Product.MainUnitInfo.UnitName;
                lblMainSupplier.Text = _Product.MainSupplierInfo?.PartyInfo?.PartyName ?? "N/A";
                lblActivity.Text = _Product.IsActive ? "مفعل" : "غير مفعل";
                lblProductDescribtion.Text = string.IsNullOrEmpty(_Product.Description) ? "N/A" : _Product.Description;
                llCreatedBy.Text = _Product.CreatedByUserInfo?.UserName ?? "N/A";
                lblCreatedAt.Text = _Product.CreatedAt?.ToString("HH:mm:ss yyyy/MM/dd") ?? "N/A";
                llUpdatedBy.Text = _Product.UpdatedByUserInfo?.UserName ?? "N/A";
                lblUpdatedAt.Text = _Product.UpdatedAt?.ToString("HH:mm:ss yyyy/MM/dd") ?? "N/A";

                if (!string.IsNullOrEmpty(_Product.ImagePath))
                {
                    pbProductImage.ImageLocation = _Product.ImagePath;
                }
                else
                {
                    pbProductImage.Image = Resources.product;
                }

                tabControl.SelectedIndex = 0;
                _LoadDataForUnitsPage();
                _LoadDataForSuppliersPage();
                _LoadDataForInventoriesPage();
                _LoadDataForStockTransactionsPage();
            }
        }

        public ctrProductInfo()
        {
            InitializeComponent();
        }

        private void ctrProductInfo_Load(object sender, EventArgs e)
        {
            cbUnit.Items.AddRange(clsUnit.GetAllUnitNames());
            cbWarehouse.Items.AddRange(clsWarehouseService.GetWarehouseNames());
            cbTransactionType.Items.AddRange(clsStockTransactionService.GetStockTransactionTypeNames());
            cbTransactionReason.Items.AddRange(clsStockTransactionService.GetStockTransactionReasonNames());
        }

        private void ShowTransferOperationInfo_Click(object sender, EventArgs e)
        {
            if (dgvStockTransactions.SelectedRows.Count == 0)
            {
                return;
            }

            clsStockTransaction currentStockTransaction = clsStockTransactionService.CreateInstance().Find(_GetSelectedTransactionID());

            if (currentStockTransaction != null)
            {
                if (currentStockTransaction.TransactionReason == clsStockTransaction.enTransactionReason.TransferOperation)
                {
                    int? transferOperationID = (int?)dgvStockTransactions.SelectedRows[0].Cells[dgvStockTransactions.Columns["TransferOperationID"].Index].Value;

                    if (transferOperationID != null)
                    {
                        frmShowTransferOperationInfo showTransferOperationInfo = new frmShowTransferOperationInfo(transferOperationID.Value);
                        showTransferOperationInfo.ShowDialog();
                    }
                    else
                    {
                        clsFormMessages.ShowError("لم يتم العثور على عملية النقل");
                    }
                }
                else
                {
                    clsFormMessages.ShowError("لا يمكن عرض تفاصيل عملية النقل لأن سبب حركة المخزون ليس من نوع نقل بضاعة");
                }
            }
            else
            {
                clsFormMessages.ShowError("لم يتم العثور على سجل حركة المخزون");
            }
        }

        private void ShowInvoiceDetails_Click(object sender, EventArgs e)
        {
            if (dgvStockTransactions.SelectedRows.Count == 0)
            {
                return;
            }

            clsStockTransaction currentStockTransaction = clsStockTransactionService.CreateInstance().Find(_GetSelectedTransactionID());

            if (currentStockTransaction != null)
            {
                if (currentStockTransaction.TransactionReason == clsStockTransaction.enTransactionReason.Purchase ||
                    currentStockTransaction.TransactionReason == clsStockTransaction.enTransactionReason.PurchaseReturn ||
                    currentStockTransaction.TransactionReason == clsStockTransaction.enTransactionReason.Sales ||
                    currentStockTransaction.TransactionReason == clsStockTransaction.enTransactionReason.SalesReturn)
                {
                    int? invoiceID = (int?)dgvStockTransactions.SelectedRows[0].Cells[dgvStockTransactions.Columns["SourceInvoiceID"].Index].Value;

                    if (invoiceID != null)
                    {
                        frmShowInvoiceInfo showInvoiceInfo = new frmShowInvoiceInfo(invoiceID.Value);
                        showInvoiceInfo.ShowDialog();
                    }
                    else
                    {
                        clsFormMessages.ShowError("لم يتم العثور على الفاتورة");
                    }
                }
                else
                {
                    clsFormMessages.ShowError("لا يمكن عرض تفاصيل الفاتورة لأن سبب حركة المخزون لم ينتج عنه فاتورة مشتريات/مرتجعاتمشتريات/مبيعات/مرتجعات مبيعات");
                }
            }
            else
            {
                clsFormMessages.ShowError("لم يتم العثور على سجل حركة المخزون");
            }
        }

        private void UpdateReorderQuantity_Click(object sender, EventArgs e)
        {
            if (dgvInventories.SelectedRows.Count == 0)
            {
                return;
            }

            frmUpdateReorderInventoryQuantity inventoryQuantity = new frmUpdateReorderInventoryQuantity(_GetSelectedInventoryID());
            clsInventoryService.CreateInstance().EntitySaved += ReorderQuantityUpdated_EntitySaved;
            inventoryQuantity.ShowDialog();
            clsInventoryService.CreateInstance().EntitySaved -= ReorderQuantityUpdated_EntitySaved;
        }

        private void ReorderQuantityUpdated_EntitySaved(object sender, BusinessLogic.Interfaces.EntitySavedEventArgs e)
        {
            _LoadDataForInventoriesPage();
        }

        private void tabControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (tabControl.SelectedTab == pageUnits)
            {
                dgvUnits.ClearSelection();
            }
            else if (tabControl.SelectedTab == pageSuppliers)
            {
                dgvSuppliers.ClearSelection();
            }
            else if (tabControl.SelectedTab == pageInventories)
            {
                dgvInventories.ClearSelection();
            }
            else if (tabControl.SelectedTab == pageStockTransactions)
            {
                dgvStockTransactions.ClearSelection();
            }
        }

        private void _LoadDataForUnitsPage()
        {
            dgvUnits.DataSource = _Product.GetProductUnitsTable();

            if (dgvUnits.Rows.Count > 0)
            {
                clsFormHelper.DisableSortableDataGridViewColumns(dgvUnits);

                dgvUnits.ColumnHeadersDefaultCellStyle.Font =
                    new Font("Tahoma", 7, FontStyle.Bold);

                dgvUnits.DefaultCellStyle.Font =
                     new Font("Tahoma", 8);

                dgvUnits.Columns[0].HeaderText = "م";
                dgvUnits.Columns[0].Width = 45;

                dgvUnits.Columns[1].HeaderText = "معرف المنتج";
                dgvUnits.Columns[1].Visible = false;

                dgvUnits.Columns[2].HeaderText = "معرف الوحدة الأساسية";
                dgvUnits.Columns[2].Visible = false;
                
                dgvUnits.Columns[3].HeaderText = "معرف الوحدة الحالية";
                dgvUnits.Columns[3].Visible = false;

                dgvUnits.Columns[4].HeaderText = "الوحدة";
                dgvUnits.Columns[4].Width = 85;

                dgvUnits.Columns[5].HeaderText = "الباركود";
                dgvUnits.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvUnits.Columns[6].HeaderText = "معامل التحويل";
                dgvUnits.Columns[6].Width = 90;

                dgvUnits.Columns[7].HeaderText = "متوسط سعر الشراء (جنيه)";
                dgvUnits.Columns[7].Width = 110;

                dgvUnits.Columns[8].HeaderText = "سعر البيع (جنيه)";
                dgvUnits.Columns[8].Width = 100;

                dgvUnits.Columns[9].HeaderText = "معدل الربح (%)";
                dgvUnits.Columns[9].Width = 90;
            }
        }

        private void _LoadDataForSuppliersPage()
        {
            dgvSuppliers.DataSource = _Product.GetSuppliersTable();

            if (dgvSuppliers.Rows.Count > 0)
            {
                clsFormHelper.DisableSortableDataGridViewColumns(dgvSuppliers);

                dgvSuppliers.ColumnHeadersDefaultCellStyle.Font =
                    new Font("Tahoma", 7, FontStyle.Bold);

                dgvSuppliers.DefaultCellStyle.Font =
                     new Font("Tahoma", 8);

                dgvSuppliers.Columns[0].HeaderText = "م";
                dgvSuppliers.Columns[0].Width = 45;

                dgvSuppliers.Columns[1].HeaderText = "معرف المورد";
                dgvSuppliers.Columns[1].Visible = false;

                dgvSuppliers.Columns[2].HeaderText = "المورد";
                dgvSuppliers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvSuppliers.Columns[3].HeaderText = "معرف الوحدة";
                dgvSuppliers.Columns[3].Visible = false;

                dgvSuppliers.Columns[4].HeaderText = "الوحدة";
                dgvSuppliers.Columns[4].Width = 85;

                dgvSuppliers.Columns[5].HeaderText = "تاريخ آخر شراء";
                dgvSuppliers.Columns[5].Width = 85;

                dgvSuppliers.Columns[6].HeaderText = "سعر آخر شراء (جنيه)";
                dgvSuppliers.Columns[6].Width = 85;

                dgvSuppliers.Columns[7].HeaderText = "متوسط سعر الشراء (جنيه)";
                dgvSuppliers.Columns[7].Width = 110;

                dgvSuppliers.Columns[8].HeaderText = "مجموع المشتريات (جنيه)";
                dgvSuppliers.Columns[8].Width = 100;

                dgvSuppliers.Columns[9].HeaderText = "مجموع المرتجعات (جنيه)";
                dgvSuppliers.Columns[9].Width = 100;
            }
        }

        private void ShowSupplierInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                return;
            }

            clsSupplier supplier = clsSupplierService.CreateInstance().Find(clsFormHelper.GetSelectedRowID(dgvSuppliers, 1));

            if (supplier == null)
            {
                clsFormMessages.ShowError("لم يتم العثور على المورد");
                return;
            }

            frmShowSupplierInfo supplierInfo = new frmShowSupplierInfo(supplier);
            supplierInfo.ShowDialog();
        }

        private void SuppliedItemsLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                return;
            }

            frmSuppliedItemsLogList suppliedItemsLogList = new frmSuppliedItemsLogList(
                    Convert.ToString(dgvSuppliers.SelectedRows[0].Cells["SupplierName"].Value),
                    _Product.ProductName,
                    Convert.ToString(dgvSuppliers.SelectedRows[0].Cells["UnitName"].Value)
                    );

            frmMainForm.OpenForm(suppliedItemsLogList);
        }

        private void SuppliersContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            clsFormHelper.PreventContextMenuOnEmptyClick(dgvSuppliers, e);

            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                e.Cancel = true;
            }
        }

        private void dgvSuppliers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button is MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvSuppliers.Rows[e.RowIndex].Selected = true;
            }
        }

        private void _LoadDataForInventoriesPage()
        {
            dgvInventories.DataSource = _Product.GetInventoriesTable();

            if (dgvInventories.Rows.Count > 0)
            {
                clsFormHelper.DisableSortableDataGridViewColumns(dgvInventories);

                dgvInventories.ColumnHeadersDefaultCellStyle.Font =
                    new Font("Tahoma", 7, FontStyle.Bold);

                dgvInventories.DefaultCellStyle.Font =
                     new Font("Tahoma", 8);

                dgvInventories.Columns[0].HeaderText = "م";
                dgvInventories.Columns[0].Width = 40;

                dgvInventories.Columns[1].HeaderText = "معرف المخزون";
                dgvInventories.Columns[1].Visible = false;

                dgvInventories.Columns[2].HeaderText = "الوحدة";
                dgvInventories.Columns[2].Width = 80;

                dgvInventories.Columns[3].HeaderText = "معرف المخزن";
                dgvInventories.Columns[3].Visible = false;

                dgvInventories.Columns[4].HeaderText = "المخزن";
                dgvInventories.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvInventories.Columns[5].HeaderText = "حد إعادة الطلب";
                dgvInventories.Columns[5].Width = 60;

                dgvInventories.Columns[6].HeaderText = "الكمية الحالية";
                dgvInventories.Columns[6].Width = 75;

                dgvInventories.Columns[7].HeaderText = "الحالة";
                dgvInventories.Columns[7].Width = 50;

                dgvInventories.Columns[8].HeaderText = "تكلفة شراء المخزون (جنيه)";
                dgvInventories.Columns[8].Width = 110;

                dgvInventories.Columns[9].HeaderText = "قيمة بيع المخزون (جنيه)";
                dgvInventories.Columns[9].Width = 110;

                dgvInventories.Columns[10].HeaderText = "الربح المتوقع (جنيه)";
                dgvInventories.Columns[10].Width = 90;

                dgvInventories.Columns[11].HeaderText = "معدل الربح (%)";
                dgvInventories.Columns[11].Width = 75;
            }
        }

        private void ShowTransactionLog_Click(object sender, EventArgs e)
        {
            if (dgvInventories.SelectedRows.Count == 0)
            {
                return;
            }

            clsInventory currentInventory = clsInventoryService.CreateInstance().Find(clsFormHelper.GetSelectedRowID(dgvInventories, 1));

            if (currentInventory != null)
            {
                frmStockTransactionsList inventoryTransactions = new frmStockTransactionsList(
                    currentInventory.ProductInfo.ProductName,
                    currentInventory.UnitInfo.UnitName,
                    currentInventory.WarehouseInfo.WarehouseName
                    );

                frmMainForm.OpenForm(inventoryTransactions);
            }
            else
            {
                clsFormMessages.ShowError("لم يتم العثور على المخزون");
            }
        }

        private void GoToInventoriesListtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInventories.SelectedRows.Count == 0)
            {
                return;
            }

            clsInventory currentInventory = clsInventoryService.CreateInstance().Find(clsFormHelper.GetSelectedRowID(dgvInventories, "InventoryID"));

            if (currentInventory != null)
            {
                frmInventoriesList inventoriesList = new frmInventoriesList(
                    productName: currentInventory.ProductInfo.ProductName,
                    unitName: currentInventory.UnitInfo.UnitName,
                    warehouseName: currentInventory.WarehouseInfo.WarehouseName
                    );

                frmMainForm.OpenForm(inventoriesList);
            }
            else
            {
                clsFormMessages.ShowError("لم يتم العثور على المخزون");
            }
        }

        private void dgvInventories_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            clsFormHelper.ApplyGreenYellowRedRowStyle(dgvInventories, e, "InventoryStatus", "آمن", "منخفض", "نفذ");
        }

        private void dgvInventories_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button is MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvInventories.Rows[e.RowIndex].Selected = true;
            }
        }

        private void InventoriesContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            clsFormHelper.PreventContextMenuOnEmptyClick(dgvInventories, e);

            if (dgvInventories.SelectedRows.Count == 0)
            {
                e.Cancel = true;
            }
        }

        private int _GetSelectedInventoryID()
        {
            try
            {
                return (int?)dgvInventories.SelectedRows[0].Cells["InventoryID"].Value ?? -1;
            }
            catch
            {
                return -1;
            }
        }

        private void _LoadDataForStockTransactionsPage()
        {
            dgvStockTransactions.DataSource = _Product.GetStockTransactionsTable();

            cbUnit.SelectedIndex = cbWarehouse.SelectedIndex =
                cbTransactionType.SelectedIndex = cbTransactionReason.SelectedIndex = 0;
            
            cbRange.SelectedIndex = 4;

            if (dgvStockTransactions.Rows.Count > 0)
            {
                clsFormHelper.DisableSortableDataGridViewColumns(dgvStockTransactions);

                cbUnit.Enabled = cbWarehouse.Enabled = cbTransactionType.Enabled =
                    cbTransactionReason.Enabled = cbRange.Enabled = true;

                dgvStockTransactions.ColumnHeadersDefaultCellStyle.Font =
                    new Font("Tahoma", 7, FontStyle.Bold);

                dgvStockTransactions.DefaultCellStyle.Font =
                     new Font("Tahoma", 8);

                dgvStockTransactions.Columns[0].HeaderText = "م";
                dgvStockTransactions.Columns[0].Width = 40;
                dgvStockTransactions.Columns[0].Visible = true;

                dgvStockTransactions.Columns[1].HeaderText = "معرف الحركة";
                dgvStockTransactions.Columns[1].Visible = false;

                dgvStockTransactions.Columns[2].HeaderText = "الوحدة";
                dgvStockTransactions.Columns[2].Width = 80;

                dgvStockTransactions.Columns[3].HeaderText = "المخزن";
                dgvStockTransactions.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvStockTransactions.Columns[4].HeaderText = "معرف نوع الحركة";
                dgvStockTransactions.Columns[4].Visible = false;

                dgvStockTransactions.Columns[5].HeaderText = "نوع الحركة";
                dgvStockTransactions.Columns[5].Width = 65;

                dgvStockTransactions.Columns[6].HeaderText = "سبب الحركة";
                dgvStockTransactions.Columns[6].Width = 120;

                dgvStockTransactions.Columns[7].HeaderText = "الكمية قبل الحركة";
                dgvStockTransactions.Columns[7].Width = 80;

                dgvStockTransactions.Columns[8].HeaderText = "التأثير على المخزون";
                dgvStockTransactions.Columns[8].Width = 85;

                dgvStockTransactions.Columns[9].HeaderText = "الكمية بعد الحركة";
                dgvStockTransactions.Columns[9].Width = 80;

                dgvStockTransactions.Columns[10].HeaderText = "تاريخ الحركة";
                dgvStockTransactions.Columns[10].Width = 120;

                dgvStockTransactions.Columns[11].HeaderText = "معرف الفاتورة";
                dgvStockTransactions.Columns[11].Visible = false;

                dgvStockTransactions.Columns[12].HeaderText = "معرف حركة النقل";
                dgvStockTransactions.Columns[12].Visible = false;
            }
            else
            {
                cbUnit.Enabled = cbWarehouse.Enabled = cbTransactionType.Enabled =
                    cbTransactionReason.Enabled = cbRange.Enabled = false;

                colTransactionNo.Visible = false;
            }
        }

        private void dgvStockTransactions_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            clsFormHelper.ApplyGreenRedRowStyle(dgvStockTransactions, e, "TransactionTypeID", 1, 2);
        }

        private void dgvStockTransactions_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvStockTransactions.Rows[e.RowIndex].Cells[colTransactionNo.Index].Value = e.RowIndex + 1;
        }

        private void dgvStockTransactions_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button is MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvStockTransactions.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dgvStockTransactions_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvStockTransactions.SelectedRows.Count == 1)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    clsStockTransaction currentStockTransaction = clsStockTransactionService.CreateInstance().Find(_GetSelectedTransactionID());

                    if (currentStockTransaction != null && currentStockTransaction.TransactionReason == clsStockTransaction.enTransactionReason.TransferOperation)
                    {
                        ShowTransferOperationInfo_Click(sender, e);
                    }
                    else
                    {
                        ShowInvoiceDetails_Click(sender, e);
                    }
                }
            }
        }

        private void dgvStockTransactions_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1 || e.Button == MouseButtons.Right || dgvStockTransactions.SelectedRows.Count == 0)
            {
                return;
            }

            clsStockTransaction currentStockTransaction = clsStockTransactionService.CreateInstance().Find(_GetSelectedTransactionID());

            if (currentStockTransaction != null && currentStockTransaction.TransactionReason == clsStockTransaction.enTransactionReason.TransferOperation)
            {
                ShowTransferOperationInfo_Click(sender, e);
            }
            else
            {
                ShowInvoiceDetails_Click(sender, e);
            }
        }

        private void stockTransactionsContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            clsFormHelper.PreventContextMenuOnEmptyClick(dgvStockTransactions, e);

            if (dgvStockTransactions.SelectedRows.Count == 0)
            {
                e.Cancel = true;
                return;
            }

            if (dgvStockTransactions.CurrentRow.Index >= 0)
            {
                StockTransactionsContextMenuStrip.Items[0].Visible = StockTransactionsContextMenuStrip.Items[1].Visible = false;

                clsStockTransaction currentStockTransaction = clsStockTransactionService.CreateInstance().Find(_GetSelectedTransactionID());

                if (currentStockTransaction != null)
                {
                    if (currentStockTransaction.TransactionReason == clsStockTransaction.enTransactionReason.TransferOperation)
                    {
                        StockTransactionsContextMenuStrip.Items[1].Visible = true;
                    }
                    else
                    {
                        StockTransactionsContextMenuStrip.Items[0].Visible = true;
                    }
                }
            }
        }

        private void cbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilterForInvoicesPage();
        }

        private void cbWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilterForInvoicesPage();
        }

        private void cbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilterForInvoicesPage();
        }

        private void cbTransactionReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilterForInvoicesPage();
        }

        private void cbRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilterForInvoicesPage();
        }

        private int _GetSelectedTransactionID()
        {
            try
            {
                return (int?)dgvStockTransactions.SelectedRows[0].Cells["TransactionID"].Value ?? -1;
            }
            catch
            {
                return -1;
            }
        }

        private void _ApplyFilterForInvoicesPage()
        {
            if (dgvStockTransactions.DataSource == null || (dgvStockTransactions.DataSource as DataTable).Rows.Count == 0)
            {
                return;
            }

            List<string> filters = new List<string>();
            DataView stockTransaction = (dgvStockTransactions.DataSource as DataTable).DefaultView;
            DateTime range;

            if (cbUnit.SelectedIndex != 0)
            {
                filters.Add($"UnitName = '{cbUnit.Text}'");
            }

            if (cbWarehouse.SelectedIndex != 0)
            {
                filters.Add($"WarehouseName = '{cbWarehouse.Text}'");
            }

            if (cbTransactionType.SelectedIndex != 0)
            {
                filters.Add($"TransactionTypeName = '{cbTransactionType.Text}'");
            }

            if (cbTransactionReason.SelectedIndex != 0)
            {
                filters.Add($"ReasonName = '{cbTransactionReason.Text}'");
            }

            if (cbRange.SelectedIndex == 0)
            {
                range = DateTime.Now.AddDays(-1);
            }
            else if (cbRange.SelectedIndex == 1)
            {
                range = DateTime.Now.AddDays(-7);
            }
            else if (cbRange.SelectedIndex == 2)
            {
                range = DateTime.Now.AddMonths(-1);
            }
            else if (cbRange.SelectedIndex == 3)
            {
                range = DateTime.Now.AddMonths(-6);
            }
            else
            {
                range = DateTime.Now.AddYears(-1);
            }

            filters.Add($"(TransactionTime >= #{range:yyyy-MM-dd}# AND TransactionTime <= #{DateTime.Now:yyyy-MM-dd}#)");
            stockTransaction.RowFilter = string.Join(" AND ", filters);
        }

    }
}
