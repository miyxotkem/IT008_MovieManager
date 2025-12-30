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
        //private string imageFolder = @"D:\Truongpham-code\DoAn_IT008\MovieManager\MovieManager\Snacks";
        private string imageFolder = @"C:\Users\Thinh Phat\Documents\UIT\MovieManager\MovieManager\Snacks";
        public SnackDisplay()
        {
            InitializeComponent();
            this.SnackDisplayFlowLayoutPanel.Resize += (sender, e) => LoadSnack();
        }
        int itemsPerRow = 6;
        int marginSize = 20;
        int scrollbarBuffer = 30;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!this.DesignMode)
            {
                LoadSnack();
            }
        }
        void LoadSnack()
        {
            SnackDisplayFlowLayoutPanel.SuspendLayout();
            SnackDisplayFlowLayoutPanel.Controls.Clear();
            List<Snack> snackList = SnackDAO.Instance.LoadSnackList();
            string baseDirectory = Application.StartupPath;
            int totalMarginPerCard = marginSize * 2;
            int cardWidth = (SnackDisplayFlowLayoutPanel.Width - scrollbarBuffer) / itemsPerRow - totalMarginPerCard;
            foreach (Snack snack in snackList)
            {
                Guna2CustomGradientPanel pnl = new Guna2CustomGradientPanel()
                {
                    Width = cardWidth,
                    Height = MovieDAO.Height - 50,
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
                    Height = 100,
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
                    Text = snack.Name.ToUpper(),
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    ForeColor = Color.White,
                    BackColor = Color.Transparent,
                    Dock = DockStyle.Top,
                    Height = 50,
                    TextAlign = ContentAlignment.TopLeft,
                    AutoEllipsis = true
                };

                Guna2PictureBox pic = new Guna2PictureBox()
                {
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Tag = snack,
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
                pnlText.Controls.Add(lblTitle);
                pnl.Controls.Add(pnlText);
                pic.Click += new EventHandler(panel_click);
                pic.Tag = snack;
                SnackDisplayFlowLayoutPanel.Controls.Add(pnl);
            }
            SnackDisplayFlowLayoutPanel.ResumeLayout();
        }

        private void panel_click(object sender, EventArgs e)
        {
            PictureBox panel = (PictureBox)sender;    
            if (panel != null && panel.Tag is Snack snack)
            {
                SelectSnack selectSnack = new SelectSnack(snack, this.Parent);
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
