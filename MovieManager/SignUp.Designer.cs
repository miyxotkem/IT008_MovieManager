namespace MovieManager
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.FullNameTextBoxSignUp = new Guna.UI2.WinForms.Guna2TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.UsernameTextBoxSignUp = new Guna.UI2.WinForms.Guna2TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordTextBoxSignUp = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.RetypePasswordTextBoxSignUp = new Guna.UI2.WinForms.Guna2TextBox();
            this.RetypePasswordLabel = new System.Windows.Forms.Label();
            this.EmailTextBoxSignUp = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.SignUpButtonSignUp = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Panel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.TermsAndConditions = new System.Windows.Forms.LinkLabel();
            this.TermsAndConditionsCheckBoxSignUp = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Home = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.ExitButtonSignUp = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.epFullName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.epRetype = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.Panel.SuspendLayout();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRetype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // FullNameTextBoxSignUp
            // 
            this.FullNameTextBoxSignUp.BorderRadius = 12;
            this.FullNameTextBoxSignUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FullNameTextBoxSignUp.DefaultText = "";
            this.FullNameTextBoxSignUp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FullNameTextBoxSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FullNameTextBoxSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FullNameTextBoxSignUp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FullNameTextBoxSignUp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FullNameTextBoxSignUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FullNameTextBoxSignUp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FullNameTextBoxSignUp.Location = new System.Drawing.Point(67, 48);
            this.FullNameTextBoxSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FullNameTextBoxSignUp.Name = "FullNameTextBoxSignUp";
            this.FullNameTextBoxSignUp.PasswordChar = '\0';
            this.FullNameTextBoxSignUp.PlaceholderText = "";
            this.FullNameTextBoxSignUp.SelectedText = "";
            this.FullNameTextBoxSignUp.Size = new System.Drawing.Size(356, 48);
            this.FullNameTextBoxSignUp.TabIndex = 0;
            this.FullNameTextBoxSignUp.Enter += new System.EventHandler(this.FullNameTextBoxSignUp_Enter);
            this.FullNameTextBoxSignUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullNameTextBoxSignUp_KeyPress);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(76, 30);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(68, 16);
            this.FullNameLabel.TabIndex = 1;
            this.FullNameLabel.Text = "Full Name";
            // 
            // UsernameTextBoxSignUp
            // 
            this.UsernameTextBoxSignUp.BorderRadius = 12;
            this.UsernameTextBoxSignUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTextBoxSignUp.DefaultText = "";
            this.UsernameTextBoxSignUp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTextBoxSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTextBoxSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTextBoxSignUp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTextBoxSignUp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTextBoxSignUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UsernameTextBoxSignUp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTextBoxSignUp.Location = new System.Drawing.Point(511, 48);
            this.UsernameTextBoxSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameTextBoxSignUp.Name = "UsernameTextBoxSignUp";
            this.UsernameTextBoxSignUp.PasswordChar = '\0';
            this.UsernameTextBoxSignUp.PlaceholderText = "";
            this.UsernameTextBoxSignUp.SelectedText = "";
            this.UsernameTextBoxSignUp.Size = new System.Drawing.Size(356, 48);
            this.UsernameTextBoxSignUp.TabIndex = 2;
            this.UsernameTextBoxSignUp.Enter += new System.EventHandler(this.UsernameTextBoxSignUp_Enter);
            this.UsernameTextBoxSignUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsernameTextBoxSignUp_KeyPress);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(521, 30);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(70, 16);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordTextBoxSignUp
            // 
            this.PasswordTextBoxSignUp.BorderRadius = 12;
            this.PasswordTextBoxSignUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBoxSignUp.DefaultText = "";
            this.PasswordTextBoxSignUp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextBoxSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextBoxSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBoxSignUp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBoxSignUp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextBoxSignUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordTextBoxSignUp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextBoxSignUp.Location = new System.Drawing.Point(511, 144);
            this.PasswordTextBoxSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordTextBoxSignUp.Name = "PasswordTextBoxSignUp";
            this.PasswordTextBoxSignUp.PasswordChar = '●';
            this.PasswordTextBoxSignUp.PlaceholderText = "";
            this.PasswordTextBoxSignUp.SelectedText = "";
            this.PasswordTextBoxSignUp.Size = new System.Drawing.Size(356, 48);
            this.PasswordTextBoxSignUp.TabIndex = 3;
            this.PasswordTextBoxSignUp.UseSystemPasswordChar = true;
            this.PasswordTextBoxSignUp.Enter += new System.EventHandler(this.PasswordTextBoxSignUp_Enter);
            this.PasswordTextBoxSignUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTextBoxSignUp_KeyPress);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(521, 126);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(67, 16);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // RetypePasswordTextBoxSignUp
            // 
            this.RetypePasswordTextBoxSignUp.BorderRadius = 12;
            this.RetypePasswordTextBoxSignUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RetypePasswordTextBoxSignUp.DefaultText = "";
            this.RetypePasswordTextBoxSignUp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RetypePasswordTextBoxSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RetypePasswordTextBoxSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RetypePasswordTextBoxSignUp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RetypePasswordTextBoxSignUp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RetypePasswordTextBoxSignUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RetypePasswordTextBoxSignUp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RetypePasswordTextBoxSignUp.Location = new System.Drawing.Point(511, 240);
            this.RetypePasswordTextBoxSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RetypePasswordTextBoxSignUp.Name = "RetypePasswordTextBoxSignUp";
            this.RetypePasswordTextBoxSignUp.PasswordChar = '●';
            this.RetypePasswordTextBoxSignUp.PlaceholderText = "";
            this.RetypePasswordTextBoxSignUp.SelectedText = "";
            this.RetypePasswordTextBoxSignUp.Size = new System.Drawing.Size(356, 48);
            this.RetypePasswordTextBoxSignUp.TabIndex = 4;
            this.RetypePasswordTextBoxSignUp.UseSystemPasswordChar = true;
            this.RetypePasswordTextBoxSignUp.Enter += new System.EventHandler(this.RetypePasswordTextBoxSignUp_Enter);
            this.RetypePasswordTextBoxSignUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RetypePasswordTextBoxSignUp_KeyPress);
            // 
            // RetypePasswordLabel
            // 
            this.RetypePasswordLabel.AutoSize = true;
            this.RetypePasswordLabel.Location = new System.Drawing.Point(521, 222);
            this.RetypePasswordLabel.Name = "RetypePasswordLabel";
            this.RetypePasswordLabel.Size = new System.Drawing.Size(114, 16);
            this.RetypePasswordLabel.TabIndex = 1;
            this.RetypePasswordLabel.Text = "Retype Password";
            // 
            // EmailTextBoxSignUp
            // 
            this.EmailTextBoxSignUp.BorderRadius = 12;
            this.EmailTextBoxSignUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextBoxSignUp.DefaultText = "";
            this.EmailTextBoxSignUp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailTextBoxSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailTextBoxSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextBoxSignUp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextBoxSignUp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTextBoxSignUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmailTextBoxSignUp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTextBoxSignUp.Location = new System.Drawing.Point(67, 144);
            this.EmailTextBoxSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailTextBoxSignUp.Name = "EmailTextBoxSignUp";
            this.EmailTextBoxSignUp.PasswordChar = '\0';
            this.EmailTextBoxSignUp.PlaceholderText = "";
            this.EmailTextBoxSignUp.SelectedText = "";
            this.EmailTextBoxSignUp.Size = new System.Drawing.Size(356, 48);
            this.EmailTextBoxSignUp.TabIndex = 1;
            this.EmailTextBoxSignUp.Enter += new System.EventHandler(this.EmailTextBoxSignUp_Enter);
            this.EmailTextBoxSignUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTextBoxSignUp_KeyPress);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(76, 126);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 16);
            this.EmailLabel.TabIndex = 1;
            this.EmailLabel.Text = "Email";
            // 
            // SignUpButtonSignUp
            // 
            this.SignUpButtonSignUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.SignUpButtonSignUp.BorderRadius = 12;
            this.SignUpButtonSignUp.BorderThickness = 1;
            this.SignUpButtonSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SignUpButtonSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SignUpButtonSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignUpButtonSignUp.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignUpButtonSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SignUpButtonSignUp.FillColor = System.Drawing.Color.Empty;
            this.SignUpButtonSignUp.FillColor2 = System.Drawing.Color.Empty;
            this.SignUpButtonSignUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SignUpButtonSignUp.ForeColor = System.Drawing.Color.Black;
            this.SignUpButtonSignUp.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.SignUpButtonSignUp.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.SignUpButtonSignUp.HoverState.ForeColor = System.Drawing.Color.White;
            this.SignUpButtonSignUp.Location = new System.Drawing.Point(378, 368);
            this.SignUpButtonSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignUpButtonSignUp.Name = "SignUpButtonSignUp";
            this.SignUpButtonSignUp.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.SignUpButtonSignUp.Size = new System.Drawing.Size(178, 48);
            this.SignUpButtonSignUp.TabIndex = 6;
            this.SignUpButtonSignUp.Text = "Sign Up";
            this.SignUpButtonSignUp.Click += new System.EventHandler(this.SignUpButtonSignUp_Click);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.Transparent;
            this.Panel.BorderRadius = 30;
            this.Panel.BorderThickness = 1;
            this.Panel.Controls.Add(this.TermsAndConditions);
            this.Panel.Controls.Add(this.TermsAndConditionsCheckBoxSignUp);
            this.Panel.Controls.Add(this.SignUpButtonSignUp);
            this.Panel.Controls.Add(this.EmailLabel);
            this.Panel.Controls.Add(this.RetypePasswordLabel);
            this.Panel.Controls.Add(this.PasswordLabel);
            this.Panel.Controls.Add(this.UsernameLabel);
            this.Panel.Controls.Add(this.FullNameLabel);
            this.Panel.Controls.Add(this.EmailTextBoxSignUp);
            this.Panel.Controls.Add(this.RetypePasswordTextBoxSignUp);
            this.Panel.Controls.Add(this.PasswordTextBoxSignUp);
            this.Panel.Controls.Add(this.UsernameTextBoxSignUp);
            this.Panel.Controls.Add(this.FullNameTextBoxSignUp);
            this.Panel.Location = new System.Drawing.Point(57, 112);
            this.Panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel.Name = "Panel";
            this.Panel.ShadowDecoration.BorderRadius = 30;
            this.Panel.ShadowDecoration.Enabled = true;
            this.Panel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.Panel.Size = new System.Drawing.Size(933, 560);
            this.Panel.TabIndex = 3;
            // 
            // TermsAndConditions
            // 
            this.TermsAndConditions.AutoSize = true;
            this.TermsAndConditions.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.TermsAndConditions.Location = new System.Drawing.Point(521, 334);
            this.TermsAndConditions.Name = "TermsAndConditions";
            this.TermsAndConditions.Size = new System.Drawing.Size(127, 16);
            this.TermsAndConditions.TabIndex = 4;
            this.TermsAndConditions.TabStop = true;
            this.TermsAndConditions.Text = "terms and condtions";
            // 
            // TermsAndConditionsCheckBoxSignUp
            // 
            this.TermsAndConditionsCheckBoxSignUp.AutoSize = true;
            this.TermsAndConditionsCheckBoxSignUp.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TermsAndConditionsCheckBoxSignUp.CheckedState.BorderRadius = 0;
            this.TermsAndConditionsCheckBoxSignUp.CheckedState.BorderThickness = 0;
            this.TermsAndConditionsCheckBoxSignUp.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TermsAndConditionsCheckBoxSignUp.Location = new System.Drawing.Point(286, 333);
            this.TermsAndConditionsCheckBoxSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TermsAndConditionsCheckBoxSignUp.Name = "TermsAndConditionsCheckBoxSignUp";
            this.TermsAndConditionsCheckBoxSignUp.Size = new System.Drawing.Size(220, 20);
            this.TermsAndConditionsCheckBoxSignUp.TabIndex = 5;
            this.TermsAndConditionsCheckBoxSignUp.Text = "By checking this, I agree with our";
            this.TermsAndConditionsCheckBoxSignUp.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TermsAndConditionsCheckBoxSignUp.UncheckedState.BorderRadius = 0;
            this.TermsAndConditionsCheckBoxSignUp.UncheckedState.BorderThickness = 0;
            this.TermsAndConditionsCheckBoxSignUp.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // Home
            // 
            this.Home.Controls.Add(this.ExitButtonSignUp);
            this.Home.Controls.Add(this.SignUpLabel);
            this.Home.Controls.Add(this.Panel);
            this.Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Home.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.Home.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.Home.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.Home.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.Home.Location = new System.Drawing.Point(0, 0);
            this.Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(1047, 595);
            this.Home.TabIndex = 4;
            // 
            // ExitButtonSignUp
            // 
            this.ExitButtonSignUp.BackColor = System.Drawing.Color.Transparent;
            this.ExitButtonSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitButtonSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitButtonSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitButtonSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitButtonSignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.ExitButtonSignUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExitButtonSignUp.ForeColor = System.Drawing.Color.White;
            this.ExitButtonSignUp.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ExitButtonSignUp.Location = new System.Drawing.Point(1008, 11);
            this.ExitButtonSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButtonSignUp.Name = "ExitButtonSignUp";
            this.ExitButtonSignUp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ExitButtonSignUp.Size = new System.Drawing.Size(27, 24);
            this.ExitButtonSignUp.TabIndex = 5;
            this.ExitButtonSignUp.Click += new System.EventHandler(this.ExitButtonSignUp_Click);
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.BackColor = System.Drawing.Color.Transparent;
            this.SignUpLabel.Font = new System.Drawing.Font("Stencil", 30F);
            this.SignUpLabel.Location = new System.Drawing.Point(409, 28);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(217, 59);
            this.SignUpLabel.TabIndex = 4;
            this.SignUpLabel.Text = "Sign Up";
            // 
            // epFullName
            // 
            this.epFullName.ContainerControl = this;
            // 
            // epUsername
            // 
            this.epUsername.ContainerControl = this;
            // 
            // epEmail
            // 
            this.epEmail.ContainerControl = this;
            // 
            // epPass
            // 
            this.epPass.ContainerControl = this;
            // 
            // epRetype
            // 
            this.epRetype.ContainerControl = this;
            // 
            // epCheck
            // 
            this.epCheck.ContainerControl = this;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 595);
            this.Controls.Add(this.Home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRetype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox FullNameTextBoxSignUp;
        private System.Windows.Forms.Label FullNameLabel;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTextBoxSignUp;
        private System.Windows.Forms.Label UsernameLabel;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextBoxSignUp;
        private System.Windows.Forms.Label PasswordLabel;
        private Guna.UI2.WinForms.Guna2TextBox RetypePasswordTextBoxSignUp;
        private System.Windows.Forms.Label RetypePasswordLabel;
        private Guna.UI2.WinForms.Guna2TextBox EmailTextBoxSignUp;
        private System.Windows.Forms.Label EmailLabel;
        private Guna.UI2.WinForms.Guna2GradientButton SignUpButtonSignUp;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Panel;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Home;
        private System.Windows.Forms.Label SignUpLabel;
        private Guna.UI2.WinForms.Guna2CheckBox TermsAndConditionsCheckBoxSignUp;
        private System.Windows.Forms.LinkLabel TermsAndConditions;
        private Guna.UI2.WinForms.Guna2CircleButton ExitButtonSignUp;
        private System.Windows.Forms.ErrorProvider epFullName;
        private System.Windows.Forms.ErrorProvider epUsername;
        private System.Windows.Forms.ErrorProvider epEmail;
        private System.Windows.Forms.ErrorProvider epPass;
        private System.Windows.Forms.ErrorProvider epRetype;
        private System.Windows.Forms.ErrorProvider epCheck;
    }
}