namespace MovieManager
{
    partial class ForgetPassword
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
            this.PanelForgetPass = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.ResetPassLabelForgetPass = new System.Windows.Forms.Label();
            this.UsernameTextboxForgetPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.ContinueButtonForgetPass = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PreviousButtonForgetPass = new Guna.UI2.WinForms.Guna2GradientButton();
            this.UsernameLabelForgetPass = new System.Windows.Forms.Label();
            this.PanelForgetPass.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelForgetPass
            // 
            this.PanelForgetPass.BackColor = System.Drawing.Color.Transparent;
            this.PanelForgetPass.Controls.Add(this.ResetPassLabelForgetPass);
            this.PanelForgetPass.Controls.Add(this.guna2CustomGradientPanel1);
            this.PanelForgetPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForgetPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.PanelForgetPass.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.PanelForgetPass.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.PanelForgetPass.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.PanelForgetPass.Location = new System.Drawing.Point(0, 0);
            this.PanelForgetPass.Name = "PanelForgetPass";
            this.PanelForgetPass.Size = new System.Drawing.Size(902, 729);
            this.PanelForgetPass.TabIndex = 0;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 30;
            this.guna2CustomGradientPanel1.Controls.Add(this.UsernameLabelForgetPass);
            this.guna2CustomGradientPanel1.Controls.Add(this.PreviousButtonForgetPass);
            this.guna2CustomGradientPanel1.Controls.Add(this.ContinueButtonForgetPass);
            this.guna2CustomGradientPanel1.Controls.Add(this.UsernameTextboxForgetPass);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(158, 186);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(582, 424);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // ResetPassLabelForgetPass
            // 
            this.ResetPassLabelForgetPass.AutoSize = true;
            this.ResetPassLabelForgetPass.BackColor = System.Drawing.Color.Transparent;
            this.ResetPassLabelForgetPass.Font = new System.Drawing.Font("Stencil", 30F);
            this.ResetPassLabelForgetPass.Location = new System.Drawing.Point(228, 60);
            this.ResetPassLabelForgetPass.Name = "ResetPassLabelForgetPass";
            this.ResetPassLabelForgetPass.Size = new System.Drawing.Size(448, 59);
            this.ResetPassLabelForgetPass.TabIndex = 5;
            this.ResetPassLabelForgetPass.Text = "Reset Password";
            // 
            // UsernameTextboxForgetPass
            // 
            this.UsernameTextboxForgetPass.BorderRadius = 12;
            this.UsernameTextboxForgetPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTextboxForgetPass.DefaultText = "";
            this.UsernameTextboxForgetPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTextboxForgetPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTextboxForgetPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTextboxForgetPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTextboxForgetPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTextboxForgetPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UsernameTextboxForgetPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTextboxForgetPass.Location = new System.Drawing.Point(82, 94);
            this.UsernameTextboxForgetPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameTextboxForgetPass.Name = "UsernameTextboxForgetPass";
            this.UsernameTextboxForgetPass.PasswordChar = '\0';
            this.UsernameTextboxForgetPass.PlaceholderText = "";
            this.UsernameTextboxForgetPass.SelectedText = "";
            this.UsernameTextboxForgetPass.Size = new System.Drawing.Size(418, 48);
            this.UsernameTextboxForgetPass.TabIndex = 1;
            this.UsernameTextboxForgetPass.Enter += new System.EventHandler(this.UsernameTextboxForgetPass_Enter);
            this.UsernameTextboxForgetPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsernameTextboxForgetPass_KeyPress);
            this.UsernameTextboxForgetPass.Leave += new System.EventHandler(this.FullNameTextBoxSignUp_Leave);
            // 
            // ContinueButtonForgetPass
            // 
            this.ContinueButtonForgetPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ContinueButtonForgetPass.BorderRadius = 12;
            this.ContinueButtonForgetPass.BorderThickness = 1;
            this.ContinueButtonForgetPass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ContinueButtonForgetPass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ContinueButtonForgetPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ContinueButtonForgetPass.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ContinueButtonForgetPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ContinueButtonForgetPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ContinueButtonForgetPass.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.ContinueButtonForgetPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ContinueButtonForgetPass.ForeColor = System.Drawing.Color.White;
            this.ContinueButtonForgetPass.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ContinueButtonForgetPass.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.ContinueButtonForgetPass.HoverState.ForeColor = System.Drawing.Color.White;
            this.ContinueButtonForgetPass.Location = new System.Drawing.Point(198, 180);
            this.ContinueButtonForgetPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContinueButtonForgetPass.Name = "ContinueButtonForgetPass";
            this.ContinueButtonForgetPass.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.ContinueButtonForgetPass.Size = new System.Drawing.Size(206, 48);
            this.ContinueButtonForgetPass.TabIndex = 3;
            this.ContinueButtonForgetPass.Text = "Continue";
            this.ContinueButtonForgetPass.Click += new System.EventHandler(this.ContinueButtonForgetPass_Click);
            // 
            // PreviousButtonForgetPass
            // 
            this.PreviousButtonForgetPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.PreviousButtonForgetPass.BorderRadius = 12;
            this.PreviousButtonForgetPass.BorderThickness = 1;
            this.PreviousButtonForgetPass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PreviousButtonForgetPass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PreviousButtonForgetPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PreviousButtonForgetPass.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PreviousButtonForgetPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PreviousButtonForgetPass.FillColor = System.Drawing.Color.Empty;
            this.PreviousButtonForgetPass.FillColor2 = System.Drawing.Color.Empty;
            this.PreviousButtonForgetPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PreviousButtonForgetPass.ForeColor = System.Drawing.Color.Black;
            this.PreviousButtonForgetPass.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.PreviousButtonForgetPass.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.PreviousButtonForgetPass.HoverState.ForeColor = System.Drawing.Color.White;
            this.PreviousButtonForgetPass.Location = new System.Drawing.Point(198, 259);
            this.PreviousButtonForgetPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PreviousButtonForgetPass.Name = "PreviousButtonForgetPass";
            this.PreviousButtonForgetPass.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.PreviousButtonForgetPass.Size = new System.Drawing.Size(206, 48);
            this.PreviousButtonForgetPass.TabIndex = 4;
            this.PreviousButtonForgetPass.Text = "Previous";
            this.PreviousButtonForgetPass.Click += new System.EventHandler(this.PreviousButtonForgetPass_Click);
            // 
            // UsernameLabelForgetPass
            // 
            this.UsernameLabelForgetPass.AutoSize = true;
            this.UsernameLabelForgetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabelForgetPass.Location = new System.Drawing.Point(99, 58);
            this.UsernameLabelForgetPass.Name = "UsernameLabelForgetPass";
            this.UsernameLabelForgetPass.Size = new System.Drawing.Size(213, 20);
            this.UsernameLabelForgetPass.TabIndex = 5;
            this.UsernameLabelForgetPass.Text = "Enter your username below";
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 729);
            this.Controls.Add(this.PanelForgetPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forget Password";
            this.PanelForgetPass.ResumeLayout(false);
            this.PanelForgetPass.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel PanelForgetPass;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label ResetPassLabelForgetPass;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTextboxForgetPass;
        private Guna.UI2.WinForms.Guna2GradientButton ContinueButtonForgetPass;
        private Guna.UI2.WinForms.Guna2GradientButton PreviousButtonForgetPass;
        private System.Windows.Forms.Label UsernameLabelForgetPass;
    }
}