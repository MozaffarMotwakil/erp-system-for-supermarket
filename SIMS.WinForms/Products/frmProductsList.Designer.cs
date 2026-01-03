namespace SIMS.WinForms.Products
{
    partial class frmProductsList
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
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.addProducrToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ctrProductInfo = new SIMS.WinForms.Products.ctrProductInfo();
            this.cbProductActivity = new System.Windows.Forms.ComboBox();
            this.CategoriesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalRecordsText
            // 
            this.lblTotalRecordsText.Size = new System.Drawing.Size(142, 16);
            this.lblTotalRecordsText.Text = "إجمالي عدد المنتجات:";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.Location = new System.Drawing.Point(159, 691);
            this.lblTotalRecords.Size = new System.Drawing.Size(154, 16);
            this.lblTotalRecords.Text = "4";
            // 
            // lblSearchHintText
            // 
            this.lblSearchHintText.Text = "أدخل إسم المنتج أو المورد الأساسي";
            // 
            // cbCategory
            // 
            this.cbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "كل التصنيفات"});
            this.cbCategory.Location = new System.Drawing.Point(435, 9);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(200, 24);
            this.cbCategory.TabIndex = 45;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCatigory_SelectedIndexChanged);
            this.cbCategory.Leave += new System.EventHandler(this.cbCatigory_Leave);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.White;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProducrToolStripButton,
            this.CategoriesToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.ShowItemToolTips = false;
            this.toolStrip.Size = new System.Drawing.Size(1112, 40);
            this.toolStrip.TabIndex = 47;
            this.toolStrip.Text = "toolStrip1";
            // 
            // addProducrToolStripButton
            // 
            this.addProducrToolStripButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducrToolStripButton.Image = global::SIMS.WinForms.Properties.Resources.shopping_basket_add;
            this.addProducrToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addProducrToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addProducrToolStripButton.Name = "addProducrToolStripButton";
            this.addProducrToolStripButton.Size = new System.Drawing.Size(133, 37);
            this.addProducrToolStripButton.Text = "   إضافة منتج جديد";
            this.addProducrToolStripButton.Click += new System.EventHandler(this.addProducrToolStripButton_Click);
            // 
            // ctrProductInfo
            // 
            this.ctrProductInfo.Entity = null;
            this.ctrProductInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrProductInfo.Location = new System.Drawing.Point(12, 43);
            this.ctrProductInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrProductInfo.Name = "ctrProductInfo";
            this.ctrProductInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrProductInfo.Size = new System.Drawing.Size(850, 270);
            this.ctrProductInfo.TabIndex = 46;
            this.ctrProductInfo.TabStop = false;
            this.ctrProductInfo.Visible = false;
            // 
            // cbProductActivity
            // 
            this.cbProductActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductActivity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductActivity.FormattingEnabled = true;
            this.cbProductActivity.Items.AddRange(new object[] {
            "كل المنتجات",
            "المنتجات المفعلة",
            "المنتجات غير المفعلة"});
            this.cbProductActivity.Location = new System.Drawing.Point(643, 9);
            this.cbProductActivity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbProductActivity.Name = "cbProductActivity";
            this.cbProductActivity.Size = new System.Drawing.Size(200, 24);
            this.cbProductActivity.TabIndex = 50;
            this.cbProductActivity.SelectedIndexChanged += new System.EventHandler(this.cbProductActivity_SelectedIndexChanged);
            // 
            // CategoriesToolStripButton
            // 
            this.CategoriesToolStripButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesToolStripButton.Image = global::SIMS.WinForms.Properties.Resources.dairy_products;
            this.CategoriesToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CategoriesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CategoriesToolStripButton.Name = "CategoriesToolStripButton";
            this.CategoriesToolStripButton.Size = new System.Drawing.Size(112, 37);
            this.CategoriesToolStripButton.Text = "   قائمة الفئات";
            this.CategoriesToolStripButton.Click += new System.EventHandler(this.CategoriesToolStripButton_Click);
            // 
            // frmProductsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 714);
            this.Controls.Add(this.cbProductActivity);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.ctrProductInfo);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmProductsList";
            this.ShowSearchTextBox = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة المنتجات";
            this.Load += new System.EventHandler(this.frmProductsList_Load);
            this.Controls.SetChildIndex(this.toolStrip, 0);
            this.Controls.SetChildIndex(this.searchPanel, 0);
            this.Controls.SetChildIndex(this.lblTotalRecordsText, 0);
            this.Controls.SetChildIndex(this.lblTotalRecords, 0);
            this.Controls.SetChildIndex(this.ctrProductInfo, 0);
            this.Controls.SetChildIndex(this.cbCategory, 0);
            this.Controls.SetChildIndex(this.cbProductActivity, 0);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCategory;
        private ctrProductInfo ctrProductInfo;
        protected System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton addProducrToolStripButton;
        private System.Windows.Forms.ComboBox cbProductActivity;
        private System.Windows.Forms.ToolStripButton CategoriesToolStripButton;
    }
}