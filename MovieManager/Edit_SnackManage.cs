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
using Guna.UI2.WinForms;

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
            Control parentContainer = CategoryComboBox.Parent;
            if (parentContainer != null)
            {
                parentContainer.Controls.Remove(ImportButton);
                parentContainer.Controls.Remove(ImportLabel);
                parentContainer.Controls.Remove(ImportTextBox);
            }
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
                    CategoryComboBox.SelectedIndex = snack.Category;
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
        private int import = 0;
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
                import += importAmount;
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
                    CategoryComboBox.SelectedIndex,
                    main.ID
                };
                if (import != 0)
                {
                    string query2 = @"INSERT INTO HISTORY VALUES ( @idsnack , @quantity , @date )";
                    object[] values2 = new object[]
                    {
                    main.ID,
                    import,
                    DateTime.Today
                    };
                    dp.ExecuteNonQuery(query2, values2);
                }
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
            if (NameTextBox.Text == "")
            {
                MessageBox.Show("Forget something?");
                return;
            }
            string query = @"INSERT INTO SNACK VALUES ( @name , @price , @stock , @category );
                            SELECT SCOPE_IDENTITY()";
            if (PriceTextBox.Text == "")
                PriceTextBox.Text = "0";
            if (StockTextBox.Text == "")
                StockTextBox.Text = "0";
            if(CategoryComboBox.Text == "")
                CategoryComboBox.SelectedIndex = 0;
            object[] values = new object[]
            {
                    NameTextBox.Text,
                    float.Parse(PriceTextBox.Text),
                    Convert.ToInt32(StockTextBox.Text),
                    CategoryComboBox.SelectedIndex
            };
            object result = dp.ExecuteScalar(query, values);
            string actdest = dest;
            int snackId = 0;
            if (result != null)
                snackId = Convert.ToInt32(result);
            if (snackId > 0)
            {
                string snackFileName = $"{snackId}.jpg";
                actdest = Path.Combine(dest, snackFileName);
                if (path != null)
                    File.Copy(path, actdest, true);
            }
            SnackChanged?.Invoke(this, EventArgs.Empty);
            CancelButton.PerformClick();
        }
        public event EventHandler SnackChanged;
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
