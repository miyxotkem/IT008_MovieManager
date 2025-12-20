namespace MovieManager
{
    partial class AddShowTime
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
            this.ScreenCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.ScreenLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.MovieLabel = new System.Windows.Forms.Label();
            this.CancelButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ApplyButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PosterPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.EndTimeTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.DurationCB = new Guna.UI2.WinForms.Guna2TextBox();
            this.StartTimeDTP = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ToDTP = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.FromDTP = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.MovieCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PosterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ScreenCB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ToLabel);
            this.panel1.Controls.Add(this.FromLabel);
            this.panel1.Controls.Add(this.StartTimeLabel);
            this.panel1.Controls.Add(this.ScreenLabel);
            this.panel1.Controls.Add(this.DurationLabel);
            this.panel1.Controls.Add(this.MovieLabel);
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.ApplyButton);
            this.panel1.Controls.Add(this.PosterPictureBox);
            this.panel1.Controls.Add(this.EndTimeTB);
            this.panel1.Controls.Add(this.DurationCB);
            this.panel1.Controls.Add(this.StartTimeDTP);
            this.panel1.Controls.Add(this.ToDTP);
            this.panel1.Controls.Add(this.FromDTP);
            this.panel1.Controls.Add(this.MovieCB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 800);
            this.panel1.TabIndex = 0;
            // 
            // ScreenCB
            // 
            this.ScreenCB.BackColor = System.Drawing.Color.Transparent;
            this.ScreenCB.BorderRadius = 12;
            this.ScreenCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ScreenCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScreenCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ScreenCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ScreenCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ScreenCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ScreenCB.ItemHeight = 30;
            this.ScreenCB.Items.AddRange(new object[] {
            "Screen 1",
            "Screen 2",
            "Screen 3"});
            this.ScreenCB.Location = new System.Drawing.Point(1010, 200);
            this.ScreenCB.Name = "ScreenCB";
            this.ScreenCB.Size = new System.Drawing.Size(250, 36);
            this.ScreenCB.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1020, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "End Time";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(810, 480);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(27, 20);
            this.ToLabel.TabIndex = 10;
            this.ToLabel.Text = "To";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(810, 380);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(46, 20);
            this.FromLabel.TabIndex = 10;
            this.FromLabel.Text = "From";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Location = new System.Drawing.Point(810, 280);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(82, 20);
            this.StartTimeLabel.TabIndex = 10;
            this.StartTimeLabel.Text = "Start Time";
            // 
            // ScreenLabel
            // 
            this.ScreenLabel.AutoSize = true;
            this.ScreenLabel.Location = new System.Drawing.Point(1020, 180);
            this.ScreenLabel.Name = "ScreenLabel";
            this.ScreenLabel.Size = new System.Drawing.Size(60, 20);
            this.ScreenLabel.TabIndex = 10;
            this.ScreenLabel.Text = "Screen";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(810, 180);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(70, 20);
            this.DurationLabel.TabIndex = 10;
            this.DurationLabel.Text = "Duration";
            // 
            // MovieLabel
            // 
            this.MovieLabel.AutoSize = true;
            this.MovieLabel.Location = new System.Drawing.Point(810, 80);
            this.MovieLabel.Name = "MovieLabel";
            this.MovieLabel.Size = new System.Drawing.Size(50, 20);
            this.MovieLabel.TabIndex = 10;
            this.MovieLabel.Text = "Movie";
            // 
            // CancelButton
            // 
            this.CancelButton.Animated = true;
            this.CancelButton.BorderRadius = 14;
            this.CancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.CancelButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(1245, 683);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(193, 76);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Animated = true;
            this.ApplyButton.BorderRadius = 14;
            this.ApplyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ApplyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ApplyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ApplyButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ApplyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ApplyButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ApplyButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.ApplyButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ApplyButton.ForeColor = System.Drawing.Color.White;
            this.ApplyButton.Location = new System.Drawing.Point(1023, 683);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(193, 76);
            this.ApplyButton.TabIndex = 9;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // PosterPictureBox
            // 
            this.PosterPictureBox.BorderRadius = 12;
            this.PosterPictureBox.ImageRotate = 0F;
            this.PosterPictureBox.Location = new System.Drawing.Point(200, 100);
            this.PosterPictureBox.Name = "PosterPictureBox";
            this.PosterPictureBox.Size = new System.Drawing.Size(460, 560);
            this.PosterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PosterPictureBox.TabIndex = 7;
            this.PosterPictureBox.TabStop = false;
            // 
            // EndTimeTB
            // 
            this.EndTimeTB.BorderRadius = 12;
            this.EndTimeTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EndTimeTB.DefaultText = "";
            this.EndTimeTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EndTimeTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EndTimeTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EndTimeTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EndTimeTB.Enabled = false;
            this.EndTimeTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EndTimeTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EndTimeTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EndTimeTB.Location = new System.Drawing.Point(1010, 300);
            this.EndTimeTB.Name = "EndTimeTB";
            this.EndTimeTB.PasswordChar = '\0';
            this.EndTimeTB.PlaceholderText = "";
            this.EndTimeTB.SelectedText = "";
            this.EndTimeTB.Size = new System.Drawing.Size(250, 60);
            this.EndTimeTB.TabIndex = 2;
            // 
            // DurationCB
            // 
            this.DurationCB.BorderRadius = 12;
            this.DurationCB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DurationCB.DefaultText = "";
            this.DurationCB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DurationCB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DurationCB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DurationCB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DurationCB.Enabled = false;
            this.DurationCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DurationCB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DurationCB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DurationCB.Location = new System.Drawing.Point(800, 200);
            this.DurationCB.Name = "DurationCB";
            this.DurationCB.PasswordChar = '\0';
            this.DurationCB.PlaceholderText = "";
            this.DurationCB.SelectedText = "";
            this.DurationCB.Size = new System.Drawing.Size(200, 60);
            this.DurationCB.TabIndex = 2;
            // 
            // StartTimeDTP
            // 
            this.StartTimeDTP.BorderRadius = 12;
            this.StartTimeDTP.BorderThickness = 1;
            this.StartTimeDTP.Checked = true;
            this.StartTimeDTP.CustomFormat = "HH:mm:ss";
            this.StartTimeDTP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.StartTimeDTP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartTimeDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTimeDTP.Location = new System.Drawing.Point(800, 300);
            this.StartTimeDTP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.StartTimeDTP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.StartTimeDTP.Name = "StartTimeDTP";
            this.StartTimeDTP.Size = new System.Drawing.Size(200, 60);
            this.StartTimeDTP.TabIndex = 1;
            this.StartTimeDTP.Value = new System.DateTime(2025, 12, 20, 21, 0, 0, 0);
            this.StartTimeDTP.ValueChanged += new System.EventHandler(this.StartTimeDTP_ValueChanged);
            // 
            // ToDTP
            // 
            this.ToDTP.BorderRadius = 12;
            this.ToDTP.BorderThickness = 1;
            this.ToDTP.Checked = true;
            this.ToDTP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ToDTP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToDTP.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ToDTP.Location = new System.Drawing.Point(800, 500);
            this.ToDTP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ToDTP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ToDTP.Name = "ToDTP";
            this.ToDTP.Size = new System.Drawing.Size(460, 60);
            this.ToDTP.TabIndex = 1;
            this.ToDTP.Value = new System.DateTime(2025, 12, 20, 21, 2, 45, 308);
            // 
            // FromDTP
            // 
            this.FromDTP.BorderRadius = 12;
            this.FromDTP.BorderThickness = 1;
            this.FromDTP.Checked = true;
            this.FromDTP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.FromDTP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FromDTP.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.FromDTP.Location = new System.Drawing.Point(800, 400);
            this.FromDTP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.FromDTP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.FromDTP.Name = "FromDTP";
            this.FromDTP.Size = new System.Drawing.Size(460, 60);
            this.FromDTP.TabIndex = 1;
            this.FromDTP.Value = new System.DateTime(2025, 12, 20, 21, 44, 21, 94);
            // 
            // MovieCB
            // 
            this.MovieCB.BackColor = System.Drawing.Color.Transparent;
            this.MovieCB.BorderRadius = 12;
            this.MovieCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.MovieCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MovieCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MovieCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MovieCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MovieCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.MovieCB.ItemHeight = 30;
            this.MovieCB.Location = new System.Drawing.Point(800, 100);
            this.MovieCB.Name = "MovieCB";
            this.MovieCB.Size = new System.Drawing.Size(460, 36);
            this.MovieCB.TabIndex = 0;
            this.MovieCB.SelectedIndexChanged += new System.EventHandler(this.MovieCB_SelectedIndexChanged);
            // 
            // AddShowTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AddShowTime";
            this.Size = new System.Drawing.Size(1500, 800);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PosterPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox MovieCB;
        private Guna.UI2.WinForms.Guna2DateTimePicker FromDTP;
        private Guna.UI2.WinForms.Guna2DateTimePicker StartTimeDTP;
        private Guna.UI2.WinForms.Guna2TextBox DurationCB;
        private Guna.UI2.WinForms.Guna2PictureBox PosterPictureBox;
        private Guna.UI2.WinForms.Guna2TextBox EndTimeTB;
        private Guna.UI2.WinForms.Guna2GradientButton CancelButton;
        private Guna.UI2.WinForms.Guna2GradientButton ApplyButton;
        private Guna.UI2.WinForms.Guna2DateTimePicker ToDTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label MovieLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label FromLabel;
        private Guna.UI2.WinForms.Guna2ComboBox ScreenCB;
        private System.Windows.Forms.Label ScreenLabel;
    }
}
