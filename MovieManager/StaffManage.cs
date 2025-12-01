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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Label n = new Label()
            {
                Location = new Point(100, 10),
                Width = 300,
                Text = "Name",
                Font = new Font(Font, FontStyle.Bold)
            };
            Label r = new Label()
            {
                Location = new Point(400, 10),
                Width = 100,
                Text = "Role",
                Font = new Font(Font, FontStyle.Bold)
            };
            Label e = new Label()
            {
                Location = new Point(550, 10),
                Width = 200,
                Text = "Email",
                Font = new Font(Font, FontStyle.Bold)
            };
            Label s = new Label()
            {
                Location = new Point(800, 10),
                Width = 100,
                Text = "Shift",
                Font = new Font(Font, FontStyle.Bold)
            };
            Label a = new Label()
            {
                Location = new Point(950, 10),
                Width = 100,
                Text = "Accept",
                Font = new Font(Font, FontStyle.Bold)
            };
            p.Controls.Add(n);
            p.Controls.Add(r);
            p.Controls.Add(e);
            p.Controls.Add(s);
            p.Controls.Add(a);
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
                    Location = new Point(100, 20),
                    Width = 300,
                    Text = staff.Name
                };
                Label role = new Label()
                {
                    Location = new Point(400, 20),
                    Width = 100,
                    Text = staff.Role
                };
                Label email = new Label()
                {
                    Location = new Point(550, 20),
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
                    Location = new Point (965, 20),
                    Tag = staff.Id,
                    Checked = isAccepted
                };
                pnl.Controls.Add(name);
                pnl.Controls.Add(role);
                pnl.Controls.Add(email);
                pnl.Controls.Add(shift);
                pnl.Controls.Add(accept);
                flowLayoutPanel1.Controls.Add(pnl);
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
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            SearchAndFilter();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            sync();
        }
    }
}
