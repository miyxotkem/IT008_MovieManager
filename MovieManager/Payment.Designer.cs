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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.OutsidePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Container = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.VoucherButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TitlePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddCustomerButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ReloadButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.ResetButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ExportButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ViewButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PayButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ContentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PaymentLabel = new System.Windows.Forms.Label();
            this.OutsidePanel.SuspendLayout();
            this.Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutsidePanel
            // 
            this.OutsidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.OutsidePanel.Controls.Add(this.Container);
            this.OutsidePanel.Controls.Add(this.PaymentLabel);
            this.OutsidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutsidePanel.Location = new System.Drawing.Point(0, 0);
            this.OutsidePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutsidePanel.Name = "OutsidePanel";
            this.OutsidePanel.Size = new System.Drawing.Size(1792, 1154);
            this.OutsidePanel.TabIndex = 0;
            this.OutsidePanel.Resize += new System.EventHandler(this.guna2Panel1_Resize);
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.Transparent;
            this.Container.BorderRadius = 40;
            this.Container.Controls.Add(this.VoucherButton);
            this.Container.Controls.Add(this.TitlePanel);
            this.Container.Controls.Add(this.AddCustomerButton);
            this.Container.Controls.Add(this.ReloadButton);
            this.Container.Controls.Add(this.NameLabel);
            this.Container.Controls.Add(this.TotalLabel);
            this.Container.Controls.Add(this.ResetButton);
            this.Container.Controls.Add(this.ExportButton);
            this.Container.Controls.Add(this.ViewButton);
            this.Container.Controls.Add(this.PayButton);
            this.Container.Controls.Add(this.ContentPanel);
            this.Container.Location = new System.Drawing.Point(195, 152);
            this.Container.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Container.Name = "Container";
            this.Container.ShadowDecoration.BorderRadius = 40;
            this.Container.ShadowDecoration.Enabled = true;
            this.Container.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.Container.Size = new System.Drawing.Size(1402, 978);
            this.Container.TabIndex = 12;
            // 
            // VoucherButton
            // 
            this.VoucherButton.Animated = true;
            this.VoucherButton.BackColor = System.Drawing.Color.Transparent;
            this.VoucherButton.BorderRadius = 4;
            this.VoucherButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.VoucherButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.VoucherButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.VoucherButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.VoucherButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.VoucherButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.VoucherButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.VoucherButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.VoucherButton.ForeColor = System.Drawing.Color.White;
            this.VoucherButton.Image = global::MovieManager.Properties.Resources.sell_30dp_BLACK_FILL0_wght400_GRAD0_opsz24;
            this.VoucherButton.ImageSize = new System.Drawing.Size(30, 30);
            this.VoucherButton.Location = new System.Drawing.Point(330, 886);
            this.VoucherButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VoucherButton.Name = "VoucherButton";
            this.VoucherButton.Size = new System.Drawing.Size(62, 62);
            this.VoucherButton.TabIndex = 15;
            this.VoucherButton.Click += new System.EventHandler(this.VoucherButton_Click);
            // 
            // TitlePanel
            // 
            this.TitlePanel.Location = new System.Drawing.Point(62, 65);
            this.TitlePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(1277, 105);
            this.TitlePanel.TabIndex = 11;
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Animated = true;
            this.AddCustomerButton.BackColor = System.Drawing.Color.Transparent;
            this.AddCustomerButton.BorderRadius = 4;
            this.AddCustomerButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddCustomerButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddCustomerButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddCustomerButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddCustomerButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddCustomerButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.AddCustomerButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.AddCustomerButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddCustomerButton.ForeColor = System.Drawing.Color.White;
            this.AddCustomerButton.Image = global::MovieManager.Properties.Resources.group_30dp_BLACK_FILL0_wght400_GRAD0_opsz24;
            this.AddCustomerButton.ImageSize = new System.Drawing.Size(30, 30);
            this.AddCustomerButton.Location = new System.Drawing.Point(409, 886);
            this.AddCustomerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(62, 62);
            this.AddCustomerButton.TabIndex = 14;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.Animated = true;
            this.ReloadButton.BackColor = System.Drawing.Color.Transparent;
            this.ReloadButton.BorderRadius = 4;
            this.ReloadButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ReloadButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ReloadButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ReloadButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ReloadButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ReloadButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ReloadButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.ReloadButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ReloadButton.ForeColor = System.Drawing.Color.White;
            this.ReloadButton.Image = ((System.Drawing.Image)(resources.GetObject("ReloadButton.Image")));
            this.ReloadButton.ImageSize = new System.Drawing.Size(30, 30);
            this.ReloadButton.Location = new System.Drawing.Point(251, 886);
            this.ReloadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(62, 62);
            this.ReloadButton.TabIndex = 13;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(58, 31);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(185, 20);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Customer\'s name: Guest";
            // 
            // TotalLabel
            // 
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(507, 810);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(832, 36);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "Total: 0";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.Animated = true;
            this.ResetButton.BackColor = System.Drawing.Color.Transparent;
            this.ResetButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ResetButton.BorderRadius = 12;
            this.ResetButton.BorderThickness = 1;
            this.ResetButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ResetButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ResetButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ResetButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ResetButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ResetButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ResetButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ResetButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.ResetButton.Location = new System.Drawing.Point(62, 886);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.ResetButton.Size = new System.Drawing.Size(172, 62);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
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
            this.ExportButton.Location = new System.Drawing.Point(773, 886);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.ExportButton.Size = new System.Drawing.Size(172, 62);
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
            this.ViewButton.Location = new System.Drawing.Point(970, 886);
            this.ViewButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.ViewButton.Size = new System.Drawing.Size(172, 62);
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
            this.PayButton.Location = new System.Drawing.Point(1167, 886);
            this.PayButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PayButton.Name = "PayButton";
            this.PayButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.PayButton.Size = new System.Drawing.Size(172, 62);
            this.PayButton.TabIndex = 5;
            this.PayButton.Text = "Pay";
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.ContentPanel.Location = new System.Drawing.Point(62, 178);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1278, 601);
            this.ContentPanel.TabIndex = 1;
            // 
            // PaymentLabel
            // 
            this.PaymentLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PaymentLabel.AutoSize = true;
            this.PaymentLabel.Font = new System.Drawing.Font("Stencil", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentLabel.Location = new System.Drawing.Point(697, 50);
            this.PaymentLabel.Name = "PaymentLabel";
            this.PaymentLabel.Size = new System.Drawing.Size(398, 61);
            this.PaymentLabel.TabIndex = 6;
            this.PaymentLabel.Text = "PAYMENT SITE";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OutsidePanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Payment";
            this.Size = new System.Drawing.Size(1792, 1154);
            this.Load += new System.EventHandler(this.Payment_Load);
            this.OutsidePanel.ResumeLayout(false);
            this.OutsidePanel.PerformLayout();
            this.Container.ResumeLayout(false);
            this.Container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel OutsidePanel;
        private System.Windows.Forms.Label PaymentLabel;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Container;
        private System.Windows.Forms.FlowLayoutPanel ContentPanel;
        private Guna.UI2.WinForms.Guna2GradientButton PayButton;
        private Guna.UI2.WinForms.Guna2GradientButton ExportButton;
        private Guna.UI2.WinForms.Guna2GradientButton ViewButton;
        private System.Windows.Forms.Label TotalLabel;
        private Guna.UI2.WinForms.Guna2GradientButton ReloadButton;
        private Guna.UI2.WinForms.Guna2GradientButton ResetButton;
        private Guna.UI2.WinForms.Guna2GradientButton AddCustomerButton;
        private System.Windows.Forms.Label NameLabel;
        private Guna.UI2.WinForms.Guna2GradientButton VoucherButton;
        private System.Windows.Forms.FlowLayoutPanel TitlePanel;
    }
}
