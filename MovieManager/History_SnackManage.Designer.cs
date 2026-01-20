namespace MovieManager
{
    partial class History_SnackManage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.HistoryLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.HistoryLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 1000);
            this.panel1.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ExitButton.Location = new System.Drawing.Point(1458, 15);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ExitButton.Size = new System.Drawing.Size(30, 30);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderRadius = 50;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.FLP);
            this.panel2.Location = new System.Drawing.Point(287, 144);
            this.panel2.Name = "panel2";
            this.panel2.ShadowDecoration.BorderRadius = 50;
            this.panel2.ShadowDecoration.Enabled = true;
            this.panel2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(926, 973);
            this.panel2.TabIndex = 6;
            // 
            // FLP
            // 
            this.FLP.BackColor = System.Drawing.Color.White;
            this.FLP.Location = new System.Drawing.Point(24, 117);
            this.FLP.Name = "FLP";
            this.FLP.Size = new System.Drawing.Size(879, 736);
            this.FLP.TabIndex = 0;
            // 
            // HistoryLabel
            // 
            this.HistoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HistoryLabel.AutoSize = true;
            this.HistoryLabel.Font = new System.Drawing.Font("Stencil", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryLabel.Location = new System.Drawing.Point(516, 42);
            this.HistoryLabel.Name = "HistoryLabel";
            this.HistoryLabel.Size = new System.Drawing.Size(469, 61);
            this.HistoryLabel.TabIndex = 5;
            this.HistoryLabel.Text = "Import History";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(24, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(878, 69);
            this.panel3.TabIndex = 1;
            // 
            // History_SnackManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "History_SnackManage";
            this.Size = new System.Drawing.Size(1500, 1000);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HistoryLabel;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel2;
        private System.Windows.Forms.FlowLayoutPanel FLP;
        private Guna.UI2.WinForms.Guna2CircleButton ExitButton;
        private System.Windows.Forms.Panel panel3;
    }
}
