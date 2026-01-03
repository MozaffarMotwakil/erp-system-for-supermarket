using System;
using System.ComponentModel;
using System.Windows.Forms;
using BusinessLogic.Products;
using BusinessLogic.Validation;
using DVLD.WinForms.Utils;

namespace SIMS.WinForms.Products
{
    public partial class frmAddEditCategory : Form
    {
        private clsCategory _Category;
        private enMode _FormMode;

        public frmAddEditCategory()
        {
            InitializeComponent();
            _FormMode = enMode.Add;
        }

        public frmAddEditCategory(int categoryID)
        {
            InitializeComponent();
            _Category = clsCategoryService.CreateInstance().Find(categoryID);
            _FormMode = enMode.Edit;
        }

        public frmAddEditCategory(clsCategory category)
        {
            InitializeComponent();
            _Category = category;
            _FormMode = enMode.Edit;
        }

        private void frmAddEditCategory_Load(object sender, EventArgs e)
        {
            this.Text = _FormMode is enMode.Add ?
                "إضافة فئة جديدة" :
                "تعديل معلومات فئة";

            if (_FormMode is enMode.Edit)
            {
                if (_Category == null)
                {
                    this.Close();
                    clsFormMessages.ShowError("لم يتم العثور على الفئة");
                    return;
                }

                txtCategoryName.Text = _Category.CategoryName;
                txtDescription.Text = _Category.Description;
            }
        }

        private void txtWarehouseName_Validating(object sender, CancelEventArgs e)
        {
            clsFormValidation.ValidatingRequiredField(txtCategoryName, errorProvider, "يجب إدخال إسم للفئة");
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
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
                _Category = new clsCategory(
                    txtCategoryName.Text,
                    txtDescription.Text
                    );
            }
            else
            {
                _Category.CategoryName = txtCategoryName.Text;
                _Category.Description = txtDescription.Text;
            }

            clsValidationResult validationResult = _Category.Save();

            if (validationResult.IsValid)
            {
                if (_FormMode is enMode.Add)
                {
                    clsFormMessages.ShowSuccess("تم إضافة الفئة بنجاح");
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

    }
}
