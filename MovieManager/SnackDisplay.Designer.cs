namespace MovieManager
{
    partial class SnackDisplay
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
            this.SnackDisplayFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // SnackDisplayFlowLayoutPanel
            // 
            this.SnackDisplayFlowLayoutPanel.AutoScroll = true;
            this.SnackDisplayFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SnackDisplayFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.SnackDisplayFlowLayoutPanel.Name = "SnackDisplayFlowLayoutPanel";
            this.SnackDisplayFlowLayoutPanel.Size = new System.Drawing.Size(1792, 1154);
            this.SnackDisplayFlowLayoutPanel.TabIndex = 0;
            // 
            // SnackDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SnackDisplayFlowLayoutPanel);
            this.Name = "SnackDisplay";
            this.Size = new System.Drawing.Size(1792, 1154);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SnackDisplayFlowLayoutPanel;
    }
}
