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
            pictureBox1 = new PictureBox();
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
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(217, 58, 43);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(20, 26, 70);
            lblWelcome.Location = new Point(433, 9);
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
            lblHint.Location = new Point(442, 58);
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
            rdoResident.Location = new Point(448, 106);
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
            rdoVolunteer.Location = new Point(576, 106);
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
            rdoAdmin.Location = new Point(728, 106);
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
            lblUsername.Location = new Point(448, 155);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(106, 28);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(446, 186);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(408, 37);
            txtUsername.TabIndex = 10;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(446, 236);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(101, 28);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(448, 267);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(408, 37);
            txtPassword.TabIndex = 12;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(448, 327);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(408, 38);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(448, 401);
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
            lblNew.Location = new Point(585, 366);
            lblNew.Name = "lblNew";
            lblNew.Size = new Size(133, 28);
            lblNew.TabIndex = 15;
            lblNew.Text = "New to ResQ?";
            // 
            // lblHelp
            // 
            lblHelp.Font = new Font("Segoe UI", 9F);
            lblHelp.ForeColor = Color.FromArgb(61, 68, 104);
            lblHelp.Location = new Point(432, 441);
            lblHelp.Name = "lblHelp";
            lblHelp.Size = new Size(448, 53);
            lblHelp.TabIndex = 16;
            lblHelp.Text = "Need help using the computer? A family member, \r\nneighbour or volunteer can assist you.";
            lblHelp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_2026_11_07_032256;
            pictureBox2.Location = new Point(0, -21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(393, 541);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 504);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
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
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ResQ - Login";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private PictureBox pictureBox2;
    }
}