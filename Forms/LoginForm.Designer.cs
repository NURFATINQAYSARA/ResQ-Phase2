namespace ResQ.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pnlLeft = new Panel();
            pictureBox1 = new PictureBox();
            lblTagAdmin = new Label();
            lblTagVolunteer = new Label();
            lblTagResident = new Label();
            lblTagline = new Label();
            lblBrand = new Label();
            lblWelcome = new Label();
            lblHint = new Label();
            rdoResident = new RadioButton();
            rdoVolunteer = new RadioButton();
            rdoAdmin = new RadioButton();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            lblNew = new Label();
            lblHelp = new Label();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(217, 58, 43);
            pnlLeft.Controls.Add(pictureBox1);
            pnlLeft.Controls.Add(lblTagAdmin);
            pnlLeft.Controls.Add(lblTagVolunteer);
            pnlLeft.Controls.Add(lblTagResident);
            pnlLeft.Controls.Add(lblTagline);
            pnlLeft.Controls.Add(lblBrand);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(504, 504);
            pnlLeft.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblTagAdmin
            // 
            lblTagAdmin.BackColor = Color.White;
            lblTagAdmin.ForeColor = Color.FromArgb(27, 31, 107);
            lblTagAdmin.Location = new Point(56, 443);
            lblTagAdmin.Name = "lblTagAdmin";
            lblTagAdmin.Size = new Size(228, 37);
            lblTagAdmin.TabIndex = 4;
            lblTagAdmin.Text = "Administrator";
            lblTagAdmin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTagVolunteer
            // 
            lblTagVolunteer.BackColor = Color.White;
            lblTagVolunteer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTagVolunteer.ForeColor = Color.FromArgb(90, 58, 0);
            lblTagVolunteer.Location = new Point(57, 389);
            lblTagVolunteer.Name = "lblTagVolunteer";
            lblTagVolunteer.Size = new Size(229, 42);
            lblTagVolunteer.TabIndex = 3;
            lblTagVolunteer.Text = "Community Volunteer";
            lblTagVolunteer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTagResident
            // 
            lblTagResident.BackColor = Color.White;
            lblTagResident.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTagResident.ForeColor = Color.FromArgb(217, 58, 43);
            lblTagResident.Location = new Point(56, 336);
            lblTagResident.Name = "lblTagResident";
            lblTagResident.Size = new Size(229, 40);
            lblTagResident.TabIndex = 2;
            lblTagResident.Text = "Resident";
            lblTagResident.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTagline
            // 
            lblTagline.BackColor = Color.Transparent;
            lblTagline.Font = new Font("Segoe UI", 13F);
            lblTagline.ForeColor = Color.White;
            lblTagline.Location = new Point(57, 236);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(408, 90);
            lblTagline.TabIndex = 1;
            lblTagline.Text = "Community Emergency Response and Support Application";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.BackColor = Color.Transparent;
            lblBrand.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(40, 138);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(234, 106);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "ResQ";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(20, 26, 70);
            lblWelcome.Location = new Point(508, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(296, 54);
            lblWelcome.TabIndex = 6;
            lblWelcome.Text = "Welcome back";
            // 
            // lblHint
            // 
            lblHint.AutoSize = true;
            lblHint.BackColor = Color.Transparent;
            lblHint.ForeColor = Color.FromArgb(61, 68, 104);
            lblHint.Location = new Point(516, 58);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(291, 28);
            lblHint.TabIndex = 7;
            lblHint.Text = "Choose your role, then log in.";
            // 
            // rdoResident
            // 
            rdoResident.Appearance = Appearance.Button;
            rdoResident.AutoSize = true;
            rdoResident.Checked = true;
            rdoResident.Location = new Point(524, 106);
            rdoResident.Name = "rdoResident";
            rdoResident.Size = new Size(104, 38);
            rdoResident.TabIndex = 8;
            rdoResident.TabStop = true;
            rdoResident.Text = "Resident";
            rdoResident.TextAlign = ContentAlignment.MiddleCenter;
            rdoResident.UseVisualStyleBackColor = true;
            // 
            // rdoVolunteer
            // 
            rdoVolunteer.Appearance = Appearance.Button;
            rdoVolunteer.Location = new Point(650, 106);
            rdoVolunteer.Name = "rdoVolunteer";
            rdoVolunteer.Size = new Size(131, 44);
            rdoVolunteer.TabIndex = 8;
            rdoVolunteer.Text = "Volunteer";
            rdoVolunteer.TextAlign = ContentAlignment.MiddleCenter;
            rdoVolunteer.UseVisualStyleBackColor = true;
            // 
            // rdoAdmin
            // 
            rdoAdmin.Appearance = Appearance.Button;
            rdoAdmin.Location = new Point(804, 107);
            rdoAdmin.Name = "rdoAdmin";
            rdoAdmin.Size = new Size(126, 44);
            rdoAdmin.TabIndex = 8;
            rdoAdmin.Text = "Admin";
            rdoAdmin.TextAlign = ContentAlignment.MiddleCenter;
            rdoAdmin.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(524, 155);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(106, 28);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(522, 186);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(408, 37);
            txtUsername.TabIndex = 10;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(522, 236);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(101, 28);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(524, 267);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(408, 37);
            txtPassword.TabIndex = 12;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(524, 327);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(408, 38);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(524, 401);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(408, 40);
            btnRegister.TabIndex = 14;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblNew
            // 
            lblNew.AutoSize = true;
            lblNew.Font = new Font("Segoe UI", 10F);
            lblNew.Location = new Point(661, 366);
            lblNew.Name = "lblNew";
            lblNew.Size = new Size(133, 28);
            lblNew.TabIndex = 15;
            lblNew.Text = "New to ResQ?";
            // 
            // lblHelp
            // 
            lblHelp.Font = new Font("Segoe UI", 9F);
            lblHelp.ForeColor = Color.FromArgb(61, 68, 104);
            lblHelp.Location = new Point(508, 441);
            lblHelp.Name = "lblHelp";
            lblHelp.Size = new Size(448, 53);
            lblHelp.TabIndex = 16;
            lblHelp.Text = "Need help using the computer? A family member, \r\nneighbour or volunteer can assist you.";
            lblHelp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 504);
            Controls.Add(lblHelp);
            Controls.Add(lblNew);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(rdoAdmin);
            Controls.Add(rdoVolunteer);
            Controls.Add(rdoResident);
            Controls.Add(lblHint);
            Controls.Add(lblWelcome);
            Controls.Add(pnlLeft);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ResQ - Login";
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLeft;
        private Label lblBrand;
        private Label lblTagline;
        private Label lblTagAdmin;
        private Label lblTagVolunteer;
        private Label lblTagResident;
        private PictureBox pictureBox1;
        private Label lblWelcome;
        private Label lblHint;
        private RadioButton rdoResident;
        private RadioButton rdoVolunteer;
        private RadioButton rdoAdmin;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Label lblNew;
        private Label lblHelp;
    }
}