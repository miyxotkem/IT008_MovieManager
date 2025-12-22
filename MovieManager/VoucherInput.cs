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
using MovieManager.DTO;
namespace MovieManager
{
    public partial class VoucherInput : Form
    {
        private float total_bill;
        private Bill bill;
        public VoucherInput()
        {
            InitializeComponent();
        }

        public VoucherInput( float total_bill, Bill bill)
        {
            InitializeComponent(); 
            this.total_bill = total_bill;   
            this.bill = bill;
        }

        private void ExitButtonSignUp_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string code = VoucherTextbox.Text; 
            Voucher voucher = VoucherDAO.Instance.GetVoucher(code);
            if ( voucher == null)
            {
                MessageBox.Show("Voucher is invalid or expired", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            else
            {
                if (total_bill < voucher.Min_total_bill || !BillInfoDAO.Instance.CheckExistingFilmInBill(bill.IdBill))
                {
                    MessageBox.Show("Can not apply this voucher for this bill.","Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }    
                BillDAO.Instance.ApplyVoucherForBill(bill.IdBill, voucher.Id);
                MessageBox.Show("Applied successfully. Please reload the bill to see changes.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            } 
                
        }
    }
}
