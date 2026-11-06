namespace ResQ.Pages
{
    partial class RequestMonitorPage
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
            btnAll = new Button();
            btnPending = new Button();
            btnProgress = new Button();
            btnCompleted = new Button();
            pnlRequests = new Panel();
            dgvRequests = new DataGridView();
            lblStatus = new Label();
            lblNote = new Label();
            pnlRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
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
            lblTitle.Text = "Request monitor";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblSubtitle.Location = new Point(24, 72);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(852, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "All requests. Assign a volunteer to a Pending request, or verify a finished one.";
            // 
            // btnRefresh
            // 
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
            // btnAll
            // 
            btnAll.BackColor = Color.FromArgb(27, 31, 107);
            btnAll.FlatAppearance.BorderColor = Color.FromArgb(201, 205, 223);
            btnAll.FlatStyle = FlatStyle.Flat;
            btnAll.ForeColor = Color.White;
            btnAll.Location = new Point(24, 112);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(126, 40);
            btnAll.TabIndex = 3;
            btnAll.Text = "All";
            btnAll.UseVisualStyleBackColor = false;
            btnAll.Click += btnAll_Click;
            // 
            // btnPending
            // 
            btnPending.BackColor = Color.White;
            btnPending.FlatAppearance.BorderColor = Color.FromArgb(201, 205, 223);
            btnPending.FlatStyle = FlatStyle.Flat;
            btnPending.ForeColor = Color.FromArgb(20, 26, 70);
            btnPending.Location = new Point(162, 112);
            btnPending.Name = "btnPending";
            btnPending.Size = new Size(140, 40);
            btnPending.TabIndex = 4;
            btnPending.Text = "Pending";
            btnPending.UseVisualStyleBackColor = false;
            btnPending.Click += btnPending_Click;
            // 
            // btnProgress
            // 
            btnProgress.BackColor = Color.White;
            btnProgress.FlatAppearance.BorderColor = Color.FromArgb(201, 205, 223);
            btnProgress.FlatStyle = FlatStyle.Flat;
            btnProgress.ForeColor = Color.FromArgb(20, 26, 70);
            btnProgress.Location = new Point(314, 112);
            btnProgress.Name = "btnProgress";
            btnProgress.Size = new Size(150, 40);
            btnProgress.TabIndex = 5;
            btnProgress.Text = "In Progress";
            btnProgress.UseVisualStyleBackColor = false;
            btnProgress.Click += btnProgress_Click;
            // 
            // btnCompleted
            // 
            btnCompleted.BackColor = Color.White;
            btnCompleted.FlatAppearance.BorderColor = Color.FromArgb(201, 205, 223);
            btnCompleted.FlatStyle = FlatStyle.Flat;
            btnCompleted.ForeColor = Color.FromArgb(20, 26, 70);
            btnCompleted.Location = new Point(476, 112);
            btnCompleted.Name = "btnCompleted";
            btnCompleted.Size = new Size(150, 40);
            btnCompleted.TabIndex = 6;
            btnCompleted.Text = "Completed";
            btnCompleted.UseVisualStyleBackColor = false;
            btnCompleted.Click += btnCompleted_Click;
            // 
            // pnlRequests
            // 
            pnlRequests.BackColor = Color.White;
            pnlRequests.Controls.Add(dgvRequests);
            pnlRequests.Location = new Point(24, 176);
            pnlRequests.Name = "pnlRequests";
            pnlRequests.Size = new Size(852, 340);
            pnlRequests.TabIndex = 7;
            // 
            // dgvRequests
            // 
            dgvRequests.AllowUserToAddRows = false;
            dgvRequests.AllowUserToDeleteRows = false;
            dgvRequests.BackgroundColor = Color.White;
            dgvRequests.BorderStyle = BorderStyle.None;
            dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequests.Location = new Point(12, 12);
            dgvRequests.MultiSelect = false;
            dgvRequests.Name = "dgvRequests";
            dgvRequests.ReadOnly = true;
            dgvRequests.RowHeadersVisible = false;
            dgvRequests.RowHeadersWidth = 62;
            dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequests.Size = new Size(828, 316);
            dgvRequests.TabIndex = 0;
            dgvRequests.CellContentClick += dgvRequests_CellContentClick;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.AutoEllipsis = true;
            lblStatus.ForeColor = Color.FromArgb(20, 26, 70);
            lblStatus.Location = new Point(24, 990);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(1011, 30);
            lblStatus.TabIndex = 8;
            // 
            // lblNote
            // 
            lblNote.ForeColor = Color.FromArgb(20, 26, 70);
            lblNote.Location = new Point(24, 536);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(852, 34);
            lblNote.TabIndex = 9;
            lblNote.Text = "NS = Needs Support. Verified completions are written to the Safety Log.";
            // 
            // RequestMonitorPage
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(241, 242, 248);
            Controls.Add(lblNote);
            Controls.Add(lblStatus);
            Controls.Add(pnlRequests);
            Controls.Add(btnCompleted);
            Controls.Add(btnProgress);
            Controls.Add(btnPending);
            Controls.Add(btnAll);
            Controls.Add(btnRefresh);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Name = "RequestMonitorPage";
            Size = new Size(1059, 494);
            pnlRequests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Button btnRefresh;
        private Button btnAll;
        private Button btnPending;
        private Button btnProgress;
        private Button btnCompleted;
        private Panel pnlRequests;
        private DataGridView dgvRequests;
        private Label lblStatus;
        private Label lblNote;
    }
}
