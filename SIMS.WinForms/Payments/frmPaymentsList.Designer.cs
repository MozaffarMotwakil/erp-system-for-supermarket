namespace SIMS.WinForms.Payments
{
    partial class frmPaymentsList
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
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.cbResponseEmployee = new System.Windows.Forms.ComboBox();
            this.cbPaymentReason = new System.Windows.Forms.ComboBox();
            this.cbPaymentType = new System.Windows.Forms.ComboBox();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.cbRange = new System.Windows.Forms.ComboBox();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchPanel
            // 
            this.searchPanel.Location = new System.Drawing.Point(556, 18);
            this.searchPanel.Size = new System.Drawing.Size(331, 26);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::SIMS.WinForms.Properties.Resources.search_icon;
            this.pictureBox.Location = new System.Drawing.Point(301, 0);
            // 
            // lblSearchHintText
            // 
            this.lblSearchHintText.Size = new System.Drawing.Size(292, 16);
            this.lblSearchHintText.Text = "أدخل إسم الطرف المقابل أو رقم الفاتورة";
            // 
            // txtSearch
            // 
            this.txtSearch.Size = new System.Drawing.Size(301, 26);
            this.txtSearch.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbPaymentMethod);
            this.panel2.Controls.Add(this.cbResponseEmployee);
            this.panel2.Controls.Add(this.cbPaymentReason);
            this.panel2.Controls.Add(this.cbPaymentType);
            this.panel2.Controls.Add(this.dtpDateFrom);
            this.panel2.Controls.Add(this.dtpDateTo);
            this.panel2.Controls.Add(this.cbRange);
            this.panel2.Controls.Add(this.btnApplyFilter);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1112, 57);
            this.panel2.TabIndex = 68;
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentMethod.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Items.AddRange(new object[] {
            "كل طرق الدفع",
            "كاش",
            "تحويل بنكي"});
            this.cbPaymentMethod.Location = new System.Drawing.Point(793, 3);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(150, 22);
            this.cbPaymentMethod.TabIndex = 2;
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
            this.cbResponseEmployee.Location = new System.Drawing.Point(562, 20);
            this.cbResponseEmployee.Name = "cbResponseEmployee";
            this.cbResponseEmployee.Size = new System.Drawing.Size(225, 22);
            this.cbResponseEmployee.TabIndex = 4;
            // 
            // cbPaymentReason
            // 
            this.cbPaymentReason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPaymentReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentReason.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentReason.FormattingEnabled = true;
            this.cbPaymentReason.Items.AddRange(new object[] {
            "كل الأسباب",
            "مشتريات",
            "مرتجعات مشتريات",
            "مبيعات",
            "مرتجعات مبيعات"});
            this.cbPaymentReason.Location = new System.Drawing.Point(949, 30);
            this.cbPaymentReason.Name = "cbPaymentReason";
            this.cbPaymentReason.Size = new System.Drawing.Size(150, 22);
            this.cbPaymentReason.TabIndex = 1;
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentType.FormattingEnabled = true;
            this.cbPaymentType.Items.AddRange(new object[] {
            "كل المعاملات",
            "المدفوعات",
            "المقبوضات"});
            this.cbPaymentType.Location = new System.Drawing.Point(949, 3);
            this.cbPaymentType.Name = "cbPaymentType";
            this.cbPaymentType.Size = new System.Drawing.Size(150, 22);
            this.cbPaymentType.TabIndex = 0;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateFrom.Enabled = false;
            this.dtpDateFrom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(74, 5);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.RightToLeftLayout = true;
            this.dtpDateFrom.Size = new System.Drawing.Size(110, 21);
            this.dtpDateFrom.TabIndex = 6;
            this.dtpDateFrom.ValueChanged += new System.EventHandler(this.dtpDateFrom_ValueChanged);
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateTo.Enabled = false;
            this.dtpDateTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(74, 30);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.RightToLeftLayout = true;
            this.dtpDateTo.Size = new System.Drawing.Size(110, 21);
            this.dtpDateTo.TabIndex = 7;
            // 
            // cbRange
            // 
            this.cbRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRange.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRange.FormattingEnabled = true;
            this.cbRange.Items.AddRange(new object[] {
            "آخر 24 ساعة",
            "آخر 7 أيام",
            "آخر شهر",
            "آخر 3 شهور",
            "آخر 6 شهور",
            "أخر 12 شهر",
            "كل الأيام",
            "مخصص"});
            this.cbRange.Location = new System.Drawing.Point(793, 30);
            this.cbRange.Name = "cbRange";
            this.cbRange.Size = new System.Drawing.Size(150, 22);
            this.cbRange.TabIndex = 3;
            this.cbRange.SelectedIndexChanged += new System.EventHandler(this.cbRange_SelectedIndexChanged);
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.BackgroundImage = global::SIMS.WinForms.Properties.Resources.search_icon;
            this.btnApplyFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnApplyFilter.Location = new System.Drawing.Point(11, 5);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(45, 45);
            this.btnApplyFilter.TabIndex = 8;
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 30);
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
            this.label2.Location = new System.Drawing.Point(185, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 72;
            this.label2.Text = "من:";
            // 
            // frmPaymentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 714);
            this.Controls.Add(this.panel2);
            this.Name = "frmPaymentsList";
            this.ShowIcon = false;
            this.ShowSearchTextBox = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المدفوعات/المقبوضات";
            this.Load += new System.EventHandler(this.frmPaymentsList_Load);
            this.Controls.SetChildIndex(this.lblTotalRecords, 0);
            this.Controls.SetChildIndex(this.lblTotalRecordsText, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.searchPanel, 0);
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
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.ComboBox cbRange;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbResponseEmployee;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.ComboBox cbPaymentType;
        private System.Windows.Forms.ComboBox cbPaymentReason;
    }
}