namespace MovieManager
{
    partial class Payment
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
            this.OutsidePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Container = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.ExportButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ViewButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PayButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ContentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ExitButtonSignUp = new Guna.UI2.WinForms.Guna2CircleButton();
            this.PaymentLabel = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.OutsidePanel.SuspendLayout();
            this.Container.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutsidePanel
            // 
            this.OutsidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.OutsidePanel.Controls.Add(this.Container);
            this.OutsidePanel.Controls.Add(this.ExitButtonSignUp);
            this.OutsidePanel.Controls.Add(this.PaymentLabel);
            this.OutsidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutsidePanel.Location = new System.Drawing.Point(0, 0);
            this.OutsidePanel.Name = "OutsidePanel";
            this.OutsidePanel.Size = new System.Drawing.Size(1593, 923);
            this.OutsidePanel.TabIndex = 0;
            this.OutsidePanel.Resize += new System.EventHandler(this.guna2Panel1_Resize);
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.Transparent;
            this.Container.BorderRadius = 20;
            this.Container.Controls.Add(this.guna2CustomGradientPanel1);
            this.Container.Controls.Add(this.ExportButton);
            this.Container.Controls.Add(this.ViewButton);
            this.Container.Controls.Add(this.PayButton);
            this.Container.Controls.Add(this.ContentPanel);
            this.Container.Location = new System.Drawing.Point(173, 122);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(1246, 782);
            this.Container.TabIndex = 12;
            // 
            // ExportButton
            // 
            this.ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportButton.Animated = true;
            this.ExportButton.BackColor = System.Drawing.Color.Transparent;
            this.ExportButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ExportButton.BorderRadius = 12;
            this.ExportButton.BorderThickness = 1;
            this.ExportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExportButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExportButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ExportButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.ExportButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExportButton.ForeColor = System.Drawing.Color.White;
            this.ExportButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ExportButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.ExportButton.Location = new System.Drawing.Point(687, 709);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.ExportButton.Size = new System.Drawing.Size(153, 50);
            this.ExportButton.TabIndex = 7;
            this.ExportButton.Text = "Export";
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewButton.Animated = true;
            this.ViewButton.BackColor = System.Drawing.Color.Transparent;
            this.ViewButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ViewButton.BorderRadius = 12;
            this.ViewButton.BorderThickness = 1;
            this.ViewButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ViewButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ViewButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ViewButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ViewButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ViewButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ViewButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.ViewButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ViewButton.ForeColor = System.Drawing.Color.White;
            this.ViewButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ViewButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.ViewButton.Location = new System.Drawing.Point(862, 709);
            this.ViewButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.ViewButton.Size = new System.Drawing.Size(153, 50);
            this.ViewButton.TabIndex = 6;
            this.ViewButton.Text = "View Ticket";
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // PayButton
            // 
            this.PayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PayButton.Animated = true;
            this.PayButton.BackColor = System.Drawing.Color.Transparent;
            this.PayButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.PayButton.BorderRadius = 12;
            this.PayButton.BorderThickness = 1;
            this.PayButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PayButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PayButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PayButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PayButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PayButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.PayButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.PayButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PayButton.ForeColor = System.Drawing.Color.White;
            this.PayButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.PayButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.PayButton.Location = new System.Drawing.Point(1037, 709);
            this.PayButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PayButton.Name = "PayButton";
            this.PayButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.PayButton.Size = new System.Drawing.Size(153, 50);
            this.PayButton.TabIndex = 5;
            this.PayButton.Text = "Pay";
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.ContentPanel.Location = new System.Drawing.Point(55, 24);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1136, 599);
            this.ContentPanel.TabIndex = 1;
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
            this.ExitButtonSignUp.Location = new System.Drawing.Point(1556, 13);
            this.ExitButtonSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButtonSignUp.Name = "ExitButtonSignUp";
            this.ExitButtonSignUp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ExitButtonSignUp.Size = new System.Drawing.Size(24, 24);
            this.ExitButtonSignUp.TabIndex = 11;
            this.ExitButtonSignUp.Click += new System.EventHandler(this.ExitButtonSignUp_Click);
            // 
            // PaymentLabel
            // 
            this.PaymentLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PaymentLabel.AutoSize = true;
            this.PaymentLabel.Font = new System.Drawing.Font("Stencil", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentLabel.Location = new System.Drawing.Point(628, 32);
            this.PaymentLabel.Name = "PaymentLabel";
            this.PaymentLabel.Size = new System.Drawing.Size(336, 52);
            this.PaymentLabel.TabIndex = 6;
            this.PaymentLabel.Text = "PAYMENT SITE";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.Controls.Add(this.TotalLabel);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(835, 635);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(356, 59);
            this.guna2CustomGradientPanel1.TabIndex = 8;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(3, 15);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(105, 29);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "Total: 0";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OutsidePanel);
            this.Name = "Payment";
            this.Size = new System.Drawing.Size(1593, 923);
            this.Load += new System.EventHandler(this.Payment_Load);
            this.OutsidePanel.ResumeLayout(false);
            this.OutsidePanel.PerformLayout();
            this.Container.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel OutsidePanel;
        private System.Windows.Forms.Label PaymentLabel;
        private Guna.UI2.WinForms.Guna2CircleButton ExitButtonSignUp;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Container;
        private System.Windows.Forms.FlowLayoutPanel ContentPanel;
        private Guna.UI2.WinForms.Guna2GradientButton PayButton;
        private Guna.UI2.WinForms.Guna2GradientButton ExportButton;
        private Guna.UI2.WinForms.Guna2GradientButton ViewButton;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label TotalLabel;
    }
}
