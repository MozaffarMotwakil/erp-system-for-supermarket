namespace SIMS.WinForms.Warehouses
{
    partial class frmTransferedOperationsList
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
            this.cbRange = new System.Windows.Forms.ComboBox();
            this.cbDestinationWarehouse = new System.Windows.Forms.ComboBox();
            this.cbSourceWarehouse = new System.Windows.Forms.ComboBox();
            this.dtpTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbResponseEmployee = new System.Windows.Forms.ComboBox();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalRecordsText
            // 
            this.lblTotalRecordsText.Size = new System.Drawing.Size(168, 16);
            this.lblTotalRecordsText.Text = "إجمالي عدد عمليات النقل:";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.Location = new System.Drawing.Point(185, 691);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbRange);
            this.panel2.Controls.Add(this.cbDestinationWarehouse);
            this.panel2.Controls.Add(this.cbSourceWarehouse);
            this.panel2.Controls.Add(this.dtpTimeFrom);
            this.panel2.Controls.Add(this.dtpDateFrom);
            this.panel2.Controls.Add(this.dtpTimeTo);
            this.panel2.Controls.Add(this.dtpDateTo);
            this.panel2.Controls.Add(this.btnApplyFilter);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbResponseEmployee);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1112, 57);
            this.panel2.TabIndex = 67;
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
            this.cbRange.Location = new System.Drawing.Point(587, 19);
            this.cbRange.Name = "cbRange";
            this.cbRange.Size = new System.Drawing.Size(150, 22);
            this.cbRange.TabIndex = 68;
            this.cbRange.SelectedIndexChanged += new System.EventHandler(this.cbRange_SelectedIndexChanged);
            // 
            // cbDestinationWarehouse
            // 
            this.cbDestinationWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDestinationWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestinationWarehouse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDestinationWarehouse.FormattingEnabled = true;
            this.cbDestinationWarehouse.Items.AddRange(new object[] {
            "كل المخازن"});
            this.cbDestinationWarehouse.Location = new System.Drawing.Point(743, 19);
            this.cbDestinationWarehouse.Name = "cbDestinationWarehouse";
            this.cbDestinationWarehouse.Size = new System.Drawing.Size(175, 22);
            this.cbDestinationWarehouse.TabIndex = 73;
            this.cbDestinationWarehouse.Leave += new System.EventHandler(this.cbDestinationWarehouse_Leave);
            // 
            // cbSourceWarehouse
            // 
            this.cbSourceWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSourceWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSourceWarehouse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSourceWarehouse.FormattingEnabled = true;
            this.cbSourceWarehouse.Items.AddRange(new object[] {
            "كل المخازن"});
            this.cbSourceWarehouse.Location = new System.Drawing.Point(924, 19);
            this.cbSourceWarehouse.Name = "cbSourceWarehouse";
            this.cbSourceWarehouse.Size = new System.Drawing.Size(175, 22);
            this.cbSourceWarehouse.TabIndex = 74;
            this.cbSourceWarehouse.Leave += new System.EventHandler(this.cbSourceWarehouse_Leave);
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
            this.cbResponseEmployee.Location = new System.Drawing.Point(356, 19);
            this.cbResponseEmployee.Name = "cbResponseEmployee";
            this.cbResponseEmployee.Size = new System.Drawing.Size(225, 22);
            this.cbResponseEmployee.TabIndex = 1;
            // 
            // frmTransferedOperationsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 714);
            this.Controls.Add(this.panel2);
            this.Name = "frmTransferedOperationsList";
            this.ShowIcon = false;
            this.ShowSearchTextBox = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سجل عمليات النقل";
            this.Load += new System.EventHandler(this.frmTransferedOperationsList_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.lblTotalRecords, 0);
            this.Controls.SetChildIndex(this.searchPanel, 0);
            this.Controls.SetChildIndex(this.lblTotalRecordsText, 0);
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
        private System.Windows.Forms.DateTimePicker dtpTimeFrom;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.DateTimePicker dtpTimeTo;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbResponseEmployee;
        private System.Windows.Forms.ComboBox cbDestinationWarehouse;
        private System.Windows.Forms.ComboBox cbSourceWarehouse;
        private System.Windows.Forms.ComboBox cbRange;
    }
}