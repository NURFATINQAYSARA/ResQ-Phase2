namespace ResQ.Pages
{
    partial class ReportIncidentPage
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
            lblHazard = new Label();
            lblStatus = new Label();
            pnlHazardChoices = new Panel();
            rdoFlood = new RadioButton();
            rdoRoad = new RadioButton();
            rdoTree = new RadioButton();
            lblLocation = new Label();
            txtLocation = new TextBox();
            lblPriority = new Label();
            pnlPriorityChoices = new Panel();
            rdoHigh = new RadioButton();
            rdoMedium = new RadioButton();
            rdoLow = new RadioButton();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnSend = new Button();
            btnClear = new Button();
            pnlMyReports = new Panel();
            btnRefresh = new Button();
            dgvMyReports = new DataGridView();
            lblMyReports = new Label();
            pnlHazardChoices.SuspendLayout();
            pnlPriorityChoices.SuspendLayout();
            pnlMyReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyReports).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblTitle.Location = new Point(24, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(650, 75);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Report an Incident";
            // 
            // lblSubtitle
            // 
            lblSubtitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblSubtitle.Location = new Point(24, 72);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(852, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Text the administrator about a hazard in your area.";
            // 
            // lblHazard
            // 
            lblHazard.ForeColor = Color.FromArgb(20, 26, 70);
            lblHazard.Location = new Point(24, 112);
            lblHazard.Name = "lblHazard";
            lblHazard.Size = new Size(452, 38);
            lblHazard.TabIndex = 2;
            lblHazard.Text = "Hazard type";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.AutoEllipsis = true;
            lblStatus.ForeColor = Color.FromArgb(20, 26, 70);
            lblStatus.Location = new Point(24, 584);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(852, 30);
            lblStatus.TabIndex = 3;
            // 
            // pnlHazardChoices
            // 
            pnlHazardChoices.Controls.Add(rdoFlood);
            pnlHazardChoices.Controls.Add(rdoRoad);
            pnlHazardChoices.Controls.Add(rdoTree);
            pnlHazardChoices.Location = new Point(24, 142);
            pnlHazardChoices.Name = "pnlHazardChoices";
            pnlHazardChoices.Size = new Size(452, 58);
            pnlHazardChoices.TabIndex = 4;
            // 
            // rdoFlood
            // 
            rdoFlood.Appearance = Appearance.Button;
            rdoFlood.BackColor = Color.White;
            rdoFlood.FlatStyle = FlatStyle.Flat;
            rdoFlood.ForeColor = Color.FromArgb(27, 31, 107);
            rdoFlood.Location = new Point(308, 4);
            rdoFlood.Name = "rdoFlood";
            rdoFlood.Size = new Size(144, 44);
            rdoFlood.TabIndex = 2;
            rdoFlood.TabStop = true;
            rdoFlood.Text = "Flooding";
            rdoFlood.TextAlign = ContentAlignment.MiddleCenter;
            rdoFlood.UseVisualStyleBackColor = false;
            // 
            // rdoRoad
            // 
            rdoRoad.Appearance = Appearance.Button;
            rdoRoad.BackColor = Color.White;
            rdoRoad.FlatStyle = FlatStyle.Flat;
            rdoRoad.ForeColor = Color.FromArgb(20, 26, 70);
            rdoRoad.Location = new Point(154, 4);
            rdoRoad.Name = "rdoRoad";
            rdoRoad.Size = new Size(144, 44);
            rdoRoad.TabIndex = 1;
            rdoRoad.TabStop = true;
            rdoRoad.Text = "Blocked road";
            rdoRoad.TextAlign = ContentAlignment.MiddleCenter;
            rdoRoad.UseVisualStyleBackColor = false;
            // 
            // rdoTree
            // 
            rdoTree.Appearance = Appearance.Button;
            rdoTree.BackColor = Color.White;
            rdoTree.FlatStyle = FlatStyle.Flat;
            rdoTree.ForeColor = Color.FromArgb(217, 58, 43);
            rdoTree.Location = new Point(0, 4);
            rdoTree.Name = "rdoTree";
            rdoTree.Size = new Size(144, 44);
            rdoTree.TabIndex = 0;
            rdoTree.TabStop = true;
            rdoTree.Text = "Fallen tree";
            rdoTree.TextAlign = ContentAlignment.MiddleCenter;
            rdoTree.UseVisualStyleBackColor = false;
            // 
            // lblLocation
            // 
            lblLocation.ForeColor = Color.FromArgb(20, 26, 70);
            lblLocation.Location = new Point(24, 212);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(452, 34);
            lblLocation.TabIndex = 5;
            lblLocation.Text = "Location";
            // 
            // txtLocation
            // 
            txtLocation.BackColor = Color.White;
            txtLocation.ForeColor = Color.FromArgb(20, 26, 70);
            txtLocation.Location = new Point(24, 240);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(452, 39);
            txtLocation.TabIndex = 6;
            // 
            // lblPriority
            // 
            lblPriority.ForeColor = Color.FromArgb(20, 26, 70);
            lblPriority.Location = new Point(24, 286);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(452, 32);
            lblPriority.TabIndex = 7;
            lblPriority.Text = "Priority";
            // 
            // pnlPriorityChoices
            // 
            pnlPriorityChoices.Controls.Add(rdoHigh);
            pnlPriorityChoices.Controls.Add(rdoMedium);
            pnlPriorityChoices.Controls.Add(rdoLow);
            pnlPriorityChoices.Location = new Point(24, 316);
            pnlPriorityChoices.Name = "pnlPriorityChoices";
            pnlPriorityChoices.Size = new Size(452, 56);
            pnlPriorityChoices.TabIndex = 8;
            // 
            // rdoHigh
            // 
            rdoHigh.Appearance = Appearance.Button;
            rdoHigh.BackColor = Color.White;
            rdoHigh.FlatStyle = FlatStyle.Flat;
            rdoHigh.ForeColor = Color.FromArgb(217, 58, 43);
            rdoHigh.Location = new Point(244, 4);
            rdoHigh.Name = "rdoHigh";
            rdoHigh.Size = new Size(100, 44);
            rdoHigh.TabIndex = 2;
            rdoHigh.TabStop = true;
            rdoHigh.Text = "High";
            rdoHigh.TextAlign = ContentAlignment.MiddleCenter;
            rdoHigh.UseVisualStyleBackColor = false;
            // 
            // rdoMedium
            // 
            rdoMedium.Appearance = Appearance.Button;
            rdoMedium.BackColor = Color.White;
            rdoMedium.FlatStyle = FlatStyle.Flat;
            rdoMedium.ForeColor = Color.FromArgb(107, 74, 7);
            rdoMedium.Location = new Point(112, 4);
            rdoMedium.Name = "rdoMedium";
            rdoMedium.Size = new Size(120, 44);
            rdoMedium.TabIndex = 1;
            rdoMedium.TabStop = true;
            rdoMedium.Text = "Medium";
            rdoMedium.TextAlign = ContentAlignment.MiddleCenter;
            rdoMedium.UseVisualStyleBackColor = false;
            // 
            // rdoLow
            // 
            rdoLow.Appearance = Appearance.Button;
            rdoLow.BackColor = Color.White;
            rdoLow.FlatStyle = FlatStyle.Flat;
            rdoLow.ForeColor = Color.FromArgb(31, 138, 76);
            rdoLow.Location = new Point(0, 4);
            rdoLow.Name = "rdoLow";
            rdoLow.Size = new Size(100, 44);
            rdoLow.TabIndex = 0;
            rdoLow.TabStop = true;
            rdoLow.Text = "Low";
            rdoLow.TextAlign = ContentAlignment.MiddleCenter;
            rdoLow.UseVisualStyleBackColor = false;
            // 
            // lblDescription
            // 
            lblDescription.ForeColor = Color.FromArgb(20, 26, 70);
            lblDescription.Location = new Point(24, 386);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(452, 36);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.ForeColor = Color.FromArgb(20, 26, 70);
            txtDescription.Location = new Point(24, 414);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(452, 104);
            txtDescription.TabIndex = 10;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(217, 58, 43);
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(24, 538);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(152, 51);
            btnSend.TabIndex = 11;
            btnSend.Text = "Send report";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.FromArgb(20, 26, 70);
            btnClear.Location = new Point(182, 538);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 51);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // pnlMyReports
            // 
            pnlMyReports.BackColor = Color.White;
            pnlMyReports.Controls.Add(btnRefresh);
            pnlMyReports.Controls.Add(dgvMyReports);
            pnlMyReports.Controls.Add(lblMyReports);
            pnlMyReports.Location = new Point(500, 112);
            pnlMyReports.Name = "pnlMyReports";
            pnlMyReports.Size = new Size(376, 300);
            pnlMyReports.TabIndex = 13;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.FromArgb(20, 26, 70);
            btnRefresh.Location = new Point(250, 256);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 38);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvMyReports
            // 
            dgvMyReports.AllowUserToAddRows = false;
            dgvMyReports.AllowUserToDeleteRows = false;
            dgvMyReports.BackgroundColor = Color.White;
            dgvMyReports.BorderStyle = BorderStyle.None;
            dgvMyReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyReports.Location = new Point(16, 54);
            dgvMyReports.MultiSelect = false;
            dgvMyReports.Name = "dgvMyReports";
            dgvMyReports.ReadOnly = true;
            dgvMyReports.RowHeadersVisible = false;
            dgvMyReports.RowHeadersWidth = 82;
            dgvMyReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMyReports.Size = new Size(344, 198);
            dgvMyReports.TabIndex = 1;
            // 
            // lblMyReports
            // 
            lblMyReports.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMyReports.ForeColor = Color.FromArgb(20, 26, 70);
            lblMyReports.Location = new Point(16, 10);
            lblMyReports.Name = "lblMyReports";
            lblMyReports.Size = new Size(344, 50);
            lblMyReports.TabIndex = 0;
            lblMyReports.Text = "My reports";
            // 
            // ReportIncidentPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMyReports);
            Controls.Add(btnClear);
            Controls.Add(btnSend);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(pnlPriorityChoices);
            Controls.Add(lblPriority);
            Controls.Add(txtLocation);
            Controls.Add(lblLocation);
            Controls.Add(pnlHazardChoices);
            Controls.Add(lblStatus);
            Controls.Add(lblHazard);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Name = "ReportIncidentPage";
            Size = new Size(1783, 813);
            pnlHazardChoices.ResumeLayout(false);
            pnlPriorityChoices.ResumeLayout(false);
            pnlMyReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMyReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblHazard;
        private Label lblStatus;
        private Panel pnlHazardChoices;
        private RadioButton rdoTree;
        private RadioButton rdoFlood;
        private RadioButton rdoRoad;
        private Label lblLocation;
        private TextBox txtLocation;
        private Label lblPriority;
        private Panel pnlPriorityChoices;
        private RadioButton rdoMedium;
        private RadioButton rdoLow;
        private RadioButton rdoHigh;
        private Label lblDescription;
        private TextBox txtDescription;
        private Button btnSend;
        private Button btnClear;
        private Panel pnlMyReports;
        private DataGridView dgvMyReports;
        private Label lblMyReports;
        private Button btnRefresh;
    }
}