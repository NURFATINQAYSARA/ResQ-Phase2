namespace ResQ.Forms
{
    partial class AssignVolunteerForm
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
            lblTitle = new Label();
            lblRequest = new Label();
            lblVolunteer = new Label();
            cmbVolunteer = new ComboBox();
            btnAssign = new Button();
            btnCancel = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblTitle.Location = new Point(20, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(520, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Assign volunteer";
            // 
            // lblRequest
            // 
            lblRequest.ForeColor = Color.FromArgb(20, 26, 70);
            lblRequest.Location = new Point(20, 70);
            lblRequest.Name = "lblRequest";
            lblRequest.Size = new Size(520, 32);
            lblRequest.TabIndex = 1;
            lblRequest.Text = "Request ID: -";
            // 
            // lblVolunteer
            // 
            lblVolunteer.ForeColor = Color.FromArgb(20, 26, 70);
            lblVolunteer.Location = new Point(20, 122);
            lblVolunteer.Name = "lblVolunteer";
            lblVolunteer.Size = new Size(520, 26);
            lblVolunteer.TabIndex = 2;
            lblVolunteer.Text = "Approved volunteer\t";
            // 
            // cmbVolunteer
            // 
            cmbVolunteer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVolunteer.FormattingEnabled = true;
            cmbVolunteer.Location = new Point(20, 154);
            cmbVolunteer.Name = "cmbVolunteer";
            cmbVolunteer.Size = new Size(520, 36);
            cmbVolunteer.TabIndex = 3;
            // 
            // btnAssign
            // 
            btnAssign.BackColor = Color.FromArgb(27, 31, 107);
            btnAssign.FlatStyle = FlatStyle.Flat;
            btnAssign.ForeColor = Color.White;
            btnAssign.Location = new Point(20, 212);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(150, 40);
            btnAssign.TabIndex = 4;
            btnAssign.Text = "Assign\t";
            btnAssign.UseVisualStyleBackColor = false;
            btnAssign.Click += btnAssign_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(201, 205, 223);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.FromArgb(20, 26, 70);
            btnCancel.Location = new Point(186, 212);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel\t";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.FromArgb(20, 26, 70);
            lblStatus.Location = new Point(20, 272);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(520, 44);
            lblStatus.TabIndex = 6;
            // 
            // AssignVolunteerForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(241, 242, 248);
            ClientSize = new Size(609, 362);
            Controls.Add(lblStatus);
            Controls.Add(btnCancel);
            Controls.Add(btnAssign);
            Controls.Add(cmbVolunteer);
            Controls.Add(lblVolunteer);
            Controls.Add(lblRequest);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AssignVolunteerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Assign volunteer";
            Load += AssignVolunteerForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblRequest;
        private Label lblVolunteer;
        private ComboBox cmbVolunteer;
        private Button btnAssign;
        private Button btnCancel;
        private Label lblStatus;
    }
}