using MovieManager.DAO;
using MovieManager.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieManager
{
    public partial class Edit_SnackManage : UserControl
    {
        private List<Snack> snacks = SnackDAO.Instance.LoadSnackList();
        private Snack main = null;
        public Edit_SnackManage()
        {
            InitializeComponent();
            ApplyButton.Text = "Add";
            ApplyButton.Click -= ApplyButton_Click;
            ApplyButton.Click += Add_Click;
        }
        public Edit_SnackManage(int snackId)
        {
            InitializeComponent();
            foreach(Snack snack in snacks)
            {
                if(snack.ID == snackId)
                {
                    main = snack;
                    NameTextBox.Text = snack.Name;
                    PriceTextBox.Text = snack.Price.ToString();
                    StockTextBox.Text = snack.Stock.ToString();
                    CategoryTextBox.Text = snack.Category == 0 ? "Food" : "Beverage";
                    string fileName = main.ID.ToString() + ".jpg";
                    string fullImagePath = Path.Combine(dest, fileName);
                    if (File.Exists(fullImagePath))
                        SnackPic.Image = LoadImageUnlocked(fullImagePath);
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
        private DataProvider dp = new DataProvider();
        private string dest = @"C:\Users\Thinh Phat\Documents\UIT\MovieManager\MovieManager\Snacks";
        private Image LoadImageUnlocked(string path)
        {
            byte[] bytes = File.ReadAllBytes(path);
            MemoryStream ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ImportTextBox.Text))
            {
                MessageBox.Show("Please enter a number for importation", "Notification");
                return;
            }
            if (int.TryParse(ImportTextBox.Text, out int importAmount) && int.TryParse(StockTextBox.Text, out int currentStock))
            {
                StockTextBox.Text = (importAmount + currentStock).ToString();
                ImportTextBox.Text = "";
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if(NameTextBox.Text == "")
            {
                MessageBox.Show("Forget something?");
                return;
            }
            if (MessageBox.Show("Save changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = @"UPDATE SNACK SET name = @name , price = @price , stock = @stock , category = @category WHERE id = @id";
                object[] values = new object[]
                {
                    NameTextBox.Text,
                    float.Parse(PriceTextBox.Text),
                    Convert.ToInt32(StockTextBox.Text),
                    CategoryTextBox.Text == "Food" ? 0 : 1,
                    main.ID
                };
                string actdest = dest;
                int snackId = main.ID;
                if (snackId > 0)
                {
                    string posterFileName = $"{snackId}.jpg";
                    actdest = Path.Combine(dest, posterFileName);
                }
                if(isImageDeleted)
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    if (File.Exists(actdest))
                        File.Delete(actdest);
                }
                else if (path != null)
                    if (Path.GetFullPath(path) != Path.GetFullPath(actdest))
                    {
                        if (SnackPic.Image != null)
                        {
                            SnackPic.Image.Dispose();
                            SnackPic.Image = null;
                        }
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        if (File.Exists(actdest))
                            File.Delete(actdest);
                        File.Copy(path, actdest);
                    }
                dp.ExecuteNonQuery(query, values);
                CancelButton.PerformClick();
            }
        }

        void Add_Click(object sender, EventArgs e)
        { 
            
        }

        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
                e.Handled = true;
        }

        private void StockTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = char.IsDigit(e.KeyChar);
            bool isBackspace = e.KeyChar == '\b';
            if (!isDigit && !isBackspace)
                e.Handled = true;
        }

        private void ImportTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = char.IsDigit(e.KeyChar);
            bool isBackspace = e.KeyChar == '\b';
            if (!isDigit && !isBackspace)
                e.Handled = true;
        }
        private string path = null;
        private void AddPic_Click(object sender, EventArgs e)
        {
            UploadFileDialog.Filter = "Posters (*.jpg) | *.jpg";
            if (UploadFileDialog.ShowDialog() == DialogResult.OK)
            {
                isImageDeleted = false;
                path = UploadFileDialog.FileName;
                if (SnackPic.Image != null)
                {
                    SnackPic.Image.Dispose();
                    SnackPic.Image = null;
                }
                SnackPic.Image = LoadImageUnlocked(UploadFileDialog.FileName);
            }
        }
        private bool isImageDeleted = false;
        private void RemovePic_Click(object sender, EventArgs e)
        {
            if (SnackPic.Image != null)
            {
                SnackPic.Image.Dispose();
                SnackPic.Image = null;
            }
            path = null;
            isImageDeleted = true;
        }
    }
}
