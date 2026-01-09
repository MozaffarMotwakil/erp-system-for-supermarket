using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using SIMS.WinForms.Users;
using SIMS.WinForms.Sales;
using SIMS.WinForms.Reports;
using SIMS.WinForms.Products;
using SIMS.WinForms.Payments;
using SIMS.WinForms.Suppliers;
using SIMS.WinForms.Dashboard;
using SIMS.WinForms.Purchases;
using SIMS.WinForms.Warehouses;
using SIMS.WinForms.ActivityLog;
using DVLD.WinForms.Utils;
using BusinessLogic.Reports;

namespace SIMS.WinForms
{
    public partial class frmMainForm : Form
    {
        enum enFormType 
        {
            Dashboard,
            PointOfSale,
            ProductsList,
            DiscountsList,
            TaxesList,
            SuppliersList,
            SuppliedItemsLog,
            WarehousesList,
            InventoriesList,
            StockTransactionsList,
            TransferOperations,
            PurchasesList,
            SalesList,
            UsersList,
            PaymentsList,
            ActivityLog
        };

        private Form _DashboardForm;
        private Form _PointOfSaleForm;
        private Form _ProductsListForm;
        private Form _DiscountsListForm;
        private Form _TaxesListForm;
        private Form _SuppliersList;
        private Form _SuppliedItemsLog;
        private Form _WarehousesList;
        private Form _InventoriesList;
        private Form _StockTransactionsList;
        private Form _TransferOperations;
        private Form _PurchasesList;
        private Form _SalesList;
        private Form _UsersListForm;
        private Form _PaymentsListForm;
        private Form _ActivityLogForm;
        private static frmMainForm _Instance;

        private frmMainForm()
        {
            InitializeComponent();
            ClockAndDateTimer.Start();

            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = Color.White;
                    break;
                }
            }
        }

        public static frmMainForm CreateInstance()
        {
            if (_Instance == null || _Instance.IsDisposed)
            {
                _Instance = new frmMainForm();
            }

            return _Instance;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _OpenForm(ref _DashboardForm, enFormType.Dashboard);
        }

        private void ClockAndDateTimer_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblCurrentDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void DashboardToolStripButton_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _DashboardForm, enFormType.Dashboard);
        }

        private void PointOfSelesToolStripButton_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _PointOfSaleForm, enFormType.PointOfSale);
        }

        private void SuppliersToolStripButton_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _SuppliersList, enFormType.SuppliersList);
        }

        private void SuppliedItemsLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _SuppliedItemsLog, enFormType.SuppliedItemsLog);
        }

        private void CustomersToolStripButton_Click(object sender, EventArgs e)
        {
            clsFormMessages.ShowNotImplementedFeatureWarning();
        }

        private void ProductsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _ProductsListForm, enFormType.ProductsList);
        }

        private void DiscountsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _DiscountsListForm, enFormType.DiscountsList);
        }

        private void TaxesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _TaxesListForm, enFormType.TaxesList);
        }

        private void WarehousesToolStripButton_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _WarehousesList, enFormType.WarehousesList);
        }

        private void InventoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _InventoriesList, enFormType.InventoriesList);
        }

        private void StockTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _StockTransactionsList, enFormType.StockTransactionsList);
        }

        private void TransferOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _TransferOperations, enFormType.TransferOperations);
        }

        private void PurchasesToolStripButton_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _PurchasesList, enFormType.PurchasesList);
        }

        private void SalesToolStripButton_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _SalesList, enFormType.SalesList);
        }

        private void PaymentsToolStripButton_Click(object sender, EventArgs e)
        {
            _OpenForm(ref _PaymentsListForm, enFormType.PaymentsList);
        }

        private void EmployeesToolStripButton_Click(object sender, EventArgs e)
        {
            clsFormMessages.ShowNotImplementedFeatureWarning();
        }

        private void UsersToolStripButton_Click(object sender, EventArgs e)
        {
            clsFormMessages.ShowNotImplementedFeatureWarning();
            // _OpenForm(ref _UsersListForm, enFormType.UsersList);
        }

        private void ActivityLogToolStripButton_Click(object sender, EventArgs e)
        {
            clsFormMessages.ShowNotImplementedFeatureWarning();
            // _OpenForm(ref _ActivityLogForm, enFormType.ActivityLog);
        }

        private void SettingsToolStripButton_Click(object sender, EventArgs e)
        {
            clsFormMessages.ShowNotImplementedFeatureWarning();
        }

        private void LogoutToolStripButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms["frmLogin"].Visible = true;
            this.Close();
            frmMainForm.CreateInstance();
        }

        private void _OpenForm(ref Form form, enFormType formType)
        {
            if (form == null || form.IsDisposed)
            {
                form = _GerFormType(formType);

                Type type = form.GetType();

                if (Application.OpenForms.Cast<Form>().Any(f => f.GetType() == type))
                {
                    form = null;
                    return;
                }

                // Close any opened form before opening a new form.
                for (byte i = 2; i < Application.OpenForms.Count; i++)
                {
                    Application.OpenForms[i].Close();
                }
                
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                lblCurrentFormName.Text = form.Text;
                form.Show();
            }
        }

        public static void OpenForm(Form form)
        {
            // Close any opened form before opening a new form.
            for (byte i = 2; i < Application.OpenForms.Count; i++)
            {
                Application.OpenForms[i].Close();
            }

            form.MdiParent = Application.OpenForms["frmMainForm"];
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private Form _GerFormType(enFormType formType)
        {
            switch (formType)
            {
                case enFormType.Dashboard:
                    return new frmDashboard();
                case enFormType.PointOfSale:
                    return new frmPointOfSale();
                case enFormType.ProductsList:
                    return new frmProductsList();
                case enFormType.DiscountsList:
                    return new frmDiscountsList();
                case enFormType.TaxesList:
                    return new frmTaxesList();
                case enFormType.SuppliersList:
                    return new frmSuppliersList();
                case enFormType.SuppliedItemsLog:
                    return new frmSuppliedItemsLogList();
                case enFormType.WarehousesList:
                    return new frmWarehouswList();
                case enFormType.InventoriesList:
                    return new frmInventoriesList();
                case enFormType.StockTransactionsList:
                    return new frmStockTransactionsList();
                case enFormType.TransferOperations:
                    return new frmTransferedOperationsList();
                case enFormType.PurchasesList:
                    return new frmPurchasesList();
                case enFormType.SalesList:
                    return new frmSalesList();
                case enFormType.UsersList:
                    return new frmUsersList();
                case enFormType.PaymentsList:
                    return new frmPaymentsList();
                case enFormType.ActivityLog:
                    return new frmActivityLog();
                default:
                    return new Form();
            }
        }

        private void BasicSalesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueReportFilters issueReportFilters = new frmIssueReportFilters(BasicSalesReportToolStripMenuItem.Text);
            issueReportFilters.ShowDialog();
        }

        private void BasicPurchasesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueReportFilters issueReportFilters = new frmIssueReportFilters(BasicPurchasesReportToolStripMenuItem.Text);
            issueReportFilters.ShowDialog();
        }

        private void BasicInventoriesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsFormMessages.ShowNotImplementedFeatureWarning();
        }

        private void BasicFinatcialReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsFormMessages.ShowNotImplementedFeatureWarning();
        }

    }
}
