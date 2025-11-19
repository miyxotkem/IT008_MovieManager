namespace MovieManager
{
    partial class SignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            this.BackgroundPanelSignIn = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.ExitButtonSignIn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SignInPanelSignIn = new Guna.UI2.WinForms.Guna2Panel();
            this.CreditLabelSignIn = new System.Windows.Forms.Label();
            this.SignUpPanelSignIn = new System.Windows.Forms.Panel();
            this.SignUpLinkLabelSignIn = new System.Windows.Forms.LinkLabel();
            this.DontHaveAnAccountLabelSignIn = new System.Windows.Forms.Label();
            this.ForgetPasswordLinkLabelSignIn = new System.Windows.Forms.LinkLabel();
            this.SignInButtonSignIn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PasswordLabelSignIn = new System.Windows.Forms.Label();
            this.UsernameLabelSignIn = new System.Windows.Forms.Label();
            this.PasswordTextBoxSignIn = new Guna.UI2.WinForms.Guna2TextBox();
            this.UsernameTextBoxSignIn = new Guna.UI2.WinForms.Guna2TextBox();
            this.SignInShadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.epUsernameSignIn = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPassSignIn = new System.Windows.Forms.ErrorProvider(this.components);
            this.Logo = new System.Windows.Forms.PictureBox();
            this.BackgroundPanelSignIn.SuspendLayout();
            this.SignInPanelSignIn.SuspendLayout();
            this.SignUpPanelSignIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epUsernameSignIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPassSignIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // BackgroundPanelSignIn
            // 
            this.BackgroundPanelSignIn.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundPanelSignIn.Controls.Add(this.SignInPanelSignIn);
            this.BackgroundPanelSignIn.Controls.Add(this.Logo);
            this.BackgroundPanelSignIn.Controls.Add(this.ExitButtonSignIn);
            this.BackgroundPanelSignIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanelSignIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.BackgroundPanelSignIn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BackgroundPanelSignIn.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.BackgroundPanelSignIn.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.BackgroundPanelSignIn.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanelSignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackgroundPanelSignIn.Name = "BackgroundPanelSignIn";
            this.BackgroundPanelSignIn.Size = new System.Drawing.Size(1200, 800);
            this.BackgroundPanelSignIn.TabIndex = 0;
            // 
            // ExitButtonSignIn
            // 
            this.ExitButtonSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitButtonSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitButtonSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitButtonSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitButtonSignIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.ExitButtonSignIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExitButtonSignIn.ForeColor = System.Drawing.Color.White;
            this.ExitButtonSignIn.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ExitButtonSignIn.Location = new System.Drawing.Point(1158, 12);
            this.ExitButtonSignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButtonSignIn.Name = "ExitButtonSignIn";
            this.ExitButtonSignIn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ExitButtonSignIn.Size = new System.Drawing.Size(30, 30);
            this.ExitButtonSignIn.TabIndex = 2;
            this.ExitButtonSignIn.Click += new System.EventHandler(this.ExitButtonSignIn_Click);
            // 
            // SignInPanelSignIn
            // 
            this.SignInPanelSignIn.BackColor = System.Drawing.Color.Transparent;
            this.SignInPanelSignIn.BorderRadius = 30;
            this.SignInPanelSignIn.Controls.Add(this.CreditLabelSignIn);
            this.SignInPanelSignIn.Controls.Add(this.SignUpPanelSignIn);
            this.SignInPanelSignIn.Controls.Add(this.ForgetPasswordLinkLabelSignIn);
            this.SignInPanelSignIn.Controls.Add(this.SignInButtonSignIn);
            this.SignInPanelSignIn.Controls.Add(this.PasswordLabelSignIn);
            this.SignInPanelSignIn.Controls.Add(this.UsernameLabelSignIn);
            this.SignInPanelSignIn.Controls.Add(this.PasswordTextBoxSignIn);
            this.SignInPanelSignIn.Controls.Add(this.UsernameTextBoxSignIn);
            this.SignInPanelSignIn.FillColor = System.Drawing.Color.White;
            this.SignInPanelSignIn.Location = new System.Drawing.Point(250, 280);
            this.SignInPanelSignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignInPanelSignIn.Name = "SignInPanelSignIn";
            this.SignInPanelSignIn.ShadowDecoration.BorderRadius = 30;
            this.SignInPanelSignIn.ShadowDecoration.Enabled = true;
            this.SignInPanelSignIn.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.SignInPanelSignIn.Size = new System.Drawing.Size(700, 700);
            this.SignInPanelSignIn.TabIndex = 0;
            // 
            // CreditLabelSignIn
            // 
            this.CreditLabelSignIn.AutoSize = true;
            this.CreditLabelSignIn.Location = new System.Drawing.Point(232, 491);
            this.CreditLabelSignIn.Name = "CreditLabelSignIn";
            this.CreditLabelSignIn.Size = new System.Drawing.Size(237, 20);
            this.CreditLabelSignIn.TabIndex = 8;
            this.CreditLabelSignIn.Text = "This is the creation of CTP Team";
            // 
            // SignUpPanelSignIn
            // 
            this.SignUpPanelSignIn.Controls.Add(this.SignUpLinkLabelSignIn);
            this.SignUpPanelSignIn.Controls.Add(this.DontHaveAnAccountLabelSignIn);
            this.SignUpPanelSignIn.Location = new System.Drawing.Point(200, 350);
            this.SignUpPanelSignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignUpPanelSignIn.Name = "SignUpPanelSignIn";
            this.SignUpPanelSignIn.Size = new System.Drawing.Size(300, 60);
            this.SignUpPanelSignIn.TabIndex = 7;
            // 
            // SignUpLinkLabelSignIn
            // 
            this.SignUpLinkLabelSignIn.AutoSize = true;
            this.SignUpLinkLabelSignIn.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.SignUpLinkLabelSignIn.Location = new System.Drawing.Point(205, 12);
            this.SignUpLinkLabelSignIn.Name = "SignUpLinkLabelSignIn";
            this.SignUpLinkLabelSignIn.Size = new System.Drawing.Size(70, 20);
            this.SignUpLinkLabelSignIn.TabIndex = 3;
            this.SignUpLinkLabelSignIn.TabStop = true;
            this.SignUpLinkLabelSignIn.Text = "Sign Up!";
            this.SignUpLinkLabelSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpLinkLabelSignIn_LinkClicked);
            // 
            // DontHaveAnAccountLabelSignIn
            // 
            this.DontHaveAnAccountLabelSignIn.AutoSize = true;
            this.DontHaveAnAccountLabelSignIn.BackColor = System.Drawing.Color.Transparent;
            this.DontHaveAnAccountLabelSignIn.Location = new System.Drawing.Point(22, 12);
            this.DontHaveAnAccountLabelSignIn.Name = "DontHaveAnAccountLabelSignIn";
            this.DontHaveAnAccountLabelSignIn.Size = new System.Drawing.Size(177, 20);
            this.DontHaveAnAccountLabelSignIn.TabIndex = 6;
            this.DontHaveAnAccountLabelSignIn.Text = "Don\'t have an account?";
            // 
            // ForgetPasswordLinkLabelSignIn
            // 
            this.ForgetPasswordLinkLabelSignIn.AutoSize = true;
            this.ForgetPasswordLinkLabelSignIn.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.ForgetPasswordLinkLabelSignIn.Location = new System.Drawing.Point(285, 420);
            this.ForgetPasswordLinkLabelSignIn.Name = "ForgetPasswordLinkLabelSignIn";
            this.ForgetPasswordLinkLabelSignIn.Size = new System.Drawing.Size(129, 20);
            this.ForgetPasswordLinkLabelSignIn.TabIndex = 4;
            this.ForgetPasswordLinkLabelSignIn.TabStop = true;
            this.ForgetPasswordLinkLabelSignIn.Text = "Forget Password";
            this.ForgetPasswordLinkLabelSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgetPasswordLinkLabelSignIn_LinkClicked);
            // 
            // SignInButtonSignIn
            // 
            this.SignInButtonSignIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.SignInButtonSignIn.BorderRadius = 12;
            this.SignInButtonSignIn.BorderThickness = 1;
            this.SignInButtonSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SignInButtonSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SignInButtonSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignInButtonSignIn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignInButtonSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SignInButtonSignIn.FillColor = System.Drawing.Color.Empty;
            this.SignInButtonSignIn.FillColor2 = System.Drawing.Color.Empty;
            this.SignInButtonSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButtonSignIn.ForeColor = System.Drawing.Color.Black;
            this.SignInButtonSignIn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.SignInButtonSignIn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.SignInButtonSignIn.HoverState.ForeColor = System.Drawing.Color.White;
            this.SignInButtonSignIn.Location = new System.Drawing.Point(250, 260);
            this.SignInButtonSignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignInButtonSignIn.Name = "SignInButtonSignIn";
            this.SignInButtonSignIn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.SignInButtonSignIn.Size = new System.Drawing.Size(200, 60);
            this.SignInButtonSignIn.TabIndex = 2;
            this.SignInButtonSignIn.Text = "Sign In";
            this.SignInButtonSignIn.Click += new System.EventHandler(this.SignInButtonSignIn_Click);
            // 
            // PasswordLabelSignIn
            // 
            this.PasswordLabelSignIn.AutoSize = true;
            this.PasswordLabelSignIn.Location = new System.Drawing.Point(155, 148);
            this.PasswordLabelSignIn.Name = "PasswordLabelSignIn";
            this.PasswordLabelSignIn.Size = new System.Drawing.Size(78, 20);
            this.PasswordLabelSignIn.TabIndex = 1;
            this.PasswordLabelSignIn.Text = "Password";
            // 
            // UsernameLabelSignIn
            // 
            this.UsernameLabelSignIn.AutoSize = true;
            this.UsernameLabelSignIn.Location = new System.Drawing.Point(155, 48);
            this.UsernameLabelSignIn.Name = "UsernameLabelSignIn";
            this.UsernameLabelSignIn.Size = new System.Drawing.Size(83, 20);
            this.UsernameLabelSignIn.TabIndex = 1;
            this.UsernameLabelSignIn.Text = "Username";
            // 
            // PasswordTextBoxSignIn
            // 
            this.PasswordTextBoxSignIn.BorderRadius = 12;
            this.PasswordTextBoxSignIn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBoxSignIn.DefaultText = "";
            this.PasswordTextBoxSignIn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextBoxSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextBoxSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBoxSignIn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBoxSignIn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextBoxSignIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordTextBoxSignIn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextBoxSignIn.IconRight = global::MovieManager.Properties.Resources.visibility_off_24dp_BLACK_FILL0_wght400_GRAD0_opsz24;
            this.PasswordTextBoxSignIn.IconRightSize = new System.Drawing.Size(25, 25);
            this.PasswordTextBoxSignIn.Location = new System.Drawing.Point(150, 170);
            this.PasswordTextBoxSignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordTextBoxSignIn.Name = "PasswordTextBoxSignIn";
            this.PasswordTextBoxSignIn.PasswordChar = '●';
            this.PasswordTextBoxSignIn.PlaceholderText = "";
            this.PasswordTextBoxSignIn.SelectedText = "";
            this.PasswordTextBoxSignIn.Size = new System.Drawing.Size(400, 60);
            this.PasswordTextBoxSignIn.TabIndex = 1;
            this.PasswordTextBoxSignIn.UseSystemPasswordChar = true;
            this.PasswordTextBoxSignIn.Enter += new System.EventHandler(this.PasswordTextBoxSignIn_Enter);
            this.PasswordTextBoxSignIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTextBoxSignIn_KeyPress);
            this.PasswordTextBoxSignIn.Leave += new System.EventHandler(this.PasswordTextBoxSignIn_Leave);
            // 
            // UsernameTextBoxSignIn
            // 
            this.UsernameTextBoxSignIn.BorderRadius = 12;
            this.UsernameTextBoxSignIn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTextBoxSignIn.DefaultText = "";
            this.UsernameTextBoxSignIn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTextBoxSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTextBoxSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTextBoxSignIn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTextBoxSignIn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTextBoxSignIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UsernameTextBoxSignIn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTextBoxSignIn.IconLeftSize = new System.Drawing.Size(50, 50);
            this.UsernameTextBoxSignIn.Location = new System.Drawing.Point(150, 70);
            this.UsernameTextBoxSignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameTextBoxSignIn.Name = "UsernameTextBoxSignIn";
            this.UsernameTextBoxSignIn.PasswordChar = '\0';
            this.UsernameTextBoxSignIn.PlaceholderText = "";
            this.UsernameTextBoxSignIn.SelectedText = "";
            this.UsernameTextBoxSignIn.Size = new System.Drawing.Size(400, 60);
            this.UsernameTextBoxSignIn.TabIndex = 0;
            this.UsernameTextBoxSignIn.Enter += new System.EventHandler(this.UsernameTextBoxSignIn_Enter);
            this.UsernameTextBoxSignIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsernameTextBoxSignIn_KeyPress);
            // 
            // epUsernameSignIn
            // 
            this.epUsernameSignIn.ContainerControl = this;
            // 
            // epPassSignIn
            // 
            this.epPassSignIn.ContainerControl = this;
            // 
            // Logo
            // 
            this.Logo.Image = global::MovieManager.Properties.Resources.ChatGPT_Image_Nov_19__2025__09_06_13_PM_removebg_preview;
            this.Logo.Location = new System.Drawing.Point(475, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(250, 250);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // SignInForm
            // 
            this.AcceptButton = this.SignInButtonSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.BackgroundPanelSignIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.SignInForm_Load);
            this.BackgroundPanelSignIn.ResumeLayout(false);
            this.SignInPanelSignIn.ResumeLayout(false);
            this.SignInPanelSignIn.PerformLayout();
            this.SignUpPanelSignIn.ResumeLayout(false);
            this.SignUpPanelSignIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epUsernameSignIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPassSignIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel BackgroundPanelSignIn;
        private Guna.UI2.WinForms.Guna2Panel SignInPanelSignIn;
        private System.Windows.Forms.Label UsernameLabelSignIn;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTextBoxSignIn;
        private System.Windows.Forms.Label PasswordLabelSignIn;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextBoxSignIn;
        private Guna.UI2.WinForms.Guna2GradientButton SignInButtonSignIn;
        private System.Windows.Forms.LinkLabel SignUpLinkLabelSignIn;
        private System.Windows.Forms.LinkLabel ForgetPasswordLinkLabelSignIn;
        private System.Windows.Forms.Panel SignUpPanelSignIn;
        private System.Windows.Forms.Label DontHaveAnAccountLabelSignIn;
        private System.Windows.Forms.Label CreditLabelSignIn;
        private Guna.UI2.WinForms.Guna2CircleButton ExitButtonSignIn;
        private Guna.UI2.WinForms.Guna2ShadowForm SignInShadow;
        private System.Windows.Forms.ErrorProvider epUsernameSignIn;
        private System.Windows.Forms.ErrorProvider epPassSignIn;
        private System.Windows.Forms.PictureBox Logo;
    }
}

