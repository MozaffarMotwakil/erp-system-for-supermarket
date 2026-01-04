namespace SIMS.WinForms
{
    partial class frmMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.DashboardToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PointOfSelesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SuppliersToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.SuppliersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SuppliedItemsLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ProductsDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ProductsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DiscountsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaxesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WarehousesAndInventories = new System.Windows.Forms.ToolStripDropDownButton();
            this.WarehousesToolStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.InventoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StockTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransferOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PurchasesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SalesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PaymentsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EmployeesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UsersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ReportsToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.BasicSalesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BasicPurchasesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BasicInventoriesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BasicFinatcialReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActivityLogToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SettingsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LogoutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.circularPictureBox = new ctrCircularPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCurrentFormName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.ClockAndDateTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.DarkCyan;
            this.toolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DashboardToolStripButton,
            this.PointOfSelesToolStripButton,
            this.SuppliersToolStripDropDownButton,
            this.CustomersToolStripButton,
            this.ProductsDropDownButton,
            this.WarehousesAndInventories,
            this.PurchasesToolStripButton,
            this.SalesToolStripButton,
            this.PaymentsToolStripButton,
            this.EmployeesToolStripButton,
            this.UsersToolStripButton,
            this.ReportsToolStripButton,
            this.ActivityLogToolStripButton,
            this.SettingsToolStripButton,
            this.LogoutToolStripButton});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 204);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.ShowItemToolTips = false;
            this.toolStrip.Size = new System.Drawing.Size(250, 584);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";
            // 
            // DashboardToolStripButton
            // 
            this.DashboardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DashboardToolStripButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DashboardToolStripButton.Image")));
            this.DashboardToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DashboardToolStripButton.Name = "DashboardToolStripButton";
            this.DashboardToolStripButton.Size = new System.Drawing.Size(249, 36);
            this.DashboardToolStripButton.Text = "لمحة سريعة";
            this.DashboardToolStripButton.Click += new System.EventHandler(this.DashboardToolStripButton_Click);
            // 
            // PointOfSelesToolStripButton
            // 
            this.PointOfSelesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PointOfSelesToolStripButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointOfSelesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("PointOfSelesToolStripButton.Image")));
            this.PointOfSelesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PointOfSelesToolStripButton.Name = "PointOfSelesToolStripButton";
            this.PointOfSelesToolStripButton.Size = new System.Drawing.Size(249, 36);
            this.PointOfSelesToolStripButton.Text = "Point of Seles";
            this.PointOfSelesToolStripButton.Visible = false;
            this.PointOfSelesToolStripButton.Click += new System.EventHandler(this.PointOfSelesToolStripButton_Click);
            // 
            // SuppliersToolStripDropDownButton
            // 
            this.SuppliersToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SuppliersToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SuppliersListToolStripMenuItem,
            this.SuppliedItemsLogToolStripMenuItem});
            this.SuppliersToolStripDropDownButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppliersToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("SuppliersToolStripDropDownButton.Image")));
            this.SuppliersToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SuppliersToolStripDropDownButton.Name = "SuppliersToolStripDropDownButton";
            this.SuppliersToolStripDropDownButton.Size = new System.Drawing.Size(249, 36);
            this.SuppliersToolStripDropDownButton.Text = "الموردين";
            // 
            // SuppliersListToolStripMenuItem
            // 
            this.SuppliersListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppliersListToolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.supplier_32;
            this.SuppliersListToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SuppliersListToolStripMenuItem.Name = "SuppliersListToolStripMenuItem";
            this.SuppliersListToolStripMenuItem.Size = new System.Drawing.Size(216, 38);
            this.SuppliersListToolStripMenuItem.Text = "قائمة الموردين";
            this.SuppliersListToolStripMenuItem.Click += new System.EventHandler(this.SuppliersToolStripButton_Click);
            // 
            // SuppliedItemsLogToolStripMenuItem
            // 
            this.SuppliedItemsLogToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppliedItemsLogToolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.supplied_items_32;
            this.SuppliedItemsLogToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SuppliedItemsLogToolStripMenuItem.Name = "SuppliedItemsLogToolStripMenuItem";
            this.SuppliedItemsLogToolStripMenuItem.Size = new System.Drawing.Size(216, 38);
            this.SuppliedItemsLogToolStripMenuItem.Text = "سجل التوريد";
            this.SuppliedItemsLogToolStripMenuItem.Click += new System.EventHandler(this.SuppliedItemsLogToolStripMenuItem_Click);
            // 
            // CustomersToolStripButton
            // 
            this.CustomersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CustomersToolStripButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CustomersToolStripButton.Image")));
            this.CustomersToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CustomersToolStripButton.Name = "CustomersToolStripButton";
            this.CustomersToolStripButton.Size = new System.Drawing.Size(249, 36);
            this.CustomersToolStripButton.Text = "العملاء";
            this.CustomersToolStripButton.Click += new System.EventHandler(this.CustomersToolStripButton_Click);
            // 
            // ProductsDropDownButton
            // 
            this.ProductsDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ProductsDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductsListToolStripMenuItem,
            this.DiscountsListToolStripMenuItem,
            this.TaxesListToolStripMenuItem});
            this.ProductsDropDownButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ProductsDropDownButton.Image")));
            this.ProductsDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ProductsDropDownButton.Name = "ProductsDropDownButton";
            this.ProductsDropDownButton.Size = new System.Drawing.Size(249, 36);
            this.ProductsDropDownButton.Text = "المنتجات";
            // 
            // ProductsListToolStripMenuItem
            // 
            this.ProductsListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsListToolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.dairy_products;
            this.ProductsListToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ProductsListToolStripMenuItem.Name = "ProductsListToolStripMenuItem";
            this.ProductsListToolStripMenuItem.Size = new System.Drawing.Size(216, 38);
            this.ProductsListToolStripMenuItem.Text = "قائمة المنتجات";
            this.ProductsListToolStripMenuItem.Click += new System.EventHandler(this.ProductsListToolStripMenuItem_Click);
            // 
            // DiscountsListToolStripMenuItem
            // 
            this.DiscountsListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountsListToolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.discount;
            this.DiscountsListToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DiscountsListToolStripMenuItem.Name = "DiscountsListToolStripMenuItem";
            this.DiscountsListToolStripMenuItem.Size = new System.Drawing.Size(216, 38);
            this.DiscountsListToolStripMenuItem.Text = "الخصومات";
            this.DiscountsListToolStripMenuItem.Click += new System.EventHandler(this.DiscountsListToolStripMenuItem_Click);
            // 
            // TaxesListToolStripMenuItem
            // 
            this.TaxesListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxesListToolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.dividend;
            this.TaxesListToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TaxesListToolStripMenuItem.Name = "TaxesListToolStripMenuItem";
            this.TaxesListToolStripMenuItem.Size = new System.Drawing.Size(216, 38);
            this.TaxesListToolStripMenuItem.Text = "الضرائب";
            this.TaxesListToolStripMenuItem.Click += new System.EventHandler(this.TaxesListToolStripMenuItem_Click);
            // 
            // WarehousesAndInventories
            // 
            this.WarehousesAndInventories.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.WarehousesAndInventories.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WarehousesToolStripButton,
            this.InventoriesToolStripMenuItem,
            this.StockTransactionsToolStripMenuItem,
            this.TransferOperationsToolStripMenuItem});
            this.WarehousesAndInventories.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarehousesAndInventories.Image = ((System.Drawing.Image)(resources.GetObject("WarehousesAndInventories.Image")));
            this.WarehousesAndInventories.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WarehousesAndInventories.Name = "WarehousesAndInventories";
            this.WarehousesAndInventories.Size = new System.Drawing.Size(249, 36);
            this.WarehousesAndInventories.Text = "المخازن و المخزون";
            // 
            // WarehousesToolStripButton
            // 
            this.WarehousesToolStripButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarehousesToolStripButton.Image = global::SIMS.WinForms.Properties.Resources.warehouse;
            this.WarehousesToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.WarehousesToolStripButton.Name = "WarehousesToolStripButton";
            this.WarehousesToolStripButton.Size = new System.Drawing.Size(218, 38);
            this.WarehousesToolStripButton.Text = "المخازن";
            this.WarehousesToolStripButton.Click += new System.EventHandler(this.WarehousesToolStripButton_Click);
            // 
            // InventoriesToolStripMenuItem
            // 
            this.InventoriesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoriesToolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.packages;
            this.InventoriesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.InventoriesToolStripMenuItem.Name = "InventoriesToolStripMenuItem";
            this.InventoriesToolStripMenuItem.Size = new System.Drawing.Size(218, 38);
            this.InventoriesToolStripMenuItem.Text = "المخزون";
            this.InventoriesToolStripMenuItem.Click += new System.EventHandler(this.InventoriesToolStripMenuItem_Click);
            // 
            // StockTransactionsToolStripMenuItem
            // 
            this.StockTransactionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockTransactionsToolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.stock_market;
            this.StockTransactionsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.StockTransactionsToolStripMenuItem.Name = "StockTransactionsToolStripMenuItem";
            this.StockTransactionsToolStripMenuItem.Size = new System.Drawing.Size(218, 38);
            this.StockTransactionsToolStripMenuItem.Text = "حركات المخزون";
            this.StockTransactionsToolStripMenuItem.Click += new System.EventHandler(this.StockTransactionsToolStripMenuItem_Click);
            // 
            // TransferOperationsToolStripMenuItem
            // 
            this.TransferOperationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferOperationsToolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.supply;
            this.TransferOperationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TransferOperationsToolStripMenuItem.Name = "TransferOperationsToolStripMenuItem";
            this.TransferOperationsToolStripMenuItem.Size = new System.Drawing.Size(218, 38);
            this.TransferOperationsToolStripMenuItem.Text = "عمليات النقل";
            this.TransferOperationsToolStripMenuItem.Click += new System.EventHandler(this.TransferOperationsToolStripMenuItem_Click);
            // 
            // PurchasesToolStripButton
            // 
            this.PurchasesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PurchasesToolStripButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchasesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PurchasesToolStripButton.Name = "PurchasesToolStripButton";
            this.PurchasesToolStripButton.Size = new System.Drawing.Size(249, 36);
            this.PurchasesToolStripButton.Text = "المشتريات";
            this.PurchasesToolStripButton.Click += new System.EventHandler(this.PurchasesToolStripButton_Click);
            // 
            // SalesToolStripButton
            // 
            this.SalesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SalesToolStripButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SalesToolStripButton.Image")));
            this.SalesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalesToolStripButton.Name = "SalesToolStripButton";
            this.SalesToolStripButton.Size = new System.Drawing.Size(249, 36);
            this.SalesToolStripButton.Text = "المبيعات";
            this.SalesToolStripButton.Click += new System.EventHandler(this.SalesToolStripButton_Click);
            // 
            // PaymentsToolStripButton
            // 
            this.PaymentsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PaymentsToolStripButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("PaymentsToolStripButton.Image")));
            this.PaymentsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaymentsToolStripButton.Name = "PaymentsToolStripButton";
            this.PaymentsToolStripButton.Size = new System.Drawing.Size(249, 36);
            this.PaymentsToolStripButton.Text = "المدفوعات/المقبوضات";
            this.PaymentsToolStripButton.Click += new System.EventHandler(this.PaymentsToolStripButton_Click);
            // 
            // EmployeesToolStripButton
            // 
            this.EmployeesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EmployeesToolStripButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EmployeesToolStripButton.Image")));
            this.EmployeesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EmployeesToolStripButton.Name = "EmployeesToolStripButton";
            this.EmployeesToolStripButton.Size = new System.Drawing.Size(249, 36);
            this.EmployeesToolStripButton.Text = "الموظفين";
            this.EmployeesToolStripButton.Click += new System.EventHandler(this.EmployeesToolStripButton_Click);
            // 
            // UsersToolStripButton
            // 
            this.UsersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UsersToolStripButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("UsersToolStripButton.Image")));
            this.UsersToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UsersToolStripButton.Name = "UsersToolStripButton";
            this.UsersToolStripButton.Size = new System.Drawing.Size(249, 36);
            this.UsersToolStripButton.Text = "المسخدمين و الصلاحيات";
            this.UsersToolStripButton.Click += new System.EventHandler(this.UsersToolStripButton_Click);
            // 
            // ReportsToolStripButton
            // 
            this.ReportsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ReportsToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BasicSalesReportToolStripMenuItem,
            this.BasicPurchasesReportToolStripMenuItem,
            this.BasicInventoriesReportToolStripMenuItem,
            this.BasicFinatcialReportToolStripMenuItem});
            this.ReportsToolStripButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ReportsToolStripButton.Image")));
            this.ReportsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReportsToolStripButton.Name = "ReportsToolStripButton";
            this.ReportsToolStripButton.Size = new System.Drawing.Size(249, 36);
            this.ReportsToolStripButton.Text = "التقارير";
            // 
            // BasicSalesReportToolStripMenuItem
            // 
            this.BasicSalesReportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasicSalesReportToolStripMenuItem.Name = "BasicSalesReportToolStripMenuItem";
            this.BasicSalesReportToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.BasicSalesReportToolStripMenuItem.Text = "تقرير المبيعات الشامل";
            this.BasicSalesReportToolStripMenuItem.Click += new System.EventHandler(this.BasicSalesReportToolStripMenuItem_Click);
            // 
            // BasicPurchasesReportToolStripMenuItem
            // 
            this.BasicPurchasesReportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasicPurchasesReportToolStripMenuItem.Name = "BasicPurchasesReportToolStripMenuItem";
            this.BasicPurchasesReportToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.BasicPurchasesReportToolStripMenuItem.Text = "تقرير المشتريات الشامل";
            this.BasicPurchasesReportToolStripMenuItem.Click += new System.EventHandler(this.BasicPurchasesReportToolStripMenuItem_Click);
            // 
            // BasicInventoriesReportToolStripMenuItem
            // 
            this.BasicInventoriesReportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasicInventoriesReportToolStripMenuItem.Name = "BasicInventoriesReportToolStripMenuItem";
            this.BasicInventoriesReportToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.BasicInventoriesReportToolStripMenuItem.Text = "تقرير المخزون الشامل";
            this.BasicInventoriesReportToolStripMenuItem.Click += new System.EventHandler(this.BasicInventoriesReportToolStripMenuItem_Click);
            // 
            // BasicFinatcialReportToolStripMenuItem
            // 
            this.BasicFinatcialReportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasicFinatcialReportToolStripMenuItem.Name = "BasicFinatcialReportToolStripMenuItem";
            this.BasicFinatcialReportToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.BasicFinatcialReportToolStripMenuItem.Text = "التقرير المالي الشامل";
            this.BasicFinatcialReportToolStripMenuItem.Click += new System.EventHandler(this.BasicFinatcialReportToolStripMenuItem_Click);
            // 
            // ActivityLogToolStripButton
            // 
            this.ActivityLogToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ActivityLogToolStripButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityLogToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ActivityLogToolStripButton.Image")));
            this.ActivityLogToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActivityLogToolStripButton.Name = "ActivityLogToolStripButton";
            this.ActivityLogToolStripButton.Size = new System.Drawing.Size(249, 36);
            this.ActivityLogToolStripButton.Text = "سجل النشاط";
            this.ActivityLogToolStripButton.Click += new System.EventHandler(this.ActivityLogToolStripButton_Click);
            // 
            // SettingsToolStripButton
            // 
            this.SettingsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SettingsToolStripButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsToolStripButton.Image")));
            this.SettingsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingsToolStripButton.Name = "SettingsToolStripButton";
            this.SettingsToolStripButton.Size = new System.Drawing.Size(249, 36);
            this.SettingsToolStripButton.Text = "الإعدادات";
            this.SettingsToolStripButton.Click += new System.EventHandler(this.SettingsToolStripButton_Click);
            // 
            // LogoutToolStripButton
            // 
            this.LogoutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LogoutToolStripButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("LogoutToolStripButton.Image")));
            this.LogoutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogoutToolStripButton.Name = "LogoutToolStripButton";
            this.LogoutToolStripButton.Size = new System.Drawing.Size(249, 36);
            this.LogoutToolStripButton.Text = "تسجيل الخروج";
            this.LogoutToolStripButton.Click += new System.EventHandler(this.LogoutToolStripButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.circularPictureBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 213);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "المدير العام";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "مظفر متوكل خضر سلمان";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // circularPictureBox
            // 
            this.circularPictureBox.BackColor = System.Drawing.Color.White;
            this.circularPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox.Image")));
            this.circularPictureBox.Location = new System.Drawing.Point(49, 3);
            this.circularPictureBox.Name = "circularPictureBox";
            this.circularPictureBox.Size = new System.Drawing.Size(150, 150);
            this.circularPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circularPictureBox.TabIndex = 2;
            this.circularPictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.lblCurrentFormName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblCurrentDate);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblCurrentTime);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1386, 50);
            this.panel2.TabIndex = 5;
            // 
            // lblCurrentFormName
            // 
            this.lblCurrentFormName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentFormName.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentFormName.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentFormName.ForeColor = System.Drawing.Color.White;
            this.lblCurrentFormName.Location = new System.Drawing.Point(273, 5);
            this.lblCurrentFormName.Name = "lblCurrentFormName";
            this.lblCurrentFormName.Size = new System.Drawing.Size(435, 39);
            this.lblCurrentFormName.TabIndex = 9;
            this.lblCurrentFormName.Text = "لمحة سريعة";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(714, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 39);
            this.label4.TabIndex = 9;
            this.label4.Text = "-";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(751, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "سوبرماركت الواحة";
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentDate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDate.ForeColor = System.Drawing.Color.White;
            this.lblCurrentDate.Location = new System.Drawing.Point(3, 15);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(134, 23);
            this.lblCurrentDate.TabIndex = 7;
            this.lblCurrentDate.Text = "dd/MM/yyyy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SIMS.WinForms.Properties.Resources.al_waha_mall;
            this.pictureBox1.Location = new System.Drawing.Point(1043, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentTime.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTime.Location = new System.Drawing.Point(135, 15);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(132, 23);
            this.lblCurrentTime.TabIndex = 8;
            this.lblCurrentTime.Text = "00:00:00 AM";
            // 
            // ClockAndDateTimer
            // 
            this.ClockAndDateTimer.Interval = 1000;
            this.ClockAndDateTimer.Tick += new System.EventHandler(this.ClockAndDateTimer_Tick);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmMainForm";
            this.Padding = new System.Windows.Forms.Padding(250, 50, 0, 0);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

#endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton DashboardToolStripButton;
        private System.Windows.Forms.ToolStripButton PointOfSelesToolStripButton;
        private System.Windows.Forms.ToolStripButton LogoutToolStripButton;
        private ctrCircularPictureBox circularPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton UsersToolStripButton;
        private System.Windows.Forms.ToolStripButton ActivityLogToolStripButton;
        private System.Windows.Forms.ToolStripButton PurchasesToolStripButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripDropDownButton WarehousesAndInventories;
        private System.Windows.Forms.ToolStripMenuItem InventoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StockTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WarehousesToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem TransferOperationsToolStripMenuItem;
        private System.Windows.Forms.Timer ClockAndDateTimer;
        private System.Windows.Forms.ToolStripDropDownButton SuppliersToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem SuppliersListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SuppliedItemsLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton PaymentsToolStripButton;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblCurrentFormName;
        private System.Windows.Forms.ToolStripDropDownButton ProductsDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem ProductsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DiscountsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TaxesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton EmployeesToolStripButton;
        private System.Windows.Forms.ToolStripButton SettingsToolStripButton;
        private System.Windows.Forms.ToolStripButton SalesToolStripButton;
        private System.Windows.Forms.ToolStripButton CustomersToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton ReportsToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem BasicSalesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BasicPurchasesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BasicInventoriesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BasicFinatcialReportToolStripMenuItem;
    }
}

