using Guna.UI2.WinForms;
using MovieManager.DAO;
using Org.BouncyCastle.Math.Field;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieManager
{
    public partial class ResetPassConfirm : Form
    {
        private string UserName;
        public ResetPassConfirm()
        {
            InitializeComponent();
        }

        public ResetPassConfirm(string user)
        {
            InitializeComponent();  
            UserName = user;
        }

        private bool CheckInfo()
        {
            if (PassTextboxConfirmPass.Text.Length == 0
                || RetypeTextboxConfirmPass.Text.Length == 0
                || PassTextboxConfirmPass.Text.Length <= 8)
            {
                return false;
            }
            return true;
        }
        private void ResetButtonConfirmPass_Click(object sender, EventArgs e)
        {
            if (CheckInfo())
            {
                if (PassTextboxConfirmPass.Text != RetypeTextboxConfirmPass.Text)
                {
                    MessageBox.Show("Retyping your new password must be the same as your new password!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    epRetypePass.SetError(RetypeTextboxConfirmPass, "Inconsistent with your new password");
                    RetypeTextboxConfirmPass.BorderColor = Color.Red;
                    return;
                }
                string new_pass = PassTextboxConfirmPass.Text;
                ForgetPassUsernameDAO.Instance.UpdatePassword(UserName, new_pass);
                MessageBox.Show("Update password successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                SignInForm f = new SignInForm();
                f.ShowDialog();
            } else
            {
                MessageBox.Show("Please fill all the information.", "Notificaion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                epNewPass.SetError(PassTextboxConfirmPass, "Please fill the information");
                PassTextboxConfirmPass.BorderColor = Color.Red;
                epRetypePass.SetError(RetypeTextboxConfirmPass, "Please fill the information");
                RetypeTextboxConfirmPass.BorderColor = Color.Red;
                return;
            }
        }

        private void PreviousButtonForgetVerify_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PassTextboxConfirmPass_Enter(object sender, EventArgs e)
        {
            epNewPass.Clear();
            PassTextboxConfirmPass.BorderColor = Color.Gray;
        }

        private void RetypeTextboxConfirmPass_Enter(object sender, EventArgs e)
        {
            epRetypePass.Clear();
            RetypeTextboxConfirmPass.BorderColor = Color.Gray;
        }

        private void PassTextboxConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void RetypeTextboxConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void PassTextboxConfirmPass_TextChanged(object sender, EventArgs e)
        {
            Guna2TextBox txb = (Guna2TextBox)sender;
            if (txb.Text.Length > 0 && txb.Text.Length<=8)
            {
                PassTextboxConfirmPass.BorderColor = Color.Red;
                epNewPass.SetError(PassTextboxConfirmPass, "Password must be at least 8 characters");
            }
        }
    }
}
