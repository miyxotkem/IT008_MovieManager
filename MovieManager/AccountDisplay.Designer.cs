namespace MovieManager
{
    partial class AccountDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.ContainPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.PicturePanel = new System.Windows.Forms.Panel();
            this.UpImageButtonAccount = new Guna.UI2.WinForms.Guna2CircleButton();
            this.AccountPictureBoxAccount = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.IDLabel = new System.Windows.Forms.Label();
            this.FullNameLabelAccount = new System.Windows.Forms.Label();
            this.UserTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.FullNameTextBoxAccount = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmailLabelAccount = new System.Windows.Forms.Label();
            this.IDTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.roleTextBoxAccount = new Guna.UI2.WinForms.Guna2TextBox();
            this.AvatarUpLoad = new System.Windows.Forms.OpenFileDialog();
            this.ResetButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Panel.SuspendLayout();
            this.ContainPanel.SuspendLayout();
            this.PicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountPictureBoxAccount)).BeginInit();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.ContainPanel);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1593, 923);
            this.Panel.TabIndex = 0;
            this.Panel.Resize += new System.EventHandler(this.Panel_Resize);
            // 
            // ContainPanel
            // 
            this.ContainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContainPanel.Controls.Add(this.PicturePanel);
            this.ContainPanel.Controls.Add(this.InfoPanel);
            this.ContainPanel.Location = new System.Drawing.Point(317, 59);
            this.ContainPanel.Name = "ContainPanel";
            this.ContainPanel.Size = new System.Drawing.Size(959, 805);
            this.ContainPanel.TabIndex = 5;
            this.ContainPanel.Resize += new System.EventHandler(this.guna2CustomGradientPanel1_Resize);
            // 
            // PicturePanel
            // 
            this.PicturePanel.BackColor = System.Drawing.Color.Transparent;
            this.PicturePanel.Controls.Add(this.UpImageButtonAccount);
            this.PicturePanel.Controls.Add(this.AccountPictureBoxAccount);
            this.PicturePanel.Location = new System.Drawing.Point(230, 3);
            this.PicturePanel.Name = "PicturePanel";
            this.PicturePanel.Size = new System.Drawing.Size(498, 155);
            this.PicturePanel.TabIndex = 17;
            // 
            // UpImageButtonAccount
            // 
            this.UpImageButtonAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UpImageButtonAccount.BackColor = System.Drawing.Color.Transparent;
            this.UpImageButtonAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpImageButtonAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpImageButtonAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpImageButtonAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpImageButtonAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.UpImageButtonAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UpImageButtonAccount.ForeColor = System.Drawing.Color.White;
            this.UpImageButtonAccount.Image = global::MovieManager.Properties.Resources.add_30dp_BLACK_FILL0_wght400_GRAD0_opsz24;
            this.UpImageButtonAccount.Location = new System.Drawing.Point(275, 99);
            this.UpImageButtonAccount.Name = "UpImageButtonAccount";
            this.UpImageButtonAccount.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.UpImageButtonAccount.Size = new System.Drawing.Size(38, 40);
            this.UpImageButtonAccount.TabIndex = 4;
            this.UpImageButtonAccount.Click += new System.EventHandler(this.UpImageButtonAccount_Click);
            // 
            // AccountPictureBoxAccount
            // 
            this.AccountPictureBoxAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AccountPictureBoxAccount.BackColor = System.Drawing.Color.Transparent;
            this.AccountPictureBoxAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AccountPictureBoxAccount.FillColor = System.Drawing.Color.Gray;
            this.AccountPictureBoxAccount.Image = global::MovieManager.Properties.Resources.DefaultImage;
            this.AccountPictureBoxAccount.ImageRotate = 0F;
            this.AccountPictureBoxAccount.Location = new System.Drawing.Point(185, 18);
            this.AccountPictureBoxAccount.Name = "AccountPictureBoxAccount";
            this.AccountPictureBoxAccount.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.AccountPictureBoxAccount.Size = new System.Drawing.Size(114, 121);
            this.AccountPictureBoxAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AccountPictureBoxAccount.TabIndex = 0;
            this.AccountPictureBoxAccount.TabStop = false;
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.Transparent;
            this.InfoPanel.Controls.Add(this.ResetButton);
            this.InfoPanel.Controls.Add(this.UsernameLabel);
            this.InfoPanel.Controls.Add(this.UpdateButton);
            this.InfoPanel.Controls.Add(this.IDLabel);
            this.InfoPanel.Controls.Add(this.FullNameLabelAccount);
            this.InfoPanel.Controls.Add(this.UserTextBox);
            this.InfoPanel.Controls.Add(this.FullNameTextBoxAccount);
            this.InfoPanel.Controls.Add(this.EmailLabelAccount);
            this.InfoPanel.Controls.Add(this.IDTextBox);
            this.InfoPanel.Controls.Add(this.emailTextBox);
            this.InfoPanel.Controls.Add(this.RoleLabel);
            this.InfoPanel.Controls.Add(this.roleTextBoxAccount);
            this.InfoPanel.Location = new System.Drawing.Point(63, 160);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(833, 615);
            this.InfoPanel.TabIndex = 16;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(477, 53);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(86, 20);
            this.UsernameLabel.TabIndex = 9;
            this.UsernameLabel.Text = "Username";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UpdateButton.BackColor = System.Drawing.Color.Transparent;
            this.UpdateButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.UpdateButton.BorderRadius = 12;
            this.UpdateButton.BorderThickness = 1;
            this.UpdateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.UpdateButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.UpdateButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.UpdateButton.HoverState.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.Location = new System.Drawing.Point(327, 480);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.UpdateButton.Size = new System.Drawing.Size(178, 48);
            this.UpdateButton.TabIndex = 15;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IDLabel.AutoSize = true;
            this.IDLabel.BackColor = System.Drawing.Color.Transparent;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(477, 162);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(66, 20);
            this.IDLabel.TabIndex = 13;
            this.IDLabel.Text = "Staff ID";
            // 
            // FullNameLabelAccount
            // 
            this.FullNameLabelAccount.AutoSize = true;
            this.FullNameLabelAccount.BackColor = System.Drawing.Color.Transparent;
            this.FullNameLabelAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLabelAccount.Location = new System.Drawing.Point(32, 53);
            this.FullNameLabelAccount.Name = "FullNameLabelAccount";
            this.FullNameLabelAccount.Size = new System.Drawing.Size(85, 20);
            this.FullNameLabelAccount.TabIndex = 2;
            this.FullNameLabelAccount.Text = "Full Name";
            // 
            // UserTextBox
            // 
            this.UserTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserTextBox.BorderRadius = 12;
            this.UserTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserTextBox.DefaultText = "";
            this.UserTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserTextBox.Location = new System.Drawing.Point(461, 86);
            this.UserTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.PasswordChar = '\0';
            this.UserTextBox.PlaceholderText = "";
            this.UserTextBox.SelectedText = "";
            this.UserTextBox.Size = new System.Drawing.Size(356, 48);
            this.UserTextBox.TabIndex = 10;
            this.UserTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emailTextBox_KeyPress);
            // 
            // FullNameTextBoxAccount
            // 
            this.FullNameTextBoxAccount.BorderRadius = 12;
            this.FullNameTextBoxAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FullNameTextBoxAccount.DefaultText = "";
            this.FullNameTextBoxAccount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FullNameTextBoxAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FullNameTextBoxAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FullNameTextBoxAccount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FullNameTextBoxAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FullNameTextBoxAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FullNameTextBoxAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FullNameTextBoxAccount.Location = new System.Drawing.Point(16, 87);
            this.FullNameTextBoxAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FullNameTextBoxAccount.Name = "FullNameTextBoxAccount";
            this.FullNameTextBoxAccount.PasswordChar = '\0';
            this.FullNameTextBoxAccount.PlaceholderText = "";
            this.FullNameTextBoxAccount.SelectedText = "";
            this.FullNameTextBoxAccount.Size = new System.Drawing.Size(356, 48);
            this.FullNameTextBoxAccount.TabIndex = 3;
            // 
            // EmailLabelAccount
            // 
            this.EmailLabelAccount.AutoSize = true;
            this.EmailLabelAccount.BackColor = System.Drawing.Color.Transparent;
            this.EmailLabelAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabelAccount.Location = new System.Drawing.Point(32, 162);
            this.EmailLabelAccount.Name = "EmailLabelAccount";
            this.EmailLabelAccount.Size = new System.Drawing.Size(51, 20);
            this.EmailLabelAccount.TabIndex = 5;
            this.EmailLabelAccount.Text = "Email";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IDTextBox.BorderRadius = 12;
            this.IDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDTextBox.DefaultText = "";
            this.IDTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IDTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IDTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDTextBox.Enabled = false;
            this.IDTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IDTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDTextBox.Location = new System.Drawing.Point(468, 196);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.PasswordChar = '\0';
            this.IDTextBox.PlaceholderText = "";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.SelectedText = "";
            this.IDTextBox.Size = new System.Drawing.Size(356, 48);
            this.IDTextBox.TabIndex = 14;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderRadius = 12;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.DefaultText = "";
            this.emailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.Location = new System.Drawing.Point(16, 196);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderText = "";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.Size = new System.Drawing.Size(356, 48);
            this.emailTextBox.TabIndex = 6;
            this.emailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emailTextBox_KeyPress);
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.BackColor = System.Drawing.Color.Transparent;
            this.RoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLabel.Location = new System.Drawing.Point(32, 277);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(43, 20);
            this.RoleLabel.TabIndex = 7;
            this.RoleLabel.Text = "Role";
            // 
            // roleTextBoxAccount
            // 
            this.roleTextBoxAccount.BorderRadius = 12;
            this.roleTextBoxAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roleTextBoxAccount.DefaultText = "";
            this.roleTextBoxAccount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.roleTextBoxAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.roleTextBoxAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roleTextBoxAccount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roleTextBoxAccount.Enabled = false;
            this.roleTextBoxAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roleTextBoxAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.roleTextBoxAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roleTextBoxAccount.Location = new System.Drawing.Point(16, 311);
            this.roleTextBoxAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roleTextBoxAccount.Name = "roleTextBoxAccount";
            this.roleTextBoxAccount.PasswordChar = '\0';
            this.roleTextBoxAccount.PlaceholderText = "";
            this.roleTextBoxAccount.ReadOnly = true;
            this.roleTextBoxAccount.SelectedText = "";
            this.roleTextBoxAccount.Size = new System.Drawing.Size(356, 48);
            this.roleTextBoxAccount.TabIndex = 8;
            // 
            // AvatarUpLoad
            // 
            this.AvatarUpLoad.FileName = "openFileDialog1";
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ResetButton.BackColor = System.Drawing.Color.Transparent;
            this.ResetButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ResetButton.BorderRadius = 12;
            this.ResetButton.BorderThickness = 1;
            this.ResetButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ResetButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ResetButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ResetButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ResetButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ResetButton.FillColor = System.Drawing.Color.Empty;
            this.ResetButton.FillColor2 = System.Drawing.Color.Empty;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ResetButton.ForeColor = System.Drawing.Color.Black;
            this.ResetButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ResetButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.ResetButton.HoverState.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(327, 552);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.ResetButton.Size = new System.Drawing.Size(178, 48);
            this.ResetButton.TabIndex = 16;
            this.ResetButton.Text = "Cancle";
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // AccountDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AccountDisplay";
            this.Size = new System.Drawing.Size(1593, 923);
            this.Load += new System.EventHandler(this.AccountDisplay_Load);
            this.Panel.ResumeLayout(false);
            this.ContainPanel.ResumeLayout(false);
            this.PicturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountPictureBoxAccount)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel ContainPanel;
        private Guna.UI2.WinForms.Guna2TextBox IDTextBox;
        private System.Windows.Forms.Label IDLabel;
        private Guna.UI2.WinForms.Guna2TextBox UserTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private Guna.UI2.WinForms.Guna2TextBox roleTextBoxAccount;
        private System.Windows.Forms.Label RoleLabel;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private System.Windows.Forms.Label EmailLabelAccount;
        private Guna.UI2.WinForms.Guna2CircleButton UpImageButtonAccount;
        private Guna.UI2.WinForms.Guna2TextBox FullNameTextBoxAccount;
        private System.Windows.Forms.Label FullNameLabelAccount;
        private Guna.UI2.WinForms.Guna2CirclePictureBox AccountPictureBoxAccount;
        private Guna.UI2.WinForms.Guna2GradientButton UpdateButton;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Panel PicturePanel;
        private System.Windows.Forms.OpenFileDialog AvatarUpLoad;
        private Guna.UI2.WinForms.Guna2GradientButton ResetButton;
    }
}
