namespace MovieManager
{
    partial class Edit_MovieManage
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
            this.ApplyButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.CancelButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ReleaseDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.GenreComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.RatedComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DirectorTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.LanguageTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.FormatComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TrailerTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ActorTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.BriefTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.RatedLabel = new System.Windows.Forms.Label();
            this.ReleaseDateLabel = new System.Windows.Forms.Label();
            this.DirectorLabel = new System.Windows.Forms.Label();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.DurationTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.FormatLabel = new System.Windows.Forms.Label();
            this.TrailerLabel = new System.Windows.Forms.Label();
            this.ActorLabel = new System.Windows.Forms.Label();
            this.BriefLabel = new System.Windows.Forms.Label();
            this.UploadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.UploadButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PosterTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PosterLabel = new System.Windows.Forms.Label();
            this.PosterPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PosterPictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.ApplyButton.Location = new System.Drawing.Point(1335, 891);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(193, 76);
            this.ApplyButton.TabIndex = 0;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
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
            this.CancelButton.Location = new System.Drawing.Point(1557, 891);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(193, 76);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(165, 80);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(38, 20);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BorderRadius = 12;
            this.TitleTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TitleTextBox.DefaultText = "";
            this.TitleTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TitleTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TitleTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TitleTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TitleTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TitleTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TitleTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TitleTextBox.Location = new System.Drawing.Point(155, 100);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.PasswordChar = '\0';
            this.TitleTextBox.PlaceholderText = "";
            this.TitleTextBox.SelectedText = "";
            this.TitleTextBox.Size = new System.Drawing.Size(460, 60);
            this.TitleTextBox.TabIndex = 2;
            // 
            // ReleaseDateTimePicker
            // 
            this.ReleaseDateTimePicker.BorderRadius = 12;
            this.ReleaseDateTimePicker.Checked = true;
            this.ReleaseDateTimePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ReleaseDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ReleaseDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ReleaseDateTimePicker.Location = new System.Drawing.Point(155, 400);
            this.ReleaseDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ReleaseDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ReleaseDateTimePicker.Name = "ReleaseDateTimePicker";
            this.ReleaseDateTimePicker.Size = new System.Drawing.Size(460, 60);
            this.ReleaseDateTimePicker.TabIndex = 3;
            this.ReleaseDateTimePicker.Value = new System.DateTime(2025, 11, 21, 20, 39, 3, 725);
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.BackColor = System.Drawing.Color.Transparent;
            this.GenreComboBox.BorderRadius = 12;
            this.GenreComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenreComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenreComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenreComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GenreComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.GenreComboBox.ItemHeight = 30;
            this.GenreComboBox.Items.AddRange(new object[] {
            "N/A",
            "Action",
            "Adventure",
            "Comedy",
            "Drama",
            "Horror",
            "Science Fiction (Sci-Fi)",
            "Fantasy",
            "Thriller",
            "Documentary",
            "Animation",
            "Romance",
            "Musical",
            "Mystery",
            "Western",
            "Crime",
            "Biographical"});
            this.GenreComboBox.Location = new System.Drawing.Point(155, 200);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(460, 36);
            this.GenreComboBox.TabIndex = 4;
            // 
            // RatedComboBox
            // 
            this.RatedComboBox.BackColor = System.Drawing.Color.Transparent;
            this.RatedComboBox.BorderRadius = 12;
            this.RatedComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RatedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RatedComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RatedComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RatedComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RatedComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.RatedComboBox.ItemHeight = 30;
            this.RatedComboBox.Items.AddRange(new object[] {
            "N/A",
            "P",
            "K",
            "T13",
            "T16",
            "T18"});
            this.RatedComboBox.Location = new System.Drawing.Point(155, 300);
            this.RatedComboBox.Name = "RatedComboBox";
            this.RatedComboBox.Size = new System.Drawing.Size(460, 36);
            this.RatedComboBox.TabIndex = 4;
            // 
            // DirectorTextBox
            // 
            this.DirectorTextBox.BorderRadius = 12;
            this.DirectorTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DirectorTextBox.DefaultText = "";
            this.DirectorTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DirectorTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DirectorTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DirectorTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DirectorTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DirectorTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DirectorTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DirectorTextBox.Location = new System.Drawing.Point(155, 500);
            this.DirectorTextBox.Name = "DirectorTextBox";
            this.DirectorTextBox.PasswordChar = '\0';
            this.DirectorTextBox.PlaceholderText = "";
            this.DirectorTextBox.SelectedText = "";
            this.DirectorTextBox.Size = new System.Drawing.Size(460, 60);
            this.DirectorTextBox.TabIndex = 2;
            // 
            // LanguageTextBox
            // 
            this.LanguageTextBox.BorderRadius = 12;
            this.LanguageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LanguageTextBox.DefaultText = "";
            this.LanguageTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LanguageTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LanguageTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LanguageTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LanguageTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LanguageTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LanguageTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LanguageTextBox.Location = new System.Drawing.Point(155, 600);
            this.LanguageTextBox.Name = "LanguageTextBox";
            this.LanguageTextBox.PasswordChar = '\0';
            this.LanguageTextBox.PlaceholderText = "";
            this.LanguageTextBox.SelectedText = "";
            this.LanguageTextBox.Size = new System.Drawing.Size(460, 60);
            this.LanguageTextBox.TabIndex = 2;
            // 
            // FormatComboBox
            // 
            this.FormatComboBox.BackColor = System.Drawing.Color.Transparent;
            this.FormatComboBox.BorderRadius = 12;
            this.FormatComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormatComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FormatComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FormatComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormatComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.FormatComboBox.ItemHeight = 30;
            this.FormatComboBox.Items.AddRange(new object[] {
            "N/A",
            "iMax",
            "4DX",
            "2D",
            "3D"});
            this.FormatComboBox.Location = new System.Drawing.Point(770, 100);
            this.FormatComboBox.Name = "FormatComboBox";
            this.FormatComboBox.Size = new System.Drawing.Size(460, 36);
            this.FormatComboBox.TabIndex = 4;
            // 
            // TrailerTextBox
            // 
            this.TrailerTextBox.BorderRadius = 12;
            this.TrailerTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TrailerTextBox.DefaultText = "";
            this.TrailerTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TrailerTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TrailerTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TrailerTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TrailerTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TrailerTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TrailerTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TrailerTextBox.Location = new System.Drawing.Point(770, 200);
            this.TrailerTextBox.Name = "TrailerTextBox";
            this.TrailerTextBox.PasswordChar = '\0';
            this.TrailerTextBox.PlaceholderText = "";
            this.TrailerTextBox.SelectedText = "";
            this.TrailerTextBox.Size = new System.Drawing.Size(460, 60);
            this.TrailerTextBox.TabIndex = 2;
            // 
            // ActorTextBox
            // 
            this.ActorTextBox.BorderRadius = 12;
            this.ActorTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ActorTextBox.DefaultText = "";
            this.ActorTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ActorTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ActorTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ActorTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ActorTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ActorTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ActorTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ActorTextBox.Location = new System.Drawing.Point(770, 300);
            this.ActorTextBox.Multiline = true;
            this.ActorTextBox.Name = "ActorTextBox";
            this.ActorTextBox.PasswordChar = '\0';
            this.ActorTextBox.PlaceholderText = "";
            this.ActorTextBox.SelectedText = "";
            this.ActorTextBox.Size = new System.Drawing.Size(460, 160);
            this.ActorTextBox.TabIndex = 2;
            // 
            // BriefTextBox
            // 
            this.BriefTextBox.BorderRadius = 12;
            this.BriefTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BriefTextBox.DefaultText = "";
            this.BriefTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BriefTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BriefTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BriefTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BriefTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BriefTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BriefTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BriefTextBox.Location = new System.Drawing.Point(770, 503);
            this.BriefTextBox.Multiline = true;
            this.BriefTextBox.Name = "BriefTextBox";
            this.BriefTextBox.PasswordChar = '\0';
            this.BriefTextBox.PlaceholderText = "";
            this.BriefTextBox.SelectedText = "";
            this.BriefTextBox.Size = new System.Drawing.Size(460, 257);
            this.BriefTextBox.TabIndex = 2;
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(165, 180);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(54, 20);
            this.GenreLabel.TabIndex = 1;
            this.GenreLabel.Text = "Genre";
            // 
            // RatedLabel
            // 
            this.RatedLabel.AutoSize = true;
            this.RatedLabel.Location = new System.Drawing.Point(165, 280);
            this.RatedLabel.Name = "RatedLabel";
            this.RatedLabel.Size = new System.Drawing.Size(53, 20);
            this.RatedLabel.TabIndex = 1;
            this.RatedLabel.Text = "Rated";
            // 
            // ReleaseDateLabel
            // 
            this.ReleaseDateLabel.AutoSize = true;
            this.ReleaseDateLabel.Location = new System.Drawing.Point(165, 380);
            this.ReleaseDateLabel.Name = "ReleaseDateLabel";
            this.ReleaseDateLabel.Size = new System.Drawing.Size(107, 20);
            this.ReleaseDateLabel.TabIndex = 1;
            this.ReleaseDateLabel.Text = "Release Date";
            // 
            // DirectorLabel
            // 
            this.DirectorLabel.AutoSize = true;
            this.DirectorLabel.Location = new System.Drawing.Point(165, 480);
            this.DirectorLabel.Name = "DirectorLabel";
            this.DirectorLabel.Size = new System.Drawing.Size(65, 20);
            this.DirectorLabel.TabIndex = 1;
            this.DirectorLabel.Text = "Director";
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Location = new System.Drawing.Point(165, 580);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(81, 20);
            this.LanguageLabel.TabIndex = 1;
            this.LanguageLabel.Text = "Language";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(165, 680);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(70, 20);
            this.DurationLabel.TabIndex = 1;
            this.DurationLabel.Text = "Duration";
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.BorderRadius = 12;
            this.DurationTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DurationTextBox.DefaultText = "";
            this.DurationTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DurationTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DurationTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DurationTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DurationTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DurationTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DurationTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DurationTextBox.Location = new System.Drawing.Point(155, 700);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.PasswordChar = '\0';
            this.DurationTextBox.PlaceholderText = "";
            this.DurationTextBox.SelectedText = "";
            this.DurationTextBox.Size = new System.Drawing.Size(460, 60);
            this.DurationTextBox.TabIndex = 2;
            this.DurationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DurationTextBox_KeyPress);
            // 
            // FormatLabel
            // 
            this.FormatLabel.AutoSize = true;
            this.FormatLabel.Location = new System.Drawing.Point(780, 80);
            this.FormatLabel.Name = "FormatLabel";
            this.FormatLabel.Size = new System.Drawing.Size(60, 20);
            this.FormatLabel.TabIndex = 1;
            this.FormatLabel.Text = "Format";
            // 
            // TrailerLabel
            // 
            this.TrailerLabel.AutoSize = true;
            this.TrailerLabel.Location = new System.Drawing.Point(780, 180);
            this.TrailerLabel.Name = "TrailerLabel";
            this.TrailerLabel.Size = new System.Drawing.Size(52, 20);
            this.TrailerLabel.TabIndex = 1;
            this.TrailerLabel.Text = "Trailer";
            // 
            // ActorLabel
            // 
            this.ActorLabel.AutoSize = true;
            this.ActorLabel.Location = new System.Drawing.Point(780, 280);
            this.ActorLabel.Name = "ActorLabel";
            this.ActorLabel.Size = new System.Drawing.Size(47, 20);
            this.ActorLabel.TabIndex = 1;
            this.ActorLabel.Text = "Actor";
            // 
            // BriefLabel
            // 
            this.BriefLabel.AutoSize = true;
            this.BriefLabel.Location = new System.Drawing.Point(780, 480);
            this.BriefLabel.Name = "BriefLabel";
            this.BriefLabel.Size = new System.Drawing.Size(42, 20);
            this.BriefLabel.TabIndex = 1;
            this.BriefLabel.Text = "Brief";
            // 
            // UploadFileDialog
            // 
            this.UploadFileDialog.FileName = "openFileDialog1";
            // 
            // UploadButton
            // 
            this.UploadButton.BorderRadius = 12;
            this.UploadButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UploadButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UploadButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UploadButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UploadButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UploadButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.UploadButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.UploadButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UploadButton.ForeColor = System.Drawing.Color.White;
            this.UploadButton.Location = new System.Drawing.Point(1455, 555);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(120, 60);
            this.UploadButton.TabIndex = 5;
            this.UploadButton.Text = "Upload";
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // PosterTextBox
            // 
            this.PosterTextBox.BorderRadius = 12;
            this.PosterTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PosterTextBox.DefaultText = "";
            this.PosterTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PosterTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PosterTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PosterTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PosterTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PosterTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PosterTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PosterTextBox.Location = new System.Drawing.Point(1385, 480);
            this.PosterTextBox.Name = "PosterTextBox";
            this.PosterTextBox.PasswordChar = '\0';
            this.PosterTextBox.PlaceholderText = "";
            this.PosterTextBox.SelectedText = "";
            this.PosterTextBox.Size = new System.Drawing.Size(260, 60);
            this.PosterTextBox.TabIndex = 2;
            // 
            // PosterLabel
            // 
            this.PosterLabel.AutoSize = true;
            this.PosterLabel.Location = new System.Drawing.Point(1395, 80);
            this.PosterLabel.Name = "PosterLabel";
            this.PosterLabel.Size = new System.Drawing.Size(55, 20);
            this.PosterLabel.TabIndex = 1;
            this.PosterLabel.Text = "Poster";
            // 
            // PosterPictureBox
            // 
            this.PosterPictureBox.BorderRadius = 12;
            this.PosterPictureBox.ImageRotate = 0F;
            this.PosterPictureBox.Location = new System.Drawing.Point(1385, 100);
            this.PosterPictureBox.Name = "PosterPictureBox";
            this.PosterPictureBox.Size = new System.Drawing.Size(260, 360);
            this.PosterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PosterPictureBox.TabIndex = 6;
            this.PosterPictureBox.TabStop = false;
            // 
            // Edit_MovieManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PosterPictureBox);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.RatedComboBox);
            this.Controls.Add(this.FormatComboBox);
            this.Controls.Add(this.GenreComboBox);
            this.Controls.Add(this.ReleaseDateTimePicker);
            this.Controls.Add(this.ActorTextBox);
            this.Controls.Add(this.TrailerTextBox);
            this.Controls.Add(this.LanguageTextBox);
            this.Controls.Add(this.DirectorTextBox);
            this.Controls.Add(this.BriefTextBox);
            this.Controls.Add(this.PosterTextBox);
            this.Controls.Add(this.DurationTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.ReleaseDateLabel);
            this.Controls.Add(this.LanguageLabel);
            this.Controls.Add(this.DirectorLabel);
            this.Controls.Add(this.RatedLabel);
            this.Controls.Add(this.BriefLabel);
            this.Controls.Add(this.ActorLabel);
            this.Controls.Add(this.TrailerLabel);
            this.Controls.Add(this.FormatLabel);
            this.Controls.Add(this.PosterLabel);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ApplyButton);
            this.Name = "Edit_MovieManage";
            this.Size = new System.Drawing.Size(1800, 1011);
            ((System.ComponentModel.ISupportInitialize)(this.PosterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton ApplyButton;
        private Guna.UI2.WinForms.Guna2GradientButton CancelButton;
        private System.Windows.Forms.Label TitleLabel;
        private Guna.UI2.WinForms.Guna2TextBox TitleTextBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker ReleaseDateTimePicker;
        private Guna.UI2.WinForms.Guna2ComboBox GenreComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox RatedComboBox;
        private Guna.UI2.WinForms.Guna2TextBox DirectorTextBox;
        private Guna.UI2.WinForms.Guna2TextBox LanguageTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox FormatComboBox;
        private Guna.UI2.WinForms.Guna2TextBox TrailerTextBox;
        private Guna.UI2.WinForms.Guna2TextBox ActorTextBox;
        private Guna.UI2.WinForms.Guna2TextBox BriefTextBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label RatedLabel;
        private System.Windows.Forms.Label ReleaseDateLabel;
        private System.Windows.Forms.Label DirectorLabel;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.Label DurationLabel;
        private Guna.UI2.WinForms.Guna2TextBox DurationTextBox;
        private System.Windows.Forms.Label FormatLabel;
        private System.Windows.Forms.Label TrailerLabel;
        private System.Windows.Forms.Label ActorLabel;
        private System.Windows.Forms.Label BriefLabel;
        private System.Windows.Forms.OpenFileDialog UploadFileDialog;
        private Guna.UI2.WinForms.Guna2GradientButton UploadButton;
        private Guna.UI2.WinForms.Guna2TextBox PosterTextBox;
        private System.Windows.Forms.Label PosterLabel;
        private Guna.UI2.WinForms.Guna2PictureBox PosterPictureBox;
    }
}
