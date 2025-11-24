namespace MovieManager
{
    partial class ResetPassConfirm
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
            this.PanelForgetPass = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.ResetPassLabelForgetPass = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.PassLabelResetPass = new System.Windows.Forms.Label();
            this.ResetButtonConfirmPass = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PassTextboxConfirmPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.RetypeLabelConfirmPass = new System.Windows.Forms.Label();
            this.RetypeTextboxConfirmPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.epNewPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.epRetypePass = new System.Windows.Forms.ErrorProvider(this.components);
            this.PreviousButtonForgetVerify = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PanelForgetPass.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRetypePass)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelForgetPass
            // 
            this.PanelForgetPass.BackColor = System.Drawing.Color.Transparent;
            this.PanelForgetPass.Controls.Add(this.PreviousButtonForgetVerify);
            this.PanelForgetPass.Controls.Add(this.ResetPassLabelForgetPass);
            this.PanelForgetPass.Controls.Add(this.guna2CustomGradientPanel1);
            this.PanelForgetPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForgetPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.PanelForgetPass.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.PanelForgetPass.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.PanelForgetPass.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.PanelForgetPass.Location = new System.Drawing.Point(0, 0);
            this.PanelForgetPass.Name = "PanelForgetPass";
            this.PanelForgetPass.Size = new System.Drawing.Size(889, 559);
            this.PanelForgetPass.TabIndex = 1;
            // 
            // ResetPassLabelForgetPass
            // 
            this.ResetPassLabelForgetPass.AutoSize = true;
            this.ResetPassLabelForgetPass.BackColor = System.Drawing.Color.Transparent;
            this.ResetPassLabelForgetPass.Font = new System.Drawing.Font("Stencil", 30F);
            this.ResetPassLabelForgetPass.Location = new System.Drawing.Point(205, 60);
            this.ResetPassLabelForgetPass.Name = "ResetPassLabelForgetPass";
            this.ResetPassLabelForgetPass.Size = new System.Drawing.Size(448, 59);
            this.ResetPassLabelForgetPass.TabIndex = 5;
            this.ResetPassLabelForgetPass.Text = "PASSWORD RESET";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 30;
            this.guna2CustomGradientPanel1.Controls.Add(this.RetypeLabelConfirmPass);
            this.guna2CustomGradientPanel1.Controls.Add(this.RetypeTextboxConfirmPass);
            this.guna2CustomGradientPanel1.Controls.Add(this.PassLabelResetPass);
            this.guna2CustomGradientPanel1.Controls.Add(this.ResetButtonConfirmPass);
            this.guna2CustomGradientPanel1.Controls.Add(this.PassTextboxConfirmPass);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(154, 152);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.BorderRadius = 30;
            this.guna2CustomGradientPanel1.ShadowDecoration.Enabled = true;
            this.guna2CustomGradientPanel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(582, 340);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // PassLabelResetPass
            // 
            this.PassLabelResetPass.AutoSize = true;
            this.PassLabelResetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabelResetPass.Location = new System.Drawing.Point(97, 51);
            this.PassLabelResetPass.Name = "PassLabelResetPass";
            this.PassLabelResetPass.Size = new System.Drawing.Size(161, 20);
            this.PassLabelResetPass.TabIndex = 5;
            this.PassLabelResetPass.Text = "Enter new password";
            // 
            // ResetButtonConfirmPass
            // 
            this.ResetButtonConfirmPass.Animated = true;
            this.ResetButtonConfirmPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ResetButtonConfirmPass.BorderRadius = 12;
            this.ResetButtonConfirmPass.BorderThickness = 1;
            this.ResetButtonConfirmPass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ResetButtonConfirmPass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ResetButtonConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ResetButtonConfirmPass.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ResetButtonConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ResetButtonConfirmPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ResetButtonConfirmPass.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.ResetButtonConfirmPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ResetButtonConfirmPass.ForeColor = System.Drawing.Color.White;
            this.ResetButtonConfirmPass.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ResetButtonConfirmPass.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.ResetButtonConfirmPass.HoverState.ForeColor = System.Drawing.Color.White;
            this.ResetButtonConfirmPass.Location = new System.Drawing.Point(188, 275);
            this.ResetButtonConfirmPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResetButtonConfirmPass.Name = "ResetButtonConfirmPass";
            this.ResetButtonConfirmPass.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.ResetButtonConfirmPass.Size = new System.Drawing.Size(206, 48);
            this.ResetButtonConfirmPass.TabIndex = 3;
            this.ResetButtonConfirmPass.Text = "Reset";
            this.ResetButtonConfirmPass.Click += new System.EventHandler(this.ResetButtonConfirmPass_Click);
            // 
            // PassTextboxConfirmPass
            // 
            this.PassTextboxConfirmPass.BorderRadius = 12;
            this.PassTextboxConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassTextboxConfirmPass.DefaultText = "";
            this.PassTextboxConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PassTextboxConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PassTextboxConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PassTextboxConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PassTextboxConfirmPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PassTextboxConfirmPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PassTextboxConfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PassTextboxConfirmPass.Location = new System.Drawing.Point(82, 84);
            this.PassTextboxConfirmPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PassTextboxConfirmPass.Name = "PassTextboxConfirmPass";
            this.PassTextboxConfirmPass.PasswordChar = '●';
            this.PassTextboxConfirmPass.PlaceholderText = "";
            this.PassTextboxConfirmPass.SelectedText = "";
            this.PassTextboxConfirmPass.Size = new System.Drawing.Size(418, 48);
            this.PassTextboxConfirmPass.TabIndex = 1;
            this.PassTextboxConfirmPass.UseSystemPasswordChar = true;
            this.PassTextboxConfirmPass.TextChanged += new System.EventHandler(this.PassTextboxConfirmPass_TextChanged);
            this.PassTextboxConfirmPass.Enter += new System.EventHandler(this.PassTextboxConfirmPass_Enter);
            this.PassTextboxConfirmPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassTextboxConfirmPass_KeyPress);
            // 
            // RetypeLabelConfirmPass
            // 
            this.RetypeLabelConfirmPass.AutoSize = true;
            this.RetypeLabelConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetypeLabelConfirmPass.Location = new System.Drawing.Point(97, 155);
            this.RetypeLabelConfirmPass.Name = "RetypeLabelConfirmPass";
            this.RetypeLabelConfirmPass.Size = new System.Drawing.Size(179, 20);
            this.RetypeLabelConfirmPass.TabIndex = 7;
            this.RetypeLabelConfirmPass.Text = "Re-type new password";
            // 
            // RetypeTextboxConfirmPass
            // 
            this.RetypeTextboxConfirmPass.BorderRadius = 12;
            this.RetypeTextboxConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RetypeTextboxConfirmPass.DefaultText = "";
            this.RetypeTextboxConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RetypeTextboxConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RetypeTextboxConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RetypeTextboxConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RetypeTextboxConfirmPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RetypeTextboxConfirmPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RetypeTextboxConfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RetypeTextboxConfirmPass.Location = new System.Drawing.Point(82, 188);
            this.RetypeTextboxConfirmPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RetypeTextboxConfirmPass.Name = "RetypeTextboxConfirmPass";
            this.RetypeTextboxConfirmPass.PasswordChar = '●';
            this.RetypeTextboxConfirmPass.PlaceholderText = "";
            this.RetypeTextboxConfirmPass.SelectedText = "";
            this.RetypeTextboxConfirmPass.Size = new System.Drawing.Size(418, 48);
            this.RetypeTextboxConfirmPass.TabIndex = 6;
            this.RetypeTextboxConfirmPass.UseSystemPasswordChar = true;
            this.RetypeTextboxConfirmPass.Enter += new System.EventHandler(this.RetypeTextboxConfirmPass_Enter);
            this.RetypeTextboxConfirmPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RetypeTextboxConfirmPass_KeyPress);
            // 
            // epNewPass
            // 
            this.epNewPass.ContainerControl = this;
            // 
            // epRetypePass
            // 
            this.epRetypePass.ContainerControl = this;
            // 
            // PreviousButtonForgetVerify
            // 
            this.PreviousButtonForgetVerify.BackColor = System.Drawing.Color.Transparent;
            this.PreviousButtonForgetVerify.BorderColor = System.Drawing.Color.Empty;
            this.PreviousButtonForgetVerify.BorderRadius = 12;
            this.PreviousButtonForgetVerify.BorderThickness = 1;
            this.PreviousButtonForgetVerify.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PreviousButtonForgetVerify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PreviousButtonForgetVerify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PreviousButtonForgetVerify.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PreviousButtonForgetVerify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PreviousButtonForgetVerify.FillColor = System.Drawing.Color.White;
            this.PreviousButtonForgetVerify.FillColor2 = System.Drawing.Color.White;
            this.PreviousButtonForgetVerify.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PreviousButtonForgetVerify.ForeColor = System.Drawing.Color.Black;
            this.PreviousButtonForgetVerify.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.PreviousButtonForgetVerify.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.PreviousButtonForgetVerify.HoverState.ForeColor = System.Drawing.Color.White;
            this.PreviousButtonForgetVerify.Image = global::MovieManager.Properties.Resources.arrow_back_ios_24dp_BLACK_FILL0_wght400_GRAD0_opsz24;
            this.PreviousButtonForgetVerify.Location = new System.Drawing.Point(11, 9);
            this.PreviousButtonForgetVerify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PreviousButtonForgetVerify.Name = "PreviousButtonForgetVerify";
            this.PreviousButtonForgetVerify.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.PreviousButtonForgetVerify.ShadowDecoration.BorderRadius = 12;
            this.PreviousButtonForgetVerify.ShadowDecoration.Enabled = true;
            this.PreviousButtonForgetVerify.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.PreviousButtonForgetVerify.Size = new System.Drawing.Size(44, 40);
            this.PreviousButtonForgetVerify.TabIndex = 5;
            this.PreviousButtonForgetVerify.Click += new System.EventHandler(this.PreviousButtonForgetVerify_Click);
            // 
            // ResetPassConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 559);
            this.Controls.Add(this.PanelForgetPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetPassConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassConfirm";
            this.PanelForgetPass.ResumeLayout(false);
            this.PanelForgetPass.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRetypePass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel PanelForgetPass;
        private Guna.UI2.WinForms.Guna2GradientButton PreviousButtonForgetVerify;
        private System.Windows.Forms.Label ResetPassLabelForgetPass;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label PassLabelResetPass;
        private Guna.UI2.WinForms.Guna2GradientButton ResetButtonConfirmPass;
        private Guna.UI2.WinForms.Guna2TextBox PassTextboxConfirmPass;
        private System.Windows.Forms.Label RetypeLabelConfirmPass;
        private Guna.UI2.WinForms.Guna2TextBox RetypeTextboxConfirmPass;
        private System.Windows.Forms.ErrorProvider epNewPass;
        private System.Windows.Forms.ErrorProvider epRetypePass;
    }
}