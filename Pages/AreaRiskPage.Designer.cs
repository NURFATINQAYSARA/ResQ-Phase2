namespace ResQ.Pages
{
    partial class AreaRiskPage
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
            btnRefresh = new Button();
            lblSubtitle = new Label();
            lblStatus = new Label();
            flowRisks = new FlowLayoutPanel();
            pnlRiskTemplate = new Panel();
            lblRiskBadge = new Label();
            lblRiskNote = new Label();
            lblAreaName = new Label();
            pnlRiskBand = new Panel();
            flowRisks.SuspendLayout();
            pnlRiskTemplate.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(241, 242, 248);
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblTitle.Location = new Point(24, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(852, 74);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Area Risk Dashboard";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.FromArgb(20, 26, 70);
            btnRefresh.Location = new Point(760, 22);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(116, 47);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSubtitle.AutoEllipsis = true;
            lblSubtitle.BackColor = Color.FromArgb(241, 242, 248);
            lblSubtitle.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblSubtitle.Location = new Point(24, 132);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(852, 40);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Latest levels set by the administrator. Shown by the colour and by text.";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.AutoEllipsis = true;
            lblStatus.BackColor = Color.FromArgb(241, 242, 248);
            lblStatus.ForeColor = Color.FromArgb(20, 26, 70);
            lblStatus.Location = new Point(24, 172);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(852, 460);
            lblStatus.TabIndex = 2;
            // 
            // flowRisks
            // 
            flowRisks.AutoScroll = true;
            flowRisks.BackColor = Color.FromArgb(241, 242, 248);
            flowRisks.Controls.Add(pnlRiskTemplate);
            flowRisks.FlowDirection = FlowDirection.TopDown;
            flowRisks.Location = new Point(24, 112);
            flowRisks.Name = "flowRisks";
            flowRisks.Size = new Size(852, 460);
            flowRisks.TabIndex = 3;
            flowRisks.WrapContents = false;
            // 
            // pnlRiskTemplate
            // 
            pnlRiskTemplate.BackColor = Color.White;
            pnlRiskTemplate.Controls.Add(lblRiskBadge);
            pnlRiskTemplate.Controls.Add(lblRiskNote);
            pnlRiskTemplate.Controls.Add(lblAreaName);
            pnlRiskTemplate.Controls.Add(pnlRiskBand);
            pnlRiskTemplate.Location = new Point(0, 0);
            pnlRiskTemplate.Margin = new Padding(0, 0, 0, 12);
            pnlRiskTemplate.Name = "pnlRiskTemplate";
            pnlRiskTemplate.Size = new Size(820, 80);
            pnlRiskTemplate.TabIndex = 0;
            // 
            // lblRiskBadge
            // 
            lblRiskBadge.BackColor = Color.FromArgb(217, 58, 43);
            lblRiskBadge.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRiskBadge.ForeColor = Color.White;
            lblRiskBadge.Location = new Point(650, 20);
            lblRiskBadge.Name = "lblRiskBadge";
            lblRiskBadge.Size = new Size(146, 40);
            lblRiskBadge.TabIndex = 3;
            lblRiskBadge.Text = "HIGH";
            lblRiskBadge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRiskNote
            // 
            lblRiskNote.ForeColor = Color.FromArgb(61, 68, 104);
            lblRiskNote.Location = new Point(24, 38);
            lblRiskNote.Name = "lblRiskNote";
            lblRiskNote.Size = new Size(580, 36);
            lblRiskNote.TabIndex = 2;
            lblRiskNote.Text = "Area note and last updated time";
            // 
            // lblAreaName
            // 
            lblAreaName.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAreaName.ForeColor = Color.FromArgb(20, 26, 70);
            lblAreaName.Location = new Point(24, 0);
            lblAreaName.Name = "lblAreaName";
            lblAreaName.Size = new Size(580, 38);
            lblAreaName.TabIndex = 1;
            lblAreaName.Text = "Area name (your area)";
            // 
            // pnlRiskBand
            // 
            pnlRiskBand.BackColor = Color.FromArgb(217, 58, 43);
            pnlRiskBand.Location = new Point(0, 0);
            pnlRiskBand.Name = "pnlRiskBand";
            pnlRiskBand.Size = new Size(8, 80);
            pnlRiskBand.TabIndex = 0;
            // 
            // AreaRiskPage
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(flowRisks);
            Controls.Add(lblStatus);
            Controls.Add(lblSubtitle);
            Controls.Add(btnRefresh);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Name = "AreaRiskPage";
            Padding = new Padding(0);
            Size = new Size(1783, 873);
            flowRisks.ResumeLayout(false);
            pnlRiskTemplate.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Button btnRefresh;
        private Label lblSubtitle;
        private Label lblStatus;
        private FlowLayoutPanel flowRisks;
        private Panel pnlRiskTemplate;
        private Label lblRiskBadge;
        private Label lblRiskNote;
        private Label lblAreaName;
        private Panel pnlRiskBand;
    }
}
