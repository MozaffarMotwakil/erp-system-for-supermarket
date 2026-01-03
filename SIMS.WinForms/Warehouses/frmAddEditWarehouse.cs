using System;
using System.ComponentModel;
using System.Windows.Forms;
using BusinessLogic.Employees;
using BusinessLogic.Validation;
using BusinessLogic.Warehouses;
using DVLD.WinForms.Utils;

namespace SIMS.WinForms.Warehouses
{
    public partial class frmAddEditWarehouse : Form
    {
        private clsWarehouse _Warehouse;
        private enMode _FormMode;

        public frmAddEditWarehouse()
        {
            InitializeComponent();
            _Warehouse = null;
            _FormMode = enMode.Add;
        }

        public frmAddEditWarehouse(clsWarehouse warehouse)
        {
            InitializeComponent();
            _Warehouse = warehouse;
            _FormMode = enMode.Edit;
        }

        private void frmAddEditWarehouse_Load(object sender, EventArgs e)
        {
            this.Text = _FormMode is enMode.Add ?
                "إضافة مخزن جديد" :
                "تعديل معلومات مخزن";

            cbResponsibleEmployee.DataSource = clsEmployeeService.GetEmployeesList();
            cbResponsibleEmployee.DisplayMember = "EmployeeName";
            cbResponsibleEmployee.ValueMember = "EmployeeID";
            cbResponsibleEmployee.SelectedIndex = -1;
            cbResponsibleEmployee.Text = "إختر الموظف المسؤول عن المخزن";

            if (_FormMode is enMode.Edit)
            {
                if (_Warehouse is null)
                {
                    this.Close();
                    clsFormMessages.ShowError("لم يتم العثور على المخزن");
                    return;
                }

                if (_Warehouse.Type == clsWarehouse.enWarehouseType.ShopWarehouse)
                {
                    this.Close();
                    clsFormMessages.ShowError("لا يمكن تعديل معلومات مخزن المحل");
                    return;
                }

                txtWarehouseName.Text = _Warehouse.WarehouseName;
                rbSubWarehouse.Checked = !(rbMainWarehouse.Checked =
                    (_Warehouse.Type == clsWarehouse.enWarehouseType.MainWarehouse));
                cbResponsibleEmployee.SelectedValue = _Warehouse.ResponsibleEmployeeInfo.EmployeeID;
                txtAddress.Text = _Warehouse.Address;
            }
        }

        private void frmAddEditWarehouse_Shown(object sender, EventArgs e)
        {
            txtWarehouseName.Focus();
        }

        private void txtWarehouseName_Validating(object sender, CancelEventArgs e)
        {
            clsFormValidation.ValidatingRequiredField(txtWarehouseName, errorProvider, "لايمكن أن يكون إسم المخزن فارغا");
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            clsFormValidation.ValidatingRequiredField(txtAddress, errorProvider, "لا يمكن أن يكون عنوان المخزن فارغا");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!clsFormValidation.IsDataValid(this, errorProvider))
            {
                clsFormMessages.ShowInvalidDataError();
                return;
            }

            if (!clsFormMessages.Confirm("هل أنت متأكد من أنك تريد الحفظ ؟"))
            {
                return;
            }
                
            if (_FormMode is enMode.Add)
            {
                _Warehouse = new clsWarehouse(
                    txtWarehouseName.Text, 
                    txtAddress.Text, 
                    rbMainWarehouse.Checked ? 
                        clsWarehouse.enWarehouseType.MainWarehouse :
                        clsWarehouse.enWarehouseType.SubWarehouse, 
                    (int)cbResponsibleEmployee.SelectedValue
                    );
            }
            else
            {
                _Warehouse.WarehouseName = txtWarehouseName.Text;
                _Warehouse.Address = txtAddress.Text;
                _Warehouse.Type = rbMainWarehouse.Checked ?
                    clsWarehouse.enWarehouseType.MainWarehouse :
                    clsWarehouse.enWarehouseType.SubWarehouse;

                if (_Warehouse.ResponsibleEmployeeInfo.EmployeeID != (int)cbResponsibleEmployee.SelectedValue)
                {
                    _Warehouse.UpdateResponsibleEmployee((int)cbResponsibleEmployee.SelectedValue);
                }
            }

            clsValidationResult validationResult = clsWarehouseService.CreateInstance().Save(_Warehouse);

            if (validationResult.IsValid)
            {
                if (_FormMode is enMode.Add)
                {
                    clsFormMessages.ShowSuccess("تم إضافة المخزن بنجاح");
                }
                else
                {
                    clsFormMessages.ShowSuccess("تم حفظ التغيرات بنجاح");
                }

                this.Close();
            }
            else
            {
                clsFormMessages.ShowValidationErrors(validationResult);
            }
        }

        private void cbResponsibleEmployee_Enter(object sender, EventArgs e)
        {
            if (cbResponsibleEmployee.SelectedIndex == -1)
            {
                cbResponsibleEmployee.Text = string.Empty;
            }
        }

        private void cbResponsibleEmployee_Leave(object sender, EventArgs e)
        {
            if (cbResponsibleEmployee.SelectedIndex == -1)
            {
                cbResponsibleEmployee.Text = "إختر الموظف المسؤول عن المخزن";
            }
        }

        private void cbResponsibleEmployee_Validating(object sender, CancelEventArgs e)
        {
            clsFormValidation.ValidatingRequiredField(cbResponsibleEmployee, errorProvider, "يجب تعيين موظف مسؤول عن المخزن");
        }

    }
}
