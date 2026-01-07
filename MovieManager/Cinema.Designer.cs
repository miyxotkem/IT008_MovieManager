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
            this.GraphDisplayButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PaymentButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AccountDisplayButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.VoucherManageButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ShowTimeManageButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.CustomerManageButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.StaffManageButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SnackManageButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.MovieManageButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SnackDisplayButtonCinema = new Guna.UI2.WinForms.Guna2GradientButton();
            this.MovieDisplayButtonCinema = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SideBarZoomButtonCinema = new Guna.UI2.WinForms.Guna2GradientButton();
            this.CinemaShadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.SideBarPanelCinema.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBarPanelCinema
            // 
            this.SideBarPanelCinema.Controls.Add(this.GraphDisplayButton);
            this.SideBarPanelCinema.Controls.Add(this.PaymentButton);
            this.SideBarPanelCinema.Controls.Add(this.AccountDisplayButton);
            this.SideBarPanelCinema.Controls.Add(this.VoucherManageButton);
            this.SideBarPanelCinema.Controls.Add(this.ShowTimeManageButton);
            this.SideBarPanelCinema.Controls.Add(this.CustomerManageButton);
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
            this.SideBarPanelCinema.Size = new System.Drawing.Size(89, 844);
            this.SideBarPanelCinema.TabIndex = 2;
            // 
            // GraphDisplayButton
            // 
            this.GraphDisplayButton.Animated = true;
            this.GraphDisplayButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.GraphDisplayButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.GraphDisplayButton.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.GraphDisplayButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GraphDisplayButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GraphDisplayButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GraphDisplayButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GraphDisplayButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GraphDisplayButton.FillColor = System.Drawing.Color.White;
            this.GraphDisplayButton.FillColor2 = System.Drawing.Color.White;
            this.GraphDisplayButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GraphDisplayButton.ForeColor = System.Drawing.Color.Black;
            this.GraphDisplayButton.Image = global::MovieManager.Properties.Resources.bar_chart_30dp_BLACK_FILL0_wght400_GRAD0_opsz24;
            this.GraphDisplayButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GraphDisplayButton.ImageOffset = new System.Drawing.Point(10, 0);
            this.GraphDisplayButton.ImageSize = new System.Drawing.Size(25, 25);
            this.GraphDisplayButton.Location = new System.Drawing.Point(0, 328);
            this.GraphDisplayButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GraphDisplayButton.Name = "GraphDisplayButton";
            this.GraphDisplayButton.Size = new System.Drawing.Size(89, 64);
            this.GraphDisplayButton.TabIndex = 3;
            this.GraphDisplayButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GraphDisplayButton.TextOffset = new System.Drawing.Point(12, 0);
            this.GraphDisplayButton.CheckedChanged += new System.EventHandler(this.Statistic_Click);
            this.GraphDisplayButton.Click += new System.EventHandler(this.Statistic_Click);
            // 
            // PaymentButton
            // 
            this.PaymentButton.Animated = true;
            this.PaymentButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.PaymentButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.PaymentButton.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.PaymentButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PaymentButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PaymentButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PaymentButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PaymentButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PaymentButton.FillColor = System.Drawing.Color.White;
            this.PaymentButton.FillColor2 = System.Drawing.Color.White;
            this.PaymentButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PaymentButton.ForeColor = System.Drawing.Color.Black;
            this.PaymentButton.Image = global::MovieManager.Properties.Resources.Payment_Icon;
            this.PaymentButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PaymentButton.ImageOffset = new System.Drawing.Point(10, 0);
            this.PaymentButton.ImageSize = new System.Drawing.Size(25, 25);
            this.PaymentButton.Location = new System.Drawing.Point(0, 264);
            this.PaymentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(89, 64);
            this.PaymentButton.TabIndex = 2;
            this.PaymentButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PaymentButton.TextOffset = new System.Drawing.Point(12, 0);
            this.PaymentButton.CheckedChanged += new System.EventHandler(this.PaymentButton_Click);
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
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
            this.AccountDisplayButton.Location = new System.Drawing.Point(0, 768);
            this.AccountDisplayButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccountDisplayButton.Name = "AccountDisplayButton";
            this.AccountDisplayButton.Size = new System.Drawing.Size(89, 64);
            this.AccountDisplayButton.TabIndex = 1;
            this.AccountDisplayButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AccountDisplayButton.TextOffset = new System.Drawing.Point(12, 0);
            this.AccountDisplayButton.CheckedChanged += new System.EventHandler(this.SnackManageButton_CheckedChanged);
            this.AccountDisplayButton.Click += new System.EventHandler(this.AccountDisplayButton_Click);
            // 
            // VoucherManageButton
            // 
            this.VoucherManageButton.Animated = true;
            this.VoucherManageButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.VoucherManageButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.VoucherManageButton.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.VoucherManageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.VoucherManageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.VoucherManageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.VoucherManageButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.VoucherManageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.VoucherManageButton.FillColor = System.Drawing.Color.White;
            this.VoucherManageButton.FillColor2 = System.Drawing.Color.White;
            this.VoucherManageButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.VoucherManageButton.ForeColor = System.Drawing.Color.Black;
            this.VoucherManageButton.Image = global::MovieManager.Properties.Resources.redeem_30dp_BLACK_FILL0_wght400_GRAD0_opsz24;
            this.VoucherManageButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.VoucherManageButton.ImageOffset = new System.Drawing.Point(10, 0);
            this.VoucherManageButton.ImageSize = new System.Drawing.Size(25, 25);
            this.VoucherManageButton.Location = new System.Drawing.Point(0, 704);
            this.VoucherManageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VoucherManageButton.Name = "VoucherManageButton";
            this.VoucherManageButton.Size = new System.Drawing.Size(89, 64);
            this.VoucherManageButton.TabIndex = 1;
            this.VoucherManageButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.VoucherManageButton.TextOffset = new System.Drawing.Point(12, 0);
            this.VoucherManageButton.Click += new System.EventHandler(this.VoucherManageButton_Click);
            // 
            // ShowTimeManageButton
            // 
            this.ShowTimeManageButton.Animated = true;
            this.ShowTimeManageButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ShowTimeManageButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ShowTimeManageButton.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.ShowTimeManageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ShowTimeManageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ShowTimeManageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ShowTimeManageButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ShowTimeManageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ShowTimeManageButton.FillColor = System.Drawing.Color.White;
            this.ShowTimeManageButton.FillColor2 = System.Drawing.Color.White;
            this.ShowTimeManageButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ShowTimeManageButton.ForeColor = System.Drawing.Color.Black;
            this.ShowTimeManageButton.Image = global::MovieManager.Properties.Resources.folder_eye_30dp_BLACK_FILL0_wght400_GRAD0_opsz24;
            this.ShowTimeManageButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ShowTimeManageButton.ImageOffset = new System.Drawing.Point(10, 0);
            this.ShowTimeManageButton.ImageSize = new System.Drawing.Size(25, 25);
            this.ShowTimeManageButton.Location = new System.Drawing.Point(0, 640);
            this.ShowTimeManageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowTimeManageButton.Name = "ShowTimeManageButton";
            this.ShowTimeManageButton.Size = new System.Drawing.Size(89, 64);
            this.ShowTimeManageButton.TabIndex = 1;
            this.ShowTimeManageButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ShowTimeManageButton.TextOffset = new System.Drawing.Point(12, 0);
            this.ShowTimeManageButton.Click += new System.EventHandler(this.ShowTimeManageButton_Click);
            // 
            // CustomerManageButton
            // 
            this.CustomerManageButton.Animated = true;
            this.CustomerManageButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CustomerManageButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.CustomerManageButton.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.CustomerManageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CustomerManageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CustomerManageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CustomerManageButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CustomerManageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CustomerManageButton.FillColor = System.Drawing.Color.White;
            this.CustomerManageButton.FillColor2 = System.Drawing.Color.White;
            this.CustomerManageButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomerManageButton.ForeColor = System.Drawing.Color.Black;
            this.CustomerManageButton.Image = global::MovieManager.Properties.Resources.group_30dp_BLACK_FILL0_wght400_GRAD0_opsz24;
            this.CustomerManageButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CustomerManageButton.ImageOffset = new System.Drawing.Point(10, 0);
            this.CustomerManageButton.ImageSize = new System.Drawing.Size(25, 25);
            this.CustomerManageButton.Location = new System.Drawing.Point(0, 576);
            this.CustomerManageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerManageButton.Name = "CustomerManageButton";
            this.CustomerManageButton.Size = new System.Drawing.Size(89, 64);
            this.CustomerManageButton.TabIndex = 1;
            this.CustomerManageButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CustomerManageButton.TextOffset = new System.Drawing.Point(12, 0);
            this.CustomerManageButton.Click += new System.EventHandler(this.CustomerManageButton_Click);
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
            this.StaffManageButton.Location = new System.Drawing.Point(0, 512);
            this.StaffManageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StaffManageButton.Name = "StaffManageButton";
            this.StaffManageButton.Size = new System.Drawing.Size(89, 64);
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
            this.SnackManageButton.Location = new System.Drawing.Point(0, 448);
            this.SnackManageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SnackManageButton.Name = "SnackManageButton";
            this.SnackManageButton.Size = new System.Drawing.Size(89, 64);
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
            this.MovieManageButton.Location = new System.Drawing.Point(0, 384);
            this.MovieManageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MovieManageButton.Name = "MovieManageButton";
            this.MovieManageButton.Size = new System.Drawing.Size(89, 64);
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
            this.SnackDisplayButtonCinema.Location = new System.Drawing.Point(0, 200);
            this.SnackDisplayButtonCinema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SnackDisplayButtonCinema.Name = "SnackDisplayButtonCinema";
            this.SnackDisplayButtonCinema.Size = new System.Drawing.Size(89, 64);
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
            this.MovieDisplayButtonCinema.Location = new System.Drawing.Point(0, 136);
            this.MovieDisplayButtonCinema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MovieDisplayButtonCinema.Name = "MovieDisplayButtonCinema";
            this.MovieDisplayButtonCinema.Size = new System.Drawing.Size(89, 64);
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
            this.SideBarZoomButtonCinema.Location = new System.Drawing.Point(31, 32);
            this.SideBarZoomButtonCinema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SideBarZoomButtonCinema.Name = "SideBarZoomButtonCinema";
            this.SideBarZoomButtonCinema.Size = new System.Drawing.Size(27, 24);
            this.SideBarZoomButtonCinema.TabIndex = 0;
            this.SideBarZoomButtonCinema.Click += new System.EventHandler(this.ZoomButtonCinema_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainPanel.Location = new System.Drawing.Point(-342, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1960, 844);
            this.MainPanel.TabIndex = 3;
            // 
            // Cinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 844);
            this.Controls.Add(this.SideBarPanelCinema);
            this.Controls.Add(this.MainPanel);
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
        private Guna.UI2.WinForms.Guna2ShadowForm CinemaShadow;
        private Guna.UI2.WinForms.Guna2GradientButton MovieManageButton;
        private Guna.UI2.WinForms.Guna2GradientButton SnackManageButton;
        private Guna.UI2.WinForms.Guna2GradientButton AccountDisplayButton;
        private Guna.UI2.WinForms.Guna2GradientButton StaffManageButton;
        private Guna.UI2.WinForms.Guna2GradientButton CustomerManageButton;
        private Guna.UI2.WinForms.Guna2GradientButton ShowTimeManageButton;
        private Guna.UI2.WinForms.Guna2Panel MainPanel;
        private Guna.UI2.WinForms.Guna2GradientButton PaymentButton;
        private Guna.UI2.WinForms.Guna2GradientButton GraphDisplayButton;
        private Guna.UI2.WinForms.Guna2GradientButton VoucherManageButton;
    }
}