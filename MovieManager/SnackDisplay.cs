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
using System.Collections.Concurrent;

namespace MovieManager
{
    public partial class SnackDisplay : UserControl
    {
        private ConcurrentQueue<(string Path, Guna2PictureBox Pic)> loadQueue = new ConcurrentQueue<(string, Guna2PictureBox)>();
        private bool isProcessingQueue = false;
        private string imageFolder = @"D:\Truongpham-code\DoAn_IT008\MovieManager\MovieManager\Snacks";
        //private string imageFolder = @"C:\Users\Thinh Phat\Documents\UIT\MovieManager\MovieManager\Snacks";
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
        //void LoadSnack()
        //{
        //    SnackDisplayFlowLayoutPanel.SuspendLayout();
        //    SnackDisplayFlowLayoutPanel.Controls.Clear();
        //    List<Snack> snackList = SnackDAO.Instance.LoadSnackList();
        //    string baseDirectory = Application.StartupPath;
        //    int totalMarginPerCard = marginSize * 2;
        //    int cardWidth = (SnackDisplayFlowLayoutPanel.Width - scrollbarBuffer) / itemsPerRow - totalMarginPerCard;
        //    foreach (Snack snack in snackList)
        //    {
        //        Guna2CustomGradientPanel pnl = new Guna2CustomGradientPanel()
        //        {
        //            Width = cardWidth,
        //            Height = MovieDAO.Height - 50,
        //            Margin = new Padding(marginSize),
        //            BorderRadius = 14,
        //            FillColor = Color.White,
        //            ShadowDecoration =
        //            {
        //                Enabled = true,
        //                Depth = 10,
        //                Color = Color.Black,
        //                BorderRadius = 14
        //            }
        //        };

        //        Guna2Panel pnlText = new Guna2Panel()
        //        {
        //            Height = 100,
        //            Dock = DockStyle.Bottom,
        //            FillColor = Color.FromArgb(175, 62, 62),
        //            BorderRadius = 14,
        //            Padding = new Padding(12),
        //            CustomizableEdges =
        //            {
        //                TopLeft = false,
        //                TopRight = false,
        //                BottomLeft = true,
        //                BottomRight = true
        //            }
        //        };

        //        Label lblTitle = new Label()
        //        {
        //            Text = snack.Name.ToUpper(),
        //            Font = new Font("Segoe UI", 11, FontStyle.Bold),
        //            ForeColor = Color.White,
        //            BackColor = Color.Transparent,
        //            Dock = DockStyle.Top,
        //            Height = 50,
        //            TextAlign = ContentAlignment.TopLeft,
        //            AutoEllipsis = true
        //        };

        //        Guna2PictureBox pic = new Guna2PictureBox()
        //        {
        //            Dock = DockStyle.Fill,
        //            SizeMode = PictureBoxSizeMode.StretchImage,
        //            Tag = snack,
        //            BorderRadius = 14,
        //            CustomizableEdges = 
        //            { 
        //                TopLeft = true, 
        //                TopRight = true, 
        //                BottomLeft = false, 
        //                BottomRight = false 
        //            }
        //        };
        //        try
        //        {
        //            string fileName = snack.ID.ToString() + ".jpg";
        //            string fullImagePath = Path.Combine(imageFolder, fileName);
        //            if (File.Exists(fullImagePath))
        //            {
        //                pic.Image = LoadImageUnlocked(fullImagePath);
        //            }
        //            else
        //            {
        //                pic.BackColor = Color.Silver;
        //                Console.WriteLine($"Image not found. Looked for: {fullImagePath}");
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Error loading image: " + ex.Message);
        //            pic.BackColor = Color.Red;
        //        }
        //        pnl.Controls.Add(pic);
        //        pnlText.Controls.Add(lblTitle);
        //        pnl.Controls.Add(pnlText);
        //        pic.Click += new EventHandler(panel_click);
        //        pic.Tag = snack;
        //        SnackDisplayFlowLayoutPanel.Controls.Add(pnl);
        //    }
        //    SnackDisplayFlowLayoutPanel.ResumeLayout();
        //}

        void LoadSnack()
        {
            SnackDisplayFlowLayoutPanel.SuspendLayout();
            SnackDisplayFlowLayoutPanel.Controls.Clear();
            List<Snack> snackList = SnackDAO.Instance.LoadSnackList();

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
                    ShadowDecoration = { Enabled = true, Depth = 10, Color = Color.Black, BorderRadius = 14 }
                };

