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
            LoadMovie();
        }

        private void Cinema_Load(object sender, EventArgs e)
        {
            ShadowCinema.SetShadowForm(this);
        }

        void LoadMovie()
        {
            List<Movie> movieList =  MovieDAO.Instance.LoadMovieList();
            string baseDirectory = Application.StartupPath;
            string imageFolder = Path.Combine(baseDirectory, "Posters");
            foreach (Movie movie in movieList)
            {
                Panel pnl = new Panel()
                { 
                    Width = MovieDAO.Width,
                    Height = MovieDAO.Height,
                    Margin = new Padding(15)
                };
                Label lblTitle = new Label()
                {
                    Text = movie.Title.ToString() + Environment.NewLine +
                           movie.Genre.ToString() + Environment.NewLine +
                           movie.Rated.ToString() + Environment.NewLine +
                           movie.Language.ToString() + Environment.NewLine +
                           movie.Duration.ToString() + Environment.NewLine +
                           movie.Format.ToString(),
                    Height = 100,
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.MiddleLeft,
                    BackColor = Color.FromArgb(175, 62, 62),
                    ForeColor = Color.White
                };
                PictureBox pic = new PictureBox()
                {
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                try
                {
                    string fileName = movie.ID.ToString() + ".jpg";
                    string fullImagePath = Path.Combine(imageFolder, fileName);
                    if (File.Exists(fullImagePath))
                    {
                        pic.Image = Image.FromFile(fullImagePath);
                    }
                    else
                    {
                        pic.BackColor = Color.Silver;
                        Console.WriteLine($"Image not found. Looked for: {fullImagePath}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading image: " + ex.Message);
                    pic.BackColor = Color.Red;
                }
                pnl.Controls.Add(pic);
                pnl.Controls.Add(lblTitle);
                lblTitle.BringToFront();
                MovieDisplayFlowLayoutPanel.Controls.Add(pnl);
            }
        }
    }
}
