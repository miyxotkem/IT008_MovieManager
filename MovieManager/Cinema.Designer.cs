namespace MovieManager
{
    partial class Cinema
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
            this.MovieDisplayFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShadowCinema = new Siticone.Desktop.UI.WinForms.SiticoneShadowForm(this.components);
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.SuspendLayout();
            // 
            // MovieDisplayFlowLayoutPanel
            // 
            this.MovieDisplayFlowLayoutPanel.AutoScroll = true;
            this.MovieDisplayFlowLayoutPanel.Location = new System.Drawing.Point(128, 46);
            this.MovieDisplayFlowLayoutPanel.Name = "MovieDisplayFlowLayoutPanel";
            this.MovieDisplayFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.MovieDisplayFlowLayoutPanel.Size = new System.Drawing.Size(1792, 1154);
            this.MovieDisplayFlowLayoutPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 46);
            this.panel1.TabIndex = 1;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 46);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(133, 1154);
            this.siticonePanel1.TabIndex = 0;
            // 
            // Cinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1200);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MovieDisplayFlowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cinema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinema";
            this.Load += new System.EventHandler(this.Cinema_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MovieDisplayFlowLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneShadowForm ShadowCinema;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
    }
}