                Guna2Panel pnlText = new Guna2Panel()
                {
                    Height = 100,
                    Dock = DockStyle.Bottom,
                    FillColor = Color.FromArgb(175, 62, 62),
                    BorderRadius = 14,
                    Padding = new Padding(12),
                    CustomizableEdges = { TopLeft = false, TopRight = false, BottomLeft = true, BottomRight = true }
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
                    Tag = snack, // Đảm bảo Tag được gán ở đây
                    BorderRadius = 14,
                    BackColor = Color.FromArgb(224, 224, 224),
                    CustomizableEdges = { TopLeft = true, TopRight = true, BottomLeft = false, BottomRight = false }
                };

                // Gán sự kiện click cho cả ảnh và panel văn bản để đồng nhất
                pic.Click += panel_click;
                pnlText.Click += panel_click;
                lblTitle.Click += panel_click;

                pnlText.Controls.Add(lblTitle);
                pnl.Controls.Add(pic);
                pnl.Controls.Add(pnlText);

                SnackDisplayFlowLayoutPanel.Controls.Add(pnl);

                // Load ảnh chạy ngầm
                string fileName = snack.ID.ToString() + ".jpg";
                string fullImagePath = Path.Combine(imageFolder, fileName);
                //LoadSnackImageAsync(fullImagePath, pic);
                loadQueue.Enqueue((fullImagePath, pic));
            }
            SnackDisplayFlowLayoutPanel.ResumeLayout();

            if (!isProcessingQueue)
            {
                ProcessLoadQueue();
            }
        }

        private async void ProcessLoadQueue()
        {
            isProcessingQueue = true;

            while (loadQueue.TryDequeue(out var item))
            {
                if (item.Pic.IsDisposed) continue;

                try
                {
                    if (File.Exists(item.Path))
                    {
                        Image img = await Task.Run(() =>
                        {
                            try
                            {
                                // Đọc toàn bộ byte để giải phóng file ngay lập tức
                                byte[] buffer = File.ReadAllBytes(item.Path);
                                using (MemoryStream ms = new MemoryStream(buffer))
                                {
                                    return new Bitmap(ms);
                                }
                            }
                            catch { return null; }
                        });

                        if (img != null && !item.Pic.IsDisposed)
                        {
                            item.Pic.Image = img;
                            item.Pic.BackColor = Color.Transparent;
                        }
                    }
                    else
                    {
                        item.Pic.BackColor = Color.Silver;
                    }
                }
                catch { item.Pic.BackColor = Color.Red; }

                // Nghỉ một chút (rất nhỏ) để UI kịp vẽ lại và không bị treo
                await Task.Delay(10);
            }

            isProcessingQueue = false;
        }

        // Hàm load ảnh bất đồng bộ cho Snack
        private async void LoadSnackImageAsync(string path, Guna2PictureBox pic)
        {
            if (string.IsNullOrEmpty(path) || pic == null) return;

            try
            {
                if (File.Exists(path))
                {
                    // Sử dụng Task.Run để đọc file an toàn
                    Image img = await Task.Run(() =>
                    {
                        try
                        {
                            // Cách đọc file an toàn nhất, tránh bị khóa file (Sharing Violation)
                            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
                            {
                                // Tạo bản sao ảnh trong bộ nhớ để có thể đóng file ngay lập tức
                                using (Image tempImg = Image.FromStream(fs))
                                {
                                    return new Bitmap(tempImg);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Lỗi đọc file {path}: {ex.Message}");
                            return null;
                        }
                    });

                    // Kiểm tra pic còn tồn tại trên giao diện không mới gán ảnh
                    if (img != null && pic != null && !pic.IsDisposed && pic.FindForm() != null)
                    {
                        // Sử dụng Invoke nếu cần, nhưng async/await thường đã xử lý việc quay lại UI thread
                        pic.Image = img;
                        pic.BackColor = Color.Transparent;
                    }
                }
                else
                {
                    // Nếu không tìm thấy file, để màu xám bạc thay vì đỏ cho đỡ xấu
                    pic.BackColor = Color.Silver;
                    Console.WriteLine($"Không tìm thấy file: {path}");
                }
            }
            catch (Exception ex)
            {
                // Chỉ đổi màu đỏ khi có lỗi hệ thống nghiêm trọng
                if (pic != null && !pic.IsDisposed) pic.BackColor = Color.Red;
                Console.WriteLine($"Lỗi nghiêm trọng: {ex.Message}");
            }
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
