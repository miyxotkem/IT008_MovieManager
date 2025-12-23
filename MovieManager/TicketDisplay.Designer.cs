namespace MovieManager
{
    partial class TicketDisplay
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ManageSnack = new System.Windows.Forms.Label();
            this.ExportButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Container = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.TicketContain = new System.Windows.Forms.FlowLayoutPanel();
            this.BackButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel1.SuspendLayout();
            this.Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.Container);
            this.guna2Panel1.Controls.Add(this.ManageSnack);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1325, 900);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Resize += new System.EventHandler(this.guna2Panel1_Resize);
            // 
            // ManageSnack
            // 
            this.ManageSnack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ManageSnack.AutoSize = true;
            this.ManageSnack.Font = new System.Drawing.Font("Stencil", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageSnack.Location = new System.Drawing.Point(572, 24);
            this.ManageSnack.Name = "ManageSnack";
            this.ManageSnack.Size = new System.Drawing.Size(181, 52);
            this.ManageSnack.TabIndex = 5;
            this.ManageSnack.Text = "TICKET";
            // 
            // ExportButton
            // 
            this.ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportButton.Animated = true;
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
            this.ExportButton.Location = new System.Drawing.Point(980, 740);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.ExportButton.Size = new System.Drawing.Size(153, 50);
            this.ExportButton.TabIndex = 7;
            this.ExportButton.Text = "Export";
            // 
            // Container
            // 
            this.Container.BorderRadius = 20;
            this.Container.Controls.Add(this.BackButton);
            this.Container.Controls.Add(this.TicketContain);
            this.Container.Controls.Add(this.ExportButton);
            this.Container.FillColor = System.Drawing.Color.White;
            this.Container.FillColor2 = System.Drawing.Color.White;
            this.Container.Location = new System.Drawing.Point(75, 85);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(1175, 800);
            this.Container.TabIndex = 8;
            // 
            // TicketContain
            // 
            this.TicketContain.AutoScroll = true;
            this.TicketContain.Location = new System.Drawing.Point(32, 10);
            this.TicketContain.Name = "TicketContain";
            this.TicketContain.Size = new System.Drawing.Size(700, 780);
            this.TicketContain.TabIndex = 7;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.Animated = true;
            this.BackButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.BackButton.BorderRadius = 12;
            this.BackButton.BorderThickness = 1;
            this.BackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackButton.FillColor = System.Drawing.Color.Transparent;
            this.BackButton.FillColor2 = System.Drawing.Color.Transparent;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.BackButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.BackButton.Location = new System.Drawing.Point(779, 740);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.BackButton.Size = new System.Drawing.Size(153, 50);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TicketDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "TicketDisplay";
            this.Size = new System.Drawing.Size(1325, 900);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label ManageSnack;
        private Guna.UI2.WinForms.Guna2GradientPanel Container;
        private Guna.UI2.WinForms.Guna2GradientButton ExportButton;
        private System.Windows.Forms.FlowLayoutPanel TicketContain;
        private Guna.UI2.WinForms.Guna2GradientButton BackButton;
    }
}
