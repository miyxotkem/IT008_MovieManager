namespace MovieManager
{
    partial class Cinema
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SideBarPanelCinema = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.MovieManageButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SnackDisplayButtonCinema = new Guna.UI2.WinForms.Guna2GradientButton();
            this.MovieDisplayButtonCinema = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SideBarZoomButtonCinema = new Guna.UI2.WinForms.Guna2GradientButton();
            this.CinemaShadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.MovieDisplay = new MovieManager.MovieDisplay();
            this.SnackDisplay = new MovieManager.SnackDisplay();
            this.MovieManage = new MovieManager.MovieManage();
            this.SideBarPanelCinema.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBarPanelCinema
            // 
            this.SideBarPanelCinema.Controls.Add(this.MovieManageButton);
            this.SideBarPanelCinema.Controls.Add(this.SnackDisplayButtonCinema);
            this.SideBarPanelCinema.Controls.Add(this.MovieDisplayButtonCinema);
            this.SideBarPanelCinema.Controls.Add(this.SideBarZoomButtonCinema);
            this.SideBarPanelCinema.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarPanelCinema.Location = new System.Drawing.Point(0, 0);
            this.SideBarPanelCinema.Name = "SideBarPanelCinema";
            this.SideBarPanelCinema.ShadowDecoration.Enabled = true;
            this.SideBarPanelCinema.Size = new System.Drawing.Size(100, 1200);
            this.SideBarPanelCinema.TabIndex = 2;
            // 
            // MovieManageButton
            // 
            this.MovieManageButton.Animated = true;
            this.MovieManageButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.MovieManageButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.MovieManageButton.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.MovieManageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MovieManageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MovieManageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MovieManageButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MovieManageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MovieManageButton.FillColor = System.Drawing.Color.White;
            this.MovieManageButton.FillColor2 = System.Drawing.Color.White;
            this.MovieManageButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MovieManageButton.ForeColor = System.Drawing.Color.Black;
            this.MovieManageButton.Image = global::MovieManager.Properties.Resources.split_scene_24dp_BLACK_FILL0_wght400_GRAD0_opsz24;
            this.MovieManageButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MovieManageButton.ImageOffset = new System.Drawing.Point(10, 0);
            this.MovieManageButton.ImageSize = new System.Drawing.Size(25, 25);
            this.MovieManageButton.Location = new System.Drawing.Point(0, 330);
            this.MovieManageButton.Name = "MovieManageButton";
            this.MovieManageButton.Size = new System.Drawing.Size(100, 80);
            this.MovieManageButton.TabIndex = 1;
            this.MovieManageButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MovieManageButton.TextOffset = new System.Drawing.Point(12, 0);
            this.MovieManageButton.CheckedChanged += new System.EventHandler(this.MovieManageButton_CheckedChanged);
            // 
            // SnackDisplayButtonCinema
            // 
            this.SnackDisplayButtonCinema.Animated = true;
            this.SnackDisplayButtonCinema.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.SnackDisplayButtonCinema.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.SnackDisplayButtonCinema.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.SnackDisplayButtonCinema.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SnackDisplayButtonCinema.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SnackDisplayButtonCinema.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SnackDisplayButtonCinema.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SnackDisplayButtonCinema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SnackDisplayButtonCinema.FillColor = System.Drawing.Color.White;
            this.SnackDisplayButtonCinema.FillColor2 = System.Drawing.Color.White;
            this.SnackDisplayButtonCinema.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SnackDisplayButtonCinema.ForeColor = System.Drawing.Color.Black;
            this.SnackDisplayButtonCinema.Image = global::MovieManager.Properties.Resources.fastfood_24dp_BLACK_FILL0_wght400_GRAD0_opsz24;
            this.SnackDisplayButtonCinema.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SnackDisplayButtonCinema.ImageOffset = new System.Drawing.Point(10, 0);
            this.SnackDisplayButtonCinema.ImageSize = new System.Drawing.Size(25, 25);
            this.SnackDisplayButtonCinema.Location = new System.Drawing.Point(0, 250);
            this.SnackDisplayButtonCinema.Name = "SnackDisplayButtonCinema";
            this.SnackDisplayButtonCinema.Size = new System.Drawing.Size(100, 80);
            this.SnackDisplayButtonCinema.TabIndex = 1;
            this.SnackDisplayButtonCinema.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SnackDisplayButtonCinema.TextOffset = new System.Drawing.Point(12, 0);
            this.SnackDisplayButtonCinema.CheckedChanged += new System.EventHandler(this.SnackDisplayButtonCinema_CheckedChanged);
            // 
            // MovieDisplayButtonCinema
            // 
            this.MovieDisplayButtonCinema.Animated = true;
            this.MovieDisplayButtonCinema.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.MovieDisplayButtonCinema.Checked = true;
            this.MovieDisplayButtonCinema.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.MovieDisplayButtonCinema.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.MovieDisplayButtonCinema.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MovieDisplayButtonCinema.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MovieDisplayButtonCinema.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MovieDisplayButtonCinema.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MovieDisplayButtonCinema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MovieDisplayButtonCinema.FillColor = System.Drawing.Color.White;
            this.MovieDisplayButtonCinema.FillColor2 = System.Drawing.Color.White;
            this.MovieDisplayButtonCinema.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MovieDisplayButtonCinema.ForeColor = System.Drawing.Color.Black;
            this.MovieDisplayButtonCinema.Image = global::MovieManager.Properties.Resources.MovieDisplay;
            this.MovieDisplayButtonCinema.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MovieDisplayButtonCinema.ImageOffset = new System.Drawing.Point(10, 0);
            this.MovieDisplayButtonCinema.ImageSize = new System.Drawing.Size(25, 25);
            this.MovieDisplayButtonCinema.Location = new System.Drawing.Point(0, 170);
            this.MovieDisplayButtonCinema.Name = "MovieDisplayButtonCinema";
            this.MovieDisplayButtonCinema.Size = new System.Drawing.Size(100, 80);
            this.MovieDisplayButtonCinema.TabIndex = 1;
            this.MovieDisplayButtonCinema.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MovieDisplayButtonCinema.TextOffset = new System.Drawing.Point(12, 0);
            this.MovieDisplayButtonCinema.CheckedChanged += new System.EventHandler(this.MovieDisplayButtonCinema_CheckedChanged);
            // 
            // SideBarZoomButtonCinema
            // 
            this.SideBarZoomButtonCinema.BackColor = System.Drawing.Color.Transparent;
            this.SideBarZoomButtonCinema.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SideBarZoomButtonCinema.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SideBarZoomButtonCinema.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SideBarZoomButtonCinema.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SideBarZoomButtonCinema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SideBarZoomButtonCinema.FillColor = System.Drawing.Color.Transparent;
            this.SideBarZoomButtonCinema.FillColor2 = System.Drawing.Color.Transparent;
            this.SideBarZoomButtonCinema.FocusedColor = System.Drawing.Color.Transparent;
            this.SideBarZoomButtonCinema.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SideBarZoomButtonCinema.ForeColor = System.Drawing.Color.White;
            this.SideBarZoomButtonCinema.Image = global::MovieManager.Properties.Resources.SideBar;
            this.SideBarZoomButtonCinema.ImageSize = new System.Drawing.Size(25, 25);
            this.SideBarZoomButtonCinema.Location = new System.Drawing.Point(35, 40);
            this.SideBarZoomButtonCinema.Name = "SideBarZoomButtonCinema";
            this.SideBarZoomButtonCinema.Size = new System.Drawing.Size(30, 30);
            this.SideBarZoomButtonCinema.TabIndex = 0;
            this.SideBarZoomButtonCinema.Click += new System.EventHandler(this.ZoomButtonCinema_Click);
            // 
            // MovieDisplay
            // 
            this.MovieDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieDisplay.Location = new System.Drawing.Point(107, 40);
            this.MovieDisplay.Name = "MovieDisplay";
            this.MovieDisplay.Size = new System.Drawing.Size(1813, 1160);
            this.MovieDisplay.TabIndex = 0;
            // 
            // SnackDisplay
            // 
            this.SnackDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SnackDisplay.Location = new System.Drawing.Point(107, 40);
            this.SnackDisplay.Name = "SnackDisplay";
            this.SnackDisplay.Size = new System.Drawing.Size(1813, 1160);
            this.SnackDisplay.TabIndex = 4;
            // 
            // MovieManage
            // 
            this.MovieManage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieManage.Location = new System.Drawing.Point(107, 40);
            this.MovieManage.Name = "MovieManage";
            this.MovieManage.Size = new System.Drawing.Size(1813, 1160);
            this.MovieManage.TabIndex = 5;
            // 
            // Cinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1200);
            this.Controls.Add(this.SideBarPanelCinema);
            this.Controls.Add(this.MovieDisplay);
            this.Controls.Add(this.SnackDisplay);
            this.Controls.Add(this.MovieManage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cinema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cinema_Load);
            this.SideBarPanelCinema.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel SideBarPanelCinema;
        private Guna.UI2.WinForms.Guna2GradientButton SideBarZoomButtonCinema;
        private Guna.UI2.WinForms.Guna2GradientButton SnackDisplayButtonCinema;
        private Guna.UI2.WinForms.Guna2GradientButton MovieDisplayButtonCinema;
        private MovieDisplay MovieDisplay;
        private SnackDisplay SnackDisplay;
        private Guna.UI2.WinForms.Guna2ShadowForm CinemaShadow;
        private Guna.UI2.WinForms.Guna2GradientButton MovieManageButton;
        private MovieManage MovieManage;
    }
}