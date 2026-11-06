namespace ResQ.Forms
{
    partial class VolunteerApprovalForm
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
            lblInfo = new Label();
            dgvVolunteers = new DataGridView();
            btnApprove = new Button();
            btnClose = new Button();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVolunteers).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblTitle.Location = new Point(20, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(520, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Volunteer approval\t";
            // 
            // lblInfo
            // 
            lblInfo.ForeColor = Color.FromArgb(20, 26, 70);
            lblInfo.Location = new Point(20, 66);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(520, 28);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Select a waiting volunteer, then Approve.";
            // 
            // dgvVolunteers
            // 
            dgvVolunteers.AllowUserToAddRows = false;
            dgvVolunteers.AllowUserToDeleteRows = false;
            dgvVolunteers.BackgroundColor = Color.White;
            dgvVolunteers.BorderStyle = BorderStyle.None;
            dgvVolunteers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVolunteers.Location = new Point(20, 106);
            dgvVolunteers.MultiSelect = false;
            dgvVolunteers.Name = "dgvVolunteers";
            dgvVolunteers.ReadOnly = true;
            dgvVolunteers.RowHeadersVisible = false;
            dgvVolunteers.RowHeadersWidth = 62;
            dgvVolunteers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVolunteers.Size = new Size(520, 204);
            dgvVolunteers.TabIndex = 2;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.FromArgb(27, 31, 107);
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(20, 328);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(150, 40);
            btnApprove.TabIndex = 3;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.FromArgb(20, 26, 70);
            btnClose.Location = new Point(186, 328);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 40);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.FromArgb(20, 26, 70);
            lblStatus.Location = new Point(20, 380);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(520, 34);
            lblStatus.TabIndex = 5;
            // 
            // VolunteerApprovalForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 242, 248);
            ClientSize = new Size(592, 419);
            Controls.Add(lblStatus);
            Controls.Add(btnClose);
            Controls.Add(btnApprove);
            Controls.Add(dgvVolunteers);
            Controls.Add(lblInfo);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VolunteerApprovalForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Volunteer approval";
            ((System.ComponentModel.ISupportInitialize)dgvVolunteers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblInfo;
        private DataGridView dgvVolunteers;
        private Button btnApprove;
        private Button btnClose;
        private Label lblStatus;
    }
}