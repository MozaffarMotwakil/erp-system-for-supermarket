namespace SIMS.WinForms.Products
{
    partial class ctrProductInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pageBasicInfo = new System.Windows.Forms.TabPage();
            this.llUpdatedBy = new System.Windows.Forms.LinkLabel();
            this.llCreatedBy = new System.Windows.Forms.LinkLabel();
            this.lblUpdatedAt = new System.Windows.Forms.Label();
            this.lblProductDescribtion = new System.Windows.Forms.Label();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.lblActivity = new System.Windows.Forms.Label();
            this.lblMainSupplier = new System.Windows.Forms.Label();
            this.lblMainUnit = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.pageUnits = new System.Windows.Forms.TabPage();
            this.dgvUnits = new System.Windows.Forms.DataGridView();
            this.pageSuppliers = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.SuppliersContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowSupplierInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SuppliedItemsLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageInventories = new System.Windows.Forms.TabPage();
            this.dgvInventories = new System.Windows.Forms.DataGridView();
            this.InventoriesContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.عرضحركاتالمخزونToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلحدإعادةالطلبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageStockTransactions = new System.Windows.Forms.TabPage();
            this.cbRange = new System.Windows.Forms.ComboBox();
            this.cbTransactionReason = new System.Windows.Forms.ComboBox();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.cbWarehouse = new System.Windows.Forms.ComboBox();
            this.cbTransactionType = new System.Windows.Forms.ComboBox();
            this.dgvStockTransactions = new System.Windows.Forms.DataGridView();
            this.colTransactionNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockTransactionsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.عرضتفاصيلالفاتورةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.GoToInventoriesListtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.pageBasicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.pageUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).BeginInit();
            this.pageSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.SuppliersContextMenuStrip.SuspendLayout();
            this.pageInventories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventories)).BeginInit();
            this.InventoriesContextMenuStrip.SuspendLayout();
            this.pageStockTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockTransactions)).BeginInit();
            this.StockTransactionsContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageBasicInfo);
            this.tabControl.Controls.Add(this.pageUnits);
            this.tabControl.Controls.Add(this.pageSuppliers);
            this.tabControl.Controls.Add(this.pageInventories);
            this.tabControl.Controls.Add(this.pageStockTransactions);
            this.tabControl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeftLayout = true;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(844, 264);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // pageBasicInfo
            // 
            this.pageBasicInfo.BackColor = System.Drawing.Color.White;
            this.pageBasicInfo.Controls.Add(this.llUpdatedBy);
            this.pageBasicInfo.Controls.Add(this.llCreatedBy);
            this.pageBasicInfo.Controls.Add(this.lblUpdatedAt);
            this.pageBasicInfo.Controls.Add(this.lblProductDescribtion);
            this.pageBasicInfo.Controls.Add(this.lblCreatedAt);
            this.pageBasicInfo.Controls.Add(this.lblActivity);
            this.pageBasicInfo.Controls.Add(this.lblMainSupplier);
            this.pageBasicInfo.Controls.Add(this.lblMainUnit);
            this.pageBasicInfo.Controls.Add(this.lblCategory);
            this.pageBasicInfo.Controls.Add(this.lblProductName);
            this.pageBasicInfo.Controls.Add(this.label12);
            this.pageBasicInfo.Controls.Add(this.label16);
            this.pageBasicInfo.Controls.Add(this.label11);
            this.pageBasicInfo.Controls.Add(this.label13);
            this.pageBasicInfo.Controls.Add(this.label9);
            this.pageBasicInfo.Controls.Add(this.label8);
            this.pageBasicInfo.Controls.Add(this.label5);
            this.pageBasicInfo.Controls.Add(this.label4);
            this.pageBasicInfo.Controls.Add(this.label2);
            this.pageBasicInfo.Controls.Add(this.label1);
            this.pageBasicInfo.Controls.Add(this.pbProductImage);
            this.pageBasicInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageBasicInfo.Location = new System.Drawing.Point(4, 23);
            this.pageBasicInfo.Name = "pageBasicInfo";
            this.pageBasicInfo.Padding = new System.Windows.Forms.Padding(3);
            this.pageBasicInfo.Size = new System.Drawing.Size(836, 237);
            this.pageBasicInfo.TabIndex = 0;
            this.pageBasicInfo.Text = "المعلومات الأساسية";
            // 
            // llUpdatedBy
            // 
            this.llUpdatedBy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llUpdatedBy.Location = new System.Drawing.Point(202, 190);
            this.llUpdatedBy.Name = "llUpdatedBy";
            this.llUpdatedBy.Size = new System.Drawing.Size(504, 16);
            this.llUpdatedBy.TabIndex = 23;
            this.llUpdatedBy.TabStop = true;
            this.llUpdatedBy.Text = "N/A";
            // 
            // llCreatedBy
            // 
            this.llCreatedBy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llCreatedBy.Location = new System.Drawing.Point(202, 144);
            this.llCreatedBy.Name = "llCreatedBy";
            this.llCreatedBy.Size = new System.Drawing.Size(504, 16);
            this.llCreatedBy.TabIndex = 23;
            this.llCreatedBy.TabStop = true;
            this.llCreatedBy.Text = "N/A";
            // 
            // lblUpdatedAt
            // 
            this.lblUpdatedAt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatedAt.ForeColor = System.Drawing.Color.Black;
            this.lblUpdatedAt.Location = new System.Drawing.Point(202, 213);
            this.lblUpdatedAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdatedAt.Name = "lblUpdatedAt";
            this.lblUpdatedAt.Size = new System.Drawing.Size(504, 16);
            this.lblUpdatedAt.TabIndex = 22;
            this.lblUpdatedAt.Text = "N/A";
            this.lblUpdatedAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductDescribtion
            // 
            this.lblProductDescribtion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDescribtion.ForeColor = System.Drawing.Color.Black;
            this.lblProductDescribtion.Location = new System.Drawing.Point(202, 121);
            this.lblProductDescribtion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductDescribtion.Name = "lblProductDescribtion";
            this.lblProductDescribtion.Size = new System.Drawing.Size(504, 16);
            this.lblProductDescribtion.TabIndex = 22;
            this.lblProductDescribtion.Text = "N/A";
            this.lblProductDescribtion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedAt.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedAt.Location = new System.Drawing.Point(202, 167);
            this.lblCreatedAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(504, 16);
            this.lblCreatedAt.TabIndex = 22;
            this.lblCreatedAt.Text = "N/A";
            this.lblCreatedAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblActivity
            // 
            this.lblActivity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivity.ForeColor = System.Drawing.Color.Black;
            this.lblActivity.Location = new System.Drawing.Point(202, 98);
            this.lblActivity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(504, 16);
            this.lblActivity.TabIndex = 22;
            this.lblActivity.Text = "N/A";
            this.lblActivity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMainSupplier
            // 
            this.lblMainSupplier.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainSupplier.ForeColor = System.Drawing.Color.Black;
            this.lblMainSupplier.Location = new System.Drawing.Point(202, 75);
            this.lblMainSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMainSupplier.Name = "lblMainSupplier";
            this.lblMainSupplier.Size = new System.Drawing.Size(504, 16);
            this.lblMainSupplier.TabIndex = 22;
            this.lblMainSupplier.Text = "N/A";
            this.lblMainSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMainUnit
            // 
            this.lblMainUnit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainUnit.ForeColor = System.Drawing.Color.Black;
            this.lblMainUnit.Location = new System.Drawing.Point(202, 52);
            this.lblMainUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMainUnit.Name = "lblMainUnit";
            this.lblMainUnit.Size = new System.Drawing.Size(504, 16);
            this.lblMainUnit.TabIndex = 22;
            this.lblMainUnit.Text = "N/A";
            this.lblMainUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.Black;
            this.lblCategory.Location = new System.Drawing.Point(202, 29);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(504, 16);
            this.lblCategory.TabIndex = 22;
            this.lblCategory.Text = "N/A";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.Red;
            this.lblProductName.Location = new System.Drawing.Point(202, 6);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(504, 16);
            this.lblProductName.TabIndex = 22;
            this.lblProductName.Text = "N/A";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(738, 190);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "عدل بواسطة:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(743, 121);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 16);
            this.label16.TabIndex = 12;
            this.label16.Text = "وصف المنتج:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(726, 213);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "تاريخ آخر تعديل:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(729, 144);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "أضيف بواسطة:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(740, 167);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "تاريخ الإضافة:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(742, 98);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "حالة التفعيل:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(716, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "المورد الأساسي:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(714, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "الوحدة الأساسية:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(740, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "الفئة/الصنف:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(748, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "إسم المنتج:";
            // 
            // pbProductImage
            // 
            this.pbProductImage.Image = global::SIMS.WinForms.Properties.Resources.product;
            this.pbProductImage.Location = new System.Drawing.Point(7, 6);
            this.pbProductImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(188, 225);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductImage.TabIndex = 3;
            this.pbProductImage.TabStop = false;
            // 
            // pageUnits
            // 
            this.pageUnits.BackColor = System.Drawing.Color.White;
            this.pageUnits.Controls.Add(this.dgvUnits);
            this.pageUnits.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageUnits.Location = new System.Drawing.Point(4, 23);
            this.pageUnits.Name = "pageUnits";
            this.pageUnits.Padding = new System.Windows.Forms.Padding(3);
            this.pageUnits.Size = new System.Drawing.Size(836, 237);
            this.pageUnits.TabIndex = 1;
            this.pageUnits.Text = "الوحدات";
            // 
            // dgvUnits
            // 
            this.dgvUnits.AllowUserToAddRows = false;
            this.dgvUnits.AllowUserToDeleteRows = false;
            this.dgvUnits.AllowUserToResizeColumns = false;
            this.dgvUnits.AllowUserToResizeRows = false;
            this.dgvUnits.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnits.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUnits.Location = new System.Drawing.Point(6, 6);
            this.dgvUnits.MultiSelect = false;
            this.dgvUnits.Name = "dgvUnits";
            this.dgvUnits.ReadOnly = true;
            this.dgvUnits.RowHeadersVisible = false;
            this.dgvUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnits.Size = new System.Drawing.Size(824, 225);
            this.dgvUnits.TabIndex = 4;
            // 
            // pageSuppliers
            // 
            this.pageSuppliers.BackColor = System.Drawing.Color.White;
            this.pageSuppliers.Controls.Add(this.label3);
            this.pageSuppliers.Controls.Add(this.dgvSuppliers);
            this.pageSuppliers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageSuppliers.Location = new System.Drawing.Point(4, 23);
            this.pageSuppliers.Name = "pageSuppliers";
            this.pageSuppliers.Padding = new System.Windows.Forms.Padding(3);
            this.pageSuppliers.Size = new System.Drawing.Size(836, 237);
            this.pageSuppliers.TabIndex = 2;
            this.pageSuppliers.Text = "الموردين";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(563, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "- تنويه: المنوسطات و المجاميع محسوبة على آخر 12 شهر";
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.AllowUserToResizeColumns = false;
            this.dgvSuppliers.AllowUserToResizeRows = false;
            this.dgvSuppliers.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.ContextMenuStrip = this.SuppliersContextMenuStrip;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuppliers.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSuppliers.Location = new System.Drawing.Point(6, 6);
            this.dgvSuppliers.MultiSelect = false;
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.RowHeadersVisible = false;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.Size = new System.Drawing.Size(824, 212);
            this.dgvSuppliers.TabIndex = 3;
            this.dgvSuppliers.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSuppliers_CellMouseDown);
            // 
            // SuppliersContextMenuStrip
            // 
            this.SuppliersContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowSupplierInfoToolStripMenuItem,
            this.SuppliedItemsLogToolStripMenuItem});
            this.SuppliersContextMenuStrip.Name = "SuppliersContextMenuStrip";
            this.SuppliersContextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SuppliersContextMenuStrip.Size = new System.Drawing.Size(199, 80);
            this.SuppliersContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.SuppliersContextMenuStrip_Opening);
            // 
            // ShowSupplierInfoToolStripMenuItem
            // 
            this.ShowSupplierInfoToolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.supplier_32;
            this.ShowSupplierInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowSupplierInfoToolStripMenuItem.Name = "ShowSupplierInfoToolStripMenuItem";
            this.ShowSupplierInfoToolStripMenuItem.Size = new System.Drawing.Size(198, 38);
            this.ShowSupplierInfoToolStripMenuItem.Text = "عرض معلومات المورد";
            this.ShowSupplierInfoToolStripMenuItem.Click += new System.EventHandler(this.ShowSupplierInfoToolStripMenuItem_Click);
            // 
            // SuppliedItemsLogToolStripMenuItem
            // 
            this.SuppliedItemsLogToolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.supplied_items_32;
            this.SuppliedItemsLogToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SuppliedItemsLogToolStripMenuItem.Name = "SuppliedItemsLogToolStripMenuItem";
            this.SuppliedItemsLogToolStripMenuItem.Size = new System.Drawing.Size(198, 38);
            this.SuppliedItemsLogToolStripMenuItem.Text = "عرض سجل التوريد";
            this.SuppliedItemsLogToolStripMenuItem.Click += new System.EventHandler(this.SuppliedItemsLogToolStripMenuItem_Click);
            // 
            // pageInventories
            // 
            this.pageInventories.BackColor = System.Drawing.Color.White;
            this.pageInventories.Controls.Add(this.dgvInventories);
            this.pageInventories.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageInventories.Location = new System.Drawing.Point(4, 23);
            this.pageInventories.Name = "pageInventories";
            this.pageInventories.Padding = new System.Windows.Forms.Padding(3);
            this.pageInventories.Size = new System.Drawing.Size(836, 237);
            this.pageInventories.TabIndex = 3;
            this.pageInventories.Text = "المخزون";
            // 
            // dgvInventories
            // 
            this.dgvInventories.AllowUserToAddRows = false;
            this.dgvInventories.AllowUserToDeleteRows = false;
            this.dgvInventories.AllowUserToResizeColumns = false;
            this.dgvInventories.AllowUserToResizeRows = false;
            this.dgvInventories.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInventories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventories.ContextMenuStrip = this.InventoriesContextMenuStrip;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventories.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInventories.Location = new System.Drawing.Point(6, 6);
            this.dgvInventories.MultiSelect = false;
            this.dgvInventories.Name = "dgvInventories";
            this.dgvInventories.ReadOnly = true;
            this.dgvInventories.RowHeadersVisible = false;
            this.dgvInventories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventories.Size = new System.Drawing.Size(824, 225);
            this.dgvInventories.TabIndex = 4;
            this.dgvInventories.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInventories_CellMouseDown);
            this.dgvInventories.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvInventories_RowPrePaint);
            // 
            // InventoriesContextMenuStrip
            // 
            this.InventoriesContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GoToInventoriesListtoolStripMenuItem,
            this.عرضحركاتالمخزونToolStripMenuItem,
            this.تعديلحدإعادةالطلبToolStripMenuItem});
            this.InventoriesContextMenuStrip.Name = "contextMenuStrip2";
            this.InventoriesContextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InventoriesContextMenuStrip.Size = new System.Drawing.Size(201, 140);
            this.InventoriesContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.InventoriesContextMenuStrip_Opening);
            // 
            // عرضحركاتالمخزونToolStripMenuItem
            // 
            this.عرضحركاتالمخزونToolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.stock_market;
            this.عرضحركاتالمخزونToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.عرضحركاتالمخزونToolStripMenuItem.Name = "عرضحركاتالمخزونToolStripMenuItem";
            this.عرضحركاتالمخزونToolStripMenuItem.Size = new System.Drawing.Size(200, 38);
            this.عرضحركاتالمخزونToolStripMenuItem.Text = "عرض حركات المخزون";
            this.عرضحركاتالمخزونToolStripMenuItem.Click += new System.EventHandler(this.ShowTransactionLog_Click);
            // 
            // تعديلحدإعادةالطلبToolStripMenuItem
            // 
            this.تعديلحدإعادةالطلبToolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.edit;
            this.تعديلحدإعادةالطلبToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.تعديلحدإعادةالطلبToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.تعديلحدإعادةالطلبToolStripMenuItem.Name = "تعديلحدإعادةالطلبToolStripMenuItem";
            this.تعديلحدإعادةالطلبToolStripMenuItem.Size = new System.Drawing.Size(200, 38);
            this.تعديلحدإعادةالطلبToolStripMenuItem.Text = "تعديل حد إعادة الطلب";
            this.تعديلحدإعادةالطلبToolStripMenuItem.Click += new System.EventHandler(this.UpdateReorderQuantity_Click);
            // 
            // pageStockTransactions
            // 
            this.pageStockTransactions.BackColor = System.Drawing.Color.White;
            this.pageStockTransactions.Controls.Add(this.cbRange);
            this.pageStockTransactions.Controls.Add(this.cbTransactionReason);
            this.pageStockTransactions.Controls.Add(this.cbUnit);
            this.pageStockTransactions.Controls.Add(this.cbWarehouse);
            this.pageStockTransactions.Controls.Add(this.cbTransactionType);
            this.pageStockTransactions.Controls.Add(this.dgvStockTransactions);
            this.pageStockTransactions.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageStockTransactions.Location = new System.Drawing.Point(4, 23);
            this.pageStockTransactions.Name = "pageStockTransactions";
            this.pageStockTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.pageStockTransactions.Size = new System.Drawing.Size(836, 237);
            this.pageStockTransactions.TabIndex = 4;
            this.pageStockTransactions.Text = "حركات المخزون";
            // 
            // cbRange
            // 
            this.cbRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRange.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRange.FormattingEnabled = true;
            this.cbRange.Items.AddRange(new object[] {
            "آخر 24 ساعة",
            "آخر 7 أيام",
            "آخر شهر",
            "آخر 6 شهور",
            "أخر 12 شهر"});
            this.cbRange.Location = new System.Drawing.Point(201, 6);
            this.cbRange.Name = "cbRange";
            this.cbRange.Size = new System.Drawing.Size(121, 21);
            this.cbRange.TabIndex = 4;
            this.cbRange.SelectedIndexChanged += new System.EventHandler(this.cbRange_SelectedIndexChanged);
            // 
            // cbTransactionReason
            // 
            this.cbTransactionReason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTransactionReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransactionReason.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTransactionReason.FormattingEnabled = true;
            this.cbTransactionReason.Items.AddRange(new object[] {
            "كل الأسباب"});
            this.cbTransactionReason.Location = new System.Drawing.Point(328, 6);
            this.cbTransactionReason.Name = "cbTransactionReason";
            this.cbTransactionReason.Size = new System.Drawing.Size(121, 21);
            this.cbTransactionReason.TabIndex = 3;
            this.cbTransactionReason.SelectedIndexChanged += new System.EventHandler(this.cbTransactionReason_SelectedIndexChanged);
            // 
            // cbUnit
            // 
            this.cbUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Items.AddRange(new object[] {
            "كل الوحدات"});
            this.cbUnit.Location = new System.Drawing.Point(709, 6);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(121, 21);
            this.cbUnit.TabIndex = 0;
            this.cbUnit.SelectedIndexChanged += new System.EventHandler(this.cbUnit_SelectedIndexChanged);
            // 
            // cbWarehouse
            // 
            this.cbWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWarehouse.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWarehouse.FormattingEnabled = true;
            this.cbWarehouse.Items.AddRange(new object[] {
            "كل المخازن"});
            this.cbWarehouse.Location = new System.Drawing.Point(582, 6);
            this.cbWarehouse.Name = "cbWarehouse";
            this.cbWarehouse.Size = new System.Drawing.Size(121, 21);
            this.cbWarehouse.TabIndex = 1;
            this.cbWarehouse.SelectedIndexChanged += new System.EventHandler(this.cbWarehouse_SelectedIndexChanged);
            // 
            // cbTransactionType
            // 
            this.cbTransactionType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransactionType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTransactionType.FormattingEnabled = true;
            this.cbTransactionType.Items.AddRange(new object[] {
            "كل الحركات"});
            this.cbTransactionType.Location = new System.Drawing.Point(455, 6);
            this.cbTransactionType.Name = "cbTransactionType";
            this.cbTransactionType.Size = new System.Drawing.Size(121, 21);
            this.cbTransactionType.TabIndex = 2;
            this.cbTransactionType.SelectedIndexChanged += new System.EventHandler(this.cbTransactionType_SelectedIndexChanged);
            // 
            // dgvStockTransactions
            // 
            this.dgvStockTransactions.AllowUserToAddRows = false;
            this.dgvStockTransactions.AllowUserToDeleteRows = false;
            this.dgvStockTransactions.AllowUserToResizeColumns = false;
            this.dgvStockTransactions.AllowUserToResizeRows = false;
            this.dgvStockTransactions.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStockTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTransactionNo});
            this.dgvStockTransactions.ContextMenuStrip = this.StockTransactionsContextMenuStrip;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockTransactions.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStockTransactions.Location = new System.Drawing.Point(6, 33);
            this.dgvStockTransactions.MultiSelect = false;
            this.dgvStockTransactions.Name = "dgvStockTransactions";
            this.dgvStockTransactions.ReadOnly = true;
            this.dgvStockTransactions.RowHeadersVisible = false;
            this.dgvStockTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockTransactions.Size = new System.Drawing.Size(824, 198);
            this.dgvStockTransactions.TabIndex = 5;
            this.dgvStockTransactions.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStockTransactions_CellMouseDoubleClick);
            this.dgvStockTransactions.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStockTransactions_CellMouseDown);
            this.dgvStockTransactions.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvStockTransactions_RowPostPaint);
            this.dgvStockTransactions.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvStockTransactions_RowPrePaint);
            this.dgvStockTransactions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvStockTransactions_KeyDown);
            // 
            // colTransactionNo
            // 
            this.colTransactionNo.HeaderText = "م";
            this.colTransactionNo.Name = "colTransactionNo";
            this.colTransactionNo.ReadOnly = true;
            this.colTransactionNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTransactionNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTransactionNo.Width = 40;
            // 
            // StockTransactionsContextMenuStrip
            // 
            this.StockTransactionsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عرضتفاصيلالفاتورةToolStripMenuItem,
            this.toolStripMenuItem1});
            this.StockTransactionsContextMenuStrip.Name = "stockTransactionsContextMenuStrip";
            this.StockTransactionsContextMenuStrip.Size = new System.Drawing.Size(217, 80);
            this.StockTransactionsContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.stockTransactionsContextMenuStrip_Opening);
            // 
            // عرضتفاصيلالفاتورةToolStripMenuItem
            // 
            this.عرضتفاصيلالفاتورةToolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.Invoice_32;
            this.عرضتفاصيلالفاتورةToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.عرضتفاصيلالفاتورةToolStripMenuItem.Name = "عرضتفاصيلالفاتورةToolStripMenuItem";
            this.عرضتفاصيلالفاتورةToolStripMenuItem.Size = new System.Drawing.Size(216, 38);
            this.عرضتفاصيلالفاتورةToolStripMenuItem.Text = "عرض تفاصيل الفاتورة";
            this.عرضتفاصيلالفاتورةToolStripMenuItem.Click += new System.EventHandler(this.ShowInvoiceDetails_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::SIMS.WinForms.Properties.Resources.inventory;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(216, 38);
            this.toolStripMenuItem1.Text = "عرض تفاصيل عملية النقل";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ShowTransferOperationInfo_Click);
            // 
            // GoToInventoriesListtoolStripMenuItem
            // 
            this.GoToInventoriesListtoolStripMenuItem.Image = global::SIMS.WinForms.Properties.Resources.warehouse;
            this.GoToInventoriesListtoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.GoToInventoriesListtoolStripMenuItem.Name = "GoToInventoriesListtoolStripMenuItem";
            this.GoToInventoriesListtoolStripMenuItem.Size = new System.Drawing.Size(200, 38);
            this.GoToInventoriesListtoolStripMenuItem.Text = "الإنتقال لقائمة المخزون";
            this.GoToInventoriesListtoolStripMenuItem.Click += new System.EventHandler(this.GoToInventoriesListtoolStripMenuItem_Click);
            // 
            // ctrProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ctrProductInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(850, 270);
            this.Load += new System.EventHandler(this.ctrProductInfo_Load);
            this.tabControl.ResumeLayout(false);
            this.pageBasicInfo.ResumeLayout(false);
            this.pageBasicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.pageUnits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).EndInit();
            this.pageSuppliers.ResumeLayout(false);
            this.pageSuppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.SuppliersContextMenuStrip.ResumeLayout(false);
            this.pageInventories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventories)).EndInit();
            this.InventoriesContextMenuStrip.ResumeLayout(false);
            this.pageStockTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockTransactions)).EndInit();
            this.StockTransactionsContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageBasicInfo;
        private System.Windows.Forms.TabPage pageUnits;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMainSupplier;
        private System.Windows.Forms.Label lblMainUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.Label lblUpdatedAt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblProductDescribtion;
        private System.Windows.Forms.LinkLabel llCreatedBy;
        private System.Windows.Forms.LinkLabel llUpdatedBy;
        private System.Windows.Forms.TabPage pageSuppliers;
        private System.Windows.Forms.TabPage pageInventories;
        private System.Windows.Forms.TabPage pageStockTransactions;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.DataGridView dgvUnits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvInventories;
        private System.Windows.Forms.DataGridView dgvStockTransactions;
        private System.Windows.Forms.ComboBox cbTransactionReason;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.ComboBox cbWarehouse;
        private System.Windows.Forms.ComboBox cbTransactionType;
        private System.Windows.Forms.ComboBox cbRange;
        private System.Windows.Forms.ContextMenuStrip StockTransactionsContextMenuStrip;
        private System.Windows.Forms.ContextMenuStrip InventoriesContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem عرضتفاصيلالفاتورةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem تعديلحدإعادةالطلبToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionNo;
        private System.Windows.Forms.ContextMenuStrip SuppliersContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SuppliedItemsLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضحركاتالمخزونToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowSupplierInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GoToInventoriesListtoolStripMenuItem;
    }
}
