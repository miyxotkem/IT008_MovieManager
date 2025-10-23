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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            this.BackgroundPanelSignIn = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.SignInPanelSignIn = new Guna.UI2.WinForms.Guna2Panel();
            this.UsernameTextBoxSignIn = new Guna.UI2.WinForms.Guna2TextBox();
            this.UsernameLabelSignIn = new System.Windows.Forms.Label();
            this.PasswordTextBoxSignIn = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordLabelSignIn = new System.Windows.Forms.Label();
            this.SignInButtonSignIn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TitleLabelSignIn = new System.Windows.Forms.Label();
            this.SignUpLinkLabelSignIn = new System.Windows.Forms.LinkLabel();
            this.BackgroundPanelSignIn.SuspendLayout();
            this.SignInPanelSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundPanelSignIn
            // 
            this.BackgroundPanelSignIn.Controls.Add(this.TitleLabelSignIn);
            this.BackgroundPanelSignIn.Controls.Add(this.SignInPanelSignIn);
            this.BackgroundPanelSignIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanelSignIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.BackgroundPanelSignIn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.BackgroundPanelSignIn.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.BackgroundPanelSignIn.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.BackgroundPanelSignIn.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanelSignIn.Name = "BackgroundPanelSignIn";
            this.BackgroundPanelSignIn.Size = new System.Drawing.Size(1200, 800);
            this.BackgroundPanelSignIn.TabIndex = 0;
            // 
            // SignInPanelSignIn
            // 
            this.SignInPanelSignIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SignInPanelSignIn.Controls.Add(this.SignUpLinkLabelSignIn);
            this.SignInPanelSignIn.Controls.Add(this.SignInButtonSignIn);
            this.SignInPanelSignIn.Controls.Add(this.PasswordLabelSignIn);
            this.SignInPanelSignIn.Controls.Add(this.UsernameLabelSignIn);
            this.SignInPanelSignIn.Controls.Add(this.PasswordTextBoxSignIn);
            this.SignInPanelSignIn.Controls.Add(this.UsernameTextBoxSignIn);
            this.SignInPanelSignIn.Location = new System.Drawing.Point(250, 220);
            this.SignInPanelSignIn.Name = "SignInPanelSignIn";
            this.SignInPanelSignIn.Size = new System.Drawing.Size(700, 700);
            this.SignInPanelSignIn.TabIndex = 0;
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
            this.UsernameTextBoxSignIn.Location = new System.Drawing.Point(150, 70);
            this.UsernameTextBoxSignIn.Name = "UsernameTextBoxSignIn";
            this.UsernameTextBoxSignIn.PasswordChar = '\0';
            this.UsernameTextBoxSignIn.PlaceholderText = "";
            this.UsernameTextBoxSignIn.SelectedText = "";
            this.UsernameTextBoxSignIn.Size = new System.Drawing.Size(400, 60);
            this.UsernameTextBoxSignIn.TabIndex = 0;
            // 
            // UsernameLabelSignIn
            // 
            this.UsernameLabelSignIn.AutoSize = true;
            this.UsernameLabelSignIn.Location = new System.Drawing.Point(155, 47);
            this.UsernameLabelSignIn.Name = "UsernameLabelSignIn";
            this.UsernameLabelSignIn.Size = new System.Drawing.Size(59, 20);
            this.UsernameLabelSignIn.TabIndex = 1;
            this.UsernameLabelSignIn.Text = "Sign In";
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
            this.PasswordTextBoxSignIn.Location = new System.Drawing.Point(150, 170);
            this.PasswordTextBoxSignIn.Name = "PasswordTextBoxSignIn";
            this.PasswordTextBoxSignIn.PasswordChar = '\0';
            this.PasswordTextBoxSignIn.PlaceholderText = "";
            this.PasswordTextBoxSignIn.SelectedText = "";
            this.PasswordTextBoxSignIn.Size = new System.Drawing.Size(400, 60);
            this.PasswordTextBoxSignIn.TabIndex = 0;
            // 
            // PasswordLabelSignIn
            // 
            this.PasswordLabelSignIn.AutoSize = true;
            this.PasswordLabelSignIn.Location = new System.Drawing.Point(155, 147);
            this.PasswordLabelSignIn.Name = "PasswordLabelSignIn";
            this.PasswordLabelSignIn.Size = new System.Drawing.Size(78, 20);
            this.PasswordLabelSignIn.TabIndex = 1;
            this.PasswordLabelSignIn.Text = "Password";
            // 
            // SignInButtonSignIn
            // 
            this.SignInButtonSignIn.BorderRadius = 12;
            this.SignInButtonSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SignInButtonSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SignInButtonSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignInButtonSignIn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignInButtonSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SignInButtonSignIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.SignInButtonSignIn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.SignInButtonSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButtonSignIn.ForeColor = System.Drawing.Color.White;
            this.SignInButtonSignIn.Location = new System.Drawing.Point(220, 260);
            this.SignInButtonSignIn.Name = "SignInButtonSignIn";
            this.SignInButtonSignIn.Size = new System.Drawing.Size(260, 60);
            this.SignInButtonSignIn.TabIndex = 3;
            this.SignInButtonSignIn.Text = "Sign In";
            // 
            // TitleLabelSignIn
            // 
            this.TitleLabelSignIn.AutoSize = true;
            this.TitleLabelSignIn.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabelSignIn.Font = new System.Drawing.Font("Stencil", 30F);
            this.TitleLabelSignIn.Location = new System.Drawing.Point(350, 80);
            this.TitleLabelSignIn.Name = "TitleLabelSignIn";
            this.TitleLabelSignIn.Size = new System.Drawing.Size(500, 71);
            this.TitleLabelSignIn.TabIndex = 1;
            this.TitleLabelSignIn.Text = "Movie Manager";
            // 
            // SignUpLinkLabelSignIn
            // 
            this.SignUpLinkLabelSignIn.AutoSize = true;
            this.SignUpLinkLabelSignIn.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.SignUpLinkLabelSignIn.Location = new System.Drawing.Point(410, 340);
            this.SignUpLinkLabelSignIn.Name = "SignUpLinkLabelSignIn";
            this.SignUpLinkLabelSignIn.Size = new System.Drawing.Size(70, 20);
            this.SignUpLinkLabelSignIn.TabIndex = 4;
            this.SignUpLinkLabelSignIn.TabStop = true;
            this.SignUpLinkLabelSignIn.Text = "Sign Up!";
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.BackgroundPanelSignIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.BackgroundPanelSignIn.ResumeLayout(false);
            this.BackgroundPanelSignIn.PerformLayout();
            this.SignInPanelSignIn.ResumeLayout(false);
            this.SignInPanelSignIn.PerformLayout();
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
        private System.Windows.Forms.Label TitleLabelSignIn;
        private System.Windows.Forms.LinkLabel SignUpLinkLabelSignIn;
    }
}

