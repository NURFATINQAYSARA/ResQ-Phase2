namespace ResQ.Pages
{
    partial class RequestFeedPage
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
            chkAvailable = new CheckBox();
            btnRefresh = new Button();
            btnAll = new Button();
            btnHigh = new Button();
            btnLow = new Button();
            btnMedium = new Button();
            lblMessage = new Label();
            lblFooter = new Label();
            flpRequests = new FlowLayoutPanel();
            pnlCardTemplate = new Panel();
            btnAccept = new Button();
            lblCardStatus = new Label();
            lblCardPriority = new Label();
            lblCardDetails = new Label();
            lblNeedsSupport = new Label();
            lblCardTitle = new Label();
            pnlStripe = new Panel();
            flpRequests.SuspendLayout();
            pnlCardTemplate.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblTitle.Location = new Point(24, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 36);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Request Feed";
            // 
            // lblSubtitle
            // 
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.ForeColor = Color.FromArgb(61, 68, 104);
            lblSubtitle.Location = new Point(24, 54);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(560, 22);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Highest priority first, Needs Support residents are highlighted.";
            // 
            // chkAvailable
            // 
            chkAvailable.BackColor = Color.Transparent;
            chkAvailable.ForeColor = Color.FromArgb(20, 26, 70);
            chkAvailable.Location = new Point(660, 24);
            chkAvailable.Name = "chkAvailable";
            chkAvailable.Size = new Size(110, 30);
            chkAvailable.TabIndex = 2;
            chkAvailable.Text = "Available";
            chkAvailable.UseVisualStyleBackColor = false;
            chkAvailable.CheckedChanged += chkAvailable_CheckedChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(139, 147, 181);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.FromArgb(20, 26, 70);
            btnRefresh.Location = new Point(776, 20);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 30);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAll
            // 
            btnAll.Cursor = Cursors.Hand;
            btnAll.FlatAppearance.BorderColor = Color.FromArgb(139, 147, 181);
            btnAll.FlatStyle = FlatStyle.Flat;
            btnAll.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAll.Location = new Point(24, 90);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(90, 34);
            btnAll.TabIndex = 4;
            btnAll.Text = "All";
            btnAll.UseVisualStyleBackColor = false;
            btnAll.Click += btnAll_Click;
            // 
            // btnHigh
            // 
            btnHigh.Cursor = Cursors.Hand;
            btnHigh.FlatAppearance.BorderColor = Color.FromArgb(139, 147, 181);
            btnHigh.FlatStyle = FlatStyle.Flat;
            btnHigh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHigh.Location = new Point(122, 90);
            btnHigh.Name = "btnHigh";
            btnHigh.Size = new Size(80, 34);
            btnHigh.TabIndex = 5;
            btnHigh.Text = "High";
            btnHigh.UseVisualStyleBackColor = false;
            btnHigh.Click += btnHigh_Click;
            // 
            // btnLow
            // 
            btnLow.Cursor = Cursors.Hand;
            btnLow.FlatAppearance.BorderColor = Color.FromArgb(139, 147, 181);
            btnLow.FlatStyle = FlatStyle.Flat;
            btnLow.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLow.Location = new Point(314, 90);
            btnLow.Name = "btnLow";
            btnLow.Size = new Size(76, 34);
            btnLow.TabIndex = 6;
            btnLow.Text = "Low";
            btnLow.UseVisualStyleBackColor = false;
            btnLow.Click += btnLow_Click;
            // 
            // btnMedium
            // 
            btnMedium.Cursor = Cursors.Hand;
            btnMedium.FlatAppearance.BorderColor = Color.FromArgb(139, 147, 181);
            btnMedium.FlatStyle = FlatStyle.Flat;
            btnMedium.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMedium.Location = new Point(210, 90);
            btnMedium.Name = "btnMedium";
            btnMedium.Size = new Size(96, 34);
            btnMedium.TabIndex = 7;
            btnMedium.Text = "Medium";
            btnMedium.UseVisualStyleBackColor = false;
            btnMedium.Click += btnMedium_Click;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.Transparent;
            lblMessage.Font = new Font("Segoe UI", 9F);
            lblMessage.ForeColor = Color.FromArgb(61, 68, 104);
            lblMessage.Location = new Point(400, 96);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(476, 22);
            lblMessage.TabIndex = 8;
            // 
            // lblFooter
            // 
            lblFooter.BackColor = Color.Transparent;
            lblFooter.Font = new Font("Segoe UI", 10F);
            lblFooter.ForeColor = Color.FromArgb(61, 68, 104);
            lblFooter.Location = new Point(24, 584);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(600, 22);
            lblFooter.TabIndex = 9;
            lblFooter.Text = "Once accepted, a request is no longer offered to other volunteers.";
            // 
            // flpRequests
            // 
            flpRequests.AutoScroll = true;
            flpRequests.Controls.Add(pnlCardTemplate);
            flpRequests.FlowDirection = FlowDirection.TopDown;
            flpRequests.Location = new Point(24, 134);
            flpRequests.Name = "flpRequests";
            flpRequests.Size = new Size(852, 440);
            flpRequests.TabIndex = 10;
            flpRequests.WrapContents = false;
            // 
            // pnlCardTemplate
            // 
            pnlCardTemplate.BackColor = Color.White;
            pnlCardTemplate.Controls.Add(btnAccept);
            pnlCardTemplate.Controls.Add(lblCardStatus);
            pnlCardTemplate.Controls.Add(lblCardPriority);
            pnlCardTemplate.Controls.Add(lblCardDetails);
            pnlCardTemplate.Controls.Add(lblNeedsSupport);
            pnlCardTemplate.Controls.Add(lblCardTitle);
            pnlCardTemplate.Controls.Add(pnlStripe);
            pnlCardTemplate.Location = new Point(3, 3);
            pnlCardTemplate.Name = "pnlCardTemplate";
            pnlCardTemplate.Padding = new Padding(0, 0, 0, 12);
            pnlCardTemplate.Size = new Size(826, 88);
            pnlCardTemplate.TabIndex = 0;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.FromArgb(240, 176, 64);
            btnAccept.Cursor = Cursors.Hand;
            btnAccept.FlatAppearance.BorderColor = Color.FromArgb(240, 176, 64);
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAccept.ForeColor = Color.FromArgb(59, 39, 0);
            btnAccept.Location = new Point(736, 24);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(76, 40);
            btnAccept.TabIndex = 6;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // lblCardStatus
            // 
            lblCardStatus.BackColor = Color.FromArgb(228, 229, 234);
            lblCardStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardStatus.ForeColor = Color.FromArgb(61, 68, 104);
            lblCardStatus.Location = new Point(648, 30);
            lblCardStatus.Name = "lblCardStatus";
            lblCardStatus.Size = new Size(80, 26);
            lblCardStatus.TabIndex = 5;
            lblCardStatus.Text = "Status";
            lblCardStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCardPriority
            // 
            lblCardPriority.BackColor = Color.FromArgb(228, 229, 234);
            lblCardPriority.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardPriority.ForeColor = Color.FromArgb(61, 68, 104);
            lblCardPriority.Location = new Point(560, 30);
            lblCardPriority.Name = "lblCardPriority";
            lblCardPriority.Size = new Size(80, 26);
            lblCardPriority.TabIndex = 4;
            lblCardPriority.Text = "Priority";
            lblCardPriority.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCardDetails
            // 
            lblCardDetails.BackColor = Color.Transparent;
            lblCardDetails.ForeColor = Color.FromArgb(61, 68, 104);
            lblCardDetails.Location = new Point(24, 50);
            lblCardDetails.Name = "lblCardDetails";
            lblCardDetails.Size = new Size(520, 22);
            lblCardDetails.TabIndex = 3;
            lblCardDetails.Text = "Location - People - Mobility";
            // 
            // lblNeedsSupport
            // 
            lblNeedsSupport.BackColor = Color.FromArgb(27, 31, 107);
            lblNeedsSupport.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblNeedsSupport.ForeColor = Color.White;
            lblNeedsSupport.Location = new Point(220, 16);
            lblNeedsSupport.Name = "lblNeedsSupport";
            lblNeedsSupport.Size = new Size(124, 22);
            lblNeedsSupport.TabIndex = 2;
            lblNeedsSupport.Text = "NEEDS SUPPORT";
            lblNeedsSupport.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCardTitle
            // 
            lblCardTitle.BackColor = Color.Transparent;
            lblCardTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardTitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblCardTitle.Location = new Point(24, 14);
            lblCardTitle.Name = "lblCardTitle";
            lblCardTitle.Size = new Size(190, 26);
            lblCardTitle.TabIndex = 1;
            lblCardTitle.Text = "Help type";
            // 
            // pnlStripe
            // 
            pnlStripe.BackColor = Color.FromArgb(217, 58, 43);
            pnlStripe.Location = new Point(0, 0);
            pnlStripe.Name = "pnlStripe";
            pnlStripe.Size = new Size(8, 88);
            pnlStripe.TabIndex = 0;
            // 
            // RequestFeedPage
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(241, 242, 248);
            Controls.Add(flpRequests);
            Controls.Add(lblFooter);
            Controls.Add(lblMessage);
            Controls.Add(btnMedium);
            Controls.Add(btnLow);
            Controls.Add(btnHigh);
            Controls.Add(btnAll);
            Controls.Add(btnRefresh);
            Controls.Add(chkAvailable);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Name = "RequestFeedPage";
            Size = new Size(987, 734);
            flpRequests.ResumeLayout(false);
            pnlCardTemplate.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private CheckBox chkAvailable;
        private Button btnRefresh;
        private Button btnAll;
        private Button btnHigh;
        private Button btnLow;
        private Button btnMedium;
        private Label lblMessage;
        private Label lblFooter;
        private FlowLayoutPanel flpRequests;
        private Panel pnlCardTemplate;
        private Label lblCardTitle;
        private Panel pnlStripe;
        private Label lblCardDetails;
        private Label lblNeedsSupport;
        private Button btnAccept;
        private Label lblCardStatus;
        private Label lblCardPriority;
    }
}
