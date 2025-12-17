using Guna.UI2.WinForms;
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
    public partial class SelectSnack : UserControl
    {
        private string Source = @"D:\Truongpham-code\DoAn_IT008\MovieManager\MovieManager\Snacks";
        private Snack snack= null;
        private Control parentContainer = null;
        private Bill CurBill = null;
        public SelectSnack()
        {
            InitializeComponent();
            NameTextBox.Enabled = false;
            PriceTextBox.Enabled = false;   
        }

        public SelectSnack(Snack snack, Control parenContainer)
        {
            InitializeComponent();
            NameTextBox.Enabled = false;
            PriceTextBox.Enabled = false;
            if (snack != null)
            {
                string fileName = snack.ID.ToString() + ".jpg";
                string des = Path.Combine(Source, fileName);
                if (File.Exists(des))
                {
                    SnackPic.Image = LoadImageUnlocked(des);
                }
                NameTextBox.Text = snack.Name.ToString();
                PriceTextBox.Text = snack.Price.ToString("c");
                this.snack = snack;
            }    
            if (parenContainer != null)
            {
                this.parentContainer = parenContainer;
            }    
        }

        
        private Image LoadImageUnlocked(string path)
        {
            byte[] bytes = File.ReadAllBytes(path);
            MemoryStream ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerInput customerInput = new CustomerInput();
            customerInput.ShowDialog();
        }

        private void SelectSnack_Load(object sender, EventArgs e)
        {
            
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (CustomerDAO.Instance.CurrentCustomer == null)
            {
                CustomerDAO.Instance.CurrentCustomer = new Customer();  
            }    
            int idCustomer = CustomerDAO.Instance.CurrentCustomer.Id;
            Bill bill = BillDAO.Instance.GetIDBillFromIDCustomer(idCustomer);
            if (bill == null) // chưa có bill -> Cần tạo bill
            {
                BillDAO.Instance.CreateBill(idCustomer);
                bill = BillDAO.Instance.GetIDBillFromIDCustomer(idCustomer);
            }    
            if (bill != null && snack != null)
            {
                CurBill = bill;
                // Thêm thông tin vào billInfo 
                int Quantity = 1;
                if (QuantityTextbox.Text.Length > 0)
                {
                    try
                    {
                        Quantity = Convert.ToInt32(QuantityTextbox.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Invalid quantity.", "Notification");
                    } 
                }
                if (Quantity > snack.Stock)
                {
                    MessageBox.Show("Out of stock.", "Notification");
                    return;
                }    
                BillInfoDAO.Instance.AddBillInfoIntoBillID(bill.IdBill, "Food and Drink", snack.ID, Quantity, 0, snack.Price);
                MessageBox.Show("Successfully!", "Notification");
            }    
        }

        private void QuantityTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                return;
            }    
            e.Handled = true;
        }

        private void QuantityTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PreviousButtonForgetVerify_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            if (parentContainer != null)
            {
                parentContainer.Controls.Add(payment);
                payment.Dock = DockStyle.Fill;
                if (CurBill != null)
                {
                    payment.Tag = CurBill;
                }    
                payment.BringToFront();
            }
            this.Dispose();
        }
    }
}
