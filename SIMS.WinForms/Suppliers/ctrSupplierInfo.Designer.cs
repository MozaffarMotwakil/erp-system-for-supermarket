namespace SIMS.WinForms.Suppliers
{
    partial class ctrSupplierInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pageBasicInfo = new System.Windows.Forms.TabPage();
            this.lblNotesTitle = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.pageSuppliedProducts = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvSuppliedProducts = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastPurchaseDataTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastPurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAveragePurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalPurchases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalReturnPurchases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuppliesProductsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuppliedItemsLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageInvoices = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cbInvoicesRange = new System.Windows.Forms.ComboBox();
            this.cbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.cbInvoiceType = new System.Windows.Forms.ComboBox();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.colPurchaseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pagePayments = new System.Windows.Forms.TabPage();
            this.lblTotalPayments = new System.Windows.Forms.Label();
            this.lavel13 = new System.Windows.Forms.Label();
            this.lblTotalReceipts = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblSearchHintText = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbPaymentsRange = new System.Windows.Forms.ComboBox();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.cbPaymentType = new System.Windows.Forms.ComboBox();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.searchTimer = new System.Windows.Forms.Timer(this.components);
            this.InvoicesContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctrPersonInfo = new SIMS.WinForms.Parties.Person.ctrPersonInfo();
            this.ctrOrganizationInfo = new SIMS.WinForms.Parties.Organization.ctrOrganizationInfo();
            this.tabControl.SuspendLayout();
            this.pageBasicInfo.SuspendLayout();
            this.pageSuppliedProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliedProducts)).BeginInit();
            this.SuppliesProductsContextMenuStrip.SuspendLayout();
            this.pageInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.pagePayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageBasicInfo);
            this.tabControl.Controls.Add(this.pageSuppliedProducts);
            this.tabControl.Controls.Add(this.pageInvoices);
            this.tabControl.Controls.Add(this.pagePayments);
            this.tabControl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeftLayout = true;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(794, 264);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // pageBasicInfo
            // 
            this.pageBasicInfo.BackColor = System.Drawing.Color.White;
            this.pageBasicInfo.Controls.Add(this.ctrPersonInfo);
            this.pageBasicInfo.Controls.Add(this.lblNotesTitle);
            this.pageBasicInfo.Controls.Add(this.lblNotes);
            this.pageBasicInfo.Controls.Add(this.ctrOrganizationInfo);
            this.pageBasicInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageBasicInfo.Location = new System.Drawing.Point(4, 23);
            this.pageBasicInfo.Name = "pageBasicInfo";
            this.pageBasicInfo.Padding = new System.Windows.Forms.Padding(3);
            this.pageBasicInfo.Size = new System.Drawing.Size(786, 237);
            this.pageBasicInfo.TabIndex = 0;
            this.pageBasicInfo.Text = "المعلومات الأساسية";
            // 
            // lblNotesTitle
            // 
            this.lblNotesTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotesTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotesTitle.Location = new System.Drawing.Point(703, 188);
            this.lblNotesTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNotesTitle.Name = "lblNotesTitle";
            this.lblNotesTitle.Size = new System.Drawing.Size(75, 16);
            this.lblNotesTitle.TabIndex = 60;
            this.lblNotesTitle.Text = "الملاحظات:";
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.Color.Black;
            this.lblNotes.Location = new System.Drawing.Point(188, 188);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(458, 16);
            this.lblNotes.TabIndex = 59;
            this.lblNotes.Text = "N/A";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pageSuppliedProducts
            // 
            this.pageSuppliedProducts.BackColor = System.Drawing.Color.White;
            this.pageSuppliedProducts.Controls.Add(this.label11);
            this.pageSuppliedProducts.Controls.Add(this.dgvSuppliedProducts);
            this.pageSuppliedProducts.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageSuppliedProducts.Location = new System.Drawing.Point(4, 23);
            this.pageSuppliedProducts.Name = "pageSuppliedProducts";
            this.pageSuppliedProducts.Padding = new System.Windows.Forms.Padding(3);
            this.pageSuppliedProducts.Size = new System.Drawing.Size(786, 237);
            this.pageSuppliedProducts.TabIndex = 1;
            this.pageSuppliedProducts.Text = "المنتجات الموردة";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(513, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(270, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "- تنويه: المنوسطات و المجاميع محسوبة على آخر 12 شهر";
            // 
            // dgvSuppliedProducts
            // 
            this.dgvSuppliedProducts.AllowUserToAddRows = false;
            this.dgvSuppliedProducts.AllowUserToDeleteRows = false;
            this.dgvSuppliedProducts.AllowUserToResizeColumns = false;
            this.dgvSuppliedProducts.AllowUserToResizeRows = false;
            this.dgvSuppliedProducts.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliedProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuppliedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliedProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colProduct,
            this.colUnit,
            this.colLastPurchaseDataTime,
            this.colLastPurchasePrice,
            this.colAveragePurchasePrice,
            this.colTotalPurchases,
            this.colTotalReturnPurchases});
            this.dgvSuppliedProducts.ContextMenuStrip = this.SuppliesProductsContextMenuStrip;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuppliedProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSuppliedProducts.Location = new System.Drawing.Point(6, 6);
            this.dgvSuppliedProducts.MultiSelect = false;
            this.dgvSuppliedProducts.Name = "dgvSuppliedProducts";
            this.dgvSuppliedProducts.ReadOnly = true;
            this.dgvSuppliedProducts.RowHeadersVisible = false;
            this.dgvSuppliedProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliedProducts.Size = new System.Drawing.Size(774, 212);
            this.dgvSuppliedProducts.TabIndex = 0;
            this.dgvSuppliedProducts.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSuppliedProducts_CellMouseDown);
            // 
            // colNo
            // 
            this.colNo.HeaderText = "م";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colNo.Width = 40;
            // 
            // colProduct
            // 
            this.colProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProduct.HeaderText = "المنتج";
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            this.colProduct.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "الوحدة";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            this.colUnit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colUnit.Width = 85;
            // 
            // colLastPurchaseDataTime
            // 
            this.colLastPurchaseDataTime.HeaderText = "تاريخ آخر شراء";
            this.colLastPurchaseDataTime.Name = "colLastPurchaseDataTime";
            this.colLastPurchaseDataTime.ReadOnly = true;
            this.colLastPurchaseDataTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colLastPurchaseDataTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colLastPurchaseDataTime.Width = 85;
            // 
            // colLastPurchasePrice
            // 
            this.colLastPurchasePrice.HeaderText = "سعر آخر شراء (جنيه)";
            this.colLastPurchasePrice.Name = "colLastPurchasePrice";
            this.colLastPurchasePrice.ReadOnly = true;
            this.colLastPurchasePrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colLastPurchasePrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colLastPurchasePrice.Width = 80;
            // 
            // colAveragePurchasePrice
            // 
            this.colAveragePurchasePrice.HeaderText = "متوسط سعر الشراء (جنيه)";
            this.colAveragePurchasePrice.Name = "colAveragePurchasePrice";
            this.colAveragePurchasePrice.ReadOnly = true;
            this.colAveragePurchasePrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colAveragePurchasePrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colAveragePurchasePrice.Width = 70;
            // 
            // colTotalPurchases
            // 
            this.colTotalPurchases.HeaderText = "مجموع المشتريات (جنيه)";
            this.colTotalPurchases.Name = "colTotalPurchases";
            this.colTotalPurchases.ReadOnly = true;
            this.colTotalPurchases.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTotalPurchases.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTotalPurchases.Width = 85;
            // 
            // colTotalReturnPurchases
            // 
            this.colTotalReturnPurchases.HeaderText = "مجموع المرتجعات (جنيه)";
            this.colTotalReturnPurchases.Name = "colTotalReturnPurchases";
            this.colTotalReturnPurchases.ReadOnly = true;
            this.colTotalReturnPurchases.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTotalReturnPurchases.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTotalReturnPurchases.Width = 85;
            // 
            // SuppliesProductsContextMenuStrip
            // 
            this.SuppliesProductsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SuppliedItemsLogToolStripMenuItem});
            this.SuppliesProductsContextMenuStrip.Name = "SuppliersContextMenuStrip";
            this.SuppliesProductsContextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SuppliesProductsContextMenuStrip.Size = new System.Drawing.Size(182, 42);
            this.SuppliesProductsContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.SuppliesProductsContextMenuStrip_Opening);
            // 
            // SuppliedItemsLogToolStripMenuItem
            // 
            this.SuppliedItemsLogToolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.supplied_items_32;
            this.SuppliedItemsLogToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SuppliedItemsLogToolStripMenuItem.Name = "SuppliedItemsLogToolStripMenuItem";
            this.SuppliedItemsLogToolStripMenuItem.Size = new System.Drawing.Size(181, 38);
            this.SuppliedItemsLogToolStripMenuItem.Text = "عرض سجل التوريد";
            this.SuppliedItemsLogToolStripMenuItem.Click += new System.EventHandler(this.SuppliedItemsLogToolStripMenuItem_Click);
            // 
            // pageInvoices
            // 
            this.pageInvoices.BackColor = System.Drawing.Color.White;
            this.pageInvoices.Controls.Add(this.label8);
            this.pageInvoices.Controls.Add(this.label9);
            this.pageInvoices.Controls.Add(this.label6);
            this.pageInvoices.Controls.Add(this.label7);
            this.pageInvoices.Controls.Add(this.label4);
            this.pageInvoices.Controls.Add(this.label3);
            this.pageInvoices.Controls.Add(this.label2);
            this.pageInvoices.Controls.Add(this.lblAmount);
            this.pageInvoices.Controls.Add(this.cbInvoicesRange);
            this.pageInvoices.Controls.Add(this.cbPaymentStatus);
            this.pageInvoices.Controls.Add(this.cbInvoiceType);
            this.pageInvoices.Controls.Add(this.dgvInvoices);
            this.pageInvoices.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageInvoices.Location = new System.Drawing.Point(4, 23);
            this.pageInvoices.Name = "pageInvoices";
            this.pageInvoices.Padding = new System.Windows.Forms.Padding(3);
            this.pageInvoices.Size = new System.Drawing.Size(786, 237);
            this.pageInvoices.TabIndex = 2;
            this.pageInvoices.Text = "المشتريات/المرتجعات";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(606, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "🔴 مدفوع جزئيا";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(460, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "🔴 مرتجعات";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(527, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "🔴 غير مدفوع ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(688, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "🔴 مدفوعة بالكامل ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "إجمالي الرصيد المستحق من المورد:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "0 جنيه";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "إجمالي الرصيد المتبقي للمورد:";
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.Red;
            this.lblAmount.Location = new System.Drawing.Point(6, 3);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(191, 13);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "0 جنيه";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbInvoicesRange
            // 
            this.cbInvoicesRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInvoicesRange.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInvoicesRange.FormattingEnabled = true;
            this.cbInvoicesRange.Items.AddRange(new object[] {
            "آخر 24 ساعة",
            "آخر 7 أيام",
            "آخر شهر",
            "آخر 6 شهور",
            "أخر 12 شهر"});
            this.cbInvoicesRange.Location = new System.Drawing.Point(405, 6);
            this.cbInvoicesRange.Name = "cbInvoicesRange";
            this.cbInvoicesRange.Size = new System.Drawing.Size(121, 21);
            this.cbInvoicesRange.TabIndex = 2;
            this.cbInvoicesRange.SelectedIndexChanged += new System.EventHandler(this.cbInvoicesRange_SelectedIndexChanged);
            // 
            // cbPaymentStatus
            // 
            this.cbPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentStatus.FormattingEnabled = true;
            this.cbPaymentStatus.Items.AddRange(new object[] {
            "كل حالات الدفع",
            "مدفوعة بالكامل",
            "مدفوعة جزئيا",
            "غير مدفوعة"});
            this.cbPaymentStatus.Location = new System.Drawing.Point(532, 6);
            this.cbPaymentStatus.Name = "cbPaymentStatus";
            this.cbPaymentStatus.Size = new System.Drawing.Size(121, 21);
            this.cbPaymentStatus.TabIndex = 1;
            this.cbPaymentStatus.SelectedIndexChanged += new System.EventHandler(this.cbPaymentStatus_SelectedIndexChanged);
            // 
            // cbInvoiceType
            // 
            this.cbInvoiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInvoiceType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInvoiceType.FormattingEnabled = true;
            this.cbInvoiceType.Items.AddRange(new object[] {
            "كل الحركات",
            "مشتريات",
            "مرتجعات"});
            this.cbInvoiceType.Location = new System.Drawing.Point(659, 6);
            this.cbInvoiceType.Name = "cbInvoiceType";
            this.cbInvoiceType.Size = new System.Drawing.Size(121, 21);
            this.cbInvoiceType.TabIndex = 0;
            this.cbInvoiceType.SelectedIndexChanged += new System.EventHandler(this.cbInvoiceType_SelectedIndexChanged);
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.AllowUserToResizeColumns = false;
            this.dgvInvoices.AllowUserToResizeRows = false;
            this.dgvInvoices.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPurchaseNo});
            this.dgvInvoices.ContextMenuStrip = this.InvoicesContextMenuStrip;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInvoices.Location = new System.Drawing.Point(6, 33);
            this.dgvInvoices.MultiSelect = false;
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.RowHeadersVisible = false;
            this.dgvInvoices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(774, 185);
            this.dgvInvoices.TabIndex = 3;
            this.dgvInvoices.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelectedCurrentRow_CellMouseClick);
            this.dgvInvoices.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ShowInvoiceInfo_CellMouseDoubleClick);
            this.dgvInvoices.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInvoices_CellMouseDown);
            this.dgvInvoices.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvInvoices_DataBindingComplete);
            this.dgvInvoices.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvInvoices_RowPrePaint);
            this.dgvInvoices.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowInvoiceInfo_KeyDown);
            // 
            // colPurchaseNo
            // 
            this.colPurchaseNo.HeaderText = "م";
            this.colPurchaseNo.Name = "colPurchaseNo";
            this.colPurchaseNo.ReadOnly = true;
            this.colPurchaseNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPurchaseNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPurchaseNo.Width = 50;
            // 
            // PaymentsContextMenuStrip
            // 
            this.PaymentsContextMenuStrip.Name = "contextMenuStrip";
            this.PaymentsContextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PaymentsContextMenuStrip.Size = new System.Drawing.Size(61, 4);
            this.PaymentsContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // pagePayments
            // 
            this.pagePayments.BackColor = System.Drawing.Color.White;
            this.pagePayments.Controls.Add(this.lblTotalPayments);
            this.pagePayments.Controls.Add(this.lavel13);
            this.pagePayments.Controls.Add(this.lblTotalReceipts);
            this.pagePayments.Controls.Add(this.label10);
            this.pagePayments.Controls.Add(this.label1);
            this.pagePayments.Controls.Add(this.label5);
            this.pagePayments.Controls.Add(this.pictureBox);
            this.pagePayments.Controls.Add(this.lblSearchHintText);
            this.pagePayments.Controls.Add(this.txtSearch);
            this.pagePayments.Controls.Add(this.cbPaymentsRange);
            this.pagePayments.Controls.Add(this.cbPaymentMethod);
            this.pagePayments.Controls.Add(this.cbPaymentType);
            this.pagePayments.Controls.Add(this.dgvPayments);
            this.pagePayments.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagePayments.Location = new System.Drawing.Point(4, 23);
            this.pagePayments.Name = "pagePayments";
            this.pagePayments.Padding = new System.Windows.Forms.Padding(3);
            this.pagePayments.Size = new System.Drawing.Size(786, 237);
            this.pagePayments.TabIndex = 3;
            this.pagePayments.Text = "المدفوعات/المقبوضات";
            // 
            // lblTotalPayments
            // 
            this.lblTotalPayments.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayments.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPayments.Location = new System.Drawing.Point(6, 2);
            this.lblTotalPayments.Name = "lblTotalPayments";
            this.lblTotalPayments.Size = new System.Drawing.Size(139, 13);
            this.lblTotalPayments.TabIndex = 51;
            this.lblTotalPayments.Text = "0 جنيه";
            this.lblTotalPayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lavel13
            // 
            this.lavel13.AutoSize = true;
            this.lavel13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lavel13.Location = new System.Drawing.Point(151, 2);
            this.lavel13.Name = "lavel13";
            this.lavel13.Size = new System.Drawing.Size(64, 13);
            this.lavel13.TabIndex = 8;
            this.lavel13.Text = "المدفوعات:";
            // 
            // lblTotalReceipts
            // 
            this.lblTotalReceipts.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReceipts.ForeColor = System.Drawing.Color.Lime;
            this.lblTotalReceipts.Location = new System.Drawing.Point(5, 16);
            this.lblTotalReceipts.Name = "lblTotalReceipts";
            this.lblTotalReceipts.Size = new System.Drawing.Size(139, 13);
            this.lblTotalReceipts.TabIndex = 52;
            this.lblTotalReceipts.Text = "0 جنيه";
            this.lblTotalReceipts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(150, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "المقبوضات:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(502, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "🔴 المقبوضات (أموال داخلة) ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(645, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "🔴 المدفوعات (أموال خارجة) ";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox.Image = global::SIMS.WinForms.Properties.Resources.search_icon;
            this.pictureBox.Location = new System.Drawing.Point(369, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(30, 26);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 43;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBoxAndSearchHintText_Click);
            // 
            // lblSearchHintText
            // 
            this.lblSearchHintText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchHintText.BackColor = System.Drawing.Color.White;
            this.lblSearchHintText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblSearchHintText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchHintText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSearchHintText.Location = new System.Drawing.Point(262, 8);
            this.lblSearchHintText.Name = "lblSearchHintText";
            this.lblSearchHintText.Size = new System.Drawing.Size(101, 16);
            this.lblSearchHintText.TabIndex = 5;
            this.lblSearchHintText.Text = "أدخل رقم الفاتورة";
            this.lblSearchHintText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSearchHintText.Click += new System.EventHandler(this.pictureBoxAndSearchHintText_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(221, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(148, 26);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // cbPaymentsRange
            // 
            this.cbPaymentsRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentsRange.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentsRange.FormattingEnabled = true;
            this.cbPaymentsRange.Items.AddRange(new object[] {
            "آخر 24 ساعة",
            "آخر 7 أيام",
            "آخر شهر",
            "آخر 6 شهور",
            "أخر 12 شهر"});
            this.cbPaymentsRange.Location = new System.Drawing.Point(405, 6);
            this.cbPaymentsRange.Name = "cbPaymentsRange";
            this.cbPaymentsRange.Size = new System.Drawing.Size(121, 21);
            this.cbPaymentsRange.TabIndex = 2;
            this.cbPaymentsRange.SelectedIndexChanged += new System.EventHandler(this.cbPaymentsRange_SelectedIndexChanged);
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentMethod.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Items.AddRange(new object[] {
            "كل طرق الدفع",
            "كاش",
            "تحويل بنكي"});
            this.cbPaymentMethod.Location = new System.Drawing.Point(532, 6);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(121, 21);
            this.cbPaymentMethod.TabIndex = 1;
            this.cbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cbPaymentMethod_SelectedIndexChanged);
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentType.FormattingEnabled = true;
            this.cbPaymentType.Items.AddRange(new object[] {
            "كل المعاملات",
            "المدفوعات",
            "المقبوضات"});
            this.cbPaymentType.Location = new System.Drawing.Point(659, 6);
            this.cbPaymentType.Name = "cbPaymentType";
            this.cbPaymentType.Size = new System.Drawing.Size(121, 21);
            this.cbPaymentType.TabIndex = 0;
            this.cbPaymentType.SelectedIndexChanged += new System.EventHandler(this.cbPaymentType_SelectedIndexChanged);
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AllowUserToResizeColumns = false;
            this.dgvPayments.AllowUserToResizeRows = false;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.ContextMenuStrip = this.PaymentsContextMenuStrip;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayments.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPayments.Location = new System.Drawing.Point(6, 33);
            this.dgvPayments.MultiSelect = false;
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersVisible = false;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(774, 185);
            this.dgvPayments.TabIndex = 4;
            this.dgvPayments.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelectedCurrentRow_CellMouseClick);
            this.dgvPayments.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ShowInvoiceInfo_CellMouseDoubleClick);
            this.dgvPayments.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPayments_DataBindingComplete);
            this.dgvPayments.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvPayments_RowPrePaint);
            this.dgvPayments.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowInvoiceInfo_KeyDown);
            // 
            // searchTimer
            // 
            this.searchTimer.Enabled = true;
            this.searchTimer.Interval = 300;
            this.searchTimer.Tick += new System.EventHandler(this.searchTimer_Tick);
            // 
            // InvoicesContextMenuStrip
            // 
            this.InvoicesContextMenuStrip.Name = "contextMenuStrip";
            this.InvoicesContextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InvoicesContextMenuStrip.Size = new System.Drawing.Size(61, 4);
            this.InvoicesContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.InvoicesContextMenuStrip_Opening);
            // 
            // ctrPersonInfo
            // 
            this.ctrPersonInfo.BackColor = System.Drawing.Color.White;
            this.ctrPersonInfo.Location = new System.Drawing.Point(7, 7);
            this.ctrPersonInfo.Margin = new System.Windows.Forms.Padding(4);
            this.ctrPersonInfo.Name = "ctrPersonInfo";
            this.ctrPersonInfo.Person = null;
            this.ctrPersonInfo.PersonType = BusinessLogic.Parties.clsParty.enPartyType.Supplier;
            this.ctrPersonInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrPersonInfo.Size = new System.Drawing.Size(775, 177);
            this.ctrPersonInfo.TabIndex = 62;
            // 
            // ctrOrganizationInfo
            // 
            this.ctrOrganizationInfo.Location = new System.Drawing.Point(188, 4);
            this.ctrOrganizationInfo.Margin = new System.Windows.Forms.Padding(4);
            this.ctrOrganizationInfo.Name = "ctrOrganizationInfo";
            this.ctrOrganizationInfo.Organization = null;
            this.ctrOrganizationInfo.OrganizationType = BusinessLogic.Parties.clsParty.enPartyType.Supplier;
            this.ctrOrganizationInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrOrganizationInfo.Size = new System.Drawing.Size(594, 138);
            this.ctrOrganizationInfo.TabIndex = 58;
            // 
            // ctrSupplierInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl);
            this.Name = "ctrSupplierInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(800, 270);
            this.tabControl.ResumeLayout(false);
            this.pageBasicInfo.ResumeLayout(false);
            this.pageSuppliedProducts.ResumeLayout(false);
            this.pageSuppliedProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliedProducts)).EndInit();
            this.SuppliesProductsContextMenuStrip.ResumeLayout(false);
            this.pageInvoices.ResumeLayout(false);
            this.pageInvoices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.pagePayments.ResumeLayout(false);
            this.pagePayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageBasicInfo;
        private System.Windows.Forms.TabPage pageSuppliedProducts;
        private System.Windows.Forms.Label lblNotesTitle;
        private System.Windows.Forms.Label lblNotes;
        private Parties.Organization.ctrOrganizationInfo ctrOrganizationInfo;
        private System.Windows.Forms.TabPage pageInvoices;
        private System.Windows.Forms.TabPage pagePayments;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.DataGridView dgvSuppliedProducts;
        private System.Windows.Forms.ComboBox cbInvoiceType;
        private System.Windows.Forms.ComboBox cbPaymentStatus;
        private System.Windows.Forms.ComboBox cbInvoicesRange;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchaseNo;
        private System.Windows.Forms.ContextMenuStrip PaymentsContextMenuStrip;
        private System.Windows.Forms.ComboBox cbPaymentsRange;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.ComboBox cbPaymentType;
        protected System.Windows.Forms.PictureBox pictureBox;
        protected System.Windows.Forms.Label lblSearchHintText;
        protected System.Windows.Forms.TextBox txtSearch;
        protected System.Windows.Forms.Timer searchTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalReceipts;
        private System.Windows.Forms.Label lavel13;
        private System.Windows.Forms.Label lblTotalPayments;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastPurchaseDataTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastPurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAveragePurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalPurchases;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalReturnPurchases;
        private Parties.Person.ctrPersonInfo ctrPersonInfo;
        private System.Windows.Forms.ContextMenuStrip SuppliesProductsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SuppliedItemsLogToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip InvoicesContextMenuStrip;
    }
}
