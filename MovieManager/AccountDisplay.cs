using MovieManager.DAO;
using MovieManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieManager
{
    public partial class AccountDisplay : UserControl
    {
        private string ChoosePath = null;
        //private string Source = @"D:\Truongpham-code\DoAn_IT008\MovieManager\MovieManager\Avatars";
        private string Source = @"C:\Users\Thinh Phat\Documents\UIT\MovieManager\MovieManager\Avatars";
        private string CurUsername = "";
        private string CurFullname = "";
        private string CurEmail = "";
        public AccountDisplay()
        {
            InitializeComponent();
        }

        private void FullNameTextBoxSignUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccountDisplay_Load(object sender, EventArgs e)
        {
            
        }

        public void Reload(string username)
        {
             AccountInfo accountInfo = AccountInfoDAO.Instance.GetAccountInfoFromUser(username);
            if (accountInfo != null)
            {
                UserTextBox.Text = accountInfo.UserName;
                emailTextBox.Text = accountInfo.Email;
                IDTextBox.Text = Convert.ToString(accountInfo.ID);
                FullNameTextBoxAccount.Text = accountInfo.FullName;
                roleTextBoxAccount.Text = accountInfo.Role;
                CurUsername = accountInfo.UserName;
                CurFullname = accountInfo.FullName;
                CurEmail = accountInfo.Email;
                int idStaff = Convert.ToInt32(IDTextBox.Text);
                string id = idStaff.ToString("000");
                string fileName = "NV" + id + ".jpg";
                string DesPath = Path.Combine(Source, fileName);
                if (File.Exists(DesPath))
                {
                    AccountPictureBoxAccount.Image = LoadImageUnlocked(DesPath);
                }
                else
                {
                    AccountPictureBoxAccount.Image = Properties.Resources.DefaultImage;
                } 
                    
            }    
        }

        private void guna2CustomGradientPanel1_Resize(object sender, EventArgs e)
        {
            PicturePanel.Left = (ContainPanel.ClientSize.Width - PicturePanel.Width) / 2;
            InfoPanel.Left = (ContainPanel.ClientSize.Width - InfoPanel.Width) / 2;
        }

        private void Panel_Resize(object sender, EventArgs e)
        {
            
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string username = UserTextBox.Text;
            string email = emailTextBox.Text;
            string FullName = FullNameTextBoxAccount.Text;
            int idStaff = Convert.ToInt32(IDTextBox.Text);
            CurUsername = username;
            CurFullname = FullName;
            CurEmail = email;
            AdminDAO.Instance.UpdateAccount(idStaff, FullName, email, username);
            if (ChoosePath != null)
            {
                string id = idStaff.ToString("000");
                string fileName = "NV" + id + ".jpg";
                string DesPath = Path.Combine(Source, fileName);
                if (File.Exists(DesPath))
                {
                    File.Delete(DesPath);
                }    
                File.Copy(ChoosePath, DesPath);
                ChoosePath = null;
            }    
            MessageBox.Show("Update successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void emailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }    
        }

        private void UpImageButtonAccount_Click(object sender, EventArgs e)
        {
            AvatarUpLoad.Filter = "Avater (*.jpg)|*.jpg";
            if (AvatarUpLoad.ShowDialog() == DialogResult.OK)
            {
                string fileName = AvatarUpLoad.FileName;
                ChoosePath = Path.Combine(Source, fileName);
                if (File.Exists(ChoosePath))
                {
                    AccountPictureBoxAccount.Image = LoadImageUnlocked(ChoosePath);
                }
            }
        }

        private Image LoadImageUnlocked(string path)
        {
            byte[] bytes = File.ReadAllBytes(path);
            MemoryStream ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            UserTextBox.Text = CurUsername;
            FullNameTextBoxAccount.Text = CurFullname;
            emailTextBox.Text = CurEmail;
            int idStaff = Convert.ToInt32(IDTextBox.Text);
            string id = idStaff.ToString("000");
            string fileName = "NV" + id + ".jpg";
            string DesPath = Path.Combine(Source, fileName);
            if (File.Exists(DesPath))
            {
                AccountPictureBoxAccount.Image = LoadImageUnlocked(DesPath);
            }
            else
            {
                AccountPictureBoxAccount.Image = Properties.Resources.DefaultImage;
            }
        }
    }
}
