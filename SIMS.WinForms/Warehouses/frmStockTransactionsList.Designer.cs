namespace SIMS.WinForms.Warehouses
{
    partial class frmStockTransactionsList
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbTransactionReason = new System.Windows.Forms.ComboBox();
            this.dtpTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.cbRange = new System.Windows.Forms.ComboBox();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbResponseEmployee = new System.Windows.Forms.ComboBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.cbWarehouse = new System.Windows.Forms.ComboBox();
            this.cbTransactionType = new System.Windows.Forms.ComboBox();
            this.lblInTransactions = new System.Windows.Forms.Label();
            this.lblOutTransactions = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalRecordsText
            // 
            this.lblTotalRecordsText.Location = new System.Drawing.Point(10, 693);
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.Location = new System.Drawing.Point(161, 693);
            this.lblTotalRecords.Size = new System.Drawing.Size(84, 14);
            // 
            // searchPanel
            // 
            this.searchPanel.Location = new System.Drawing.Point(555, 27);
            this.searchPanel.Size = new System.Drawing.Size(197, 26);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(167, 0);
            // 
            // lblSearchHintText
            // 
            this.lblSearchHintText.Size = new System.Drawing.Size(158, 16);
            this.lblSearchHintText.Text = "أدخل رقم الفاتورة";
            // 
            // txtSearch
            // 
            this.txtSearch.Size = new System.Drawing.Size(167, 26);
            this.txtSearch.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbTransactionReason);
            this.panel2.Controls.Add(this.dtpTimeFrom);
            this.panel2.Controls.Add(this.dtpDateFrom);
            this.panel2.Controls.Add(this.dtpTimeTo);
            this.panel2.Controls.Add(this.dtpDateTo);
            this.panel2.Controls.Add(this.cbRange);
            this.panel2.Controls.Add(this.btnApplyFilter);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbResponseEmployee);
            this.panel2.Controls.Add(this.cbProduct);
            this.panel2.Controls.Add(this.cbUnit);
            this.panel2.Controls.Add(this.cbWarehouse);
            this.panel2.Controls.Add(this.cbTransactionType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1112, 57);
            this.panel2.TabIndex = 66;
            // 
            // cbTransactionReason
            // 
            this.cbTransactionReason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTransactionReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransactionReason.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTransactionReason.FormattingEnabled = true;
            this.cbTransactionReason.Items.AddRange(new object[] {
            "كل الأسباب"});
            this.cbTransactionReason.Location = new System.Drawing.Point(561, 30);
            this.cbTransactionReason.Name = "cbTransactionReason";
            this.cbTransactionReason.Size = new System.Drawing.Size(150, 22);
            this.cbTransactionReason.TabIndex = 73;
            // 
            // dtpTimeFrom
            // 
            this.dtpTimeFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTimeFrom.Enabled = false;
            this.dtpTimeFrom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeFrom.Location = new System.Drawing.Point(212, 31);
            this.dtpTimeFrom.Name = "dtpTimeFrom";
            this.dtpTimeFrom.RightToLeftLayout = true;
            this.dtpTimeFrom.ShowUpDown = true;
            this.dtpTimeFrom.Size = new System.Drawing.Size(110, 21);
            this.dtpTimeFrom.TabIndex = 7;
            this.dtpTimeFrom.Value = new System.DateTime(2025, 9, 2, 0, 0, 0, 0);
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateFrom.Enabled = false;
            this.dtpDateFrom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(212, 4);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.RightToLeftLayout = true;
            this.dtpDateFrom.Size = new System.Drawing.Size(110, 21);
            this.dtpDateFrom.TabIndex = 6;
            this.dtpDateFrom.ValueChanged += new System.EventHandler(this.dtpDateFrom_ValueChanged);
            // 
            // dtpTimeTo
            // 
            this.dtpTimeTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTimeTo.Enabled = false;
            this.dtpTimeTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeTo.Location = new System.Drawing.Point(62, 31);
            this.dtpTimeTo.Name = "dtpTimeTo";
            this.dtpTimeTo.RightToLeftLayout = true;
            this.dtpTimeTo.ShowUpDown = true;
            this.dtpTimeTo.Size = new System.Drawing.Size(110, 21);
            this.dtpTimeTo.TabIndex = 9;
            this.dtpTimeTo.Value = new System.DateTime(2025, 9, 2, 0, 0, 0, 0);
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateTo.Enabled = false;
            this.dtpDateTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(62, 4);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.RightToLeftLayout = true;
            this.dtpDateTo.Size = new System.Drawing.Size(110, 21);
            this.dtpDateTo.TabIndex = 8;
            // 
            // cbRange
            // 
            this.cbRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRange.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRange.FormattingEnabled = true;
            this.cbRange.Items.AddRange(new object[] {
            "أخر 24 ساعة",
            "آخر 7 أيام",
            "آخر شهر",
            "آخر 3 شهور",
            "آخر 6 شهور",
            "آخر 12 شهر",
            "كل الأيام",
            "مخصص"});
            this.cbRange.Location = new System.Drawing.Point(359, 2);
            this.cbRange.Name = "cbRange";
            this.cbRange.Size = new System.Drawing.Size(167, 22);
            this.cbRange.TabIndex = 5;
            this.cbRange.SelectedIndexChanged += new System.EventHandler(this.cbRange_SelectedIndexChanged);
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.BackgroundImage = global::SIMS.WinForms.Properties.Resources.search_icon;
            this.btnApplyFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnApplyFilter.Location = new System.Drawing.Point(11, 5);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(45, 45);
            this.btnApplyFilter.TabIndex = 11;
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 71;
            this.label1.Text = "إلى:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 72;
            this.label2.Text = "من:";
            // 
            // cbResponseEmployee
            // 
            this.cbResponseEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbResponseEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbResponseEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbResponseEmployee.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbResponseEmployee.FormattingEnabled = true;
            this.cbResponseEmployee.Items.AddRange(new object[] {
            "كل الموظفين"});
            this.cbResponseEmployee.Location = new System.Drawing.Point(873, 30);
            this.cbResponseEmployee.Name = "cbResponseEmployee";
            this.cbResponseEmployee.Size = new System.Drawing.Size(225, 22);
            this.cbResponseEmployee.TabIndex = 1;
            this.cbResponseEmployee.Leave += new System.EventHandler(this.cbResponseEmployee_Leave);
            // 
            // cbProduct
            // 
            this.cbProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProduct.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Items.AddRange(new object[] {
            "كل المنتجات"});
            this.cbProduct.Location = new System.Drawing.Point(873, 2);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(225, 22);
            this.cbProduct.TabIndex = 0;
            this.cbProduct.Leave += new System.EventHandler(this.cbProduct_Leave);
            // 
            // cbUnit
            // 
            this.cbUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Items.AddRange(new object[] {
            "كل الوحدات"});
            this.cbUnit.Location = new System.Drawing.Point(717, 2);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(150, 22);
            this.cbUnit.TabIndex = 2;
            // 
            // cbWarehouse
            // 
            this.cbWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWarehouse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWarehouse.FormattingEnabled = true;
            this.cbWarehouse.Items.AddRange(new object[] {
            "كل المخازن"});
            this.cbWarehouse.Location = new System.Drawing.Point(717, 30);
            this.cbWarehouse.Name = "cbWarehouse";
            this.cbWarehouse.Size = new System.Drawing.Size(150, 22);
            this.cbWarehouse.TabIndex = 3;
            // 
            // cbTransactionType
            // 
            this.cbTransactionType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransactionType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTransactionType.FormattingEnabled = true;
            this.cbTransactionType.Items.AddRange(new object[] {
            "كل الحركات"});
            this.cbTransactionType.Location = new System.Drawing.Point(561, 2);
            this.cbTransactionType.Name = "cbTransactionType";
            this.cbTransactionType.Size = new System.Drawing.Size(150, 22);
            this.cbTransactionType.TabIndex = 4;
            // 
            // lblInTransactions
            // 
            this.lblInTransactions.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInTransactions.Location = new System.Drawing.Point(433, 693);
            this.lblInTransactions.Name = "lblInTransactions";
            this.lblInTransactions.Size = new System.Drawing.Size(84, 14);
            this.lblInTransactions.TabIndex = 85;
            this.lblInTransactions.Text = "N/A";
            this.lblInTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutTransactions
            // 
            this.lblOutTransactions.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutTransactions.Location = new System.Drawing.Point(703, 693);
            this.lblOutTransactions.Name = "lblOutTransactions";
            this.lblOutTransactions.Size = new System.Drawing.Size(84, 14);
            this.lblOutTransactions.TabIndex = 86;
            this.lblOutTransactions.Text = "N/A";
            this.lblOutTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 693);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 16);
            this.label3.TabIndex = 83;
            this.label3.Text = "إجمالي عدد حركات الدخول:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(523, 693);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 16);
            this.label4.TabIndex = 84;
            this.label4.Text = "إجمالي عدد حركات الخروج:";
            // 
            // frmStockTransactionsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 714);
            this.Controls.Add(this.lblInTransactions);
            this.Controls.Add(this.lblOutTransactions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Name = "frmStockTransactionsList";
            this.ShowIcon = false;
            this.ShowSearchTextBox = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سجل حركات المخزون";
            this.Load += new System.EventHandler(this.frmStockTransactionsList_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.searchPanel, 0);
            this.Controls.SetChildIndex(this.lblTotalRecordsText, 0);
            this.Controls.SetChildIndex(this.lblTotalRecords, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblOutTransactions, 0);
            this.Controls.SetChildIndex(this.lblInTransactions, 0);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTimeFrom;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTimeTo;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.ComboBox cbResponseEmployee;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.ComboBox cbWarehouse;
        private System.Windows.Forms.ComboBox cbTransactionType;
        private System.Windows.Forms.ComboBox cbRange;
        private System.Windows.Forms.Label lblInTransactions;
        private System.Windows.Forms.Label lblOutTransactions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTransactionReason;
    }
}