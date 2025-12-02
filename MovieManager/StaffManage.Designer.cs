namespace MovieManager
{
    partial class StaffManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffManage));
            this.ManageStaff = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.FilterComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.AcceptButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ReloadButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.DeleteSearchButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DeleteFilter = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManageStaff
            // 
            this.ManageStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ManageStaff.AutoSize = true;
            this.ManageStaff.Font = new System.Drawing.Font("Stencil", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageStaff.Location = new System.Drawing.Point(694, 50);
            this.ManageStaff.Name = "ManageStaff";
            this.ManageStaff.Size = new System.Drawing.Size(405, 61);
            this.ManageStaff.TabIndex = 5;
            this.ManageStaff.Text = "Manage Staff";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.ManageStaff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1792, 1154);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderRadius = 50;
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(346, 450);
            this.panel2.Name = "panel2";
            this.panel2.ShadowDecoration.BorderRadius = 50;
            this.panel2.ShadowDecoration.Enabled = true;
            this.panel2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(1100, 764);
            this.panel2.TabIndex = 10;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(35, 18);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1030, 65);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(35, 89);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1030, 612);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderRadius = 30;
            this.panel3.Controls.Add(this.FilterComboBox);
            this.panel3.Controls.Add(this.SearchTextBox);
            this.panel3.Controls.Add(this.SearchLabel);
            this.panel3.Controls.Add(this.AcceptButton);
            this.panel3.Controls.Add(this.ReloadButton);
            this.panel3.Controls.Add(this.FilterLabel);
            this.panel3.Controls.Add(this.DeleteSearchButton);
            this.panel3.Controls.Add(this.DeleteFilter);
            this.panel3.Location = new System.Drawing.Point(427, 150);
            this.panel3.Name = "panel3";
            this.panel3.ShadowDecoration.BorderRadius = 30;
            this.panel3.ShadowDecoration.Enabled = true;
            this.panel3.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(939, 226);
            this.panel3.TabIndex = 9;
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.BackColor = System.Drawing.Color.Transparent;
            this.FilterComboBox.BorderRadius = 4;
            this.FilterComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FilterComboBox.DropDownHeight = 200;
            this.FilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FilterComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FilterComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FilterComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.FilterComboBox.IntegralHeight = false;
            this.FilterComboBox.ItemHeight = 30;
            this.FilterComboBox.Items.AddRange(new object[] {
            "All",
            "Accepted",
            "Unaccepted"});
            this.FilterComboBox.Location = new System.Drawing.Point(112, 118);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(450, 36);
            this.FilterComboBox.TabIndex = 4;
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.Color.Transparent;
            this.SearchTextBox.BorderRadius = 4;
            this.SearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextBox.DefaultText = "";
            this.SearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBox.Location = new System.Drawing.Point(112, 40);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PasswordChar = '\0';
            this.SearchTextBox.PlaceholderText = "";
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.Size = new System.Drawing.Size(450, 50);
            this.SearchTextBox.TabIndex = 1;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.Location = new System.Drawing.Point(42, 54);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(64, 20);
            this.SearchLabel.TabIndex = 0;
            this.SearchLabel.Text = "Search:";
            this.SearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Animated = true;
            this.AcceptButton.BackColor = System.Drawing.Color.Transparent;
            this.AcceptButton.BorderRadius = 4;
            this.AcceptButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AcceptButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AcceptButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AcceptButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AcceptButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AcceptButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.AcceptButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.AcceptButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AcceptButton.ForeColor = System.Drawing.Color.White;
            this.AcceptButton.Image = global::MovieManager.Properties.Resources.check_30dp_BLACK_FILL0_wght400_GRAD0_opsz24;
            this.AcceptButton.ImageSize = new System.Drawing.Size(30, 30);
            this.AcceptButton.Location = new System.Drawing.Point(782, 29);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(106, 50);
            this.AcceptButton.TabIndex = 3;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
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
            this.ReloadButton.Location = new System.Drawing.Point(782, 85);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(106, 50);
            this.ReloadButton.TabIndex = 3;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // FilterLabel
            // 
            this.FilterLabel.Location = new System.Drawing.Point(42, 133);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(64, 20);
            this.FilterLabel.TabIndex = 0;
            this.FilterLabel.Text = "Filter:";
            this.FilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DeleteSearchButton
            // 
            this.DeleteSearchButton.Animated = true;
            this.DeleteSearchButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteSearchButton.BorderRadius = 4;
            this.DeleteSearchButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteSearchButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteSearchButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteSearchButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteSearchButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteSearchButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.DeleteSearchButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.DeleteSearchButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteSearchButton.ForeColor = System.Drawing.Color.White;
            this.DeleteSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteSearchButton.Image")));
            this.DeleteSearchButton.ImageSize = new System.Drawing.Size(30, 30);
            this.DeleteSearchButton.Location = new System.Drawing.Point(582, 40);
            this.DeleteSearchButton.Name = "DeleteSearchButton";
            this.DeleteSearchButton.Size = new System.Drawing.Size(50, 50);
            this.DeleteSearchButton.TabIndex = 3;
            this.DeleteSearchButton.Click += new System.EventHandler(this.DeleteSearchButton_Click);
            // 
            // DeleteFilter
            // 
            this.DeleteFilter.Animated = true;
            this.DeleteFilter.BackColor = System.Drawing.Color.Transparent;
            this.DeleteFilter.BorderRadius = 4;
            this.DeleteFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteFilter.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.DeleteFilter.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.DeleteFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteFilter.ForeColor = System.Drawing.Color.White;
            this.DeleteFilter.Image = ((System.Drawing.Image)(resources.GetObject("DeleteFilter.Image")));
            this.DeleteFilter.ImageSize = new System.Drawing.Size(30, 30);
            this.DeleteFilter.Location = new System.Drawing.Point(582, 120);
            this.DeleteFilter.Name = "DeleteFilter";
            this.DeleteFilter.Size = new System.Drawing.Size(50, 50);
            this.DeleteFilter.TabIndex = 3;
            this.DeleteFilter.Click += new System.EventHandler(this.DeleteFilter_Click);
            // 
            // StaffManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "StaffManage";
            this.Size = new System.Drawing.Size(1792, 1154);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ManageStaff;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel3;
        private Guna.UI2.WinForms.Guna2ComboBox FilterComboBox;
        private Guna.UI2.WinForms.Guna2TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private Guna.UI2.WinForms.Guna2GradientButton ReloadButton;
        private System.Windows.Forms.Label FilterLabel;
        private Guna.UI2.WinForms.Guna2GradientButton DeleteSearchButton;
        private Guna.UI2.WinForms.Guna2GradientButton DeleteFilter;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton AcceptButton;
    }
}
