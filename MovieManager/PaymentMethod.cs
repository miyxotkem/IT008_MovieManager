using Azure.Core.Extensions;
using Guna.UI2.WinForms;
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
    public partial class PaymentMethod : Form
    {
        private float Total = 0;
        private void Initial()
        {
            CashButton.Tag = "Cash";
            BankButton.Tag = "Banking";
            ApplePayButton.Tag = "ApplePay";
            CashButton.CheckedChanged += new EventHandler(CheckChange);
            BankButton.CheckedChanged += new EventHandler(CheckChange);
            ApplePayButton.CheckedChanged += new EventHandler(CheckChange);
        }
        public PaymentMethod()
        {
            InitializeComponent();
            Initial();
        }

        public PaymentMethod(float Total)
        {
            InitializeComponent();
            Initial();
            this.Total = Total;
        }
        private string Method = "Cash";

        private void PaymentMethod_Resize(object sender, EventArgs e)
        {
            MethodPanel.Left = (this.ClientSize.Width - MethodPanel.Width) / 2;
            PaymentLabel.Left = (this.ClientSize.Width - PaymentLabel.Width) / 2;
            ConfirmButton.Left = (this.ClientSize.Width - ConfirmButton.Width) / 2;
        }

        private void ExitButtonSignUp_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void PaymentMethod_Load(object sender, EventArgs e)
        {
            CashButton.Checked = true;
        }

        private void CheckChange(object sender, EventArgs e)
        {
            Guna2CustomRadioButton btn = (Guna2CustomRadioButton)sender;
            if (btn != null)
            {
                Method = btn.Tag.ToString();
            }    
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (CustomerDAO.Instance.CurrentCustomer == null)
            {
                CustomerDAO.Instance.CurrentCustomer = new Customer();
            }
            int idCustomer = CustomerDAO.Instance.CurrentCustomer.Id;
            Bill bill = BillDAO.Instance.GetIDBillFromIDCustomer(idCustomer);
            if (bill != null)
            {
                BillDAO.Instance.PayBill(bill.IdBill, Method);
                MessageBox.Show("Pay successfully", "Notification");
                if (CustomerDAO.Instance.CurrentCustomer.Id != -1) // ->Khách hàng
                {
                    CustomerDAO.Instance.IncreaseCustomerSpend(CustomerDAO.Instance.CurrentCustomer.Id, Total);
                }    
                CustomerDAO.Instance.CurrentCustomer = null;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error! Can not find appropriate bill.", "Notification");
            } 
                
        }
    }
}
