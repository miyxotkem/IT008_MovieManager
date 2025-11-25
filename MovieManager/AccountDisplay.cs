using MovieManager.DAO;
using MovieManager.DTO;
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
    public partial class AccountDisplay : UserControl
    {
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
            }    
        }
    }
}
