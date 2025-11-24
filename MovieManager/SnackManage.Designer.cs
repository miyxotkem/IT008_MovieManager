namespace MovieManager
{
    partial class SnackManage
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
            this.ManageSnack = new System.Windows.Forms.Label();
            this.ToolPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.FilterComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.ReloadButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AddButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DeleteFilter = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DeleteSearchButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.ToolPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManageSnack
            // 
            this.ManageSnack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ManageSnack.AutoSize = true;
            this.ManageSnack.Font = new System.Drawing.Font("Stencil", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageSnack.Location = new System.Drawing.Point(687, 49);
            this.ManageSnack.Name = "ManageSnack";
            this.ManageSnack.Size = new System.Drawing.Size(419, 61);
            this.ManageSnack.TabIndex = 4;
            this.ManageSnack.Text = "Manage Snack";
            // 
            // ToolPanel
            // 
            this.ToolPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ToolPanel.BackColor = System.Drawing.Color.White;
            this.ToolPanel.Controls.Add(this.FilterComboBox);
            this.ToolPanel.Controls.Add(this.ReloadButton);
            this.ToolPanel.Controls.Add(this.AddButton);
            this.ToolPanel.Controls.Add(this.DeleteFilter);
            this.ToolPanel.Controls.Add(this.DeleteSearchButton);
            this.ToolPanel.Controls.Add(this.SearchTextBox);
            this.ToolPanel.Controls.Add(this.FilterLabel);
            this.ToolPanel.Controls.Add(this.SearchLabel);
            this.ToolPanel.Location = new System.Drawing.Point(427, 178);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.ShadowDecoration.BorderRadius = 0;
            this.ToolPanel.ShadowDecoration.Enabled = true;
            this.ToolPanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.ToolPanel.Size = new System.Drawing.Size(939, 226);
            this.ToolPanel.TabIndex = 5;
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
            "Food",
            "Beverage"});
            this.FilterComboBox.Location = new System.Drawing.Point(120, 115);
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
            this.SearchTextBox.Location = new System.Drawing.Point(120, 37);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PasswordChar = '\0';
            this.SearchTextBox.PlaceholderText = "";
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.Size = new System.Drawing.Size(450, 50);
            this.SearchTextBox.TabIndex = 1;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // FilterLabel
            // 
            this.FilterLabel.Location = new System.Drawing.Point(50, 130);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(64, 20);
            this.FilterLabel.TabIndex = 0;
            this.FilterLabel.Text = "Filter:";
            this.FilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SearchLabel
            // 
            this.SearchLabel.Location = new System.Drawing.Point(50, 51);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(64, 20);
            this.SearchLabel.TabIndex = 0;
            this.SearchLabel.Text = "Search:";
            this.SearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.ReloadButton.Image = global::MovieManager.Properties.Resources.refresh_30dp_BLACK_FILL0_wght400_GRAD0_opsz24;
            this.ReloadButton.ImageSize = new System.Drawing.Size(30, 30);
            this.ReloadButton.Location = new System.Drawing.Point(786, 107);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(106, 50);
            this.ReloadButton.TabIndex = 3;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Animated = true;
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.BorderRadius = 4;
            this.AddButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.AddButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Image = global::MovieManager.Properties.Resources.add_box_30dp_BLACK_FILL0_wght400_GRAD0_opsz24;
            this.AddButton.ImageSize = new System.Drawing.Size(30, 30);
            this.AddButton.Location = new System.Drawing.Point(786, 51);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(106, 50);
            this.AddButton.TabIndex = 3;
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
            this.DeleteFilter.Image = global::MovieManager.Properties.Resources.close_30dp_BLACK_FILL0_wght400_GRAD0_opsz24;
            this.DeleteFilter.ImageSize = new System.Drawing.Size(30, 30);
            this.DeleteFilter.Location = new System.Drawing.Point(590, 117);
            this.DeleteFilter.Name = "DeleteFilter";
            this.DeleteFilter.Size = new System.Drawing.Size(50, 50);
            this.DeleteFilter.TabIndex = 3;
            this.DeleteFilter.Click += new System.EventHandler(this.DeleteFilter_Click);
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
            this.DeleteSearchButton.Image = global::MovieManager.Properties.Resources.close_30dp_BLACK_FILL0_wght400_GRAD0_opsz24;
            this.DeleteSearchButton.ImageSize = new System.Drawing.Size(30, 30);
            this.DeleteSearchButton.Location = new System.Drawing.Point(590, 37);
            this.DeleteSearchButton.Name = "DeleteSearchButton";
            this.DeleteSearchButton.Size = new System.Drawing.Size(50, 50);
            this.DeleteSearchButton.TabIndex = 3;
            this.DeleteSearchButton.Click += new System.EventHandler(this.DeleteSearchButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.Panel);
            this.panel1.Controls.Add(this.ToolPanel);
            this.panel1.Controls.Add(this.ManageSnack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1792, 1154);
            this.panel1.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(574, 459);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(644, 622);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.BackColor = System.Drawing.Color.Transparent;
            this.Panel.BorderRadius = 5;
            this.Panel.Location = new System.Drawing.Point(564, 450);
            this.Panel.Name = "Panel";
            this.Panel.ShadowDecoration.BorderRadius = 5;
            this.Panel.ShadowDecoration.Enabled = true;
            this.Panel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1);
            this.Panel.Size = new System.Drawing.Size(664, 648);
            this.Panel.TabIndex = 7;
            // 
            // SnackManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "SnackManage";
            this.Size = new System.Drawing.Size(1792, 1154);
            this.ToolPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ManageSnack;
        private Guna.UI2.WinForms.Guna2GradientPanel ToolPanel;
        private Guna.UI2.WinForms.Guna2ComboBox FilterComboBox;
        private Guna.UI2.WinForms.Guna2GradientButton ReloadButton;
        private Guna.UI2.WinForms.Guna2GradientButton AddButton;
        private Guna.UI2.WinForms.Guna2GradientButton DeleteFilter;
        private Guna.UI2.WinForms.Guna2GradientButton DeleteSearchButton;
        private Guna.UI2.WinForms.Guna2TextBox SearchTextBox;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel Panel;
    }
}
