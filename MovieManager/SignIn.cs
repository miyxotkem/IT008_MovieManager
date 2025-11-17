using Guna.UI2.WinForms;
using MovieManager.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void SignInButtonSignIn_Click(object sender, EventArgs e)
        {
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
            Guna2TextBox txb = (Guna2TextBox)sender;
            if (txb.Text.Length == 0)
            {
                errorProviderSignIn.SetError(txb, "Please fill the information.");
                txb.BorderColor = Color.Red;
            } else
            {
                errorProviderSignIn.Clear();
                txb.BorderColor = DefaultBoderColor;
            }
        }

        private void FillInformationPassError(object sender, EventArgs e)
        {
            Guna2TextBox txb = (Guna2TextBox)sender;
            string txt = txb.Text;
            if (txb.Text.Length == 0)
            {
                errorProviderSignIn.SetError(txb, "Please fill the information.");
                txb.BorderColor = Color.Red;
            }
            else if (txt.Length <= 8)
            {
                errorProviderSignIn.SetError(txb, "Password's length should be greater than 8 characters");
                txb.BorderColor = Color.Red;
            } else
            {
                errorProviderSignIn.Clear();
                txb.BorderColor = DefaultBoderColor;
            }
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

        // Dam bao do dai mat khau
        private void PasswordTextBoxSignIn_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
