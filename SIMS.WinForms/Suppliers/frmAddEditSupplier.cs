using System;
using System.Windows.Forms;
using BusinessLogic.Parties;
using BusinessLogic.Validation;
using BusinessLogic.Suppliers;
using DVLD.WinForms.Utils;

namespace SIMS.WinForms.Suppliers
{
    public partial class frmAddEditSupplier : Form
    {
        private clsParty.enPartyCategory _SupplierCategory;
        public clsParty.enPartyCategory SupplierCategory 
        {
            get
            {
                return _SupplierCategory;
            }
            set
            {
                _SupplierCategory = value;

                switch (_SupplierCategory)
                {
                    case clsParty.enPartyCategory.Person:
                        ctrAddEditOrganization.Visible = false;
                        ctrAddEditPerson.Visible = true;
                        ctrAddEditPerson.AttachErrorProvider(errorProvider);
                        break;
                    case clsParty.enPartyCategory.Organization:
                        ctrAddEditPerson.Visible = false;
                        ctrAddEditOrganization.Visible = true;
                        gbOtherInfo.Location = new System.Drawing.Point(
                            gbOtherInfo.Location.X,
                            367
                            );
                        btnSave.Location = new System.Drawing.Point(
                            btnSave.Location.X,
                            515
                            );
                        btnCancle.Location = new System.Drawing.Point(
                            btnCancle.Location.X,
                            515
                            );
                        panel.Size = new System.Drawing.Size(panel.Width, 570);
                        this.Size = new System.Drawing.Size(this.Width, 630);
                        ctrAddEditOrganization.AttachErrorProvider(errorProvider);
                        break;
                    default:
                        break;
                }
            }
        }

        public enMode FormMode;
        private clsSupplier _Supplier;

        public frmAddEditSupplier(clsParty.enPartyCategory supplierType)
        {
            InitializeComponent();
            _Supplier = null;
            SupplierCategory = supplierType;
            FormMode = enMode.Add;
        }

        public frmAddEditSupplier(clsSupplier supplier, clsParty.enPartyCategory supplierType)
        {
            InitializeComponent();
            _Supplier = supplier;
            SupplierCategory = supplierType;
            FormMode = enMode.Edit;
        }

        private void frmAddEditSupplier_Load(object sender, EventArgs e)
        {
            this.Text = FormMode is enMode.Add ?
                "إضافة مورد جديد" :
                "تعديل معلومات مورد";

            if (FormMode is enMode.Edit)
            {
                if (_Supplier is null)
                {
                    this.Close();
                    clsFormMessages.ShowError("لم يتم العثور على المورد");
                    return;
                }

                switch (_SupplierCategory)
                {
                    case clsParty.enPartyCategory.Person:
                        ctrAddEditPerson.Person = _Supplier.PartyInfo as clsPerson;
                        break;
                    case clsParty.enPartyCategory.Organization:
                        ctrAddEditOrganization.Organization = _Supplier.PartyInfo as clsOrganization;
                        break;
                }

                txtNotes.Text = _Supplier.Notes;
            }
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

            if (clsFormMessages.Confirm("هل أنت متأكد من أنك تريد الحفظ ؟"))
            {
                clsParty supplierPatyInfo = SupplierCategory is clsParty.enPartyCategory.Person ?
                    (clsParty)ctrAddEditPerson.Person :
                    (clsParty)ctrAddEditOrganization.Organization;

                if (FormMode is enMode.Add)
                {
                    _Supplier = new clsSupplier(
                        supplierPatyInfo,
                        txtNotes.Text
                    );
                }
                else
                {
                    _Supplier.ChangeInfo(supplierPatyInfo, txtNotes.Text);
                }

                clsValidationResult validationResult = clsSupplierService.CreateInstance().Save(_Supplier);

                if (validationResult.IsValid)
                {
                    if (FormMode is enMode.Add)
                    {
                        clsFormMessages.ShowSuccess("تم إضافة المورد بنجاح");
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
}
