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
    public partial class Edit_CustomerManage : UserControl
    {
        private List<Customer> customers = CustomerDAO.Instance.LoadCustomerList();
        public Edit_CustomerManage()
        {
            InitializeComponent();
        }

        public Edit_CustomerManage(int id)
        {
            InitializeComponent();
            foreach(Customer customer in customers)
            {
                if(customer.Id == id)
                {
                    NameTextBox.Text = customer.Name;
                    EmailTextBox.Text = customer.Email;
                    PhoneNumberTextBox.Text = customer.Phonenumber;
                    MoneySpentTextBox.Text = customer.Moneyspent.ToString();
                    MembershipTextBox.Text = customer.Membership == 0 ? "New" : customer.Membership == 1 ? "Bronze" : customer.Membership == 2 ? "Silver" : customer.Membership == 3 ? "Gold" : customer.Membership == 4 ? "Platinum" : "VIP PRO";
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Control parentContainer = this.Parent;
            if (parentContainer != null)
                parentContainer.Controls.Remove(this);
            this.Dispose();
        }
    }
}
