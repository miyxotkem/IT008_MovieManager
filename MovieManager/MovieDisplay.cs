using Guna.UI2.WinForms;
using MovieManager.DAO;
using MovieManager.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieManager
{
    public partial class MovieDisplay : UserControl
    {
        private string imageFolder = @"C:\Users\Thinh Phat\Documents\UIT\MovieManager\MovieManager\Posters";
        private List<Movie> _cachedMovieList;

        int itemsPerRow = 6;
        int marginSize = 20;
        int scrollbarBuffer = 30;

        public MovieDisplay()
        {
            InitializeComponent();
            this.MovieDisplayFlowLayoutPanel.Resize += MovieDisplayFlowLayoutPanel_Resize;
        }

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

            foreach (Control ctrl in MovieDisplayFlowLayoutPanel.Controls)
            {
                DisposeControlImages(ctrl);
                ctrl.Dispose();
            }
            MovieDisplayFlowLayoutPanel.Controls.Clear();

            _cachedMovieList = MovieDAO.Instance.LoadMovieList();

            int cardWidth = CalculateCardWidth();

            foreach (Movie movie in _cachedMovieList)
            {
                Guna2CustomGradientPanel pnl = CreateMovieCard(movie, cardWidth);
                MovieDisplayFlowLayoutPanel.Controls.Add(pnl);
            }

            MovieDisplayFlowLayoutPanel.ResumeLayout();
        }

        private void MovieDisplayFlowLayoutPanel_Resize(object sender, EventArgs e)
        {
            if (MovieDisplayFlowLayoutPanel.Controls.Count == 0) return;

            MovieDisplayFlowLayoutPanel.SuspendLayout();
            int newWidth = CalculateCardWidth();

            foreach (Control ctrl in MovieDisplayFlowLayoutPanel.Controls)
            {
                if (ctrl is Guna2CustomGradientPanel pnl)
                {
                    pnl.Width = newWidth;
                }
            }
            MovieDisplayFlowLayoutPanel.ResumeLayout();
        }

        private int CalculateCardWidth()
        {
            int totalMarginPerCard = marginSize * 2;
            int availableWidth = MovieDisplayFlowLayoutPanel.Width - scrollbarBuffer;
            if (availableWidth <= 0) availableWidth = 800;

            return (availableWidth / itemsPerRow) - totalMarginPerCard;
        }

        private Guna2CustomGradientPanel CreateMovieCard(Movie movie, int width)
        {
            Guna2CustomGradientPanel pnl = new Guna2CustomGradientPanel()
            {
                Width = width,
                Height = MovieDAO.Height,
                Margin = new Padding(marginSize),
                BorderRadius = 14,
                FillColor = Color.White,
                ShadowDecoration = { Enabled = true, Depth = 10, Color = Color.Black, BorderRadius = 14 },
                Tag = movie
            };

            Guna2Panel pnlText = new Guna2Panel()
            {
                Height = 150,
                Dock = DockStyle.Bottom,
                FillColor = Color.FromArgb(175, 62, 62),
                BorderRadius = 14,
                Padding = new Padding(12),
                Tag = movie,
                CustomizableEdges = { TopLeft = false, TopRight = false, BottomLeft = true, BottomRight = true }
            };

            Label lblTitle = new Label()
            {
                Text = movie.Title.ToUpper(),
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Dock = DockStyle.Top,
                Height = 50,
                Tag = movie,
                AutoEllipsis = true
            };

            Label lblDetails = new Label()
            {
                Text = $"{movie.Genre}\nRate: {movie.Rated}  •  {movie.Language}\n{movie.Duration} min  •  {movie.Format}",
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.FromArgb(230, 230, 230),
                BackColor = Color.Transparent,
                Dock = DockStyle.Fill,
                Tag = movie,
                Padding = new Padding(0, 5, 0, 0)
            };

            Guna2PictureBox pic = new Guna2PictureBox()
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Tag = movie,
                BorderRadius = 14,
                BackColor = Color.FromArgb(224, 224, 224),
                CustomizableEdges = { TopLeft = true, TopRight = true, BottomLeft = false, BottomRight = false }
            };

            pic.Click += Panel_Click;
            pnlText.Click += Panel_Click;
            lblTitle.Click += Panel_Click;
            lblDetails.Click += Panel_Click;

            pnlText.Controls.Add(lblDetails);
            pnlText.Controls.Add(lblTitle);
            lblDetails.BringToFront();

            pnl.Controls.Add(pic);
            pnl.Controls.Add(pnlText);

            string fileName = movie.ID.ToString() + ".jpg";
            string fullImagePath = Path.Combine(imageFolder, fileName);
            LoadImageAsync(fullImagePath, pic);

            return pnl;
        }

        private async void LoadImageAsync(string path, Guna2PictureBox pic)
        {
            try
            {
                if (File.Exists(path))
                {
                    Image img = await Task.Run(() =>
                    {
                        try
                        {
                            byte[] bytes = File.ReadAllBytes(path);
                            return new Bitmap(new MemoryStream(bytes));
                        }
                        catch { return null; }
                    });

                    if (img != null && pic != null && !pic.IsDisposed && pic.Visible)
                    {
                        pic.Image = img;
                        pic.BackColor = Color.Transparent;
                    }
                    else
                    {
                        img?.Dispose();
                    }
                }
            }
            catch { }
        }

        public void Panel_Click(object sender, EventArgs e)
        {
            Control clickedControl = sender as Control;
            if (clickedControl == null) return;

            Movie selectedMovie = clickedControl.Tag as Movie;
            if (selectedMovie == null) return;

            Control parentContainer = this.Parent;

            if (parentContainer != null)
            {
                SelectMovie sm = new SelectMovie(selectedMovie, parentContainer, parentContainer);
                sm.Dock = DockStyle.Fill;
                parentContainer.Controls.Add(sm);
                sm.BringToFront();
            }
        }

        private void DisposeControlImages(Control ctrl)
        {
            if (ctrl.Controls.Count > 0)
            {
                foreach (Control child in ctrl.Controls) DisposeControlImages(child);
            }

            if (ctrl is PictureBox pic && pic.Image != null)
            {
                pic.Image.Dispose();
                pic.Image = null;
            }
        }

        public void Reload()
        {
            LoadMovie();
        }
    }
}