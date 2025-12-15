namespace MovieManager
{
    partial class CustomerInput
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ConfirmButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ExitButtonSignUp = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.guna2Panel1.Controls.Add(this.ExitButtonSignUp);
            this.guna2Panel1.Controls.Add(this.ConfirmButton);
            this.guna2Panel1.Controls.Add(this.PhoneNumberLabel);
            this.guna2Panel1.Controls.Add(this.PhoneNumberTextBox);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(528, 238);
            this.guna2Panel1.TabIndex = 0;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(69, 58);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(97, 16);
            this.PhoneNumberLabel.TabIndex = 5;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.BorderRadius = 12;
            this.PhoneNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneNumberTextBox.DefaultText = "";
            this.PhoneNumberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PhoneNumberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PhoneNumberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneNumberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneNumberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PhoneNumberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(60, 76);
            this.PhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.PasswordChar = '\0';
            this.PhoneNumberTextBox.PlaceholderText = "";
            this.PhoneNumberTextBox.SelectedText = "";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(409, 48);
            this.PhoneNumberTextBox.TabIndex = 6;
            this.PhoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberTextBox_KeyPress);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Animated = true;
            this.ConfirmButton.BorderRadius = 14;
            this.ConfirmButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ConfirmButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ConfirmButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ConfirmButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ConfirmButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ConfirmButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ConfirmButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.ConfirmButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConfirmButton.ForeColor = System.Drawing.Color.White;
            this.ConfirmButton.Location = new System.Drawing.Point(178, 155);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(172, 48);
            this.ConfirmButton.TabIndex = 9;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ExitButtonSignUp
            // 
            this.ExitButtonSignUp.BackColor = System.Drawing.Color.Transparent;
            this.ExitButtonSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitButtonSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitButtonSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitButtonSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitButtonSignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.ExitButtonSignUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExitButtonSignUp.ForeColor = System.Drawing.Color.White;
            this.ExitButtonSignUp.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ExitButtonSignUp.Location = new System.Drawing.Point(492, 11);
            this.ExitButtonSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButtonSignUp.Name = "ExitButtonSignUp";
            this.ExitButtonSignUp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ExitButtonSignUp.Size = new System.Drawing.Size(24, 24);
            this.ExitButtonSignUp.TabIndex = 10;
            this.ExitButtonSignUp.Click += new System.EventHandler(this.ExitButtonSignUp_Click);
            // 
            // CustomerInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 238);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private Guna.UI2.WinForms.Guna2TextBox PhoneNumberTextBox;
        private Guna.UI2.WinForms.Guna2GradientButton ConfirmButton;
        private Guna.UI2.WinForms.Guna2CircleButton ExitButtonSignUp;
    }
}