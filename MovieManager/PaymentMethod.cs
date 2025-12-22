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
            ApplePayButton.Tag = "ApplePay";
            BankButton.Tag = "Banking";
            CashButton.Tag = "Cash";
            ApplePayButton.CheckedChanged += new EventHandler(CheckChange);
            BankButton.CheckedChanged += new EventHandler(CheckChange);
            CashButton.CheckedChanged += new EventHandler(CheckChange);
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
            Bill bill = BillDAO.Instance.GetUncheckedBill();
            if (bill != null)
            {
                BillDAO.Instance.PayBill(bill.IdBill, Method);
                Voucher v = VoucherDAO.Instance.GetVoucherFromID(bill.IdVoucher);
                if (v != null && v.Code != "HSSV") VoucherDAO.Instance.DeleteVoucher(v.Id);
                MessageBox.Show("Pay successfully. Please reload the bill first.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (BillDAO.Instance.CheckValidCustomer(bill.IdBill))
                {
                    CustomerDAO.Instance.IncreaseCustomerSpend(bill.IdCustomer, Total);
                }    
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error! Can not find appropriate bill.", "Notification");
            } 
                
        }
    }
}
