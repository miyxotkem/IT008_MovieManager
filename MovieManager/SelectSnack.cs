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
        public SelectSnack()
        {
            InitializeComponent();
            NameTextBox.Enabled = false;
            PriceTextBox.Enabled = false;   
        }

        public SelectSnack(Snack snack)
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
            if (CustomerDAO.Instance.CurrentCustomer != null)
            {
                AddCustomerButton.Visible = false;
            }
            else
            {
                AddCustomerButton.Visible = true;
            } 
                
        }
    }
}
