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
    public partial class MovieDisplay : UserControl
    {
        private string imageFolder = @"C:\Users\Thinh Phat\Documents\UIT\MovieManager\MovieManager\Posters";
        //private string imageFolder = @"D:\Truongpham-code\DoAn_IT008\MovieManager\MovieManager\Posters";
        public MovieDisplay()
        {
            InitializeComponent();
            this.MovieDisplayFlowLayoutPanel.Resize += (sender, e) => LoadMovie();
        }
        int itemsPerRow = 6;
        int marginSize = 20;
        int scrollbarBuffer = 30;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!this.DesignMode)
            {
                LoadMovie();
            }
        }
        public void LoadMovie()
        {
            MovieDisplayFlowLayoutPanel.SuspendLayout();
            MovieDisplayFlowLayoutPanel.Controls.Clear();
            List<Movie> movieList = MovieDAO.Instance.LoadMovieList();
            string baseDirectory = Application.StartupPath;
            int totalMarginPerCard = marginSize * 2;
            int cardWidth = (MovieDisplayFlowLayoutPanel.Width - scrollbarBuffer) / itemsPerRow - totalMarginPerCard;
            foreach (Movie movie in movieList)
            {
                 Guna2CustomGradientPanel pnl = new Guna2CustomGradientPanel()
                 {
                    Width = cardWidth,
                    Height = MovieDAO.Height,
                    Margin = new Padding(marginSize),
                    BorderRadius = 14,
                    FillColor = Color.White,
                    ShadowDecoration = 
                    { 
                        Enabled = true, 
                        Depth = 10,
                        Color = Color.Black,
                        BorderRadius = 14 
                    }
                 };

                Guna2Panel pnlText = new Guna2Panel()
                {
                    Height = 150,
                    Dock = DockStyle.Bottom,
                    FillColor = Color.FromArgb(175, 62, 62),
                    BorderRadius = 14,
                    Padding = new Padding(12),
                    CustomizableEdges = 
                    { 
                        TopLeft = false, 
                        TopRight = false, 
                        BottomLeft = true, 
                        BottomRight = true 
                    }
                };

                Label lblTitle = new Label()
                {
                    Text = movie.Title.ToUpper(),
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    ForeColor = Color.White,
                    BackColor = Color.Transparent,
                    Dock = DockStyle.Top,
                    Height = 50,
                    TextAlign = ContentAlignment.TopLeft,
                    AutoEllipsis = true
                };

                Label lblDetails = new Label()
                {
                    Text = $"{movie.Genre}\n" +
                       $"Rate: {movie.Rated}  •  {movie.Language}\n" +
                       $"{movie.Duration} min  •  {movie.Format}",
                    Font = new Font("Segoe UI", 9, FontStyle.Regular),
                    ForeColor = Color.FromArgb(230, 230, 230),
                    BackColor = Color.Transparent,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.TopLeft,
                    Padding = new Padding(0, 5, 0, 0)
                };

                Guna2PictureBox pic = new Guna2PictureBox()
                {
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Tag = movie,
                    BorderRadius = 14,
                    CustomizableEdges = 
                    { 
                        TopLeft = true, 
                        TopRight = true, 
                        BottomLeft = false, 
                        BottomRight = false 
                    }
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
                pnlText.Click += Panel_Click;
                lblTitle.Click += Panel_Click;
                lblDetails.Click += Panel_Click;
                pnlText.Controls.Add(lblTitle);
                pnlText.Controls.Add(lblDetails);
                lblDetails.BringToFront();
                pnl.Controls.Add(pic);
                pnl.Controls.Add(pnlText);
                MovieDisplayFlowLayoutPanel.Controls.Add(pnl);
            }
            MovieDisplayFlowLayoutPanel.ResumeLayout();
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
