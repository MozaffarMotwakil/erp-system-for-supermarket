using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BusinessLogic.Products;
using BusinessLogic.Warehouses;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Products;
using SIMS.WinForms.Properties;
using static BusinessLogic.Warehouses.clsInventoryService;

namespace SIMS.WinForms.Warehouses
{
    public partial class frmInventoriesList : BaseInventoriesForm
    {
        private enShowMode _ShowMode;
        private string _ProductName;
        private string _UnitName;
        private string _WarehouseName;

        public frmInventoriesList()
        {
            InitializeComponent();
        }

        public frmInventoriesList(string productName = "كل المنتجات",
            string unitName = "كل الوحدات", string warehouseName = "كل المخازن")
        {
            InitializeComponent();
            frmMainForm.CreateInstance().lblCurrentFormName.Text = this.Text;
            _ProductName = string.IsNullOrWhiteSpace(productName) ? "كل المنتجات" : productName;
            _UnitName = string.IsNullOrWhiteSpace(unitName) ? "كل الوحدات" : unitName;
            _WarehouseName = string.IsNullOrWhiteSpace(warehouseName) ? "كل المخازن" : warehouseName;
            _ShowMode = enShowMode.Special;
        }

        private void frmInventoriesList_Load(object sender, EventArgs e)
        {
            contextMenuStrip.Items.Clear();

            contextMenuStrip.Items.Add("عرض حركات المخزون");
            contextMenuStrip.Items[0].Image = Resources.stock_market;
            contextMenuStrip.Items[0].ImageScaling = ToolStripItemImageScaling.None;
            contextMenuStrip.Items[0].Click += ShowTransactionLog_Click;

            contextMenuStrip.Items.Add("تعديل معلومات المنتج");
            contextMenuStrip.Items[1].Image = Resources.shopping_basket_edit;
            contextMenuStrip.Items[1].ImageScaling = ToolStripItemImageScaling.None;
            contextMenuStrip.Items[1].Click += ShowProductInfo_Click;

            contextMenuStrip.Items.Add("تعديل حد إعادة الطلب");
            contextMenuStrip.Items[2].Image = Resources.edit;
            contextMenuStrip.Items[2].ImageScaling = ToolStripItemImageScaling.None;
            contextMenuStrip.Items[2].Click += UpdateReorderQuantity_Click;

            cbProduct.SelectedIndex = cbCategory.SelectedIndex =
                cbUnit.SelectedIndex = cbWarehouse.SelectedIndex = 
                cbInventoryStatus.SelectedIndex = 0;

            cbProduct.Items.AddRange(clsProductService.GetAllProductNames());
            cbCategory.Items.AddRange(clsCategoryService.GetCategoryNames());
            cbUnit.Items.AddRange(clsUnit.GetAllUnitNames());
            cbWarehouse.Items.AddRange(clsWarehouseService.GetWarehouseNames());

            dgvEntitiesList.RowPrePaint += dgvEntitiesList_RowPrePaint;
            clsProductService.CreateInstance().EntitySaved += FrmInventoriesList_ProductSaved;

            if (_ShowMode == enShowMode.Special)
            {
                cbProduct.SelectedItem = _ProductName;
                cbUnit.SelectedItem = _UnitName;
                cbWarehouse.SelectedItem = _WarehouseName;
                btnApplyFilter_Click(sender, e);
            }
        }

        protected override void LoadData()
        {
            base.LoadData();
            AllowDeleteRecord = false;
        }

        private void FrmInventoriesList_ProductSaved(object sender, BusinessLogic.Interfaces.EntitySavedEventArgs e)
        {
            base.EntitySavedEvent(sender, e);
        }

