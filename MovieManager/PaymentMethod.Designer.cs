namespace MovieManager
{
    partial class PaymentMethod
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
            this.PaymentLabel = new System.Windows.Forms.Label();
            this.MethodPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.CashButton = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.BankButton = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.ApplePayButton = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.ExitButtonSignUp = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ConfirmButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.MethodPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PaymentLabel
            // 
            this.PaymentLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PaymentLabel.AutoSize = true;
            this.PaymentLabel.Font = new System.Drawing.Font("Stencil", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentLabel.Location = new System.Drawing.Point(85, 9);
            this.PaymentLabel.Name = "PaymentLabel";
            this.PaymentLabel.Size = new System.Drawing.Size(420, 52);
            this.PaymentLabel.TabIndex = 7;
            this.PaymentLabel.Text = "PAYMENT METHOD";
            // 
            // MethodPanel
            // 
            this.MethodPanel.BorderRadius = 20;
            this.MethodPanel.Controls.Add(this.ApplePayButton);
            this.MethodPanel.Controls.Add(this.BankButton);
            this.MethodPanel.Controls.Add(this.CashButton);
            this.MethodPanel.Location = new System.Drawing.Point(130, 92);
            this.MethodPanel.Name = "MethodPanel";
            this.MethodPanel.Size = new System.Drawing.Size(330, 221);
            this.MethodPanel.TabIndex = 8;
            // 
            // CashButton
            // 
            this.CashButton.BackColor = System.Drawing.Color.Transparent;
            this.CashButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CashButton.CheckedState.BorderThickness = 0;
            this.CashButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CashButton.CheckedState.InnerColor = System.Drawing.Color.White;
            this.CashButton.Location = new System.Drawing.Point(55, 25);
            this.CashButton.Name = "CashButton";
            this.CashButton.Size = new System.Drawing.Size(20, 20);
            this.CashButton.TabIndex = 0;
            this.CashButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CashButton.UncheckedState.BorderThickness = 2;
            this.CashButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.CashButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // BankButton
            // 
            this.BankButton.BackColor = System.Drawing.Color.Transparent;
            this.BankButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BankButton.CheckedState.BorderThickness = 0;
            this.BankButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BankButton.CheckedState.InnerColor = System.Drawing.Color.White;
            this.BankButton.Location = new System.Drawing.Point(55, 98);
            this.BankButton.Name = "BankButton";
            this.BankButton.Size = new System.Drawing.Size(20, 20);
            this.BankButton.TabIndex = 1;
            this.BankButton.Text = "guna2CustomRadioButton1";
            this.BankButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.BankButton.UncheckedState.BorderThickness = 2;
            this.BankButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.BankButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // ApplePayButton
            // 
            this.ApplePayButton.BackColor = System.Drawing.Color.Transparent;
            this.ApplePayButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ApplePayButton.CheckedState.BorderThickness = 0;
            this.ApplePayButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ApplePayButton.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ApplePayButton.Location = new System.Drawing.Point(55, 171);
            this.ApplePayButton.Name = "ApplePayButton";
            this.ApplePayButton.Size = new System.Drawing.Size(20, 20);
            this.ApplePayButton.TabIndex = 2;
            this.ApplePayButton.Text = "guna2CustomRadioButton1";
            this.ApplePayButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ApplePayButton.UncheckedState.BorderThickness = 2;
            this.ApplePayButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ApplePayButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // ExitButtonSignUp
            // 
            this.ExitButtonSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButtonSignUp.BackColor = System.Drawing.Color.Transparent;
            this.ExitButtonSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitButtonSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitButtonSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitButtonSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitButtonSignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.ExitButtonSignUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExitButtonSignUp.ForeColor = System.Drawing.Color.White;
            this.ExitButtonSignUp.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ExitButtonSignUp.Location = new System.Drawing.Point(554, 11);
            this.ExitButtonSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButtonSignUp.Name = "ExitButtonSignUp";
            this.ExitButtonSignUp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ExitButtonSignUp.Size = new System.Drawing.Size(24, 24);
            this.ExitButtonSignUp.TabIndex = 12;
            this.ExitButtonSignUp.Click += new System.EventHandler(this.ExitButtonSignUp_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmButton.Animated = true;
            this.ConfirmButton.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ConfirmButton.BorderRadius = 12;
            this.ConfirmButton.BorderThickness = 1;
            this.ConfirmButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ConfirmButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ConfirmButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ConfirmButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ConfirmButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ConfirmButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ConfirmButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.ConfirmButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConfirmButton.ForeColor = System.Drawing.Color.White;
            this.ConfirmButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ConfirmButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.ConfirmButton.Location = new System.Drawing.Point(219, 352);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.ConfirmButton.Size = new System.Drawing.Size(153, 50);
            this.ConfirmButton.TabIndex = 13;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // PaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.ExitButtonSignUp);
            this.Controls.Add(this.MethodPanel);
            this.Controls.Add(this.PaymentLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentMethod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentMethod";
            this.Load += new System.EventHandler(this.PaymentMethod_Load);
            this.Resize += new System.EventHandler(this.PaymentMethod_Resize);
            this.MethodPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PaymentLabel;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel MethodPanel;
        private Guna.UI2.WinForms.Guna2CustomRadioButton ApplePayButton;
        private Guna.UI2.WinForms.Guna2CustomRadioButton BankButton;
        private Guna.UI2.WinForms.Guna2CustomRadioButton CashButton;
        private Guna.UI2.WinForms.Guna2CircleButton ExitButtonSignUp;
        private Guna.UI2.WinForms.Guna2GradientButton ConfirmButton;
    }
}