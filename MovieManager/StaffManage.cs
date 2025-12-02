using Guna.UI2.WinForms;
using MovieManager.DAO;
using MovieManager.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace MovieManager
{
    public partial class StaffManage : UserControl
    {
        private List<Staff> staffs;
        private List<Account> accounts;
        private List<Shift> shifts;
        public StaffManage()
        {
            InitializeComponent();
            staffs = StaffDAO.Instance.LoadStaffList();
            accounts = AccountDAO.Instance.LoadAccountList();
            shifts = ShiftDAO.Instance.LoadShiftList();
            FilterComboBox.SelectedIndex = 0;
            LoadStaff(staffs);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (FilterComboBox.SelectedIndex == 0)
                SearchAndFilter();
            else
                FilterComboBox.SelectedIndex = 0;
        }

        public void LoadStaff(List<Staff> staffList)
        {
            Panel p = new Panel()
            {
                Height = 30,
                Width = 1000
            };
            Label a = new Label()
            {
                Location = new Point(5, 10),
                Width = 100,
                Text = "Status",
                Font = new Font(Font, FontStyle.Bold)
            };
            Label n = new Label()
            {
                Location = new Point(150, 10),
                Width = 250,
                Text = "Name",
                Font = new Font(Font, FontStyle.Bold)
            };
            Label r = new Label()
            {
                Location = new Point(600, 10),
                Width = 200,
                Text = "Role",
                Font = new Font(Font, FontStyle.Bold)
            };
            Label e = new Label()
            {
                Location = new Point(400, 10),
                Width = 200,
                Text = "Email",
                Font = new Font(Font, FontStyle.Bold)
            };
            Label s = new Label()
            {
                Location = new Point(800, 10),
                Width = 100,
                Text = "Shift Schedule",
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
            p.Controls.Add(r);
            p.Controls.Add(e);
            p.Controls.Add(s);
            p.Controls.Add(a);
            p.Controls.Add(ed);
            flowLayoutPanel2.Controls.Add(p);
            foreach (Staff staff in staffList)
            {
                Guna2GradientPanel pnl = new Guna2GradientPanel()
                {
                    Height = 50,
                    Width = 1000,
                };
                Label name = new Label()
                {
                    Location = new Point(150, 20),
                    Width = 250,
                    Text = staff.Name
                };
                Label role = new Label()
                {
                    Location = new Point(600, 20),
                    Width = 200,
                    Text = staff.Role
                };
                Label email = new Label()
                {
                    Location = new Point(400, 20),
                    Width = 200,
                    Text = staff.Contact_info
                };
                TimeSpan start = new TimeSpan(0, 0, 0);
                TimeSpan end = new TimeSpan(0, 0, 0);
                foreach(Shift shiftschedule in shifts)
                    if(shiftschedule.Id == staff.Idshift)
                    {
                        start = shiftschedule.Start;
                        end = shiftschedule.End;
                    }
                Label shift = new Label()
                {
                    Location = new Point(800, 20),
                    Width = 100,
                    Text = start.ToString("hh\\:mm") + " - " + end.ToString("hh\\:mm")
                };
                bool isAccepted = false;
                foreach (Account account in accounts)
                    if (account.Idstaff == staff.Id)
                        isAccepted = account.Accept;
                CheckBox accept = new CheckBox()
                {
                    Location = new Point (15, 16),
                    Tag = staff.Id,
                    Checked = isAccepted
                };
                Label accepted = new Label()
                {
                    Location = new Point(0, 20),
                    Text = "Accepted"
                };
                Guna2GradientButton edit = new Guna2GradientButton()
                {
                    Image = global::MovieManager.Properties.Resources.manage_accounts_30dp_BLACK_FILL0_wght400_GRAD0_opsz24,
                    Animated = true,
                    Tag = staff.Id,
                    BorderRadius = 10,
                    Size = new Size(30, 30),
                    FillColor = Color.FromArgb(175, 62, 62),
                    FillColor2 = Color.FromArgb(218, 108, 108),
                    Location = new Point(950, 12)
                };
                edit.Click += EditButton;
                pnl.Controls.Add(name);
                pnl.Controls.Add(role);
                pnl.Controls.Add(email);
                pnl.Controls.Add(shift);
                if (isAccepted)
                    pnl.Controls.Add(accepted);
                else
                    pnl.Controls.Add(accept);
                pnl.Controls.Add(edit);
                flowLayoutPanel1.Controls.Add(pnl);
            }
        }

        void EditButton(object sender, EventArgs e)
        {
            Guna2GradientButton btn = sender as Guna2GradientButton;
            if (btn != null && btn.Tag is int staffId)
            {
                Edit_StaffManage emm = new Edit_StaffManage(staffId);
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
                LoadStaff(StaffDAO.Instance.LoadStaffList());
                return;
            }
            List<Staff> filter = new List<Staff>();
            List<Account> filter2 = new List<Account>();
            bool isAccepted = false;
            foreach (Staff staff in staffs)
            {
                foreach (Account account in accounts)
                    if (account.Idstaff == staff.Id)
                        isAccepted = account.Accept;
                if (SearchTextBox.Text.Length == 0 && (FilterComboBox.Text == "Accepted" ? true : false) == isAccepted)
                    filter.Add(staff);
                else if (FilterComboBox.Text == "All" && staff.Name.ToLower().Contains(SearchTextBox.Text.ToLower()))
                    filter.Add(staff);
                else if (staff.Name.ToLower().Contains(SearchTextBox.Text.ToLower()) && (FilterComboBox.Text == "Accepted" ? true : false) == isAccepted)
                    filter.Add(staff);
            }
            if (filter.Count > 0)
                LoadStaff(filter);
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

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchAndFilter();
        }

        private void DeleteFilter_Click(object sender, EventArgs e)
        {
            FilterComboBox.SelectedIndex = 0;
            SearchAndFilter();
        }

        void sync()
        {
            staffs = StaffDAO.Instance.LoadStaffList();
            accounts = AccountDAO.Instance.LoadAccountList();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            SearchAndFilter();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            sync();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            int checkedCount = 0;
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Guna2GradientPanel pnl)
                {
                    CheckBox accept = pnl.Controls.OfType<CheckBox>().FirstOrDefault();
                    if (accept != null && accept.Checked)
                    {
                        checkedCount++;
                    }
                }
            }
            if (checkedCount == 0)
            {
                MessageBox.Show("Please select at least one staff member to accept.", "No Staff Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to accept {checkedCount} staff member(s)? This action cannot be undone.", "Confirm Acceptance", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control is Guna2GradientPanel pnl)
                        foreach (Control control2 in pnl.Controls)
                            if (control2 is CheckBox accept)
                                if (accept.Checked)
                                {
                                    string query = @"UPDATE ACCOUNT SET accept = 1 WHERE idstaff = @id";
                                    object[] values = new object[] { accept.Tag };
                                    DataProvider dp = new DataProvider();
                                    dp.ExecuteNonQuery(query, values);
                                }
                }
            }
            sync();
        }
    }
}
