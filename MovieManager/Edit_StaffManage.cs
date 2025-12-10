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
        //private string Source = @"D:\Truongpham-code\DoAn_IT008\MovieManager\MovieManager\Avatars";
        private string Source = @"C:\Users\Thinh Phat\Documents\UIT\MovieManager\MovieManager\Avatars";
        public Edit_StaffManage()
        {
            InitializeComponent();
        }

        public Edit_StaffManage(int id)
        {
            InitializeComponent();
            foreach (Shift shiftschedule in shifts)
                ShiftComboBox.Items.Add(shiftschedule.Start.ToString("hh\\:mm") + " - " + shiftschedule.End.ToString("hh\\:mm"));
            foreach(Staff staff in staffs)
                if(staff.Id == id)
                {
                    main = staff;
                    foreach (Account account in accounts)
                        if (account.Idstaff == main.Id)
                        {
                            activate = account.Accept == false ? 0 : 1;
                            admin = account.Admin == false ? 0 : 1;
                        }
                    foreach (Account account in accounts)
                        if (staff.Id == account.Idstaff)
                        {
                            if (account.Admin)
                            {
                                PromoteAdmin.Text = "Demote an admin";
                                PromoteAdmin.ForeColor = Color.Black;
                                PromoteAdmin.FillColor = Color.Transparent;
                                PromoteAdmin.FillColor2 = Color.Transparent;
                                PromoteAdmin.BorderThickness = 2;
                            }
                            else
                            {
                                PromoteAdmin.Text = "Promote Admin";
                                PromoteAdmin.ForeColor = Color.White;
                                PromoteAdmin.FillColor = Color.FromArgb(175, 62, 62);
                                PromoteAdmin.FillColor2 = Color.FromArgb(218, 108, 108);
                                PromoteAdmin.BorderThickness = 0;
                            }
                            if (account.Accept)
                            {
                                DeactiveButton.Text = "Deactivate Account";
                                DeactiveButton.ForeColor = Color.White;
                                DeactiveButton.FillColor = Color.FromArgb(175, 62, 62);
                                DeactiveButton.FillColor2 = Color.FromArgb(218, 108, 108);
                                DeactiveButton.BorderThickness = 0;
                            }
                            else
                            {
                                DeactiveButton.Text = "Already Deactivated";
                                DeactiveButton.ForeColor = Color.Black;
                                DeactiveButton.FillColor = Color.Transparent;
                                DeactiveButton.FillColor2 = Color.Transparent;
                                DeactiveButton.BorderThickness = 2;
                            }
                        }
                    NameTextBox.Text = staff.Name;
                    EmailTextBox.Text = staff.Contact_info;
                    RoleTextBox.Text = staff.Role;
                    foreach (Shift shift in shifts)
                        if (shift.Id == main.Idshift)
                            ShiftComboBox.SelectedIndex = shift.Id - 1;
                    string ID = staff.Id.ToString("000");
                    string fileName = "NV" + ID + ".png";
                    string DesPath = Path.Combine(Source, fileName);
                    if (File.Exists(DesPath))
                    {
                        SnackPic.Image = LoadImageUnlocked(DesPath);
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
        private int activate = 0;
        private int admin = 0;
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = @"UPDATE STAFF SET role = @role , idshiftschedule = @shift WHERE id = @id ";
                string query2 = @"UPDATE ACCOUNT SET accept = @active , admin = @admin WHERE idstaff = @id ";
                object[] values = new object[]
                {
                    RoleTextBox.Text,
                    ShiftComboBox.SelectedIndex + 1,
                    main.Id
                };
                object[] values2 = new object[]
                {
                    activate,
                    admin,
                    main.Id,
                };
                dp.ExecuteNonQuery(query, values);
                dp.ExecuteNonQuery(query2, values2);
                CancelButton.PerformClick();
            }
        }

        private void DeactiveButton_Click(object sender, EventArgs e)
        {
            if (activate == 1)
            {
                activate = 0;
                DeactiveButton.ForeColor = Color.Black;
                DeactiveButton.FillColor = Color.Transparent;
                DeactiveButton.FillColor2 = Color.Transparent;
                DeactiveButton.BorderThickness = 2;
            }
            else
                MessageBox.Show("Accouunt has been deactivated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void PromoteAdmin_Click(object sender, EventArgs e)
        {
            admin = admin == 0 ? 1 : 0;
            if (admin == 1)
            {
                PromoteAdmin.ForeColor = Color.Black;
                PromoteAdmin.FillColor = Color.Transparent;
                PromoteAdmin.FillColor2 = Color.Transparent;
                PromoteAdmin.BorderThickness = 2;
            }
            else
            {
                PromoteAdmin.ForeColor = Color.White;
                PromoteAdmin.FillColor = Color.FromArgb(175, 62, 62);
                PromoteAdmin.FillColor2 = Color.FromArgb(218, 108, 108);
                PromoteAdmin.BorderThickness = 0;
            }
        }

        private Image LoadImageUnlocked(string path)
        {
            byte[] bytes = File.ReadAllBytes(path);
            MemoryStream ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }
    }
}
