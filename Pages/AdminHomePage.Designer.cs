namespace ResQ.Pages
{
    partial class AdminHomePage
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
            pnlPending = new Panel();
            lblPending = new Label();
            countPending = new Label();
            bandPending = new Panel();
            pnlAccepted = new Panel();
            lblAccepted = new Label();
            countAccepted = new Label();
            bandAccepted = new Panel();
            pnlProgress = new Panel();
            lblProgress = new Label();
            countProgress = new Label();
            bandProgress = new Panel();
            pnlSafe = new Panel();
            lblSafe = new Label();
            countSafe = new Label();
            bandSafe = new Panel();
            pnlCompleted = new Panel();
            lblCompleted = new Label();
            countCompleted = new Label();
            bandCompleted = new Panel();
            pnlAttention = new Panel();
            lblPendingRequest = new Label();
            lblVolunteers = new Label();
            btnOpen = new Button();
            btnApprove = new Button();
            btnReview = new Button();
            lblIncidents = new Label();
            lblAttentionTitle = new Label();
            pnlRisks = new Panel();
            flowAreaRisks = new FlowLayoutPanel();
            pnlAreaTemplate = new Panel();
            lblAreaBadge = new Label();
            lblAreaName = new Label();
            lblRiskTitle = new Label();
            pnlPending.SuspendLayout();
            pnlAccepted.SuspendLayout();
            pnlProgress.SuspendLayout();
            pnlSafe.SuspendLayout();
            pnlCompleted.SuspendLayout();
            pnlAttention.SuspendLayout();
            pnlRisks.SuspendLayout();
            flowAreaRisks.SuspendLayout();
            pnlAreaTemplate.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(241, 242, 248);
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblTitle.Location = new Point(24, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(650, 44);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Administrator home";
            // 
            // lblSubtitle
            // 
            lblSubtitle.BackColor = Color.FromArgb(241, 242, 248);
            lblSubtitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblSubtitle.Location = new Point(24, 72);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(852, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Monitor requests, keep information accurate, review the log.";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
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
            lblStatus.BackColor = Color.FromArgb(241, 242, 248);
            lblStatus.ForeColor = Color.FromArgb(20, 26, 70);
            lblStatus.Location = new Point(24, 825);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(1111, 30);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "clear it so it’s empty";
            // 
            // pnlPending
            // 
            pnlPending.BackColor = Color.White;
            pnlPending.Controls.Add(lblPending);
            pnlPending.Controls.Add(countPending);
            pnlPending.Controls.Add(bandPending);
            pnlPending.Location = new Point(24, 112);
            pnlPending.Name = "pnlPending";
            pnlPending.Size = new Size(156, 96);
            pnlPending.TabIndex = 4;
            // 
            // lblPending
            // 
            lblPending.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblPending.Location = new Point(14, 62);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(128, 32);
            lblPending.TabIndex = 2;
            lblPending.Text = "Pending";
            lblPending.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // countPending
            // 
            countPending.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            countPending.Location = new Point(14, 8);
            countPending.Name = "countPending";
            countPending.Size = new Size(128, 52);
            countPending.TabIndex = 1;
            countPending.Text = "0";
            countPending.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bandPending
            // 
            bandPending.BackColor = Color.FromArgb(110, 110, 110);
            bandPending.Location = new Point(0, 0);
            bandPending.Name = "bandPending";
            bandPending.Size = new Size(156, 5);
            bandPending.TabIndex = 0;
            // 
            // pnlAccepted
            // 
            pnlAccepted.BackColor = Color.White;
            pnlAccepted.Controls.Add(lblAccepted);
            pnlAccepted.Controls.Add(countAccepted);
            pnlAccepted.Controls.Add(bandAccepted);
            pnlAccepted.Location = new Point(198, 112);
            pnlAccepted.Name = "pnlAccepted";
            pnlAccepted.Size = new Size(156, 96);
            pnlAccepted.TabIndex = 5;
            // 
            // lblAccepted
            // 
            lblAccepted.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblAccepted.Location = new Point(14, 62);
            lblAccepted.Name = "lblAccepted";
            lblAccepted.Size = new Size(128, 32);
            lblAccepted.TabIndex = 2;
            lblAccepted.Text = "Accepted";
            lblAccepted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // countAccepted
            // 
            countAccepted.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            countAccepted.Location = new Point(14, 8);
            countAccepted.Name = "countAccepted";
            countAccepted.Size = new Size(128, 52);
            countAccepted.TabIndex = 1;
            countAccepted.Text = "0";
            countAccepted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bandAccepted
            // 
            bandAccepted.BackColor = Color.FromArgb(240, 176, 64);
            bandAccepted.Location = new Point(0, 0);
            bandAccepted.Name = "bandAccepted";
            bandAccepted.Size = new Size(156, 5);
            bandAccepted.TabIndex = 0;
            // 
            // pnlProgress
            // 
            pnlProgress.BackColor = Color.White;
            pnlProgress.Controls.Add(lblProgress);
            pnlProgress.Controls.Add(countProgress);
            pnlProgress.Controls.Add(bandProgress);
            pnlProgress.Location = new Point(372, 112);
            pnlProgress.Name = "pnlProgress";
            pnlProgress.Size = new Size(156, 96);
            pnlProgress.TabIndex = 6;
            // 
            // lblProgress
            // 
            lblProgress.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblProgress.Location = new Point(14, 62);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(128, 32);
            lblProgress.TabIndex = 2;
            lblProgress.Text = "In Progress";
            lblProgress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // countProgress
            // 
            countProgress.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            countProgress.Location = new Point(14, 8);
            countProgress.Name = "countProgress";
            countProgress.Size = new Size(128, 52);
            countProgress.TabIndex = 1;
            countProgress.Text = "0";
            countProgress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bandProgress
            // 
            bandProgress.BackColor = Color.FromArgb(217, 58, 43);
            bandProgress.Location = new Point(0, 0);
            bandProgress.Name = "bandProgress";
            bandProgress.Size = new Size(156, 5);
            bandProgress.TabIndex = 0;
            // 
            // pnlSafe
            // 
            pnlSafe.BackColor = Color.White;
            pnlSafe.Controls.Add(lblSafe);
            pnlSafe.Controls.Add(countSafe);
            pnlSafe.Controls.Add(bandSafe);
            pnlSafe.Location = new Point(546, 112);
            pnlSafe.Name = "pnlSafe";
            pnlSafe.Size = new Size(156, 96);
            pnlSafe.TabIndex = 7;
            // 
            // lblSafe
            // 
            lblSafe.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblSafe.Location = new Point(2, 62);
            lblSafe.Name = "lblSafe";
            lblSafe.Size = new Size(151, 32);
            lblSafe.TabIndex = 2;
            lblSafe.Text = "Safe / Evacuated";
            lblSafe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // countSafe
            // 
            countSafe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            countSafe.Location = new Point(14, 8);
            countSafe.Name = "countSafe";
            countSafe.Size = new Size(128, 52);
            countSafe.TabIndex = 1;
            countSafe.Text = "0";
            countSafe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bandSafe
            // 
            bandSafe.BackColor = Color.FromArgb(31, 138, 76);
            bandSafe.Location = new Point(0, 0);
            bandSafe.Name = "bandSafe";
            bandSafe.Size = new Size(156, 5);
            bandSafe.TabIndex = 0;
            // 
            // pnlCompleted
            // 
            pnlCompleted.BackColor = Color.White;
            pnlCompleted.Controls.Add(lblCompleted);
            pnlCompleted.Controls.Add(countCompleted);
            pnlCompleted.Controls.Add(bandCompleted);
            pnlCompleted.Location = new Point(720, 112);
            pnlCompleted.Name = "pnlCompleted";
            pnlCompleted.Size = new Size(156, 96);
            pnlCompleted.TabIndex = 8;
            // 
            // lblCompleted
            // 
            lblCompleted.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCompleted.Location = new Point(2, 62);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(151, 32);
            lblCompleted.TabIndex = 2;
            lblCompleted.Text = "Completed";
            lblCompleted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // countCompleted
            // 
            countCompleted.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            countCompleted.Location = new Point(14, 8);
            countCompleted.Name = "countCompleted";
            countCompleted.Size = new Size(128, 52);
            countCompleted.TabIndex = 1;
            countCompleted.Text = "0";
            countCompleted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bandCompleted
            // 
            bandCompleted.BackColor = Color.FromArgb(27, 31, 107);
            bandCompleted.Location = new Point(0, 0);
            bandCompleted.Name = "bandCompleted";
            bandCompleted.Size = new Size(156, 5);
            bandCompleted.TabIndex = 0;
            // 
            // pnlAttention
            // 
            pnlAttention.BackColor = Color.White;
            pnlAttention.Controls.Add(lblPendingRequest);
            pnlAttention.Controls.Add(lblVolunteers);
            pnlAttention.Controls.Add(btnOpen);
            pnlAttention.Controls.Add(btnApprove);
            pnlAttention.Controls.Add(btnReview);
            pnlAttention.Controls.Add(lblIncidents);
            pnlAttention.Controls.Add(lblAttentionTitle);
            pnlAttention.Location = new Point(23, 253);
            pnlAttention.Name = "pnlAttention";
            pnlAttention.Size = new Size(490, 278);
            pnlAttention.TabIndex = 9;
            // 
            // lblPendingRequest
            // 
            lblPendingRequest.AutoSize = true;
            lblPendingRequest.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPendingRequest.Location = new Point(18, 209);
            lblPendingRequest.Name = "lblPendingRequest";
            lblPendingRequest.Size = new Size(289, 25);
            lblPendingRequest.TabIndex = 6;
            lblPendingRequest.Text = "Pending requests need attention";
            // 
            // lblVolunteers
            // 
            lblVolunteers.AutoSize = true;
            lblVolunteers.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVolunteers.Location = new Point(18, 144);
            lblVolunteers.Name = "lblVolunteers";
            lblVolunteers.Size = new Size(324, 25);
            lblVolunteers.TabIndex = 5;
            lblVolunteers.Text = "Volunteer accounts waiting approval";
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.Navy;
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.ForeColor = Color.White;
            btnOpen.Location = new Point(358, 204);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(112, 38);
            btnOpen.TabIndex = 4;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.Navy;
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(358, 138);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(112, 38);
            btnApprove.TabIndex = 3;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnReview
            // 
            btnReview.BackColor = Color.FromArgb(27, 31, 107);
            btnReview.FlatStyle = FlatStyle.Flat;
            btnReview.ForeColor = Color.White;
            btnReview.Location = new Point(358, 72);
            btnReview.Name = "btnReview";
            btnReview.Size = new Size(112, 38);
            btnReview.TabIndex = 2;
            btnReview.Text = "Review";
            btnReview.UseVisualStyleBackColor = false;
            btnReview.Click += btnReview_Click;
            // 
            // lblIncidents
            // 
            lblIncidents.AutoSize = true;
            lblIncidents.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIncidents.Location = new Point(18, 76);
            lblIncidents.Name = "lblIncidents";
            lblIncidents.Size = new Size(247, 25);
            lblIncidents.TabIndex = 1;
            lblIncidents.Text = "Pending incidents to review";
            // 
            // lblAttentionTitle
            // 
            lblAttentionTitle.AutoSize = true;
            lblAttentionTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAttentionTitle.Location = new Point(18, 16);
            lblAttentionTitle.Name = "lblAttentionTitle";
            lblAttentionTitle.Size = new Size(257, 32);
            lblAttentionTitle.TabIndex = 0;
            lblAttentionTitle.Text = "Needs your attention";
            // 
            // pnlRisks
            // 
            pnlRisks.BackColor = Color.White;
            pnlRisks.Controls.Add(flowAreaRisks);
            pnlRisks.Controls.Add(lblRiskTitle);
            pnlRisks.Location = new Point(537, 252);
            pnlRisks.Name = "pnlRisks";
            pnlRisks.Size = new Size(338, 320);
            pnlRisks.TabIndex = 10;
            // 
            // flowAreaRisks
            // 
            flowAreaRisks.AutoScroll = true;
            flowAreaRisks.Controls.Add(pnlAreaTemplate);
            flowAreaRisks.FlowDirection = FlowDirection.TopDown;
            flowAreaRisks.Location = new Point(16, 60);
            flowAreaRisks.Name = "flowAreaRisks";
            flowAreaRisks.Size = new Size(306, 244);
            flowAreaRisks.TabIndex = 1;
            flowAreaRisks.WrapContents = false;
            // 
            // pnlAreaTemplate
            // 
            pnlAreaTemplate.Controls.Add(lblAreaBadge);
            pnlAreaTemplate.Controls.Add(lblAreaName);
            pnlAreaTemplate.Location = new Point(0, 0);
            pnlAreaTemplate.Margin = new Padding(0, 0, 0, 8);
            pnlAreaTemplate.Name = "pnlAreaTemplate";
            pnlAreaTemplate.Size = new Size(264, 46);
            pnlAreaTemplate.TabIndex = 0;
            // 
            // lblAreaBadge
            // 
            lblAreaBadge.AutoSize = true;
            lblAreaBadge.BackColor = Color.FromArgb(248, 215, 211);
            lblAreaBadge.ForeColor = Color.FromArgb(143, 29, 23);
            lblAreaBadge.Location = new Point(164, 8);
            lblAreaBadge.Name = "lblAreaBadge";
            lblAreaBadge.Size = new Size(54, 28);
            lblAreaBadge.TabIndex = 1;
            lblAreaBadge.Text = "High";
            lblAreaBadge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAreaName
            // 
            lblAreaName.AutoSize = true;
            lblAreaName.Location = new Point(8, 8);
            lblAreaName.Name = "lblAreaName";
            lblAreaName.Size = new Size(105, 28);
            lblAreaName.TabIndex = 0;
            lblAreaName.Text = "Area name";
            // 
            // lblRiskTitle
            // 
            lblRiskTitle.AutoSize = true;
            lblRiskTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRiskTitle.Location = new Point(16, 16);
            lblRiskTitle.Name = "lblRiskTitle";
            lblRiskTitle.Size = new Size(186, 32);
            lblRiskTitle.TabIndex = 0;
            lblRiskTitle.Text = "Area risk levels";
            // 
            // AdminHomePage
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(241, 242, 248);
            Controls.Add(pnlRisks);
            Controls.Add(pnlAttention);
            Controls.Add(pnlCompleted);
            Controls.Add(pnlSafe);
            Controls.Add(pnlProgress);
            Controls.Add(pnlAccepted);
            Controls.Add(pnlPending);
            Controls.Add(lblStatus);
            Controls.Add(btnRefresh);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            ForeColor = Color.FromArgb(20, 26, 70);
            Location = new Point(24, 236);
            Name = "AdminHomePage";
            Size = new Size(1087, 566);
            pnlPending.ResumeLayout(false);
            pnlAccepted.ResumeLayout(false);
            pnlProgress.ResumeLayout(false);
            pnlSafe.ResumeLayout(false);
            pnlCompleted.ResumeLayout(false);
            pnlAttention.ResumeLayout(false);
            pnlAttention.PerformLayout();
            pnlRisks.ResumeLayout(false);
            pnlRisks.PerformLayout();
            flowAreaRisks.ResumeLayout(false);
            pnlAreaTemplate.ResumeLayout(false);
            pnlAreaTemplate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Button btnRefresh;
        private Label lblStatus;
        private Panel pnlPending;
        private Label countPending;
        private Panel bandPending;
        private Label lblPending;
        private Panel pnlAccepted;
        private Label lblAccepted;
        private Label countAccepted;
        private Panel bandAccepted;
        private Panel pnlProgress;
        private Label lblProgress;
        private Label countProgress;
        private Panel bandProgress;
        private Panel pnlSafe;
        private Label lblSafe;
        private Label countSafe;
        private Panel bandSafe;
        private Panel pnlCompleted;
        private Label lblCompleted;
        private Label countCompleted;
        private Panel bandCompleted;
        private Panel pnlAttention;
        private Label lblIncidents;
        private Label lblAttentionTitle;
        private Button btnOpen;
        private Button btnApprove;
        private Button btnReview;
        private Label lblPendingRequest;
        private Label lblVolunteers;
        private Panel pnlRisks;
        private Label lblRiskTitle;
        private FlowLayoutPanel flowAreaRisks;
        private Panel pnlAreaTemplate;
        private Label lblAreaName;
        private Label lblAreaBadge;
    }
}
