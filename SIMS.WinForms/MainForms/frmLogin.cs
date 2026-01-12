using System;
using System.Windows.Forms;
using BusinessLogic;
using BusinessLogic.Users;
using DVLD.WinForms.Utils;
using SIMS.WinForms;

namespace DVLD.WinForms.MainForms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (clsLoginManager.IsLoginInformationExist())
            {
                txtUsername.Text = clsLoginManager.GetSavedUsername();
                txtPassword.Text = clsLoginManager.GetSavedPassword();
                cbRememberMe.Checked = true;
            }

            pcShowPassword.Tag = txtPassword;
        }

        private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsFormValidation.ValidatingRequiredField(txtUsername, errorProvider, "يجب إدخال إسم المستخدم");
        }

        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsFormValidation.ValidatingRequiredField(txtPassword, errorProvider, "يجب إدخال كلمة المرور");
        }

        private void frmLogin_VisibleChanged(object sender, EventArgs e)
        {
            // Ensure the logic is not executed during the initial launch when no user is logged in yet
            if (clsAppSettings.CurrentUser == null)
            {
                return;
            }

            if (cbRememberMe.Checked)
            {
                clsLoginManager.SaveLoginInformation(txtUsername.Text, txtPassword.Text);
            }
            else
            {
                clsLoginManager.DeleteLoginInformation();
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
        }

        private void pcShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            clsFormHelper.ShowPassword(sender, e);
        }

        private void pcShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            clsFormHelper.HidePassword(sender, e);

            if (cbShowPasswords.Checked)
            {
                cbShowPasswords.Checked = false;
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cbRememberMe.Checked)
            {
                clsLoginManager.DeleteLoginInformation();
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            clsFormHelper.SetPasswordsVisibility(
                new TextBox[1] { txtPassword },
                cbShowPasswords.Checked
                );
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!clsFormValidation.IsDataValid(this, errorProvider))
            {
                clsFormMessages.ShowInvalidDataError();
                return;
            }

            clsUser user = clsUser.Find(1);

            if (txtUsername.Text != "Mozaffar_Mo")
            {
                clsFormMessages.ShowError("إسم المستخدم غير صحيح");
                return;
            }

            if (txtPassword.Text != "1231235588")
            {
                clsFormMessages.ShowError("كلمة المرور غير صحيحة");
                return;
            }

            if (!user.IsActive)
            {
                clsFormMessages.ShowError("عذرا حسابك غير نشط الرجاء التواصل مع الشخص المسؤول");
                return;
            }

            clsAppSettings.CurrentUser = user;
            frmMainForm mainForm = frmMainForm.CreateInstance();
            this.Visible = false;
            mainForm.Show();
        }

    }
}
