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
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void PreviousButtonForgetPass_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FullNameTextBoxSignUp_Leave(object sender, EventArgs e)
        {
            string txt = UsernameTextboxForgetPass.Text;
            if (txt == "")
            {
                UsernameTextboxForgetPass.Text = "Username ";
                UsernameTextboxForgetPass.ForeColor = Color.Gray;
            }
        }

        private void UsernameTextboxForgetPass_Enter(object sender, EventArgs e)
        {
            UsernameTextboxForgetPass.ForeColor = Color.Black;
            if (UsernameTextboxForgetPass.Text == "Username ")
            {
                UsernameTextboxForgetPass.Text = "";
            }
        }

        // Khong cho nhap dau cach va cac ki tu dac biet
        private void UsernameTextboxForgetPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '_' || e.KeyChar == '-' || e.KeyChar == '@')
            {
                return;
            }
            e.Handled = true;
        }

        private void ContinueButtonForgetPass_Click(object sender, EventArgs e)
        {
            ForgetPassVerification f = new ForgetPassVerification();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
