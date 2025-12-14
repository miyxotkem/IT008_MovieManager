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
    public partial class MovieDisplay : UserControl
    {
        //private string imageFolder = @"C:\Users\Thinh Phat\Documents\UIT\MovieManager\MovieManager\Posters";
        private string imageFolder = @"D:\Truongpham-code\DoAn_IT008\MovieManager\MovieManager\Posters";
        public MovieDisplay()
        {
            InitializeComponent();
            LoadMovie();            
        }
        public void LoadMovie()
        {
            List<Movie> movieList = MovieDAO.Instance.LoadMovieList();
            string baseDirectory = Application.StartupPath;
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
                    Height = 150,
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.MiddleLeft,
                    BackColor = Color.FromArgb(175, 62, 62),
                    ForeColor = Color.White,
                    Padding = new Padding(5)
                };
                PictureBox pic = new PictureBox()
                {
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Tag = movie
                };
                try
                {
                    string fileName = movie.ID.ToString() + ".jpg";
                    string fullImagePath = Path.Combine(imageFolder, fileName);
                    if (File.Exists(fullImagePath))
                        pic.Image = LoadImageUnlocked(fullImagePath);
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
                pic.Click += Panel_Click;
                pnl.Controls.Add(pic);
                pnl.Controls.Add(lblTitle);
                MovieDisplayFlowLayoutPanel.Controls.Add(pnl);
            }
        }
        public void Panel_Click(object sender, EventArgs e)
        {
            PictureBox clickedPic = sender as PictureBox;
            if (clickedPic == null) return;
            Movie selectedMovie = clickedPic.Tag as Movie;
            if (selectedMovie == null) return;
            Control parentContainer = this.Parent;
            Control cinemaPanel = this.Parent;
            SelectMovie sm = new SelectMovie(selectedMovie, parentContainer, cinemaPanel);
            sm.Dock = DockStyle.Fill;
            if (parentContainer != null)
            {
                parentContainer.Controls.Add(sm);
                sm.BringToFront();
            }
        }
        private Image LoadImageUnlocked(string path)
        {
            byte[] bytes = File.ReadAllBytes(path);
            MemoryStream ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }

        public void Reload()
        {
            MovieDisplayFlowLayoutPanel.Controls.Clear();
            LoadMovie();
        }
    }
}
