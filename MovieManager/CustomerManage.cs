using Guna.UI2.WinForms;
using MovieManager.DAO;
using MovieManager.DTO;
using Org.BouncyCastle.Utilities;
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
    public partial class CustomerManage : UserControl
    {
        private List<Customer> customers;
        public CustomerManage()
        {
            InitializeComponent();
            customers = CustomerDAO.Instance.LoadCustomerList();
            FilterComboBox.SelectedIndex = 0;
            LoadCustomer(customers);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (FilterComboBox.SelectedIndex == 0)
                SearchAndFilter();
            else
                FilterComboBox.SelectedIndex = 0;
        }

        void LoadCustomer(List<Customer> customerList)
        {
            Panel p = new Panel()
            {
                Height = 30,
                Width = 1000
            };
            Label n = new Label()
            {
                Location = new Point(100, 10),
                Width = 250,
                Text = "Name",
                Font = new Font(Font, FontStyle.Bold)
            };
            Label e = new Label()
            {
                Location = new Point(350, 10),
                Width = 250,
                Text = "Email",
                Font = new Font(Font, FontStyle.Bold)
            };
            Label ph = new Label()
            {
                Location = new Point(600, 10),
                Width = 200,
                Text = "Phone number",
                Font = new Font(Font, FontStyle.Bold)
            };
            Label m = new Label()
            {
                Location = new Point(800, 10),
                Width = 100,
                Text = "Membership",
                Font = new Font(Font, FontStyle.Bold)
            };
            Label ed = new Label()
            {
                Location = new Point(950, 10),
                Width = 100,
                Text = "Edit",
                Font = new Font(Font, FontStyle.Bold)
            };
            p.Controls.Add(n);
            p.Controls.Add(e);
            p.Controls.Add(ph);
            p.Controls.Add(m);
            p.Controls.Add(ed);
            flowLayoutPanel2.Controls.Add(p);
            foreach(Customer customer in customerList)
            {
                Guna2GradientPanel pnl = new Guna2GradientPanel()
                {
                    Height = 50,
                    Width = 1000,
                };
                Label name = new Label()
                {
                    Location = new Point(100, 20),
                    Width = 250,
                    Text = customer.Name
                };
                Label email = new Label()
                {
                    Location = new Point(350, 20),
                    Width = 250,
                    Text = customer.Email
                };
                Label phonenumber = new Label()
                {
                    Location = new Point(600, 20),
                    Width = 200,
                    Text = customer.Phonenumber
                };
                Label membership = new Label()
                {
                    Location = new Point(800, 20),
                    Width = 100,
                    Text = customer.Membership == 0 ? "New" : customer.Membership == 1 ? "Bronze" : customer.Membership == 2 ? "Silver" : customer.Membership == 3 ? "Gold" : customer.Membership == 4 ? "Platinum" : "VIP PRO"
                };
                Guna2GradientButton edit = new Guna2GradientButton()
                {
                    Image = global::MovieManager.Properties.Resources.loyalty_30dp_BLACK_FILL0_wght400_GRAD0_opsz24,
                    Animated = true,
                    Tag = customer.Id,
                    BorderRadius = 10,
                    Size = new Size(30, 30),
                    FillColor = Color.FromArgb(175, 62, 62),
                    FillColor2 = Color.FromArgb(218, 108, 108),
                    Location = new Point(950, 12)
                };
                edit.Click += EditButton;
                pnl.Controls.Add(name);
                pnl.Controls.Add(email);
                pnl.Controls.Add(phonenumber);
                pnl.Controls.Add(membership);
                pnl.Controls.Add(edit);
                flowLayoutPanel1.Controls.Add(pnl);
            }
        }

        void EditButton(object sender, EventArgs e)
        {
            Guna2GradientButton btn = sender as Guna2GradientButton;
            if (btn != null && btn.Tag is int customerId)
            {
                Edit_CustomerManage emm = new Edit_CustomerManage(customerId);
                emm.Location = new Point((this.Size.Width - emm.Width) / 2, (this.Size.Height - emm.Height) / 2);
                this.Controls.Add(emm);
                emm.BringToFront();
            }
        }

        void SearchAndFilter()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            if (SearchTextBox.Text.Length == 0 && FilterComboBox.Text == "All")
            {
                LoadCustomer(CustomerDAO.Instance.LoadCustomerList());
                return;
            }
            List<Customer> filter = new List<Customer>();
            foreach (Customer customer in customers)
            {
                if (SearchTextBox.Text.Length == 0 && (customer.Membership == 0 ? "New" : customer.Membership == 1 ? "Bronze" : customer.Membership == 2 ? "Silver" : customer.Membership == 3 ? "Gold" : customer.Membership == 4 ? "Platinum" : "VIP PRO") == FilterComboBox.Text)
                    filter.Add(customer);
                else if (FilterComboBox.Text == "All" && (customer.Name.ToLower().Contains(SearchTextBox.Text.ToLower()) || customer.Email.ToLower().Contains(SearchTextBox.Text.ToLower()) || customer.Phonenumber.ToLower().Contains(SearchTextBox.Text.ToLower())))
                    filter.Add(customer);
                else if ((customer.Name.ToLower().Contains(SearchTextBox.Text.ToLower()) || customer.Email.ToLower().Contains(SearchTextBox.Text.ToLower()) || customer.Phonenumber.ToLower().Contains(SearchTextBox.Text.ToLower())) && (customer.Membership == 0 ? "New" : customer.Membership == 1 ? "Bronze" : customer.Membership == 2 ? "Silver" : customer.Membership == 3 ? "Gold" : customer.Membership == 4 ? "Platinum" : "VIP PRO") == FilterComboBox.Text)
                    filter.Add(customer);
            }
            if (filter.Count > 0)
                LoadCustomer(filter);
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchAndFilter();
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchAndFilter();
        }

        private void DeleteSearchButton_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = "";
            SearchAndFilter();
        }

        private void DeleteFilter_Click(object sender, EventArgs e)
        {
            FilterComboBox.SelectedIndex = 0;
            SearchAndFilter();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            sync();
        }

        void sync()
        {
            customers = CustomerDAO.Instance.LoadCustomerList();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            SearchAndFilter();
        }
    }
}
