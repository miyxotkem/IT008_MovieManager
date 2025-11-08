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

        private void Cinema_Load(object sender, EventArgs e)
        {
            CinemaShadow.SetShadowForm(this);
        }

        bool sidebarzoom = false;
        private void ZoomButtonCinema_Click(object sender, EventArgs e)
        {
            if (sidebarzoom == false)
            {
                SideBarZoomButtonCinema.Location = new Point(SideBarZoomButtonCinema.Location.X + 150, SideBarZoomButtonCinema.Location.Y);
                SideBarPanelCinema.Size = new Size(SideBarPanelCinema.Width + 150, SideBarPanelCinema.Height);
                ExternalPanelCinema.Size = new Size(ExternalPanelCinema.Width - 150, ExternalPanelCinema.Height);
                ExternalPanelCinema.Location = new Point(ExternalPanelCinema.Location.X + 150, ExternalPanelCinema.Location.Y);
                MovieDisplayButtonCinema.Size = new Size(MovieDisplayButtonCinema.Width + 150, MovieDisplayButtonCinema.Height);
                MovieDisplayButtonCinema.Text = "Movie Display";
                SnackDisplayButtonCinema.Size = new Size(SnackDisplayButtonCinema.Width + 150, SnackDisplayButtonCinema.Height);
                SnackDisplayButtonCinema.Text = "Snack Display";
                MovieDisplay.Size = new Size(MovieDisplay.Width - 150, MovieDisplay.Height);
                MovieDisplay.Location = new Point(MovieDisplay.Location.X + 150, MovieDisplay.Location.Y);
                SnackDisplay.Size = new Size(SnackDisplay.Width - 150, SnackDisplay.Height);
                SnackDisplay.Location = new Point(SnackDisplay.Location.X + 150, SnackDisplay.Location.Y);
                sidebarzoom = true;
            }
            else
            {
                SideBarZoomButtonCinema.Location = new Point(SideBarZoomButtonCinema.Location.X - 150, SideBarZoomButtonCinema.Location.Y);
                SideBarPanelCinema.Size = new Size(SideBarPanelCinema.Width - 150, SideBarPanelCinema.Height);
                ExternalPanelCinema.Size = new Size(ExternalPanelCinema.Width + 150, ExternalPanelCinema.Height);
                ExternalPanelCinema.Location = new Point(ExternalPanelCinema.Location.X - 150, ExternalPanelCinema.Location.Y);
                MovieDisplayButtonCinema.Size = new Size(MovieDisplayButtonCinema.Width - 150, MovieDisplayButtonCinema.Height);
                MovieDisplayButtonCinema.Text = "";
                SnackDisplayButtonCinema.Size = new Size(SnackDisplayButtonCinema.Width - 150, SnackDisplayButtonCinema.Height);
                SnackDisplayButtonCinema.Text = "";
                MovieDisplay.Size = new Size(MovieDisplay.Width + 150, MovieDisplay.Height);
                MovieDisplay.Location = new Point(MovieDisplay.Location.X - 150, MovieDisplay.Location.Y);
                SnackDisplay.Size = new Size(SnackDisplay.Width + 150, SnackDisplay.Height);
                SnackDisplay.Location = new Point(SnackDisplay.Location.X - 150, SnackDisplay.Location.Y);
                sidebarzoom = false;
            }
        }

        private void MovieDisplayButtonCinema_CheckedChanged(object sender, EventArgs e)
        {
            if (MovieDisplayButtonCinema.Checked)
            {
                MovieDisplay.BringToFront();
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
    }
}
