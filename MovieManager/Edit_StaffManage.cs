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
    public partial class Edit_StaffManage : UserControl
    {
        private List<Staff> staffs = StaffDAO.Instance.LoadStaffList();
        private List<Shift> shifts = ShiftDAO.Instance.LoadShiftList();
        private List<Account> accounts = AccountDAO.Instance.LoadAccountList();
        private Staff main = null;
        public Edit_StaffManage()
        {
            InitializeComponent();
        }

        public Edit_StaffManage(int id)
        {
            InitializeComponent();
            foreach(Shift shiftschedule in shifts)
                ShiftComboBox.Items.Add(shiftschedule.Start.ToString("hh\\:mm") + " - " + shiftschedule.End.ToString("hh\\:mm"));
            foreach(Staff staff in staffs)
                if(staff.Id == id)
                {
                    main = staff;
                    foreach(Account account in accounts)
                        if(staff.Id == account.Idstaff)
                        {
                            if (account.Admin == true)
                                PromoteAdmin.Text = "Alread an admin";
                            else
                                PromoteAdmin.Text = "Promote Admin";
                            if (account.Accept == true)
                                DeactiveButton.Text = "Deactivate Account";
                            else
                                DeactiveButton.Text = "Already Deactivated";
                        }
                    NameTextBox.Text = staff.Name;
                    EmailTextBox.Text = staff.Contact_info;
                    RoleTextBox.Text = staff.Role;
                    foreach (Shift shift in shifts)
                        if (shift.Id == main.Idshift)
                            ShiftComboBox.SelectedIndex = shift.Id - 1;
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
        private int activate = 1;
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = @"UPDATE STAFF SET role = @role WHERE id = @id ";
                string query2 = @"UPDATE ACCOUNT SET accept = @active WHERE idstaff = @id ";
                object[] values = new object[]
                {
                    RoleTextBox.Text,
                    main.Id
                };
                object[] values2 = new object[]
                {
                    activate,
                    main.Id,
                };
                dp.ExecuteNonQuery(query, values);
                dp.ExecuteNonQuery(query2, values2);
                CancelButton.PerformClick();
            }
        }

        private void DeactiveButton_Click(object sender, EventArgs e)
        {
            activate = 0;
        }
    }
}
