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
                // Thông báo không có 
                MessageBox.Show("No valid customer.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CustomerDAO.Instance.CurrentCustomer = new Customer();
            }
            else
            {
                Bill bill = BillDAO.Instance.GetUncheckedBill();
                if (bill != null)
                {
                    BillDAO.Instance.UpdateCustomerID(bill.IdBill, customer.Id);
                }    
            } 
            this.Dispose();
        }
    }
}
