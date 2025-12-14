using Guna.UI2.WinForms;
using MovieManager.DAO;
using MovieManager.DTO;
using Org.BouncyCastle.Crypto.Parameters;
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
        private string imageFolder = @"D:\Truongpham-code\DoAn_IT008\MovieManager\MovieManager\Snacks";
        //private string imageFolder = @"C:\Users\Thinh Phat\Documents\UIT\MovieManager\MovieManager\Snacks";
        public SnackDisplay()
        {
            InitializeComponent();
            LoadSnack();
        }
        void LoadSnack()
        {
            List<Snack> snackList = SnackDAO.Instance.LoadSnackList();
            string baseDirectory = Application.StartupPath;
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
                pic.Click += new EventHandler(panel_click);
                pic.Tag = snack;
                SnackDisplayFlowLayoutPanel.Controls.Add(pnl);
            }
        }

        private void panel_click(object sender, EventArgs e)
        {
            PictureBox panel = (PictureBox)sender;    
            if (panel != null && panel.Tag is Snack snack)
            {
                SelectSnack selectSnack = new SelectSnack(snack);
                this.Parent.Controls.Add(selectSnack);
                selectSnack.BringToFront();
                selectSnack.Left = (this.Parent.ClientSize.Width - selectSnack.ClientSize.Width) / 2;
                selectSnack.Top = (this.Parent.ClientSize.Height - selectSnack.ClientSize.Height) / 2;
                selectSnack.Tag = panel.Tag;
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
            SnackDisplayFlowLayoutPanel.Controls.Clear();
            LoadSnack();
        }
    }
}
