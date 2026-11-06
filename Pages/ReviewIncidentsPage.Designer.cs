namespace ResQ.Pages
{
    partial class ReviewIncidentsPage
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
            lblSubtitle = new Label();
            lblStatus = new Label();
            lblWaiting = new Label();
            flowPending = new FlowLayoutPanel();
            pnlIncidentTemplate = new Panel();
            lblHazardName = new Label();
            lblIncidentLocation = new Label();
            lblIncidentPriority = new Label();
            flowPending.SuspendLayout();
            pnlIncidentTemplate.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblTitle.Location = new Point(24, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(650, 44);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Review incidents reports";
            // 
            // lblSubtitle
            // 
            lblSubtitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblSubtitle.Location = new Point(24, 72);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(852, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Verify high-priority reports tp reduce false or duplicate entries.";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.AutoEllipsis = true;
            lblStatus.ForeColor = Color.FromArgb(20, 26, 70);
            lblStatus.Location = new Point(24, 584);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(852, 30);
            lblStatus.TabIndex = 2;
            // 
            // lblWaiting
            // 
            lblWaiting.ForeColor = Color.FromArgb(20, 26, 70);
            lblWaiting.Location = new Point(24, 112);
            lblWaiting.Name = "lblWaiting";
            lblWaiting.Size = new Size(320, 24);
            lblWaiting.TabIndex = 3;
            lblWaiting.Text = "WAITING FOR REVIEW";
            // 
            // flowPending
            // 
            flowPending.AutoScroll = true;
            flowPending.Controls.Add(pnlIncidentTemplate);
            flowPending.FlowDirection = FlowDirection.TopDown;
            flowPending.Location = new Point(24, 148);
            flowPending.Name = "flowPending";
            flowPending.Size = new Size(320, 410);
            flowPending.TabIndex = 4;
            flowPending.WrapContents = false;
            // 
            // pnlIncidentTemplate
            // 
            pnlIncidentTemplate.BackColor = Color.White;
            pnlIncidentTemplate.Controls.Add(lblIncidentPriority);
            pnlIncidentTemplate.Controls.Add(lblIncidentLocation);
            pnlIncidentTemplate.Controls.Add(lblHazardName);
            pnlIncidentTemplate.Location = new Point(0, 0);
            pnlIncidentTemplate.Margin = new Padding(0, 0, 0, 12);
            pnlIncidentTemplate.Name = "pnlIncidentTemplate";
            pnlIncidentTemplate.Size = new Size(296, 94);
            pnlIncidentTemplate.TabIndex = 0;
            // 
            // lblHazardName
            // 
            lblHazardName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHazardName.ForeColor = Color.FromArgb(20, 26, 70);
            lblHazardName.Location = new Point(14, 12);
            lblHazardName.Name = "lblHazardName";
            lblHazardName.Size = new Size(182, 24);
            lblHazardName.TabIndex = 0;
            lblHazardName.Text = "Fallen tree";
            // 
            // lblIncidentLocation
            // 
            lblIncidentLocation.ForeColor = Color.FromArgb(61, 68, 104);
            lblIncidentLocation.Location = new Point(14, 42);
            lblIncidentLocation.Name = "lblIncidentLocation";
            lblIncidentLocation.Size = new Size(182, 24);
            lblIncidentLocation.TabIndex = 1;
            lblIncidentLocation.Text = "Location";
            // 
            // lblIncidentPriority
            // 
            lblIncidentPriority.BackColor = Color.FromArgb(248, 215, 211);
            lblIncidentPriority.ForeColor = Color.FromArgb(143, 29, 23);
            lblIncidentPriority.Location = new Point(204, 28);
            lblIncidentPriority.Name = "lblIncidentPriority";
            lblIncidentPriority.Size = new Size(78, 30);
            lblIncidentPriority.TabIndex = 2;
            lblIncidentPriority.Text = "High";
            lblIncidentPriority.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReviewIncidentsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowPending);
            Controls.Add(lblWaiting);
            Controls.Add(lblStatus);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Name = "ReviewIncidentsPage";
            Size = new Size(898, 662);
            flowPending.ResumeLayout(false);
            pnlIncidentTemplate.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblStatus;
        private Label lblWaiting;
        private FlowLayoutPanel flowPending;
        private Panel pnlIncidentTemplate;
        private Label lblIncidentLocation;
        private Label lblHazardName;
        private Label lblIncidentPriority;
    }
}