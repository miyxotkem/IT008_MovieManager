using MovieManager.DAO;
using MovieManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace MovieManager
{
    public partial class Edit_MovieManage : UserControl
    {
        private List<Movie> movies = MovieDAO.Instance.LoadMovieList();
        private Movie main = null;
        public Edit_MovieManage()
        {
            InitializeComponent();
            ApplyButton.Text = "Add";
            ApplyButton.Click -= ApplyButton_Click;
            ApplyButton.Click += Add_Click;
        }
        public Edit_MovieManage(int movieid)
        {
            InitializeComponent();
            foreach (Movie movie in movies)
            {
                if (movie.ID == movieid)
                {
                    main = movie;
                    TitleTextBox.Text = movie.Title;
                    GenreComboBox.Text = movie.Genre;
                    RatedComboBox.Text = movie.Rated;
                    ReleaseDateTimePicker.Value = movie.Release_date;
                    DirectorTextBox.Text = movie.Director;
                    LanguageTextBox.Text = movie.Language;
                    DurationTextBox.Text = movie.Duration.ToString();
                    FormatComboBox.Text = movie.Format;
                    TrailerTextBox.Text = movie.Trailer;
                    ActorTextBox.Text = movie.Actor;
                    BriefTextBox.Text = movie.Brief;
                    LoadPoster();
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
        private string dest = @"C:\Users\Thinh Phat\Documents\UIT\MovieManager\MovieManager\Posters";
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (GenreComboBox.SelectedIndex == -1)
                GenreComboBox.SelectedIndex = 0;
            if (RatedComboBox.SelectedIndex == -1)
                RatedComboBox.SelectedIndex = 0;
            if (DurationTextBox.Text.Length == 0)
                DurationTextBox.Text = "0";
            if (TitleTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter the movie title");
                return;
            }
            if (MessageBox.Show("Save changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = @"UPDATE MOVIE SET title = @title , genre = @genre , rated = @rated , release_date = @release_date , director = @director , language = @language , duration = @duration , format = @format , trailer = @trailer , actor = @actor , brief = @brief WHERE id = @id";
                object[] values = new object[]
                {
                    TitleTextBox.Text,
                    GenreComboBox.Text,
                    RatedComboBox.Text,
                    ReleaseDateTimePicker.Value,
                    DirectorTextBox.Text,
                    LanguageTextBox.Text,
                    Convert.ToInt32(DurationTextBox.Text),
                    FormatComboBox.Text,
                    TrailerTextBox.Text,
                    ActorTextBox.Text,
                    BriefTextBox.Text,
                    main.ID
                };
                string actdest = dest;
                int movieId = main.ID;
                if (movieId > 0)
                {
                    string posterFileName = $"{movieId}.jpg";
                    actdest = Path.Combine(dest, posterFileName);
                }
                if (isPosterDeleted)
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    if (File.Exists(actdest))
                        File.Delete(actdest);
                }
                else if (path != null)
                    if (Path.GetFullPath(path) != Path.GetFullPath(actdest))
                    {
                        if (PosterPictureBox.Image != null)
                        {
                            PosterPictureBox.Image.Dispose();
                            PosterPictureBox.Image = null;
                        }
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        if (File.Exists(actdest))
                            File.Delete(actdest);
                        File.Copy(path, actdest);
                    }
                dp.ExecuteNonQuery(query, values);
                CancelButton.PerformClick();
            }
        }
        void Add_Click(object sender, EventArgs e)
        {
            if (GenreComboBox.SelectedIndex == -1)
                GenreComboBox.SelectedIndex = 0;
            if (RatedComboBox.SelectedIndex == -1)
                RatedComboBox.SelectedIndex = 0;
            if (DurationTextBox.Text.Length == 0)
                DurationTextBox.Text = "0";
            if (TitleTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter the movie title");
                return;
            }
            object[] values = new object[]
            {
                    TitleTextBox.Text,
                    GenreComboBox.Text,
                    RatedComboBox.Text,
                    ReleaseDateTimePicker.Value,
                    DirectorTextBox.Text,
                    LanguageTextBox.Text,
                    Convert.ToInt32(DurationTextBox.Text),
                    FormatComboBox.Text,
                    TrailerTextBox.Text,
                    ActorTextBox.Text,
                    BriefTextBox.Text
            };
            string actdest = dest;
            string query = @"INSERT INTO MOVIE(title, genre, rated, release_date, director, language, duration, format, trailer, actor, brief) 
                 VALUES ( @title , @genre , @rated , @release_date , @director , @language , @duration , @format , @trailer , @actor , @brief ); 
                 SELECT SCOPE_IDENTITY()";
            object result = dp.ExecuteScalar(query, values);
            int movieId = 0;
            if (result != null)
                movieId = Convert.ToInt32(result);
            if (movieId > 0)
            {
                string posterFileName = $"{movieId}.jpg";
                actdest = Path.Combine(dest, posterFileName);
                if (path != null)
                    File.Copy(path, actdest, true);
            }
            MovieChanged?.Invoke(this, EventArgs.Empty);
            MessageBox.Show("Added successfully!");
            CancelButton.PerformClick();
        }
        public event EventHandler MovieChanged;
        private string path = null;
        private void UploadButton_Click(object sender, EventArgs e)
        {
            UploadFileDialog.Filter = "Posters (*.jpg) | *.jpg";
            if (UploadFileDialog.ShowDialog() == DialogResult.OK)
            {
                isPosterDeleted = false;
                path = UploadFileDialog.FileName;
                if (PosterPictureBox.Image != null)
                {
                    PosterPictureBox.Image.Dispose();
                    PosterPictureBox.Image = null;
                }
                PosterPictureBox.Image = LoadImageUnlocked(UploadFileDialog.FileName);
            }
        }

        private void DurationTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = char.IsDigit(e.KeyChar);
            bool isBackspace = e.KeyChar == '\b';
            if (!isDigit && !isBackspace)
                e.Handled = true;
        }

        void LoadPoster()
        {
            string fileName = main.ID.ToString() + ".jpg";
            string fullImagePath = Path.Combine(dest, fileName);
            if (File.Exists(fullImagePath))
                PosterPictureBox.Image = LoadImageUnlocked(fullImagePath);
        }

        private Image LoadImageUnlocked(string path)
        {
            byte[] bytes = File.ReadAllBytes(path);
            MemoryStream ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }
        private bool isPosterDeleted = false;
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (PosterPictureBox.Image != null)
            {
                PosterPictureBox.Image.Dispose();
                PosterPictureBox.Image = null;
            }
            path = null;
            isPosterDeleted = true;
        }
    }
}
