namespace ResQ.Pages
{
    partial class ResidentHomePage
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
            lblTitle = new Label();
            lblSubtitle = new Label();
            btnRefresh = new Button();
            lblStatus = new Label();
            pnlRiskAlert = new Panel();
            lblRiskBadge = new Label();
            lblAlertUpdated = new Label();
            lblAlertTitle = new Label();
            btnSubmit = new Button();
            btnReport = new Button();
            btnShelter = new Button();
            pnlRecent = new Panel();
            dgvRecent = new DataGridView();
            lblRecentTitle = new Label();
            pnlRiskAlert.SuspendLayout();
            pnlRecent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecent).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblTitle.Location = new Point(24, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(650, 44);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome back";
            lblTitle.Click += label1_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblSubtitle.Location = new Point(24, 72);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(852, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Status and area load after login.";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(201, 205, 223);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.FromArgb(20, 26, 70);
            btnRefresh.Location = new Point(760, 22);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(116, 38);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.AutoEllipsis = true;
            lblStatus.ForeColor = Color.FromArgb(20, 26, 70);
            lblStatus.Location = new Point(24, 540);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(1118, 30);
            lblStatus.TabIndex = 3;
            // 
            // pnlRiskAlert
            // 
            pnlRiskAlert.BackColor = Color.FromArgb(248, 215, 211);
            pnlRiskAlert.Controls.Add(lblRiskBadge);
            pnlRiskAlert.Controls.Add(lblAlertUpdated);
            pnlRiskAlert.Controls.Add(lblAlertTitle);
            pnlRiskAlert.Location = new Point(24, 112);
            pnlRiskAlert.Name = "pnlRiskAlert";
            pnlRiskAlert.Size = new Size(852, 92);
            pnlRiskAlert.TabIndex = 4;
            // 
            // lblRiskBadge
            // 
            lblRiskBadge.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRiskBadge.ForeColor = Color.FromArgb(143, 29, 23);
            lblRiskBadge.Location = new Point(660, 24);
            lblRiskBadge.Name = "lblRiskBadge";
            lblRiskBadge.Size = new Size(170, 42);
            lblRiskBadge.TabIndex = 2;
            lblRiskBadge.Text = "RISK";
            lblRiskBadge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAlertUpdated
            // 
            lblAlertUpdated.ForeColor = Color.FromArgb(61, 68, 104);
            lblAlertUpdated.Location = new Point(20, 52);
            lblAlertUpdated.Name = "lblAlertUpdated";
            lblAlertUpdated.Size = new Size(610, 26);
            lblAlertUpdated.TabIndex = 1;
            lblAlertUpdated.Text = "Last updated: -";
            // 
            // lblAlertTitle
            // 
            lblAlertTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAlertTitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblAlertTitle.Location = new Point(20, 16);
            lblAlertTitle.Name = "lblAlertTitle";
            lblAlertTitle.Size = new Size(610, 34);
            lblAlertTitle.TabIndex = 0;
            lblAlertTitle.Text = "Area risk information";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(217, 58, 43);
            btnSubmit.FlatAppearance.BorderColor = Color.FromArgb(201, 205, 223);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(27, 228);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(272, 86);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Ask for help\r\nSubmit a request";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.FromArgb(251, 233, 200);
            btnReport.FlatAppearance.BorderColor = Color.FromArgb(201, 205, 223);
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.ForeColor = Color.FromArgb(107, 74, 7);
            btnReport.Location = new Point(314, 228);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(272, 86);
            btnReport.TabIndex = 6;
            btnReport.Text = "Report a hazard\r\nFallen tree, blocked road";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // btnShelter
            // 
            btnShelter.BackColor = Color.FromArgb(220, 221, 243);
            btnShelter.FlatAppearance.BorderColor = Color.FromArgb(201, 205, 223);
            btnShelter.FlatStyle = FlatStyle.Flat;
            btnShelter.ForeColor = Color.FromArgb(27, 31, 107);
            btnShelter.Location = new Point(604, 228);
            btnShelter.Name = "btnShelter";
            btnShelter.Size = new Size(272, 86);
            btnShelter.TabIndex = 7;
            btnShelter.Text = "Find a shelter\r\nSearch the directory";
            btnShelter.UseVisualStyleBackColor = false;
            btnShelter.Click += btnShelter_Click;
            // 
            // pnlRecent
            // 
            pnlRecent.BackColor = Color.White;
            pnlRecent.Controls.Add(dgvRecent);
            pnlRecent.Controls.Add(lblRecentTitle);
            pnlRecent.Location = new Point(24, 340);
            pnlRecent.Name = "pnlRecent";
            pnlRecent.Size = new Size(852, 224);
            pnlRecent.TabIndex = 8;
            // 
            // dgvRecent
            // 
            dgvRecent.AllowUserToAddRows = false;
            dgvRecent.AllowUserToDeleteRows = false;
            dgvRecent.BackgroundColor = Color.White;
            dgvRecent.BorderStyle = BorderStyle.None;
            dgvRecent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecent.Location = new Point(16, 58);
            dgvRecent.MultiSelect = false;
            dgvRecent.Name = "dgvRecent";
            dgvRecent.ReadOnly = true;
            dgvRecent.RowHeadersVisible = false;
            dgvRecent.RowHeadersWidth = 62;
            dgvRecent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecent.Size = new Size(820, 148);
            dgvRecent.TabIndex = 1;
            // 
            // lblRecentTitle
            // 
            lblRecentTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRecentTitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblRecentTitle.Location = new Point(16, 14);
            lblRecentTitle.Name = "lblRecentTitle";
            lblRecentTitle.Size = new Size(820, 30);
            lblRecentTitle.TabIndex = 0;
            lblRecentTitle.Text = "My recent requests";
            // 
            // ResidentHomePage
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(241, 242, 248);
            Controls.Add(pnlRecent);
            Controls.Add(btnShelter);
            Controls.Add(btnReport);
            Controls.Add(btnSubmit);
            Controls.Add(pnlRiskAlert);
            Controls.Add(lblStatus);
            Controls.Add(btnRefresh);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Name = "ResidentHomePage";
            Size = new Size(1166, 562);
            pnlRiskAlert.ResumeLayout(false);
            pnlRecent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Button btnRefresh;
        private Label lblStatus;
        private Panel pnlRiskAlert;
        private Label lblRiskBadge;
        private Label lblAlertUpdated;
        private Label lblAlertTitle;
        private Button btnSubmit;
        private Button btnReport;
        private Button btnShelter;
        private Panel pnlRecent;
        private DataGridView dgvRecent;
        private Label lblRecentTitle;
    }
}
