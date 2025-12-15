namespace MovieManager
{
    partial class MovieDisplay
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
            this.MovieDisplayFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // MovieDisplayFlowLayoutPanel
            // 
            this.MovieDisplayFlowLayoutPanel.AutoScroll = true;
            this.MovieDisplayFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieDisplayFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MovieDisplayFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MovieDisplayFlowLayoutPanel.Name = "MovieDisplayFlowLayoutPanel";
            this.MovieDisplayFlowLayoutPanel.Size = new System.Drawing.Size(1593, 923);
            this.MovieDisplayFlowLayoutPanel.TabIndex = 0;
            // 
            // MovieDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MovieDisplayFlowLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MovieDisplay";
            this.Size = new System.Drawing.Size(1593, 923);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MovieDisplayFlowLayoutPanel;
    }
}