        protected override void dgvEntitiesList_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvEntitiesList.SelectedRows.Count == 1)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ShowTransactionLog_Click(sender, e);
                }
                else if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                {
                    base.DeleteSelectedEntity();
                }
            }
        }

        protected override void dgvEntitiesList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1 || e.Button == MouseButtons.Right || dgvEntitiesList.SelectedRows.Count == 0)
            {
                return;
            }

            ShowTransactionLog_Click(sender, e);
        }

        private void dgvEntitiesList_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            clsFormHelper.ApplyGreenYellowRedRowStyle(dgvEntitiesList, e, "InventoryStatus", "آمن", "منخفض", "نفذ");
        }

        private void UpdateReorderQuantity_Click(object sender, EventArgs e)
        {
            if (dgvEntitiesList.SelectedRows.Count == 0)
            {
                return;
            }

            frmUpdateReorderInventoryQuantity inventoryQuantity = new frmUpdateReorderInventoryQuantity(clsFormHelper.GetSelectedRowID(dgvEntitiesList));
            inventoryQuantity.ShowDialog();
        }

        private void ShowProductInfo_Click(object sender, EventArgs e)
        {
            if (dgvEntitiesList.SelectedRows.Count == 0)
            {
                return;
            }

            int? productID = (int?)GetCellValue(dgvEntitiesList.Columns["ProductID"].Index);

            if (productID.HasValue)
            {
                frmAddEditProduct editProduct = new frmAddEditProduct(productID.Value);
                editProduct.ShowDialog();
            }
            else
            {
                clsFormMessages.ShowError("لم يتم العثور على المنتج");
            }
        }

        private void ShowTransactionLog_Click(object sender, EventArgs e)
        {
            if (dgvEntitiesList.SelectedRows.Count == 0)
            {
                return;
            }

            clsInventory currentInventory = clsInventoryService.CreateInstance().Find(clsFormHelper.GetSelectedRowID(dgvEntitiesList));

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

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            List<string> filters = new List<string>();

            if (cbProduct.SelectedIndex == -1 || cbUnit.SelectedIndex == -1 || cbWarehouse.SelectedIndex == -1 ||
                cbCategory.SelectedIndex == -1 || cbInventoryStatus.SelectedIndex == -1)
            {
                clsFormMessages.ShowError("هناك بعض الحقول تحتوي على قيم غير صالحة, رجاءا قم بتعيين قيم صالحة في جميع الحقول للبحث");
                return;
            }

            if (cbProduct.SelectedIndex != 0)
            {
                filters.Add($"ProductName = '{cbProduct.Text}'");
            }

            if (cbCategory.SelectedIndex != 0)
            {
                filters.Add($"CategoryName = '{cbCategory.Text}'");
            }

            if (cbUnit.SelectedIndex != 0)
            {
                filters.Add($"UnitName = '{cbUnit.Text}'");
            }

            if (cbWarehouse.SelectedIndex != 0)
            {
                filters.Add($"WarehouseName = '{cbWarehouse.Text}'");
            }

            if (cbInventoryStatus.SelectedIndex != 0)
            {
                filters.Add($"InventoryStatus = '{cbInventoryStatus.Text}'");
            }

            base.Filter = string.Join(" AND ", filters);
            base.ApplySearchFilter();
        }

        private void cbProduct_Leave(object sender, EventArgs e)
        {
            if (cbProduct.SelectedIndex == -1)
            {
                cbProduct.SelectedIndex = 0;
            }
        }

        private void cbCategory_Leave(object sender, EventArgs e)
        {
            if (cbCategory.SelectedIndex == -1)
            {
                cbCategory.SelectedIndex = 0;
            }
        }

        protected override void UpdateRecordsCountLabels()
        {
            base.UpdateRecordsCountLabels();
            InventoryInfo inventoryInfo = clsInventoryService.CreateInstance()
                .CalculateInventoriesValues(dgvEntitiesList.DataSource as DataTable);
            UpdateLabelValues(inventoryInfo);
        }

        protected override void UpdateRecordsCountLabels(DataView filteredDataSource)
        {
            base.UpdateRecordsCountLabels(filteredDataSource);
            InventoryInfo inventoryInfo = clsInventoryService.CreateInstance()
                .CalculateInventoriesValues(filteredDataSource);
            UpdateLabelValues(inventoryInfo);
        }

        private void UpdateLabelValues(InventoryInfo inventoryInfo)
        {
            lblSavedIInventoriesCount.Text = inventoryInfo.SavedItemsCount.ToString();
            lblLowedInventoriesCount.Text = inventoryInfo.LowedItemsCount.ToString();
            lblEmptyInventoriesCount.Text = inventoryInfo.EmptyItemsCount.ToString();
            lblTotalInventoryValue.Text = inventoryInfo.TotalCurrentAmount.ToString() + " ج.س";
            lblTotalProjectedSalesValue.Text = inventoryInfo.TotalProjectedSellAmount.ToString() + " ج.س";
            lblExpectedProfitValue.Text = inventoryInfo.TotalProfitAmoubt.ToString() + " ج.س";
            lblExpectedProfitRate.Text = inventoryInfo.TotalProfitRate.ToString() + "%";
        }

    }
}