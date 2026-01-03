using MovieManager.DAO;
using MovieManager.DTO;
using System;
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
    public partial class Edit_CustomerManage : UserControl
    {
        private List<Customer> customers = CustomerDAO.Instance.LoadCustomerList();
        private Customer main = null;
        public Edit_CustomerManage()
        {
            InitializeComponent();
            ApplyButton.Text = "Add";
            ApplyButton.Click -= ApplyButton_Click;
            ApplyButton.Click += Add_Click;
            Control parentContainer = MoneySpentTextBox.Parent;
            if (parentContainer != null)
            {
                parentContainer.Controls.Remove(MoneySpentTextBox);
                parentContainer.Controls.Remove(MoneySpentLabel);
                parentContainer.Controls.Remove(MembershipTextBox);
                parentContainer.Controls.Remove(MembershipLabel);
            }
        }

        public Edit_CustomerManage(int id)
        {
            InitializeComponent();
            foreach (Customer customer in customers)
            {
                if (customer.Id == id)
                {
                    main = customer;
                    NameTextBox.Text = customer.Name;
                    EmailTextBox.Text = customer.Email;
                    PhoneNumberTextBox.Text = customer.Phonenumber;
                    MoneySpentTextBox.Text = customer.Moneyspent.ToString();
                    MembershipTextBox.Text = customer.Membership == 0 ? "New" : customer.Membership == 1 ? "Bronze" : customer.Membership == 2 ? "Silver" : customer.Membership == 3 ? "Gold" : customer.Membership == 4 ? "Platinum" : "VIP PRO";
                    string fileName = main.Id.ToString() + ".jpg";
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
        private string dest = @"C:\Users\Thinh Phat\Documents\UIT\MovieManager\MovieManager\CustomerProfilePicture";
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "")
            {
                MessageBox.Show("Forget something?");
                return;
            }
            if (MessageBox.Show("Save changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = @"UPDATE CUSTOMER SET name = @name , email = @email , phone_number = @phone , membership = @mem , money_spent = @money WHERE id = @id ";
                object[] values = new object[]
                {
                    NameTextBox.Text,
                    EmailTextBox.Text,
                    PhoneNumberTextBox.Text,
                    MembershipTextBox.Text == "New" ? 0 : MembershipTextBox.Text == "Bronze" ? 1 : MembershipTextBox.Text == "Silver" ? 2 : MembershipTextBox.Text == "Gold" ? 3 : MembershipTextBox.Text == "Platinum" ? 4 : 5,
                    float.Parse(MoneySpentTextBox.Text),
                    main.Id
                };
                dp.ExecuteNonQuery(query, values);
                CusChanged?.Invoke(this, EventArgs.Empty);
                string actdest = dest;
                int snackId = main.Id;
                if (snackId > 0)
                {
                    string posterFileName = $"{snackId}.jpg";
                    actdest = Path.Combine(dest, posterFileName);
                }
                if (isImageDeleted)
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
            string query = @"INSERT INTO CUSTOMER VALUES( @name , @email , @phone , @mem , @money );
                            SELECT SCOPE_IDENTITY()";
            object[] values = new object[]
            {
                NameTextBox.Text,
                EmailTextBox.Text,
                PhoneNumberTextBox.Text,
                0,
                0,
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
            CusChanged?.Invoke(this, EventArgs.Empty);
            CancelButton.PerformClick();
        }
        public event EventHandler CusChanged;

        private Image LoadImageUnlocked(string path)
        {
            byte[] bytes = File.ReadAllBytes(path);
            MemoryStream ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }

        private string path = null;
        private bool isImageDeleted = false;

        private void UploadImageButton_Click(object sender, EventArgs e)
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

        private void RemoveImageButton_Click(object sender, EventArgs e)
        {
            if (SnackPic.Image != null)
            {
                SnackPic.Image.Dispose();
                SnackPic.Image = null;
            }
            path = null;
            isImageDeleted = true;
        }

        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = char.IsDigit(e.KeyChar);
            bool isBackspace = e.KeyChar == '\b';
            if (!isDigit && !isBackspace)
                e.Handled = true;
        }
    }
}
