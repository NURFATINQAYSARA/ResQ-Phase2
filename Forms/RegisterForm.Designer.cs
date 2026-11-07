namespace ResQ.Forms
{
    partial class RegisterForm
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
            pnlLeft = new Panel();
            lblNote = new Label();
            lblStep3Text = new Label();
            lblStep2Text = new Label();
            lblStep3 = new Label();
            lblStep2 = new Label();
            lblBrand = new Label();
            lblTagline = new Label();
            lblStep1 = new Label();
            lblStep1Text = new Label();
            lblTitle = new Label();
            lblHint = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblArea = new Label();
            txtArea = new TextBox();
            lblPassword = new Label();
            lblConfirm = new Label();
            txtPassword = new TextBox();
            txtConfirm = new TextBox();
            lblRole = new Label();
            pnlRole = new Panel();
            rdoVolunteer = new RadioButton();
            rdoResident = new RadioButton();
            lblStatus = new Label();
            pnlStatus = new Panel();
            rdoNeedsSupport = new RadioButton();
            rdoStandard = new RadioButton();
            chkHelper = new CheckBox();
            btnRegister = new Button();
            btnBack = new Button();
            lblMessage = new Label();
            pnlLeft.SuspendLayout();
            pnlRole.SuspendLayout();
            pnlStatus.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(27, 31, 107);
            pnlLeft.Controls.Add(lblNote);
            pnlLeft.Controls.Add(lblStep3Text);
            pnlLeft.Controls.Add(lblStep2Text);
            pnlLeft.Controls.Add(lblStep3);
            pnlLeft.Controls.Add(lblStep2);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.ForeColor = Color.FromArgb(20, 26, 70);
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(334, 659);
            pnlLeft.TabIndex = 0;
            // 
            // lblNote
            // 
            lblNote.ForeColor = Color.FromArgb(225, 227, 245);
            lblNote.Location = new Point(12, 540);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(295, 84);
            lblNote.TabIndex = 5;
            lblNote.Text = "Volunteer accounts are approved by an administrator. Administrator accounts are limited to authorised personnel.\r\n";
            // 
            // lblStep3Text
            // 
            lblStep3Text.BackColor = Color.FromArgb(27, 31, 107);
            lblStep3Text.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStep3Text.ForeColor = Color.White;
            lblStep3Text.Location = new Point(72, 298);
            lblStep3Text.Name = "lblStep3Text";
            lblStep3Text.Size = new Size(212, 24);
            lblStep3Text.TabIndex = 7;
            lblStep3Text.Text = "Log in";
            // 
            // lblStep2Text
            // 
            lblStep2Text.BackColor = Color.FromArgb(27, 31, 107);
            lblStep2Text.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStep2Text.ForeColor = Color.White;
            lblStep2Text.Location = new Point(72, 246);
            lblStep2Text.Name = "lblStep2Text";
            lblStep2Text.Size = new Size(212, 24);
            lblStep2Text.TabIndex = 5;
            lblStep2Text.Text = "Choose your role";
            // 
            // lblStep3
            // 
            lblStep3.BackColor = Color.White;
            lblStep3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStep3.ForeColor = Color.FromArgb(27, 31, 107);
            lblStep3.Location = new Point(30, 294);
            lblStep3.Name = "lblStep3";
            lblStep3.Size = new Size(30, 30);
            lblStep3.TabIndex = 6;
            lblStep3.Text = "3";
            lblStep3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStep2
            // 
            lblStep2.BackColor = Color.FromArgb(240, 176, 64);
            lblStep2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStep2.ForeColor = Color.FromArgb(90, 58, 0);
            lblStep2.Location = new Point(30, 242);
            lblStep2.Name = "lblStep2";
            lblStep2.Size = new Size(30, 30);
            lblStep2.TabIndex = 5;
            lblStep2.Text = "2";
            lblStep2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBrand
            // 
            lblBrand.BackColor = Color.FromArgb(27, 31, 107);
            lblBrand.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(28, 36);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(244, 52);
            lblBrand.TabIndex = 1;
            lblBrand.Text = "ResQ";
            // 
            // lblTagline
            // 
            lblTagline.BackColor = Color.FromArgb(27, 31, 107);
            lblTagline.Font = new Font("Segoe UI", 11F);
            lblTagline.ForeColor = Color.White;
            lblTagline.Location = new Point(30, 100);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(266, 70);
            lblTagline.TabIndex = 2;
            lblTagline.Text = "Register once. Each role\r\nonly sees the forms it needs.";
            // 
            // lblStep1
            // 
            lblStep1.BackColor = Color.FromArgb(217, 58, 43);
            lblStep1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStep1.ForeColor = Color.White;
            lblStep1.Location = new Point(30, 190);
            lblStep1.Name = "lblStep1";
            lblStep1.Size = new Size(30, 30);
            lblStep1.TabIndex = 3;
            lblStep1.Text = "1";
            lblStep1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStep1Text
            // 
            lblStep1Text.BackColor = Color.FromArgb(27, 31, 107);
            lblStep1Text.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStep1Text.ForeColor = Color.White;
            lblStep1Text.Location = new Point(72, 194);
            lblStep1Text.Name = "lblStep1Text";
            lblStep1Text.Size = new Size(212, 24);
            lblStep1Text.TabIndex = 4;
            lblStep1Text.Text = "Fill in your details";
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblTitle.Location = new Point(340, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(620, 44);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Register";
            // 
            // lblHint
            // 
            lblHint.BackColor = Color.White;
            lblHint.Font = new Font("Segoe UI", 10F);
            lblHint.ForeColor = Color.FromArgb(61, 68, 104);
            lblHint.Location = new Point(342, 66);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(618, 30);
            lblHint.TabIndex = 6;
            lblHint.Text = "Only the information needed to coordinate help is collected.";
            // 
            // lblFullName
            // 
            lblFullName.BackColor = Color.White;
            lblFullName.ForeColor = Color.FromArgb(20, 26, 70);
            lblFullName.Location = new Point(340, 104);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(290, 24);
            lblFullName.TabIndex = 7;
            lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.ForeColor = Color.FromArgb(20, 26, 70);
            txtFullName.Location = new Point(340, 128);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(290, 30);
            txtFullName.TabIndex = 8;
            txtFullName.TextChanged += textBox1_TextChanged;
            // 
            // lblPhone
            // 
            lblPhone.BackColor = Color.White;
            lblPhone.ForeColor = Color.FromArgb(20, 26, 70);
            lblPhone.Location = new Point(670, 104);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(290, 24);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "Phone Number";
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.ForeColor = Color.FromArgb(20, 26, 70);
            txtPhone.Location = new Point(670, 128);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(290, 30);
            txtPhone.TabIndex = 10;
            // 
            // lblUsername
            // 
            lblUsername.BackColor = Color.White;
            lblUsername.ForeColor = Color.FromArgb(20, 26, 70);
            lblUsername.Location = new Point(340, 172);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(290, 24);
            lblUsername.TabIndex = 14;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.ForeColor = Color.FromArgb(20, 26, 70);
            txtUsername.Location = new Point(340, 196);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(290, 30);
            txtUsername.TabIndex = 15;
            // 
            // lblArea
            // 
            lblArea.BackColor = Color.White;
            lblArea.ForeColor = Color.FromArgb(20, 26, 70);
            lblArea.Location = new Point(670, 172);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(290, 24);
            lblArea.TabIndex = 16;
            lblArea.Text = "Area";
            // 
            // txtArea
            // 
            txtArea.BorderStyle = BorderStyle.FixedSingle;
            txtArea.ForeColor = Color.FromArgb(20, 26, 70);
            txtArea.Location = new Point(670, 196);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(290, 30);
            txtArea.TabIndex = 17;
            // 
            // lblPassword
            // 
            lblPassword.BackColor = Color.White;
            lblPassword.ForeColor = Color.FromArgb(20, 26, 70);
            lblPassword.Location = new Point(340, 240);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(290, 24);
            lblPassword.TabIndex = 18;
            lblPassword.Text = "Password";
            // 
            // lblConfirm
            // 
            lblConfirm.BackColor = Color.White;
            lblConfirm.ForeColor = Color.FromArgb(20, 26, 70);
            lblConfirm.Location = new Point(670, 240);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(290, 24);
            lblConfirm.TabIndex = 19;
            lblConfirm.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.ForeColor = Color.FromArgb(20, 26, 70);
            txtPassword.Location = new Point(340, 264);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(290, 30);
            txtPassword.TabIndex = 20;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirm
            // 
            txtConfirm.BorderStyle = BorderStyle.FixedSingle;
            txtConfirm.ForeColor = Color.FromArgb(20, 26, 70);
            txtConfirm.Location = new Point(670, 264);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(290, 30);
            txtConfirm.TabIndex = 21;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // lblRole
            // 
            lblRole.BackColor = Color.White;
            lblRole.ForeColor = Color.FromArgb(20, 26, 70);
            lblRole.Location = new Point(340, 308);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(620, 24);
            lblRole.TabIndex = 22;
            lblRole.Text = "I am registering as";
            // 
            // pnlRole
            // 
            pnlRole.BackColor = Color.White;
            pnlRole.Controls.Add(rdoVolunteer);
            pnlRole.Controls.Add(rdoResident);
            pnlRole.ForeColor = Color.FromArgb(20, 26, 70);
            pnlRole.Location = new Point(340, 332);
            pnlRole.Name = "pnlRole";
            pnlRole.Size = new Size(620, 63);
            pnlRole.TabIndex = 23;
            // 
            // rdoVolunteer
            // 
            rdoVolunteer.Appearance = Appearance.Button;
            rdoVolunteer.Cursor = Cursors.Hand;
            rdoVolunteer.FlatStyle = FlatStyle.Flat;
            rdoVolunteer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoVolunteer.Location = new Point(316, 0);
            rdoVolunteer.Name = "rdoVolunteer";
            rdoVolunteer.Padding = new Padding(10, 0, 0, 0);
            rdoVolunteer.Size = new Size(304, 60);
            rdoVolunteer.TabIndex = 25;
            rdoVolunteer.TabStop = true;
            rdoVolunteer.Text = "Volunteer\r\n(I can help, needs approval)\r\n";
            rdoVolunteer.UseVisualStyleBackColor = false;
            // 
            // rdoResident
            // 
            rdoResident.Appearance = Appearance.Button;
            rdoResident.BackColor = Color.White;
            rdoResident.Checked = true;
            rdoResident.Cursor = Cursors.Hand;
            rdoResident.FlatStyle = FlatStyle.Flat;
            rdoResident.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoResident.Location = new Point(0, 0);
            rdoResident.Name = "rdoResident";
            rdoResident.Padding = new Padding(10, 0, 0, 0);
            rdoResident.Size = new Size(304, 60);
            rdoResident.TabIndex = 24;
            rdoResident.TabStop = true;
            rdoResident.Text = "Resident\r\n(I may need help)";
            rdoResident.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.White;
            lblStatus.ForeColor = Color.FromArgb(20, 26, 70);
            lblStatus.Location = new Point(340, 398);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(620, 24);
            lblStatus.TabIndex = 24;
            lblStatus.Text = "Resident Status";
            // 
            // pnlStatus
            // 
            pnlStatus.BackColor = Color.White;
            pnlStatus.Controls.Add(rdoNeedsSupport);
            pnlStatus.Controls.Add(rdoStandard);
            pnlStatus.ForeColor = Color.FromArgb(20, 26, 70);
            pnlStatus.Location = new Point(340, 422);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(620, 64);
            pnlStatus.TabIndex = 25;
            // 
            // rdoNeedsSupport
            // 
            rdoNeedsSupport.Appearance = Appearance.Button;
            rdoNeedsSupport.Cursor = Cursors.Hand;
            rdoNeedsSupport.FlatStyle = FlatStyle.Flat;
            rdoNeedsSupport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rdoNeedsSupport.Location = new Point(316, 0);
            rdoNeedsSupport.Name = "rdoNeedsSupport";
            rdoNeedsSupport.Padding = new Padding(10, 0, 0, 0);
            rdoNeedsSupport.Size = new Size(304, 61);
            rdoNeedsSupport.TabIndex = 1;
            rdoNeedsSupport.Text = "Needs Support\r\n(older adult, OKU, single parent)";
            rdoNeedsSupport.UseVisualStyleBackColor = false;
            // 
            // rdoStandard
            // 
            rdoStandard.Appearance = Appearance.Button;
            rdoStandard.Checked = true;
            rdoStandard.Cursor = Cursors.Hand;
            rdoStandard.FlatStyle = FlatStyle.Flat;
            rdoStandard.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            rdoStandard.Location = new Point(0, 0);
            rdoStandard.Name = "rdoStandard";
            rdoStandard.Padding = new Padding(10, 0, 0, 0);
            rdoStandard.Size = new Size(304, 61);
            rdoStandard.TabIndex = 0;
            rdoStandard.TabStop = true;
            rdoStandard.Text = "Standard";
            rdoStandard.UseVisualStyleBackColor = false;
            // 
            // chkHelper
            // 
            chkHelper.BackColor = Color.White;
            chkHelper.ForeColor = Color.FromArgb(20, 26, 70);
            chkHelper.Location = new Point(340, 492);
            chkHelper.Name = "chkHelper";
            chkHelper.Size = new Size(620, 28);
            chkHelper.TabIndex = 26;
            chkHelper.Text = "A helper is filling this in on my behalf";
            chkHelper.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(217, 58, 43);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderColor = Color.FromArgb(217, 58, 43);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(340, 540);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(410, 48);
            btnRegister.TabIndex = 27;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(139, 147, 181);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(20, 26, 70);
            btnBack.Location = new Point(770, 540);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(190, 48);
            btnBack.TabIndex = 28;
            btnBack.Text = "Back to login";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.White;
            lblMessage.ForeColor = Color.FromArgb(217, 58, 43);
            lblMessage.Location = new Point(340, 604);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(620, 46);
            lblMessage.TabIndex = 29;
            // 
            // RegisterForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            ClientSize = new Size(982, 659);
            Controls.Add(lblMessage);
            Controls.Add(btnBack);
            Controls.Add(btnRegister);
            Controls.Add(chkHelper);
            Controls.Add(pnlStatus);
            Controls.Add(lblStatus);
            Controls.Add(pnlRole);
            Controls.Add(lblRole);
            Controls.Add(txtConfirm);
            Controls.Add(txtPassword);
            Controls.Add(lblConfirm);
            Controls.Add(lblPassword);
            Controls.Add(txtArea);
            Controls.Add(lblArea);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(lblHint);
            Controls.Add(lblTitle);
            Controls.Add(lblStep1Text);
            Controls.Add(lblStep1);
            Controls.Add(lblTagline);
            Controls.Add(lblBrand);
            Controls.Add(pnlLeft);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ResQ - Registration and Role Selection";
            Load += RegisterForm_Load;
            pnlLeft.ResumeLayout(false);
            pnlRole.ResumeLayout(false);
            pnlStatus.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLeft;
        private Label lblBrand;
        private Label lblTagline;
        private Label lblStep1;
        private Label lblStep1Text;
        private Label lblUsername;
        private Label lblStep2Text;
        private Label lblStep3;
        private Label lblStep2;
        private Label lblNote;
        private Label lblStep3Text;
        private Label lblTitle;
        private Label lblHint;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblPhone;
        private TextBox txtPhone;
        private TextBox txtUsername;
        private Label lblArea;
        private TextBox txtArea;
        private Label lblPassword;
        private Label lblConfirm;
        private TextBox txtPassword;
        private TextBox txtConfirm;
        private Label lblRole;
        private Panel pnlRole;
        private RadioButton rdoResident;
        private RadioButton rdoVolunteer;
        private Label lblStatus;
        private Panel pnlStatus;
        private RadioButton rdoStandard;
        private RadioButton rdoNeedsSupport;
        private CheckBox chkHelper;
        private Button btnRegister;
        private Button btnBack;
        private Label lblMessage;
    }
}