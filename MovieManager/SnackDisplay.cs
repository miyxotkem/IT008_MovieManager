using Guna.UI2.WinForms;
using MovieManager.DAO;
using MovieManager.DTO;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieManager
{
    public class BufferedFlowLayoutPanel : FlowLayoutPanel
    {
        public BufferedFlowLayoutPanel()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }
    }
    public partial class SnackDisplay : UserControl
    {
        private ConcurrentQueue<(string Path, Guna2PictureBox Pic)> loadQueue = new ConcurrentQueue<(string, Guna2PictureBox)>();
        private bool isProcessingQueue = false;
        private string imageFolder = @"C:\Users\Thinh Phat\Documents\UIT\MovieManager\MovieManager\Snacks";
        private Color colorBackground = Color.FromArgb(240, 240, 240);
        private Color colorCardBg = Color.White;
        private Color colorHeader = Color.FromArgb(175, 62, 62);
        private Timer _resizeTimer;
        private bool isLoading = false;

        int itemsPerRow = 6;
        int marginSize = 20;
        int scrollbarBuffer = 30;

        public SnackDisplay()
        {
            InitializeComponent();
            this.SnackDisplayFlowLayoutPanel.BackColor = colorBackground;

            _resizeTimer = new Timer();
            _resizeTimer.Interval = 50;
            _resizeTimer.Tick += (s, e) => {
                _resizeTimer.Stop();
                RecalculateLayout();
            };

            this.SnackDisplayFlowLayoutPanel.Resize += SnackDisplayFlowLayoutPanel_Resize;
            SetDoubleBuffered(SnackDisplayFlowLayoutPanel);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!this.DesignMode)
            {
                LoadSnack();
            }
        }

        public static void SetDoubleBuffered(Control control)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession) return;
            System.Reflection.PropertyInfo aProp = typeof(Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance);
            if (aProp != null) aProp.SetValue(control, true, null);
        }

        void LoadSnack()
        {
            if (isLoading) return;
            isLoading = true;
            loadQueue = new ConcurrentQueue<(string, Guna2PictureBox)>();

            SnackDisplayFlowLayoutPanel.SuspendLayout();

            while (SnackDisplayFlowLayoutPanel.Controls.Count > 0)
            {
                var ct = SnackDisplayFlowLayoutPanel.Controls[0];
                SnackDisplayFlowLayoutPanel.Controls.RemoveAt(0);
                ct.Dispose();
            }

            SnackDisplayFlowLayoutPanel.Controls.Clear();
            List<Snack> snackList = SnackDAO.Instance.LoadSnackList();

            int totalMarginPerCard = marginSize * 2;
            int cardWidth = (SnackDisplayFlowLayoutPanel.Width - scrollbarBuffer) / itemsPerRow - totalMarginPerCard;

            if (cardWidth < 100) cardWidth = 150;

            foreach (Snack snack in snackList)
            {
                Guna2CustomGradientPanel pnl = new Guna2CustomGradientPanel()
                {
                    Width = cardWidth,
                    Height = MovieDAO.Height - 50,
                    Margin = new Padding(marginSize),
                    BorderRadius = 14,
                    FillColor = colorCardBg,
                    BackColor = colorBackground,
                    ShadowDecoration = { Enabled = true, Depth = 10, Color = Color.Black, BorderRadius = 14 },
                };

                Guna2Panel pnlText = new Guna2Panel()
                {
                    Height = 100,
                    Dock = DockStyle.Bottom,
                    FillColor = Color.FromArgb(175, 62, 62),
                    BorderRadius = 14,
                    Padding = new Padding(12),
                    Tag = snack,
                    CustomizableEdges = { TopLeft = false, TopRight = false, BottomLeft = true, BottomRight = true }
                };

                Label lblTitle = new Label()
                {
                    Text = snack.Name.ToUpper(),
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    ForeColor = Color.White,
                    BackColor = colorHeader,
                    Dock = DockStyle.Top,
                    Height = 50,
                    TextAlign = ContentAlignment.TopLeft,
                    Tag = snack,
                    AutoEllipsis = true
                };

                Guna2PictureBox pic = new Guna2PictureBox()
                {
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Tag = snack,
                    BorderRadius = 14,
                    BackColor = colorCardBg,
                    CustomizableEdges = { TopLeft = true, TopRight = true, BottomLeft = false, BottomRight = false }
                };

                pic.Click += panel_click;
                pnlText.Click += panel_click;
                lblTitle.Click += panel_click;

                pnlText.Controls.Add(lblTitle);
                pnl.Controls.Add(pic);
                pnl.Controls.Add(pnlText);

                SnackDisplayFlowLayoutPanel.Controls.Add(pnl);

                string fileName = snack.ID.ToString() + ".jpg";
                string fullImagePath = Path.Combine(imageFolder, fileName);
                loadQueue.Enqueue((fullImagePath, pic));
            }

            SnackDisplayFlowLayoutPanel.ResumeLayout();
            isLoading = false;

            if (!isProcessingQueue)
            {
                ProcessLoadQueue();
            }
        }

        private async void ProcessLoadQueue()
        {
            if (isProcessingQueue) return;
            isProcessingQueue = true;

            try
            {
                while (loadQueue.TryDequeue(out var item))
                {
                    if (item.Pic == null || item.Pic.IsDisposed || item.Pic.FindForm() == null)
                        continue;

                    try
                    {
                        if (File.Exists(item.Path))
                        {
                            Image img = await Task.Run(() =>
                            {
                                try
                                {
                                    byte[] buffer = File.ReadAllBytes(item.Path);
                                    using (MemoryStream ms = new MemoryStream(buffer))
                                    {
                                        return new Bitmap(ms);
                                    }
                                }
                                catch { return null; }
                            });

                            if (img != null && !item.Pic.IsDisposed && item.Pic.FindForm() != null)
                            {
                                item.Pic.Invoke(new Action(() => {
                                    if (!item.Pic.IsDisposed)
                                    {
                                        item.Pic.Image = img;
                                        item.Pic.BackColor = Color.Transparent;
                                    }
                                }));
                            }
                        }
                    }
                    catch { }

                    await Task.Delay(5);
                }
            }
            finally
            {
                isProcessingQueue = false;
            }
        }

        private void panel_click(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (ctrl.Tag is Snack snack)
            {
                SelectSnack selectSnack = new SelectSnack(snack, this.Parent);
                this.Parent.Controls.Add(selectSnack);
                selectSnack.BringToFront();
                selectSnack.Left = (this.Parent.ClientSize.Width - selectSnack.ClientSize.Width) / 2;
                selectSnack.Top = (this.Parent.ClientSize.Height - selectSnack.ClientSize.Height) / 2;
                selectSnack.Tag = ctrl.Tag;
            }
        }

        public void Reload()
        {
            LoadSnack();
        }

        private void SnackDisplayFlowLayoutPanel_Resize(object sender, EventArgs e)
        {
            _resizeTimer.Stop();
            _resizeTimer.Start();
        }

        private void RecalculateLayout()
        {
            if (SnackDisplayFlowLayoutPanel.Controls.Count == 0) return;

            int cardWidth = (SnackDisplayFlowLayoutPanel.Width - scrollbarBuffer) / itemsPerRow - (marginSize * 2);
            if (cardWidth < 100) cardWidth = 100;

            SnackDisplayFlowLayoutPanel.SuspendLayout();
            foreach (Control ctrl in SnackDisplayFlowLayoutPanel.Controls)
            {
                if (ctrl is Guna2CustomGradientPanel pnl)
                {
                    pnl.Width = cardWidth;
                }
            }
            SnackDisplayFlowLayoutPanel.ResumeLayout();
        }
    }
}