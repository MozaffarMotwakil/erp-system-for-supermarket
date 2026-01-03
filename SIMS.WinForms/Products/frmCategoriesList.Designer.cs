namespace SIMS.WinForms.Products
{
    partial class frmCategoriesList
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
            this.cbCategoryActivity = new System.Windows.Forms.ComboBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.addCategoryToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalRecordsText
            // 
            this.lblTotalRecordsText.Location = new System.Drawing.Point(9, 536);
            this.lblTotalRecordsText.Size = new System.Drawing.Size(125, 16);
            this.lblTotalRecordsText.Text = "إجمالي عدد الفئات:";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.Location = new System.Drawing.Point(142, 538);
            // 
            // searchPanel
            // 
            this.searchPanel.Size = new System.Drawing.Size(284, 26);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(254, 0);
            // 
            // lblSearchHintText
            // 
            this.lblSearchHintText.Size = new System.Drawing.Size(245, 16);
            this.lblSearchHintText.Text = "أدخل إسم الفئة";
            // 
            // txtSearch
            // 
            this.txtSearch.Size = new System.Drawing.Size(254, 26);
            // 
            // cbCategoryActivity
            // 
            this.cbCategoryActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoryActivity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoryActivity.FormattingEnabled = true;
            this.cbCategoryActivity.Items.AddRange(new object[] {
            "كل الفئات",
            "الفئات النشطه",
            "الفئات الغير نشطه"});
            this.cbCategoryActivity.Location = new System.Drawing.Point(358, 9);
            this.cbCategoryActivity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCategoryActivity.Name = "cbCategoryActivity";
            this.cbCategoryActivity.Size = new System.Drawing.Size(175, 24);
            this.cbCategoryActivity.TabIndex = 50;
            this.cbCategoryActivity.SelectedIndexChanged += new System.EventHandler(this.cbCategoryActivity_SelectedIndexChanged);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.White;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCategoryToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.ShowItemToolTips = false;
            this.toolStrip.Size = new System.Drawing.Size(834, 40);
            this.toolStrip.TabIndex = 49;
            this.toolStrip.Text = "toolStrip1";
            // 
            // addCategoryToolStripButton
            // 
            this.addCategoryToolStripButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryToolStripButton.Image = global::SIMS.WinForms.Properties.Resources.dairy_products;
            this.addCategoryToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addCategoryToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addCategoryToolStripButton.Name = "addCategoryToolStripButton";
            this.addCategoryToolStripButton.Size = new System.Drawing.Size(133, 37);
            this.addCategoryToolStripButton.Text = "   إضافة فئة جديدة";
            this.addCategoryToolStripButton.ToolTipText = "   إضافة مخزن جديد   ";
            this.addCategoryToolStripButton.Click += new System.EventHandler(this.addCategoryToolStripButton_Click);
            // 
            // frmCategoriesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.cbCategoryActivity);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCategoriesList";
            this.ShowIcon = false;
            this.ShowSearchTextBox = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة الفئات/الأصناف";
            this.Load += new System.EventHandler(this.frmCategoriesList_Load);
            this.Controls.SetChildIndex(this.toolStrip, 0);
            this.Controls.SetChildIndex(this.cbCategoryActivity, 0);
            this.Controls.SetChildIndex(this.lblTotalRecords, 0);
            this.Controls.SetChildIndex(this.searchPanel, 0);
            this.Controls.SetChildIndex(this.lblTotalRecordsText, 0);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbCategoryActivity;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton addCategoryToolStripButton;
    }
}