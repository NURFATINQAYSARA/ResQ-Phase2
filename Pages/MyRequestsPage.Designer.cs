namespace ResQ.Pages
{
    partial class MyRequestsPage
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
            lblRequestTitle = new Label();
            lblLocation = new Label();
            cboRequests = new ComboBox();
            btnRefresh = new Button();
            btnCancel = new Button();
            lblStatus = new Label();
            lblMessage = new Label();
            pnlFlow = new Panel();
            lblStep5 = new Label();
            lblStep4 = new Label();
            lblStep2 = new Label();
            lblStep3 = new Label();
            lblStep1 = new Label();
            lblFlowTitle = new Label();
            pnlActivity = new Panel();
            lstActivity = new ListBox();
            lblActivityTitle = new Label();
            pnlVolunteer = new Panel();
            lblMobility = new Label();
            lblPeople = new Label();
            lblMobilityCaption = new Label();
            lblPeopleCaption = new Label();
            lblPriority = new Label();
            lblPriorityCaption = new Label();
            lblVolunteerRole = new Label();
            lblVolunteerName = new Label();
            lblInitials = new Label();
            lblVolunteerHeading = new Label();
            pnlVolunteerAccent = new Panel();
            pnlFlow.SuspendLayout();
            pnlActivity.SuspendLayout();
            pnlVolunteer.SuspendLayout();
            SuspendLayout();
            // 
            // lblRequestTitle
            // 
            lblRequestTitle.BackColor = Color.Transparent;
            lblRequestTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRequestTitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblRequestTitle.Location = new Point(24, 16);
            lblRequestTitle.Name = "lblRequestTitle";
            lblRequestTitle.Size = new Size(440, 36);
            lblRequestTitle.TabIndex = 0;
            lblRequestTitle.Text = "My Requests";
            // 
            // lblLocation
            // 
            lblLocation.BackColor = Color.Transparent;
            lblLocation.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLocation.ForeColor = Color.FromArgb(61, 68, 104);
            lblLocation.Location = new Point(24, 54);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(440, 22);
            lblLocation.TabIndex = 1;
            lblLocation.Text = "Choose one of your requests.";
            // 
            // cboRequests
            // 
            cboRequests.BackColor = Color.White;
            cboRequests.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRequests.ForeColor = Color.FromArgb(20, 26, 70);
            cboRequests.FormattingEnabled = true;
            cboRequests.Location = new Point(476, 24);
            cboRequests.Name = "cboRequests";
            cboRequests.Size = new Size(200, 31);
            cboRequests.TabIndex = 2;
            cboRequests.SelectedIndexChanged += cboRequests_SelectedIndexChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(139, 147, 181);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.FromArgb(20, 26, 70);
            btnRefresh.Location = new Point(686, 20);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 38);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(179, 38, 30);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(143, 29, 23);
            btnCancel.Location = new Point(786, 20);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 38);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.FromArgb(228, 229, 234);
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(51, 51, 51);
            lblStatus.Location = new Point(476, 58);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(130, 24);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "No Request";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.Transparent;
            lblMessage.Font = new Font("Segoe UI", 9F);
            lblMessage.ForeColor = Color.FromArgb(61, 68, 104);
            lblMessage.Location = new Point(24, 84);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(852, 22);
            lblMessage.TabIndex = 6;
            // 
            // pnlFlow
            // 
            pnlFlow.BackColor = Color.White;
            pnlFlow.Controls.Add(lblStep5);
            pnlFlow.Controls.Add(lblStep4);
            pnlFlow.Controls.Add(lblStep2);
            pnlFlow.Controls.Add(lblStep3);
            pnlFlow.Controls.Add(lblStep1);
            pnlFlow.Controls.Add(lblFlowTitle);
            pnlFlow.ForeColor = SystemColors.Desktop;
            pnlFlow.Location = new Point(24, 110);
            pnlFlow.Name = "pnlFlow";
            pnlFlow.Size = new Size(852, 128);
            pnlFlow.TabIndex = 7;
            // 
            // lblStep5
            // 
            lblStep5.BackColor = Color.FromArgb(228, 229, 234);
            lblStep5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStep5.ForeColor = Color.FromArgb(90, 95, 117);
            lblStep5.Location = new Point(672, 44);
            lblStep5.Name = "lblStep5";
            lblStep5.Size = new Size(158, 68);
            lblStep5.TabIndex = 5;
            lblStep5.Text = "Completed\r\nNot yet";
            lblStep5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStep4
            // 
            lblStep4.BackColor = Color.FromArgb(228, 229, 234);
            lblStep4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStep4.ForeColor = Color.FromArgb(90, 95, 117);
            lblStep4.Location = new Point(508, 44);
            lblStep4.Name = "lblStep4";
            lblStep4.Size = new Size(158, 68);
            lblStep4.TabIndex = 4;
            lblStep4.Text = "Safe/Evacuated\r\nNot yet";
            lblStep4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStep2
            // 
            lblStep2.BackColor = Color.FromArgb(228, 229, 234);
            lblStep2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStep2.ForeColor = Color.FromArgb(90, 95, 117);
            lblStep2.Location = new Point(180, 44);
            lblStep2.Name = "lblStep2";
            lblStep2.Size = new Size(158, 68);
            lblStep2.TabIndex = 3;
            lblStep2.Text = "Accepted\r\nNot yet";
            lblStep2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStep3
            // 
            lblStep3.BackColor = Color.FromArgb(228, 229, 234);
            lblStep3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStep3.ForeColor = Color.FromArgb(90, 95, 117);
            lblStep3.Location = new Point(344, 44);
            lblStep3.Name = "lblStep3";
            lblStep3.Size = new Size(158, 68);
            lblStep3.TabIndex = 2;
            lblStep3.Text = "In Progress\r\nNot yet";
            lblStep3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStep1
            // 
            lblStep1.BackColor = Color.FromArgb(228, 229, 234);
            lblStep1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStep1.ForeColor = Color.FromArgb(90, 95, 117);
            lblStep1.Location = new Point(16, 44);
            lblStep1.Name = "lblStep1";
            lblStep1.Size = new Size(158, 68);
            lblStep1.TabIndex = 1;
            lblStep1.Text = "Pending\r\nNot yet";
            lblStep1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFlowTitle
            // 
            lblFlowTitle.BackColor = Color.Transparent;
            lblFlowTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFlowTitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblFlowTitle.Location = new Point(16, 12);
            lblFlowTitle.Name = "lblFlowTitle";
            lblFlowTitle.Size = new Size(300, 24);
            lblFlowTitle.TabIndex = 0;
            lblFlowTitle.Text = "Status Flow";
            // 
            // pnlActivity
            // 
            pnlActivity.BackColor = Color.White;
            pnlActivity.Controls.Add(lstActivity);
            pnlActivity.Controls.Add(lblActivityTitle);
            pnlActivity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlActivity.ForeColor = Color.FromArgb(20, 26, 70);
            pnlActivity.Location = new Point(24, 254);
            pnlActivity.Name = "pnlActivity";
            pnlActivity.Size = new Size(500, 350);
            pnlActivity.TabIndex = 8;
            // 
            // lstActivity
            // 
            lstActivity.BackColor = Color.White;
            lstActivity.BorderStyle = BorderStyle.None;
            lstActivity.Font = new Font("Segoe UI", 10F);
            lstActivity.ForeColor = Color.FromArgb(20, 26, 70);
            lstActivity.FormattingEnabled = true;
            lstActivity.IntegralHeight = false;
            lstActivity.Location = new Point(16, 44);
            lstActivity.Name = "lstActivity";
            lstActivity.Size = new Size(468, 290);
            lstActivity.TabIndex = 1;
            // 
            // lblActivityTitle
            // 
            lblActivityTitle.BackColor = Color.Transparent;
            lblActivityTitle.Location = new Point(16, 12);
            lblActivityTitle.Name = "lblActivityTitle";
            lblActivityTitle.Size = new Size(300, 24);
            lblActivityTitle.TabIndex = 0;
            lblActivityTitle.Text = "Activity";
            // 
            // pnlVolunteer
            // 
            pnlVolunteer.BackColor = Color.White;
            pnlVolunteer.Controls.Add(lblMobility);
            pnlVolunteer.Controls.Add(lblPeople);
            pnlVolunteer.Controls.Add(lblMobilityCaption);
            pnlVolunteer.Controls.Add(lblPeopleCaption);
            pnlVolunteer.Controls.Add(lblPriority);
            pnlVolunteer.Controls.Add(lblPriorityCaption);
            pnlVolunteer.Controls.Add(lblVolunteerRole);
            pnlVolunteer.Controls.Add(lblVolunteerName);
            pnlVolunteer.Controls.Add(lblInitials);
            pnlVolunteer.Controls.Add(lblVolunteerHeading);
            pnlVolunteer.Controls.Add(pnlVolunteerAccent);
            pnlVolunteer.Location = new Point(540, 254);
            pnlVolunteer.Name = "pnlVolunteer";
            pnlVolunteer.Size = new Size(336, 350);
            pnlVolunteer.TabIndex = 9;
            // 
            // lblMobility
            // 
            lblMobility.BackColor = Color.Transparent;
            lblMobility.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMobility.ForeColor = Color.FromArgb(20, 26, 70);
            lblMobility.Location = new Point(140, 212);
            lblMobility.Name = "lblMobility";
            lblMobility.Size = new Size(180, 22);
            lblMobility.TabIndex = 10;
            lblMobility.Text = "-";
            lblMobility.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPeople
            // 
            lblPeople.BackColor = Color.Transparent;
            lblPeople.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPeople.ForeColor = Color.FromArgb(20, 26, 70);
            lblPeople.Location = new Point(140, 172);
            lblPeople.Name = "lblPeople";
            lblPeople.Size = new Size(180, 22);
            lblPeople.TabIndex = 9;
            lblPeople.Text = "-";
            lblPeople.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMobilityCaption
            // 
            lblMobilityCaption.BackColor = Color.Transparent;
            lblMobilityCaption.Font = new Font("Segoe UI", 10F);
            lblMobilityCaption.ForeColor = Color.FromArgb(61, 68, 104);
            lblMobilityCaption.Location = new Point(16, 212);
            lblMobilityCaption.Name = "lblMobilityCaption";
            lblMobilityCaption.Size = new Size(120, 22);
            lblMobilityCaption.TabIndex = 8;
            lblMobilityCaption.Text = "Mobility";
            // 
            // lblPeopleCaption
            // 
            lblPeopleCaption.BackColor = Color.Transparent;
            lblPeopleCaption.Font = new Font("Segoe UI", 10F);
            lblPeopleCaption.ForeColor = Color.FromArgb(61, 68, 104);
            lblPeopleCaption.Location = new Point(16, 172);
            lblPeopleCaption.Name = "lblPeopleCaption";
            lblPeopleCaption.Size = new Size(120, 22);
            lblPeopleCaption.TabIndex = 7;
            lblPeopleCaption.Text = "People";
            // 
            // lblPriority
            // 
            lblPriority.BackColor = Color.FromArgb(228, 229, 234);
            lblPriority.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriority.ForeColor = Color.FromArgb(20, 26, 70);
            lblPriority.Location = new Point(220, 130);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(100, 26);
            lblPriority.TabIndex = 6;
            lblPriority.Text = "-";
            lblPriority.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPriorityCaption
            // 
            lblPriorityCaption.BackColor = Color.Transparent;
            lblPriorityCaption.Font = new Font("Segoe UI", 10F);
            lblPriorityCaption.ForeColor = Color.FromArgb(61, 68, 104);
            lblPriorityCaption.Location = new Point(16, 132);
            lblPriorityCaption.Name = "lblPriorityCaption";
            lblPriorityCaption.Size = new Size(120, 22);
            lblPriorityCaption.TabIndex = 5;
            lblPriorityCaption.Text = "Priority";
            // 
            // lblVolunteerRole
            // 
            lblVolunteerRole.BackColor = Color.Transparent;
            lblVolunteerRole.Font = new Font("Segoe UI", 9F);
            lblVolunteerRole.ForeColor = Color.FromArgb(61, 68, 104);
            lblVolunteerRole.Location = new Point(84, 76);
            lblVolunteerRole.Name = "lblVolunteerRole";
            lblVolunteerRole.Size = new Size(236, 20);
            lblVolunteerRole.TabIndex = 4;
            lblVolunteerRole.Text = "Waiting for a volunteer";
            // 
            // lblVolunteerName
            // 
            lblVolunteerName.BackColor = Color.Transparent;
            lblVolunteerName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVolunteerName.ForeColor = Color.FromArgb(20, 26, 70);
            lblVolunteerName.Location = new Point(84, 50);
            lblVolunteerName.Name = "lblVolunteerName";
            lblVolunteerName.Size = new Size(236, 24);
            lblVolunteerName.TabIndex = 3;
            lblVolunteerName.Text = "Not assigned yet";
            // 
            // lblInitials
            // 
            lblInitials.BackColor = Color.FromArgb(240, 176, 64);
            lblInitials.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInitials.ForeColor = Color.FromArgb(20, 26, 70);
            lblInitials.Location = new Point(16, 46);
            lblInitials.Name = "lblInitials";
            lblInitials.Size = new Size(56, 56);
            lblInitials.TabIndex = 2;
            lblInitials.Text = "--";
            lblInitials.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVolunteerHeading
            // 
            lblVolunteerHeading.BackColor = Color.Transparent;
            lblVolunteerHeading.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVolunteerHeading.ForeColor = Color.FromArgb(20, 26, 70);
            lblVolunteerHeading.Location = new Point(16, 18);
            lblVolunteerHeading.Name = "lblVolunteerHeading";
            lblVolunteerHeading.Size = new Size(300, 20);
            lblVolunteerHeading.TabIndex = 1;
            lblVolunteerHeading.Text = "YOUR VOLUNTEER";
            // 
            // pnlVolunteerAccent
            // 
            pnlVolunteerAccent.BackColor = Color.FromArgb(240, 176, 64);
            pnlVolunteerAccent.Location = new Point(0, 0);
            pnlVolunteerAccent.Name = "pnlVolunteerAccent";
            pnlVolunteerAccent.Size = new Size(336, 6);
            pnlVolunteerAccent.TabIndex = 0;
            // 
            // MyRequestsPage
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(241, 242, 248);
            Controls.Add(pnlVolunteer);
            Controls.Add(pnlActivity);
            Controls.Add(pnlFlow);
            Controls.Add(lblMessage);
            Controls.Add(lblStatus);
            Controls.Add(btnCancel);
            Controls.Add(btnRefresh);
            Controls.Add(cboRequests);
            Controls.Add(lblLocation);
            Controls.Add(lblRequestTitle);
            Name = "MyRequestsPage";
            Padding = new Padding(0);
            Size = new Size(1055, 734);
            pnlFlow.ResumeLayout(false);
            pnlActivity.ResumeLayout(false);
            pnlVolunteer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblRequestTitle;
        private Label lblLocation;
        private ComboBox cboRequests;
        private Button btnRefresh;
        private Button btnCancel;
        private Label lblStatus;
        private Label lblMessage;
        private Panel pnlFlow;
        private Label label4;
        private Label label3;
        private Label lblPeople;
        private Label lblStep3;
        private Label lblStep1;
        private Label lblStep2;
        private Label lblStep4;
        private Label lblStep5;
        private Label lblFlowTitle;
        private Panel pnlActivity;
        private ListBox lstActivity;
        private Label lblActivityTitle;
        private Panel pnlVolunteer;
        private Label lblVolunteerHeading;
        private Panel pnlVolunteerAccent;
        private Label lblVolunteerRole;
        private Label lblVolunteerName;
        private Label lblInitials;
        private Label lblPriorityCaption;
        private Label lblMobilityCaption;
        private Label lblPeopleCaption;
        private Label lblPriority;
        private Label lblMobility;
    }
}
