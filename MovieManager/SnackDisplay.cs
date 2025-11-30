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
    public partial class SnackDisplay : UserControl
    {
        public SnackDisplay()
        {
            InitializeComponent();
            LoadSnack();
        }
        void LoadSnack()
        {
            List<Snack> snackList = SnackDAO.Instance.LoadSnackList();
            string baseDirectory = Application.StartupPath;
            string imageFolder = @"C:\Users\Thinh Phat\Documents\UIT\MovieManager\MovieManager\Snacks";
            foreach (Snack snack in snackList)
            {
                Panel pnl = new Panel()
                {
                    Width = SnackDAO.Width,
                    Height = SnackDAO.Height,
                    Margin = new Padding(15)
                };
                Label lblTitle = new Label()
                {
                    Text = snack.Name.ToString(),
                    Height = 150,
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.FromArgb(175, 62, 62),
                    ForeColor = Color.White,
                    Padding = new Padding(5)
                };
                PictureBox pic = new PictureBox()
                {
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                try
                {
                    string fileName = snack.ID.ToString() + ".jpg";
                    string fullImagePath = Path.Combine(imageFolder, fileName);
                    if (File.Exists(fullImagePath))
                    {
                        pic.Image = LoadImageUnlocked(fullImagePath);
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
                SnackDisplayFlowLayoutPanel.Controls.Add(pnl);
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
