using Guna.UI2.WinForms;
using MovieManager.DAO;
using MovieManager.DTO;
using System;
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
    public partial class Cinema : Form
    {
        public Cinema()
        {
            InitializeComponent();
        }

        public Cinema(string username)
        {
            InitializeComponent();
            AccountDisplay.Reload(username);
        }
        private void Cinema_Load(object sender, EventArgs e)
        {
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
                MovieDisplay.Size = new Size(MovieDisplay.Width - 150, MovieDisplay.Height);
                MovieDisplay.Location = new Point(MovieDisplay.Location.X + 150, MovieDisplay.Location.Y);
                SnackDisplay.Size = new Size(SnackDisplay.Width - 150, SnackDisplay.Height);
                SnackDisplay.Location = new Point(SnackDisplay.Location.X + 150, SnackDisplay.Location.Y);
                MovieManage.Size = new Size(MovieManage.Width - 150, MovieManage.Height);
                MovieManage.Location = new Point(MovieManage.Location.X + 150, MovieManage.Location.Y);
                signout.Location = new Point((SideBarPanelCinema.Width - 150) / 2, SideBarPanelCinema.Height - 80);
                SnackManage.Size = new Size(SnackManage.Width - 150, SnackManage.Height);
                SnackManage.Location = new Point(SnackManage.Location.X + 150, SnackManage.Location.Y);
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
                MovieDisplay.Size = new Size(MovieDisplay.Width + 150, MovieDisplay.Height);
                MovieDisplay.Location = new Point(MovieDisplay.Location.X - 150, MovieDisplay.Location.Y);
                SnackDisplay.Size = new Size(SnackDisplay.Width + 150, SnackDisplay.Height);
                SnackDisplay.Location = new Point(SnackDisplay.Location.X - 150, SnackDisplay.Location.Y);
                MovieManage.Size = new Size(MovieManage.Width + 150, MovieManage.Height);
                MovieManage.Location = new Point(MovieManage.Location.X - 150, MovieManage.Location.Y);
                SnackManage.Size = new Size(SnackManage.Width + 150, SnackManage.Height);
                SnackManage.Location = new Point(SnackManage.Location.X - 150, SnackManage.Location.Y);
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

        private void MovieDisplayButtonCinema_CheckedChanged(object sender, EventArgs e)
        {
            if (MovieDisplayButtonCinema.Checked)
            {
                MovieDisplay.BringToFront();
                MovieDisplay.Reload();
                if(sidebarzoom == true)
                    SideBarZoomButtonCinema.PerformClick();
            }
        }

        private void SnackDisplayButtonCinema_CheckedChanged(object sender, EventArgs e)
        {
            if (SnackDisplayButtonCinema.Checked)
            {
                SnackDisplay.BringToFront();
                if (sidebarzoom == true)
                    SideBarZoomButtonCinema.PerformClick();
            }
        }

        private void MovieManageButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MovieManageButton.Checked)
            {
                MovieManage.BringToFront();
                if (sidebarzoom == true)
                    SideBarZoomButtonCinema.PerformClick();
            }
        }

        private void SnackManageButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SnackManageButton.Checked)
            {
                SnackManage.BringToFront();
                if(sidebarzoom == true)
                    SideBarZoomButtonCinema.PerformClick();
            }
        }
    }
}
