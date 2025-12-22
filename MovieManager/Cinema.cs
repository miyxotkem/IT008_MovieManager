using Guna.UI2.WinForms;
using MovieManager.DAO;
using MovieManager.DTO;
using Org.BouncyCastle.Math.Field;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieManager
{
    public partial class Cinema : Form
    {
        private string user = null;
        private MovieDisplay movieDisplay;
        private SnackDisplay snackDisplay;
        private MovieManage movieManage;
        private SnackManage snackManage;
        private CustomerManage customerManage;
        private AccountDisplay accountDisplay;
        private StaffManage staffManage;
        private ShowTimeManage showTimeManage;
        private Payment payment;
        public Cinema()
        {
            InitializeComponent(); 
        }

        public Cinema(string username)
        {
            InitializeComponent();
            //AccountDisplay.Reload(username);
            user = username;
        }
        private void FirstLoad()
        {
            movieDisplay = new MovieDisplay();
            movieDisplay.Reload();
            movieDisplay.Dock = DockStyle.Fill;
            snackDisplay = new SnackDisplay();
            snackDisplay.Reload();
            snackDisplay.Dock = DockStyle.Fill;
            movieManage = new MovieManage();
            movieManage.Dock = DockStyle.Fill;
            snackManage = new SnackManage();    
            snackManage.Dock = DockStyle.Fill;
            customerManage = new CustomerManage();  
            customerManage.Dock = DockStyle.Fill;
            accountDisplay = new AccountDisplay();
            if (user != null ) accountDisplay.Reload(user);
            accountDisplay.Dock = DockStyle.Fill;   
            staffManage = new StaffManage();
            staffManage.Dock = DockStyle.Fill;
            showTimeManage = new ShowTimeManage();
            showTimeManage.Dock = DockStyle.Fill;
            payment = new Payment();
            payment.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(movieManage);
            MainPanel.Controls.Add(snackManage);
            MainPanel.Controls.Add(movieDisplay);
            MainPanel.Controls.Add(snackDisplay);
            MainPanel.Controls.Add(customerManage);
            MainPanel.Controls.Add(staffManage);
            MainPanel.Controls.Add(accountDisplay);
            MainPanel.Controls.Add(showTimeManage);
            MainPanel.Controls.Add(payment);
            if (this.Tag is Account account)
            {
                MovieManageButton.Enabled = account.Admin;
                SnackManageButton.Enabled = account.Admin;
                CustomerManageButton.Enabled = account.Admin;   
                StaffManageButton.Enabled = account.Admin;
                ShowTimeManageButton.Enabled = account.Admin;
            }    
        }
        private void Cinema_Load(object sender, EventArgs e)
        {
            FirstLoad();
            MovieDisplayButtonCinema.Checked = true;
            CinemaShadow.SetShadowForm(this);            
            title.Text = "Movie Manager";
            title.AutoSize = false;
            title.Size = new Size(200, 100);
            title.Location = new Point(10, 10);
            title.TextAlign = ContentAlignment.MiddleRight;
            title.BackColor = Color.Transparent;
            title.ForeColor = Color.FromArgb(175, 62, 62);
            title.Font = new Font("Stencil", 20);                
            SideBarPanelCinema.Controls.Add(title);
            title.Visible = false;

            signout.Text = "Sign Out";
            signout.Size = new Size(150, 50);
            signout.BackColor = Color.Transparent;
            signout.BorderRadius = 12;
            signout.BorderThickness = 1;
            signout.ForeColor = Color.Black;
            signout.BorderColor = Color.FromArgb(175, 62, 62);
            signout.FillColor = Color.White;
            signout.FillColor2 = Color.White;
            signout.HoverState.FillColor = Color.FromArgb(175, 62, 62);
            signout.HoverState.FillColor2 = Color.FromArgb(218, 108, 108);
            signout.HoverState.ForeColor = Color.White;
            signout.AutoSize = false;
            signout.Click += SignOut;
            SideBarPanelCinema.Controls.Add(signout);
            signout.Visible = false;
        }
        Label title = new Label();
        Guna2GradientButton signout = new Guna2GradientButton();
        bool sidebarzoom = false;
        private void ZoomButtonCinema_Click(object sender, EventArgs e)
        {
            if (sidebarzoom == false)
            {
                SideBarPanelCinema.Size = new Size(SideBarPanelCinema.Width + 150, SideBarPanelCinema.Height);
                MovieDisplayButtonCinema.Size = new Size(MovieDisplayButtonCinema.Width + 150, MovieDisplayButtonCinema.Height);
                MovieDisplayButtonCinema.Text = "Movie Display";
                SnackDisplayButtonCinema.Size = new Size(SnackDisplayButtonCinema.Width + 150, SnackDisplayButtonCinema.Height);
                SnackDisplayButtonCinema.Text = "Snack Display";
                MovieManageButton.Size = new Size(MovieManageButton.Width + 150, MovieManageButton.Height);
                MovieManageButton.Text = "Movie Manage";
                SnackManageButton.Size = new Size(SnackManageButton.Width + 150, SnackManageButton.Height);
                SnackManageButton.Text = "Snack Manage";
                AccountDisplayButton.Size = new Size(AccountDisplayButton.Width + 150, AccountDisplayButton.Height);
                AccountDisplayButton.Text = "Account";
                StaffManageButton.Size = new Size(StaffManageButton.Width + 150, StaffManageButton.Height);
                StaffManageButton.Text = "Staff Manage";
                CustomerManageButton.Size = new Size(CustomerManageButton.Width + 150, CustomerManageButton.Height);
                CustomerManageButton.Text = "Customer Manage";
                ShowTimeManageButton.Size = new Size(ShowTimeManageButton.Width + 150, ShowTimeManageButton.Height);
                ShowTimeManageButton.Text = "ShowTime Manage";
                PaymentButton.Size = new Size(PaymentButton.Width + 150, PaymentButton.Height);
                PaymentButton.Text = "Payment Site";
                //MovieDisplay.Size = new Size(MovieDisplay.Width - 150, MovieDisplay.Height);
                //MovieDisplay.Location = new Point(MovieDisplay.Location.X + 150, MovieDisplay.Location.Y);
                //SnackDisplay.Size = new Size(SnackDisplay.Width - 150, SnackDisplay.Height);
                //SnackDisplay.Location = new Point(SnackDisplay.Location.X + 150, SnackDisplay.Location.Y);
                //MovieManage.Size = new Size(MovieManage.Width - 150, MovieManage.Height);
                //MovieManage.Location = new Point(MovieManage.Location.X + 150, MovieManage.Location.Y);
                signout.Location = new Point((SideBarPanelCinema.Width - 150) / 2, SideBarPanelCinema.Height - 80);
                //SnackManage.Size = new Size(SnackManage.Width - 150, SnackManage.Height);
                //SnackManage.Location = new Point(SnackManage.Location.X + 150, SnackManage.Location.Y);
                //AccountDisplay.Size = new Size(AccountDisplay.Width - 150, AccountDisplay.Height);
                //AccountDisplay.Location = new Point(AccountDisplay.Location.X + 150, AccountDisplay.Location.Y);
                //StaffManage.Size = new Size(StaffManage.Width - 150, StaffManage.Height);
                //StaffManage.Location = new Point(StaffManage.Location.X + 150, StaffManage.Location.Y);
                //CustomerManage.Size = new Size(CustomerManage.Width - 150, CustomerManage.Height);
                //CustomerManage.Location = new Point(CustomerManage.Location.X + 150, CustomerManage.Location.Y);
                //ShowTimeManage.Size = new Size(ShowTimeManage.Width - 150, ShowTimeManage.Height);
                //ShowTimeManage.Location = new Point(ShowTimeManage.Location.X + 150, ShowTimeManage.Location.Y);
                title.Visible = true;
                signout.Visible = true;
                sidebarzoom = true;
            }
            else
            {
                SideBarPanelCinema.Size = new Size(SideBarPanelCinema.Width - 150, SideBarPanelCinema.Height);
                MovieDisplayButtonCinema.Size = new Size(MovieDisplayButtonCinema.Width - 150, MovieDisplayButtonCinema.Height);
                MovieDisplayButtonCinema.Text = "";
                SnackDisplayButtonCinema.Size = new Size(SnackDisplayButtonCinema.Width - 150, SnackDisplayButtonCinema.Height);
                SnackDisplayButtonCinema.Text = "";
                MovieManageButton.Size = new Size(MovieManageButton.Width - 150, MovieManageButton.Height);
                MovieManageButton.Text = "";
                SnackManageButton.Size = new Size(SnackManageButton.Width - 150, SnackManageButton.Height);
                SnackManageButton.Text = "";
                AccountDisplayButton.Size = new Size(AccountDisplayButton.Width - 150, AccountDisplayButton.Height);
                AccountDisplayButton.Text = "";
                StaffManageButton.Size = new Size(StaffManageButton.Width - 150, StaffManageButton.Height);
                StaffManageButton.Text = "";
                CustomerManageButton.Size = new Size(CustomerManageButton.Width - 150, CustomerManageButton.Height);
                CustomerManageButton.Text = "";
                ShowTimeManageButton.Size = new Size(ShowTimeManageButton.Width - 150, ShowTimeManageButton.Height);
                ShowTimeManageButton.Text = "";
                PaymentButton.Size = new Size(PaymentButton.Width - 150, PaymentButton.Height);
                PaymentButton.Text = "";
                //MovieDisplay.Size = new Size(MovieDisplay.Width + 150, MovieDisplay.Height);
                //MovieDisplay.Location = new Point(MovieDisplay.Location.X - 150, MovieDisplay.Location.Y);
                //SnackDisplay.Size = new Size(SnackDisplay.Width + 150, SnackDisplay.Height);
                //SnackDisplay.Location = new Point(SnackDisplay.Location.X - 150, SnackDisplay.Location.Y);
                //MovieManage.Size = new Size(MovieManage.Width + 150, MovieManage.Height);
                //MovieManage.Location = new Point(MovieManage.Location.X - 150, MovieManage.Location.Y);
                //SnackManage.Size = new Size(SnackManage.Width + 150, SnackManage.Height);
                //SnackManage.Location = new Point(SnackManage.Location.X - 150, SnackManage.Location.Y);
                //AccountDisplay.Size = new Size(AccountDisplay.Width + 150, AccountDisplay.Height);
                //AccountDisplay.Location = new Point(AccountDisplay.Location.X - 150, AccountDisplay.Location.Y);
                //StaffManage.Size = new Size(StaffManage.Width + 150, StaffManage.Height);
                //StaffManage.Location = new Point(StaffManage.Location.X - 150, StaffManage.Location.Y);
                //CustomerManage.Size = new Size(CustomerManage.Width + 150, CustomerManage.Height);
                //CustomerManage.Location = new Point(CustomerManage.Location.X - 150, CustomerManage.Location.Y);
                //ShowTimeManage.Size = new Size(ShowTimeManage.Width + 150, ShowTimeManage.Height);
                //ShowTimeManage.Location = new Point(ShowTimeManage.Location.X - 150, ShowTimeManage.Location.Y);
                title.Visible = false;
                signout.Visible = false;
                sidebarzoom = false;
            }
        }

        private void SignOut(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm signInForm = new SignInForm();
            signInForm.ShowDialog();
        }

        public void MovieDisplayButtonCinema_CheckedChanged(object sender, EventArgs e)
        {
            if (MovieDisplayButtonCinema.Checked)
            {
                //MovieDisplay.BringToFront();
                //MovieDisplay.Reload();
                movieDisplay.BringToFront();
                if(sidebarzoom == true)
                    SideBarZoomButtonCinema.PerformClick();
            }
        }

        public void SnackDisplayButtonCinema_CheckedChanged(object sender, EventArgs e)
        {
            if (SnackDisplayButtonCinema.Checked)
            {
                //SnackDisplay.BringToFront();
                //SnackDisplay.Reload();
                snackDisplay.BringToFront();
                if (sidebarzoom == true)
                    SideBarZoomButtonCinema.PerformClick();
            }
        }

        public void MovieManageButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Tag is Account account)
            {
                if (!account.Admin)
                {
                    MovieManageButton.Enabled = false;
                }
            }
            if (MovieManageButton.Checked)
            {
                //MovieManage.BringToFront();
                movieManage.BringToFront();
                if (sidebarzoom == true)
                    SideBarZoomButtonCinema.PerformClick();
            }
        }

        public void SnackManageButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Tag is Account account)
            {
                if (!account.Admin)
                {
                    SnackManageButton.Enabled = false;
                }
            }
            if (SnackManageButton.Checked)
            {
                //SnackManage.BringToFront();
                snackManage.BringToFront();
                if(sidebarzoom == true)
                    SideBarZoomButtonCinema.PerformClick();
            }
        }

        public void AccountDisplayButton_Click(object sender, EventArgs e)
        {
            if (AccountDisplayButton.Checked)
            {
                //AccountDisplay.BringToFront();
                accountDisplay.BringToFront();
                if (sidebarzoom == true)
                    SideBarZoomButtonCinema.PerformClick();
            }
        }

        public void StaffManageButton_Click(object sender, EventArgs e)
        {
            if (this.Tag is Account account)
            {
                if (!account.Admin)
                {
                    StaffManageButton.Enabled = false;
                }
            }
            if (StaffManageButton.Checked)
            {
                //StaffManage.BringToFront();
                staffManage.BringToFront(); 
                if (sidebarzoom == true)
                    SideBarZoomButtonCinema.PerformClick();
            }
        }

        public void CustomerManageButton_Click(object sender, EventArgs e)
        {
            if (this.Tag is Account account)
            {
                if (!account.Admin)
                {
                    CustomerManageButton.Enabled = false;
                }
            }
            if (CustomerManageButton.Checked)
            {
                //CustomerManage.BringToFront();
                customerManage.BringToFront();
                if (sidebarzoom == true)
                    SideBarZoomButtonCinema.PerformClick();
            }
        }

        private void ShowTimeManageButton_Click(object sender, EventArgs e)
        {
            if (this.Tag is Account account)
            {
                if (!account.Admin)
                {
                    ShowTimeManageButton.Enabled = false;
                }
            }
            if (ShowTimeManageButton.Checked)
            {
                //ShowTimeManage.BringToFront();
                showTimeManage.BringToFront();
                if (sidebarzoom == true)
                    SideBarZoomButtonCinema.PerformClick();
            }
        }

        private void MovieDisplay_Load(object sender, EventArgs e)
        {

        }

        public void ChangeSnackDisplayButton(bool state)
        {
            SnackDisplayButtonCinema.Checked = state;
        }

        public void ChangeMovieDisplayButton(bool state)
        {
            MovieDisplayButtonCinema.Checked =state;    
        }

        public void ChangePayMentButton(bool state)
        {
            PaymentButton.Checked = state;
        }
        private void PaymentButton_Click(object sender, EventArgs e)
        {
            if (PaymentButton.Checked)
            {
                payment.BringToFront();
                payment.Reload();
                if (sidebarzoom == true)
                    SideBarZoomButtonCinema.PerformClick();
            }
        }
    }
}
