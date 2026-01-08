using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BusinessLogic.Reports;
using BusinessLogic.Warehouses;
using DVLD.WinForms.Utils;
using SIMS.WinForms.Suppliers;
using SIMS.WinForms.Warehouses;

namespace SIMS.WinForms.Dashboard
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            clsDailySummary dailySummary = new clsDailySummary();

            lblTodaySales.Text = dailySummary.TodaySales.ToString("0.##") + " ج.س";
            lblTodayTotalSalesReturn.Text = dailySummary.TodaySalesReturn.ToString("0.##") + " ج.س";
            lblTodayNetSales.Text = dailySummary.TodayNetSales.ToString("0.##") + " ج.س";
            lblTodaySalesInvoices.Text = dailySummary.TodaySalesInvoiceCount.ToString();

            lblTodayPurchases.Text = dailySummary.TodayPurchases.ToString("0.##") + " ج.س";
            lblTodayPurchasesReturn.Text = dailySummary.TodayPurchasesReturn.ToString("0.##") + " ج.س";
            lblTodayNetPurchases.Text = dailySummary.TodayNetPurchases.ToString("0.##") + " ج.س";
            lblTodayPurchasesInvoices.Text = dailySummary.TodayPurchasesInvoiceCount.ToString();

            lblTodayTotalProfits.Text = dailySummary.TodayProfit.ToString("0.##") + " ج.س";
            lblTodayProfitRate.Text = dailySummary.TodayProfitRate.ToString("0.##") + "%";

            lblCategorySalesTextHeder.Text = lblCategorySalesTextHeder.Text.Replace("الشهر الحالي", GetCurrentMonthNameAr());
            LoadCategoryChart(clsCategorySales.GetTopCategorySalesForCurrentMonth());

            dgvRunningLowProducts.DataSource = clsInventoryService.CreateInstance().GetRunningLowInventories();
            _ResetColumnsOfDGV();

            dgvRunningLowProducts.CellMouseDown += clsFormHelper.SelectingOnCurrentRowByRightMouse;
        }

        public static string GetCurrentMonthNameAr()
        {
            return DateTime.Now.ToString("MMMM", new CultureInfo("ar-EG"));
        }

        private void dgvRunningLowProducts_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            clsFormHelper.ApplyGreenYellowRedRowStyle(dgvRunningLowProducts, e, "InventoryStatus", "آمن", "منخفض", "نفذ");
        }

        private void _ResetColumnsOfDGV()
        {
            if (dgvRunningLowProducts.RowCount > 0)
            {
                dgvRunningLowProducts.ColumnHeadersDefaultCellStyle.Font =
                   new Font("Tahoma", 7, FontStyle.Bold);

                dgvRunningLowProducts.DefaultCellStyle.Font =
                    new Font("Tahoma", 8);

                clsFormHelper.DisableSortableDataGridViewColumns(dgvRunningLowProducts);

                dgvRunningLowProducts.Columns[0].HeaderText = "معرف المخزون";
                dgvRunningLowProducts.Columns[0].Visible = false;

                dgvRunningLowProducts.Columns[1].HeaderText = "معرف المنتج";
                dgvRunningLowProducts.Columns[1].Visible = false;

                dgvRunningLowProducts.Columns[2].HeaderText = "المنتج";
                dgvRunningLowProducts.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvRunningLowProducts.Columns[3].HeaderText = "الصنف/الفئة";
                dgvRunningLowProducts.Columns[3].Width = 150;
                dgvRunningLowProducts.Columns[3].Visible = false;

                dgvRunningLowProducts.Columns[4].HeaderText = "معرف الوحدة";
                dgvRunningLowProducts.Columns[4].Visible = false;

                dgvRunningLowProducts.Columns[5].HeaderText = "الوحدة";
                dgvRunningLowProducts.Columns[5].Width = 90;

                dgvRunningLowProducts.Columns[6].HeaderText = "معرف المخزن";
                dgvRunningLowProducts.Columns[6].Visible = false;

                dgvRunningLowProducts.Columns[7].HeaderText = "المخزن";
                dgvRunningLowProducts.Columns[7].Width = 120;

                dgvRunningLowProducts.Columns[8].HeaderText = "حد إعادة الطلب";
                dgvRunningLowProducts.Columns[8].Width = 55;

                dgvRunningLowProducts.Columns[9].HeaderText = "الكمية الحالية";
                dgvRunningLowProducts.Columns[9].Width = 55;

                dgvRunningLowProducts.Columns[10].HeaderText = "متوسط سعر الشراء (جنيه)";
                dgvRunningLowProducts.Columns[10].Width = 85;
                dgvRunningLowProducts.Columns[10].DefaultCellStyle.Format = "0.##";
                dgvRunningLowProducts.Columns[10].Visible = false;

                dgvRunningLowProducts.Columns[11].HeaderText = "سعر البيع (جنيه)";
                dgvRunningLowProducts.Columns[11].Width = 85;
                dgvRunningLowProducts.Columns[11].DefaultCellStyle.Format = "0.##";
                dgvRunningLowProducts.Columns[11].Visible = false;

                dgvRunningLowProducts.Columns[12].HeaderText = "تكلفة شراء المخزون (جنيه)";
                dgvRunningLowProducts.Columns[12].Width = 85;
                dgvRunningLowProducts.Columns[12].DefaultCellStyle.Format = "0.##";
                dgvRunningLowProducts.Columns[12].Visible = false;

                dgvRunningLowProducts.Columns[13].HeaderText = "قيمة بيع المخزون (جنيه)";
                dgvRunningLowProducts.Columns[13].Width = 85;
                dgvRunningLowProducts.Columns[13].DefaultCellStyle.Format = "0.##";
                dgvRunningLowProducts.Columns[13].Visible = false;

                dgvRunningLowProducts.Columns[14].HeaderText = "الربح المتوقع (جنيه)";
                dgvRunningLowProducts.Columns[14].Width = 85;
                dgvRunningLowProducts.Columns[14].DefaultCellStyle.Format = "0.##";
                dgvRunningLowProducts.Columns[14].Visible = false;

                dgvRunningLowProducts.Columns[15].HeaderText = "معدل الربح (%)";
                dgvRunningLowProducts.Columns[15].Width = 85;
                dgvRunningLowProducts.Columns[15].Visible = false;

                dgvRunningLowProducts.Columns[16].HeaderText = "آخر حركة شراء";
                dgvRunningLowProducts.Columns[16].Width = 125;
                dgvRunningLowProducts.Columns[16].Visible = false;

                dgvRunningLowProducts.Columns[17].HeaderText = "آخر حركة بيع";
                dgvRunningLowProducts.Columns[17].Width = 125;
                dgvRunningLowProducts.Columns[17].Visible = false;

                dgvRunningLowProducts.Columns[18].HeaderText = "آخر حركة نقل";
                dgvRunningLowProducts.Columns[18].Width = 125;
                dgvRunningLowProducts.Columns[18].Visible = false;

                dgvRunningLowProducts.Columns[19].HeaderText = "حالة المخزون";
                dgvRunningLowProducts.Columns[19].Width = 85;
                dgvRunningLowProducts.Columns[19].Visible = false;
            }
        }

        private void GoToInventoriesListtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRunningLowProducts.SelectedRows.Count == 0)
            {
                return;
            }

            clsInventory currentInventory = clsInventoryService.CreateInstance().Find(clsFormHelper.GetSelectedRowID(dgvRunningLowProducts, "InventoryID"));

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

        private void ShowStockTransactionsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRunningLowProducts.SelectedRows.Count == 0)
            {
                return;
            }

            clsInventory currentInventory = clsInventoryService.CreateInstance().Find(clsFormHelper.GetSelectedRowID(dgvRunningLowProducts, "InventoryID"));

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

        private void SuppliedItemsLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRunningLowProducts.SelectedRows.Count == 0)
            {
                return;
            }

            clsInventory currentInventory = clsInventoryService.CreateInstance().Find(clsFormHelper.GetSelectedRowID(dgvRunningLowProducts, "InventoryID"));

            if (currentInventory != null)
            {
                frmSuppliedItemsLogList suppliedItemsLogList = new frmSuppliedItemsLogList(
                    productName: currentInventory.ProductInfo.ProductName,
                    unitName: currentInventory.UnitInfo.UnitName,
                    warehouseName: currentInventory.WarehouseInfo.WarehouseName
                    );

                frmMainForm.OpenForm(suppliedItemsLogList);
            }
            else
            {
                clsFormMessages.ShowError("لم يتم العثور على المخزون");
            }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            clsFormHelper.PreventContextMenuOnEmptyClick(dgvRunningLowProducts, e);

            if (dgvRunningLowProducts.SelectedRows.Count == 0)
            {
                e.Cancel = true;
            }
        }

        public void LoadCategoryChart(List<clsCategorySales> categoriesSales)
        {
            var sortedList = categoriesSales
                .Where(c => c.CategoryName != "أخرى")
                .OrderByDescending(c => c.SalesAmount) 
                .ToList();

            var othersItem = categoriesSales
                .FirstOrDefault(c => c.CategoryName == "أخرى");

            if (othersItem != null)
            {
                sortedList.Add(othersItem);
            }

            var series = new Series
            {
                Name = "Categories",
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = false
            };

            chartCategoriesSales.Series.Add(series);

            decimal total = sortedList.Sum(c => c.SalesAmount);

            foreach (var item in sortedList)
            {
                int i = series.Points.AddXY(item.CategoryName, item.SalesAmount);
                decimal percent = total > 0 ? (item.SalesAmount / total) * 100 : 0;

                series.Points[i].Label = "";
                series.Points[i].LegendText = item.CategoryName;
                series.Points[i].ToolTip = $"{item.CategoryName}: {item.SalesAmount:0.##} ج.س ({percent:0.#}%)";
            }

            series["PieLabelStyle"] = "Disabled";
           
            chartCategoriesSales.Legends[0].Enabled = true;
            chartCategoriesSales.Legends[0].Docking = Docking.Bottom;
            chartCategoriesSales.Legends[0].Alignment = StringAlignment.Center;
            chartCategoriesSales.Legends[0].LegendStyle = LegendStyle.Table;
            chartCategoriesSales.Legends[0].TableStyle = LegendTableStyle.Wide;
            chartCategoriesSales.Legends[0].Font = new Font("Segoe UI", 9, FontStyle.Regular);
        }

        private void dgvRunningLowProducts_MouseDown(object sender, MouseEventArgs e)
        {

            DataGridView.HitTestInfo hit = dgvRunningLowProducts.HitTest(e.X, e.Y);

            if (hit.Type == DataGridViewHitTestType.None || hit.Type == DataGridViewHitTestType.ColumnHeader)
            {
                dgvRunningLowProducts.ClearSelection();
            }
        }

        private void Dashbord_Click(object sender, MouseEventArgs e)
        {
            dgvRunningLowProducts.ClearSelection();
        }

        private void AnyControl_MouseDown(object sender, MouseEventArgs e)
        {
            dgvRunningLowProducts.ClearSelection();
        }

        private void dgvRunningLowProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvRunningLowProducts.ClearSelection();
        }

    }
}
