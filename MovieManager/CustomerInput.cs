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
using MovieManager.DTO;
namespace MovieManager
{
    public partial class CustomerInput : Form
    {
        public CustomerInput()
        {
            InitializeComponent();
        }

        private void ExitButtonSignUp_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                return;
            }    
            e.Handled = true;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string phone = PhoneNumberTextBox.Text;
            Customer customer = CustomerDAO.Instance.CheckExistCustomer(phone);
            if (customer == null) // không có customer 
            {
                // Add số điện thoại vào 
                CustomerDAO.Instance.AddCustomer(phone);
                customer = CustomerDAO.Instance.CheckExistCustomer(phone);
                this.Dispose();
            }
            else
            {
                if (customer.Membership == 0)
                {
                    DialogResult r = new DialogResult();
                    r = MessageBox.Show("Do you want to register as a customer?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {

                    }
                }
            }
            CustomerDAO.Instance.CurrentCustomer = customer;    
        }
    }
}
