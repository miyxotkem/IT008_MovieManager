namespace MovieManager
{
    partial class SelectMovie
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
            this.BackButtonSelectMovie = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TitleSelectMovie = new System.Windows.Forms.Label();
            this.ScreenPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.StartTimePanelSelectMovie = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // BackButtonSelectMovie
            // 
            this.BackButtonSelectMovie.Animated = true;
            this.BackButtonSelectMovie.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.BackButtonSelectMovie.BorderRadius = 12;
            this.BackButtonSelectMovie.BorderThickness = 1;
            this.BackButtonSelectMovie.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackButtonSelectMovie.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackButtonSelectMovie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackButtonSelectMovie.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackButtonSelectMovie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackButtonSelectMovie.FillColor = System.Drawing.Color.Transparent;
            this.BackButtonSelectMovie.FillColor2 = System.Drawing.Color.Transparent;
            this.BackButtonSelectMovie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BackButtonSelectMovie.ForeColor = System.Drawing.Color.Black;
            this.BackButtonSelectMovie.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.BackButtonSelectMovie.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.BackButtonSelectMovie.Location = new System.Drawing.Point(25, 25);
            this.BackButtonSelectMovie.Name = "BackButtonSelectMovie";
            this.BackButtonSelectMovie.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.BackButtonSelectMovie.Size = new System.Drawing.Size(172, 62);
            this.BackButtonSelectMovie.TabIndex = 0;
            this.BackButtonSelectMovie.Text = "Back";
            this.BackButtonSelectMovie.Click += new System.EventHandler(this.BackButtonSelectMovie_Click);
            // 
            // TitleSelectMovie
            // 
            this.TitleSelectMovie.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleSelectMovie.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleSelectMovie.Location = new System.Drawing.Point(0, 0);
            this.TitleSelectMovie.Name = "TitleSelectMovie";
            this.TitleSelectMovie.Size = new System.Drawing.Size(1792, 83);
            this.TitleSelectMovie.TabIndex = 1;
            this.TitleSelectMovie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScreenPanel
            // 
            this.ScreenPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScreenPanel.BackColor = System.Drawing.Color.Transparent;
            this.ScreenPanel.FillColor = System.Drawing.Color.White;
            this.ScreenPanel.Location = new System.Drawing.Point(792, 93);
            this.ScreenPanel.Name = "ScreenPanel";
            this.ScreenPanel.ShadowColor = System.Drawing.Color.Black;
            this.ScreenPanel.Size = new System.Drawing.Size(984, 1045);
            this.ScreenPanel.TabIndex = 3;
            // 
            // StartTimePanelSelectMovie
            // 
            this.StartTimePanelSelectMovie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StartTimePanelSelectMovie.Location = new System.Drawing.Point(25, 93);
            this.StartTimePanelSelectMovie.Name = "StartTimePanelSelectMovie";
            this.StartTimePanelSelectMovie.Size = new System.Drawing.Size(761, 1045);
            this.StartTimePanelSelectMovie.TabIndex = 0;
            // 
            // SelectMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StartTimePanelSelectMovie);
            this.Controls.Add(this.ScreenPanel);
            this.Controls.Add(this.BackButtonSelectMovie);
            this.Controls.Add(this.TitleSelectMovie);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "SelectMovie";
            this.Size = new System.Drawing.Size(1792, 1154);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton BackButtonSelectMovie;
        private System.Windows.Forms.Label TitleSelectMovie;
        private Guna.UI2.WinForms.Guna2ShadowPanel ScreenPanel;
        private System.Windows.Forms.FlowLayoutPanel StartTimePanelSelectMovie;
    }
}
