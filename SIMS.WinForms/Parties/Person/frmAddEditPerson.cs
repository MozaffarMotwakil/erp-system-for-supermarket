using System;
using System.Windows.Forms;
using DVLD.WinForms.Utils;
using BusinessLogic.Parties;
using static BusinessLogic.Parties.clsParty;

namespace SIMS.WinForms.Parties.Person
{
    public partial class frmAddEditPerson : Form
    {
        public event EventHandler<clsPerson> PersonSaved;

        protected virtual void OnPersonSaved(clsPerson savedPerson)
        {
            PersonSaved?.Invoke(this, savedPerson);
        }

        public enPartyType PersonType
        {
            get
            {
                return _PersonType;
            }
            set
            {
                _PersonType = value;

                switch (_PersonType)
                {
                    case enPartyType.Employee:
                        ctrAddEditPerson.PersonType = enPartyType.Employee;
                        this.Text = FormMode is enMode.Add ?
                            "إضافة موظف جديد" :
                            "تعديل بيانات موظف";
                        break;
                    case enPartyType.Customer:
                        ctrAddEditPerson.PersonType = enPartyType.Customer;
                        this.Text = FormMode is enMode.Add ?
                            "إضافة عميل جديد" :
                            "تعديل بيانات عميل";
                        break;
                    case enPartyType.Supplier:
                        ctrAddEditPerson.PersonType = enPartyType.Supplier;
                        this.Text = FormMode is enMode.Add ?
                            "إضافة مورد جديد" :
                            "تعديل بيانات مورد";
                        break;
                    case enPartyType.ContactPerson:
                        ctrAddEditPerson.PersonType = enPartyType.ContactPerson;
                        this.Text = FormMode is enMode.Add ?
                            "إضافة جهة تواصل جديدة" :
                            "تعديل بيانات جهة التواصل";
                        break;
                    default:
                        this.Text = FormMode is enMode.Add ?
                            "إضافة شخص جديد" :
                            "تعديل بيانات شخص";
                        break;
                }
            }
        }

        public enMode FormMode { get; set; }
        private enPartyType _PersonType;
        private clsPerson _Person;

        public frmAddEditPerson(enMode formMode, enPartyType personType)
        {
            InitializeComponent();
            ctrAddEditPerson.AttachErrorProvider(errorProvider);
            _Person = null;
            FormMode = formMode;
            PersonType = personType;
        }

        public frmAddEditPerson(clsPerson person, enMode formMode, enPartyType personType)
        {
            InitializeComponent();
            ctrAddEditPerson.AttachErrorProvider(errorProvider);
            _Person = person;
            FormMode = formMode;
            PersonType = personType;
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            if (FormMode is enMode.Edit)
            {
                if (_Person is null)
                {
                    this.Close();
                    clsFormMessages.ShowError("لم يتم العثور على الشخص");
                    return;
                }

                ctrAddEditPerson.Person = _Person;
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!clsFormValidation.IsDataValid(ctrAddEditPerson, errorProvider))
            {
                clsFormMessages.ShowInvalidDataError();
                return;
            }

            _Person = ctrAddEditPerson.Person;
            OnPersonSaved(_Person);
            this.Close();
        }

    }
}
