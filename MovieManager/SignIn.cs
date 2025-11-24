using Guna.UI2.WinForms;
using MovieManager.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Net.Mime.MediaTypeNames;

namespace MovieManager
{
    public partial class SignInForm : Form
    {
        Color DefaultBoderColor = new Color();

        private void InitiateOther()
        {
            DefaultBoderColor = Color.FromArgb(213, 218, 223);
        }
        public SignInForm()
        {
            InitializeComponent();
            InitiateOther();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            SignInShadow.SetShadowForm(this);
        }

        private void ExitButtonSignIn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButtonSignIn_Click(object sender, EventArgs e)
        {

        }

        bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }

        private bool CheckNeccesaryInfor()
        {
            if (UsernameTextBoxSignIn.Text.Length == 0 || PasswordTextBoxSignIn.Text.Length == 0
                || PasswordTextBoxSignIn.Text.Length <= 8)
            {
                return false;
            }
            return true;
        }
        private void SignInButtonSignIn_Click(object sender, EventArgs e)
        {
            if (!CheckNeccesaryInfor())
            {
                if (UsernameTextBoxSignIn.Text.Length == 0)
                {
                    UsernameTextBoxSignIn.BorderColor = Color.Red;
                    epUsernameSignIn.SetError(UsernameTextBoxSignIn, "Please fill the information");
                }
                if (PasswordTextBoxSignIn.Text.Length == 0)
                {
                    PasswordTextBoxSignIn.BorderColor = Color.Red;
                    epPassSignIn.SetError(PasswordTextBoxSignIn, "Please fill the information");
                }
                MessageBox.Show("Please fill and correct all the information.", "Notification");
                return;
            }
            string usr = UsernameTextBoxSignIn.Text;
            string pas = PasswordTextBoxSignIn.Text;
            if (Login(usr, pas))
            {
                Cinema f = new Cinema();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Notification");
            }
        }

        private void SignUpLinkLabelSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp f = new SignUp();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        // Dien day du thong tin
        private void FillInformationUserError(object sender, EventArgs e)
        {

        }

        private void FillInformationPassError(object sender, EventArgs e)
        {

        }

        // UserName chi duoc nhap chu va so va mot so ki tu đặc biệt 
        private void UsernameTextBoxSignIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '_' || e.KeyChar == '-' || e.KeyChar == '@')
            {
                return;
            }
            e.Handled = true;
        }

        // Mat khau khong chua dau cach
        private void PasswordTextBoxSignIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }


        private void ForgetPasswordLinkLabelSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword f = new ForgetPassword();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void UsernameTextBoxSignIn_Enter(object sender, EventArgs e)
        {
            UsernameTextBoxSignIn.BorderColor = DefaultBoderColor;
            epUsernameSignIn.Clear();
        }

        private void PasswordTextBoxSignIn_Enter(object sender, EventArgs e)
        {
            PasswordTextBoxSignIn.BorderColor = DefaultBoderColor;
            epPassSignIn.Clear();
        }

        private void PasswordTextBoxSignIn_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void PasswordTextBoxSignIn_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBoxSignIn.Text.Length <= 8 && PasswordTextBoxSignIn.Text.Length > 0)
            {
                PasswordTextBoxSignIn.BorderColor = Color.Red;
                epPassSignIn.SetError(PasswordTextBoxSignIn, "Password must be at least 8 characters");
            } else
            {
                PasswordTextBoxSignIn.BorderColor = DefaultBoderColor;
                epPassSignIn.Clear();
            }
        }

        private void PasswordTextBoxSignIn_IconRightClick(object sender, EventArgs e)
        {

        }

        private void PasswordTextBoxSignIn_IconLeftClick(object sender, EventArgs e)
        {

        }


        private void ShowPassButtonSignIn_Click_1(object sender, EventArgs e)
        {
            PasswordTextBoxSignIn.UseSystemPasswordChar = !PasswordTextBoxSignIn.UseSystemPasswordChar;       
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PasswordTextBoxSignIn.UseSystemPasswordChar = !PasswordTextBoxSignIn.UseSystemPasswordChar;
        }
    }
}
