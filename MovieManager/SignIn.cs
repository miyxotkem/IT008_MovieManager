using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieManager.DAO;

namespace MovieManager
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
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

        
    }
}
