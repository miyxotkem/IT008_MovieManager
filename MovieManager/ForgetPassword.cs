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

namespace MovieManager
{
    public partial class ForgetPassword : Form
    {
        Color DefaultBoderColor = new Color();
        private Random random;
        private string UserEmail = "";
        private int IDStaff;
        private void InitiateOther()
        {
            DefaultBoderColor = Color.FromArgb(213, 218, 223);
            random = new Random();
        }
        public ForgetPassword()
        {
            InitiateOther();
            InitializeComponent();
        }

        public string userEmail
        {
            get { return UserEmail; }   
            private set { UserEmail = value; }
        }

        public int ID
        {
            get { return IDStaff; }
            private set { IDStaff = value; }
        }
        private void PreviousButtonForgetPass_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FullNameTextBoxSignUp_Leave(object sender, EventArgs e)
        {

        }

        private void UsernameTextboxForgetPass_Enter(object sender, EventArgs e)
        {
            UsernameTextboxForgetPass.ForeColor = Color.Black;
            if (UsernameTextboxForgetPass.Text == "Username ")
            {
                UsernameTextboxForgetPass.Text = "";
            }
            epUsernameForgetPass.Clear();
            UsernameTextboxForgetPass.BorderColor = DefaultBoderColor;
        }

        // Khong cho nhap dau cach va cac ki tu dac biet
        private void UsernameTextboxForgetPass_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ContinueButtonForgetPass_Click(object sender, EventArgs e)
        {
            if (UsernameTextboxForgetPass.Text.Length == 0 || UsernameTextboxForgetPass.Text == "Username ")
            {
                epUsernameForgetPass.SetError(UsernameTextboxForgetPass, "Please fill the information");
                UsernameTextboxForgetPass.BorderColor = Color.Red;
                MessageBox.Show("Please fill all the information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string username = UsernameTextboxForgetPass.Text;
            if (ForgetPassUsernameDAO.Instance.CheckValidUsername(username))
            {
                UserEmail = ForgetPassUsernameDAO.Instance.GetEmailFromUser(username);
                int RandomNumber = random.Next(0, 100001);
                string verificationCode = RandomNumber.ToString("000000");
                IDStaff = ForgetPassUsernameDAO.Instance.GetIDStaffFromAccount(username);
                if (IDStaff == -1)
                {
                    MessageBox.Show("Error", "Notification");
                    return;
                }    
                ForgetPassUsernameDAO.Instance.InsertValueIntoForgetTable(IDStaff, verificationCode);
                ForgetPassVerification f = new ForgetPassVerification();
                this.Hide();
                f.ShowDialog();
                this.Show();
            } else
            {
                MessageBox.Show("Incorrect username", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PreviousButtonForgetVerify_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsernameTextboxForgetPass_Leave(object sender, EventArgs e)
        {
            if (UsernameTextboxForgetPass.Text.Length == 0)
            {
                UsernameTextboxForgetPass.ForeColor = Color.Gray;
                UsernameTextboxForgetPass.Text = "Username ";
            }
        }

        private void UsernameTextboxForgetPass_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '_' || e.KeyChar == '-' || e.KeyChar == '@')
            {
                return;
            }
            e.Handled = true;
        }
    }
}
