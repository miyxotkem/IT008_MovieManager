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
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace MovieManager
{
    public partial class SnackManage : UserControl
    {
        private List<Snack> snacks;
        public SnackManage()
        {
            InitializeComponent();
            snacks = SnackDAO.Instance.LoadSnackList();
            FilterComboBox.SelectedIndex = 0;
            LoadSnack(snacks);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (FilterComboBox.SelectedIndex == 0)
                SearchAndFilter();
            else
                FilterComboBox.SelectedIndex = 0;
        }

        public void LoadSnack(List<Snack> snackList)
        {
            Panel p = new Panel()
            {
                Height = 30,
                Width = 800
            };
            Label n = new Label()
            {
                Location = new Point(100, 10),
                Width = 300,
                Text = "Name",
                Font = new Font(Font, FontStyle.Bold)
            };
            Label pr = new Label()
            {
                Location = new Point(400, 10),
                Width = 100,
                Text = "Price",
                Font = new Font(Font, FontStyle.Bold)
            };
            Label s = new Label()
            {
                Location = new Point(550, 10),
                Width = 100,
                Text = "Stock",
                Font = new Font(Font, FontStyle.Bold)
            };
            Label e = new Label()
            {
                Location = new Point(700, 10),
                Width = 100,
                Text = "Edit",
                Font = new Font(Font, FontStyle.Bold)
            };
            p.Controls.Add(n);
            p.Controls.Add(pr);
            p.Controls.Add(s);
            p.Controls.Add(e);
            flowLayoutPanel2.Controls.Add(p);
            foreach (Snack snack in snackList)
            {
                Guna2GradientPanel pnl = new Guna2GradientPanel()
                {
                    Height = 50,
                    Width = 800,
                    BorderColor = Color.Black
                };
                Label name = new Label()
                {
                    Location = new Point(100, 20),
                    Width = 300,
                    Text = snack.Name
                };
                Label price = new Label()
                {
                    Location = new Point(400, 20),
                    Width = 100,
                    Text = snack.Price.ToString()
                };
                Label stock = new Label()
                {
                    Location = new Point(550, 20),
                    Width = 100,
                    Text = snack.Stock.ToString()
                };
                Guna2GradientButton edit = new Guna2GradientButton()
                {
                    Image = global::MovieManager.Properties.Resources.production_quantity_limits_30dp_BLACK_FILL0_wght400_GRAD0_opsz24,
                    Animated = true,
                    Tag = snack.ID,
                    BorderRadius = 10,
                    Size = new Size(30, 30),
                    FillColor = Color.FromArgb(175, 62, 62),
                    FillColor2 = Color.FromArgb(218, 108, 108),
                    Location = new Point(700, 12)
                };
                edit.Click += EditButton;
                pnl.Controls.Add(name);
                pnl.Controls.Add(price);
                pnl.Controls.Add(stock);
                pnl.Controls.Add(edit);
                flowLayoutPanel1.Controls.Add(pnl);
            }
        }
        void SearchAndFilter()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            if (SearchTextBox.Text.Length == 0 && FilterComboBox.Text == "All")
            {
                LoadSnack(SnackDAO.Instance.LoadSnackList());
                return;
            }
            List<Snack> filter = new List<Snack>();
            foreach (Snack snack in snacks)
            {
                if (SearchTextBox.Text.Length == 0 && (snack.Category == 0 ? "Food" : "Beverage") == FilterComboBox.Text)
                    filter.Add(snack);
                else if (FilterComboBox.Text == "All" && snack.Name.ToLower().Contains(SearchTextBox.Text.ToLower()))
                    filter.Add(snack);
                else if (snack.Name.ToLower().Contains(SearchTextBox.Text.ToLower()) && (snack.Category == 0 ? "Food" : "Beverage") == FilterComboBox.Text)
                    filter.Add(snack);
            }
            if (filter.Count > 0)
                LoadSnack(filter);
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
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

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchAndFilter();
        }

        void sync()
        {
            snacks = SnackDAO.Instance.LoadSnackList();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            SearchAndFilter();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            sync();
        }

        void EditButton(object sender, EventArgs e)
        {
            Guna2GradientButton btn = sender as Guna2GradientButton;
            if (btn != null && btn.Tag is int snackId)
            {
                Edit_SnackManage esm = new Edit_SnackManage(snackId);
                esm.Location = new Point((this.Size.Width - esm.Width) / 2, (this.Size.Height - esm.Height) / 2);
                this.Controls.Add(esm);
                esm.BringToFront();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
                Edit_SnackManage esm = new Edit_SnackManage();
                esm.Location = new Point((this.Size.Width - esm.Width) / 2, (this.Size.Height - esm.Height) / 2);
                this.Controls.Add(esm);
                esm.BringToFront();
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            History_SnackManage hsm = new History_SnackManage();
            hsm.Location = new Point((this.Size.Width - hsm.Width) / 2, (this.Size.Height - hsm.Height) / 2);
            this.Controls.Add(hsm);
            hsm.BringToFront();
        }
    }
}
