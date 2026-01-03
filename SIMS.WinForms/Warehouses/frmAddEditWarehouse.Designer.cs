namespace SIMS.WinForms.Warehouses
{
    partial class frmAddEditWarehouse
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbWarehouseInfo = new System.Windows.Forms.GroupBox();
            this.cbResponsibleEmployee = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbSubWarehouse = new System.Windows.Forms.RadioButton();
            this.rbMainWarehouse = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWarehouseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbWarehouseInfo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.RightToLeft = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.gbWarehouseInfo);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 349);
            this.panel1.TabIndex = 0;
            // 
            // gbWarehouseInfo
            // 
            this.gbWarehouseInfo.BackColor = System.Drawing.Color.White;
            this.gbWarehouseInfo.Controls.Add(this.cbResponsibleEmployee);
            this.gbWarehouseInfo.Controls.Add(this.label6);
            this.gbWarehouseInfo.Controls.Add(this.label4);
            this.gbWarehouseInfo.Controls.Add(this.btnCancle);
            this.gbWarehouseInfo.Controls.Add(this.btnSave);
            this.gbWarehouseInfo.Controls.Add(this.txtAddress);
            this.gbWarehouseInfo.Controls.Add(this.label2);
            this.gbWarehouseInfo.Controls.Add(this.panel3);
            this.gbWarehouseInfo.Controls.Add(this.txtWarehouseName);
            this.gbWarehouseInfo.Controls.Add(this.label1);
            this.gbWarehouseInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWarehouseInfo.Location = new System.Drawing.Point(3, 3);
            this.gbWarehouseInfo.Name = "gbWarehouseInfo";
            this.gbWarehouseInfo.Size = new System.Drawing.Size(567, 339);
            this.gbWarehouseInfo.TabIndex = 26;
            this.gbWarehouseInfo.TabStop = false;
            this.gbWarehouseInfo.Text = "معلومات المخزن";
            // 
            // cbResponsibleEmployee
            // 
            this.cbResponsibleEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbResponsibleEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbResponsibleEmployee.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbResponsibleEmployee.FormattingEnabled = true;
            this.cbResponsibleEmployee.Location = new System.Drawing.Point(21, 119);
            this.cbResponsibleEmployee.Name = "cbResponsibleEmployee";
            this.cbResponsibleEmployee.Size = new System.Drawing.Size(402, 24);
            this.cbResponsibleEmployee.TabIndex = 34;
            this.cbResponsibleEmployee.Enter += new System.EventHandler(this.cbResponsibleEmployee_Enter);
            this.cbResponsibleEmployee.Leave += new System.EventHandler(this.cbResponsibleEmployee_Leave);
            this.cbResponsibleEmployee.Validating += new System.ComponentModel.CancelEventHandler(this.cbResponsibleEmployee_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "الموظف المسؤول:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(21, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(524, 33);
            this.label4.TabIndex = 30;
            this.label4.Text = "تنويه: لا يسمح بوجود أكثر من مخزن رئيسي واحد, في حال تعيين مخزن كمخزن رئيسي وكان " +
    "هناك مخزن رئيسي سابق فسيتم تغيير تصنيف المخزن الرئيسي السابق إلى مخزن فرعي بشكل " +
    "تلقائي.";
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Image = global::SIMS.WinForms.Properties.Resources.cancle;
            this.btnCancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancle.Location = new System.Drawing.Point(188, 260);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(114, 42);
            this.btnCancle.TabIndex = 27;
            this.btnCancle.Text = "    إلغاء";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::SIMS.WinForms.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(310, 260);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 42);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "    حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(21, 162);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtAddress.MaxLength = 255;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(402, 94);
            this.txtAddress.TabIndex = 25;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "عنوان المخزن:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbSubWarehouse);
            this.panel3.Controls.Add(this.rbMainWarehouse);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(236, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 26);
            this.panel3.TabIndex = 23;
            // 
            // rbSubWarehouse
            // 
            this.rbSubWarehouse.AutoSize = true;
            this.rbSubWarehouse.Checked = true;
            this.rbSubWarehouse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSubWarehouse.Location = new System.Drawing.Point(55, 3);
            this.rbSubWarehouse.Name = "rbSubWarehouse";
            this.rbSubWarehouse.Size = new System.Drawing.Size(56, 20);
            this.rbSubWarehouse.TabIndex = 3;
            this.rbSubWarehouse.TabStop = true;
            this.rbSubWarehouse.Text = "فرعي";
            this.rbSubWarehouse.UseVisualStyleBackColor = true;
            // 
            // rbMainWarehouse
            // 
            this.rbMainWarehouse.AutoSize = true;
            this.rbMainWarehouse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMainWarehouse.Location = new System.Drawing.Point(122, 3);
            this.rbMainWarehouse.Name = "rbMainWarehouse";
            this.rbMainWarehouse.Size = new System.Drawing.Size(66, 20);
            this.rbMainWarehouse.TabIndex = 2;
            this.rbMainWarehouse.Text = "رئيسي";
            this.rbMainWarehouse.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "النوع:";
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarehouseName.Location = new System.Drawing.Point(22, 29);
            this.txtWarehouseName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtWarehouseName.MaxLength = 72;
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(402, 23);
            this.txtWarehouseName.TabIndex = 22;
            this.txtWarehouseName.Validating += new System.ComponentModel.CancelEventHandler(this.txtWarehouseName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "إسم المخزن:";
            // 
            // frmAddEditWarehouse
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(602, 373);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditWarehouse";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة/تعديل مخزن";
            this.Load += new System.EventHandler(this.frmAddEditWarehouse_Load);
            this.Shown += new System.EventHandler(this.frmAddEditWarehouse_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbWarehouseInfo.ResumeLayout(false);
            this.gbWarehouseInfo.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbWarehouseInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbSubWarehouse;
        private System.Windows.Forms.RadioButton rbMainWarehouse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWarehouseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbResponsibleEmployee;
        private System.Windows.Forms.Label label6;
    }
}