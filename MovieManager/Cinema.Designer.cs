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
            this.AccountDisplayButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.StaffManageButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SnackManageButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.MovieManageButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SnackDisplayButtonCinema = new Guna.UI2.WinForms.Guna2GradientButton();
            this.MovieDisplayButtonCinema = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SideBarZoomButtonCinema = new Guna.UI2.WinForms.Guna2GradientButton();
            this.CinemaShadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.AccountDisplay = new MovieManager.AccountDisplay();
            this.MovieDisplay = new MovieManager.MovieDisplay();
            this.SnackDisplay = new MovieManager.SnackDisplay();
            this.MovieManage = new MovieManager.MovieManage();
            this.SnackManage = new MovieManager.SnackManage();
            this.StaffManage = new MovieManager.StaffManage();
            this.SideBarPanelCinema.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBarPanelCinema
            // 
            this.SideBarPanelCinema.Controls.Add(this.AccountDisplayButton);
            this.SideBarPanelCinema.Controls.Add(this.StaffManageButton);
            this.SideBarPanelCinema.Controls.Add(this.SnackManageButton);
            this.SideBarPanelCinema.Controls.Add(this.MovieManageButton);
            this.SideBarPanelCinema.Controls.Add(this.SnackDisplayButtonCinema);
            this.SideBarPanelCinema.Controls.Add(this.MovieDisplayButtonCinema);
            this.SideBarPanelCinema.Controls.Add(this.SideBarZoomButtonCinema);
            this.SideBarPanelCinema.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarPanelCinema.Location = new System.Drawing.Point(0, 0);
            this.SideBarPanelCinema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SideBarPanelCinema.Name = "SideBarPanelCinema";
            this.SideBarPanelCinema.ShadowDecoration.Enabled = true;
            this.SideBarPanelCinema.Size = new System.Drawing.Size(100, 1055);
            this.SideBarPanelCinema.TabIndex = 2;
            // 
            // AccountDisplayButton
            // 
            this.AccountDisplayButton.Animated = true;
            this.AccountDisplayButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.AccountDisplayButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.AccountDisplayButton.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.AccountDisplayButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AccountDisplayButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AccountDisplayButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AccountDisplayButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AccountDisplayButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AccountDisplayButton.FillColor = System.Drawing.Color.White;
            this.AccountDisplayButton.FillColor2 = System.Drawing.Color.White;
            this.AccountDisplayButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AccountDisplayButton.ForeColor = System.Drawing.Color.Black;
            this.AccountDisplayButton.Image = global::MovieManager.Properties.Resources.account_circle_30dp_BLACK_FILL0_wght400_GRAD0_opsz24;
            this.AccountDisplayButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AccountDisplayButton.ImageOffset = new System.Drawing.Point(10, 0);
            this.AccountDisplayButton.ImageSize = new System.Drawing.Size(25, 25);
            this.AccountDisplayButton.Location = new System.Drawing.Point(0, 800);
            this.AccountDisplayButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccountDisplayButton.Name = "AccountDisplayButton";
            this.AccountDisplayButton.Size = new System.Drawing.Size(100, 80);
            this.AccountDisplayButton.TabIndex = 1;
            this.AccountDisplayButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AccountDisplayButton.TextOffset = new System.Drawing.Point(12, 0);
            this.AccountDisplayButton.CheckedChanged += new System.EventHandler(this.SnackManageButton_CheckedChanged);
            this.AccountDisplayButton.Click += new System.EventHandler(this.AccountDisplayButton_Click);
            // 
            // StaffManageButton
            // 
            this.StaffManageButton.Animated = true;
            this.StaffManageButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.StaffManageButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.StaffManageButton.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.StaffManageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StaffManageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StaffManageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StaffManageButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StaffManageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StaffManageButton.FillColor = System.Drawing.Color.White;
            this.StaffManageButton.FillColor2 = System.Drawing.Color.White;
            this.StaffManageButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StaffManageButton.ForeColor = System.Drawing.Color.Black;
            this.StaffManageButton.Image = global::MovieManager.Properties.Resources.badge_30dp_BLACK_FILL0_wght400_GRAD0_opsz24;
            this.StaffManageButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.StaffManageButton.ImageOffset = new System.Drawing.Point(10, 0);
            this.StaffManageButton.ImageSize = new System.Drawing.Size(25, 25);
            this.StaffManageButton.Location = new System.Drawing.Point(0, 560);
            this.StaffManageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StaffManageButton.Name = "StaffManageButton";
            this.StaffManageButton.Size = new System.Drawing.Size(100, 80);
            this.StaffManageButton.TabIndex = 1;
            this.StaffManageButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.StaffManageButton.TextOffset = new System.Drawing.Point(12, 0);
            this.StaffManageButton.Click += new System.EventHandler(this.StaffManageButton_Click);
            // 
            // SnackManageButton
            // 
            this.SnackManageButton.Animated = true;
            this.SnackManageButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.SnackManageButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.SnackManageButton.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.SnackManageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SnackManageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SnackManageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SnackManageButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SnackManageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SnackManageButton.FillColor = System.Drawing.Color.White;
            this.SnackManageButton.FillColor2 = System.Drawing.Color.White;
            this.SnackManageButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SnackManageButton.ForeColor = System.Drawing.Color.Black;
            this.SnackManageButton.Image = global::MovieManager.Properties.Resources.fastfood_30dp_BLACK_FILL0_wght400_GRAD0_opsz24;
            this.SnackManageButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SnackManageButton.ImageOffset = new System.Drawing.Point(10, 0);
            this.SnackManageButton.ImageSize = new System.Drawing.Size(25, 25);
            this.SnackManageButton.Location = new System.Drawing.Point(0, 480);
            this.SnackManageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SnackManageButton.Name = "SnackManageButton";
            this.SnackManageButton.Size = new System.Drawing.Size(100, 80);
            this.SnackManageButton.TabIndex = 1;
            this.SnackManageButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SnackManageButton.TextOffset = new System.Drawing.Point(12, 0);
            this.SnackManageButton.CheckedChanged += new System.EventHandler(this.SnackManageButton_CheckedChanged);
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
            this.MovieManageButton.Location = new System.Drawing.Point(0, 400);
            this.MovieManageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.SnackDisplayButtonCinema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.MovieDisplayButtonCinema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.SideBarZoomButtonCinema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SideBarZoomButtonCinema.Name = "SideBarZoomButtonCinema";
            this.SideBarZoomButtonCinema.Size = new System.Drawing.Size(30, 30);
            this.SideBarZoomButtonCinema.TabIndex = 0;
            this.SideBarZoomButtonCinema.Click += new System.EventHandler(this.ZoomButtonCinema_Click);
            // 
            // AccountDisplay
            // 
            this.AccountDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountDisplay.Location = new System.Drawing.Point(107, 40);
            this.AccountDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccountDisplay.Name = "AccountDisplay";
            this.AccountDisplay.Size = new System.Drawing.Size(1713, 1160);
            this.AccountDisplay.TabIndex = 0;
            // 
            // MovieDisplay
            // 
            this.MovieDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieDisplay.Location = new System.Drawing.Point(107, 40);
            this.MovieDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MovieDisplay.Name = "MovieDisplay";
            this.MovieDisplay.Size = new System.Drawing.Size(1713, 1015);
            this.MovieDisplay.TabIndex = 0;
            // 
            // SnackDisplay
            // 
            this.SnackDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SnackDisplay.Location = new System.Drawing.Point(107, 40);
            this.SnackDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SnackDisplay.Name = "SnackDisplay";
            this.SnackDisplay.Size = new System.Drawing.Size(1713, 1015);
            this.SnackDisplay.TabIndex = 4;
            // 
            // MovieManage
            // 
            this.MovieManage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieManage.Location = new System.Drawing.Point(107, 40);
            this.MovieManage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MovieManage.Name = "MovieManage";
            this.MovieManage.Size = new System.Drawing.Size(1683, 1015);
            this.MovieManage.TabIndex = 5;
            // 
            // SnackManage
            // 
            this.SnackManage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SnackManage.Location = new System.Drawing.Point(107, 40);
            this.SnackManage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SnackManage.Name = "SnackManage";
            this.SnackManage.Size = new System.Drawing.Size(1683, 1015);
            this.SnackManage.TabIndex = 6;
            // 
            // StaffManage
            // 
            this.StaffManage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StaffManage.Location = new System.Drawing.Point(107, 40);
            this.StaffManage.Name = "StaffManage";
            this.StaffManage.Size = new System.Drawing.Size(1683, 1015);
            this.StaffManage.TabIndex = 7;
            // 
            // Cinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1820, 1055);
            this.Controls.Add(this.SideBarPanelCinema);
            this.Controls.Add(this.MovieDisplay);
            this.Controls.Add(this.SnackDisplay);
            this.Controls.Add(this.MovieManage);
            this.Controls.Add(this.SnackManage);
            this.Controls.Add(this.AccountDisplay);
            this.Controls.Add(this.StaffManage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private SnackManage SnackManage;
        private Guna.UI2.WinForms.Guna2GradientButton SnackManageButton;
        private AccountDisplay AccountDisplay;
        private Guna.UI2.WinForms.Guna2GradientButton AccountDisplayButton;
        private StaffManage StaffManage;
        private Guna.UI2.WinForms.Guna2GradientButton StaffManageButton;
    }
}