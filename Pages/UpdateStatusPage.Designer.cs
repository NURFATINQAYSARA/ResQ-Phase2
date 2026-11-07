namespace ResQ.Pages
{
    partial class UpdateStatusPage
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
            lblTaskTitle = new Label();
            lblTaskDetails = new Label();
            lblNeedsSupport = new Label();
            lblPriority = new Label();
            pnlStatus = new Panel();
            lblStep5 = new Label();
            lblStep4 = new Label();
            lblStep3 = new Label();
            lblStep2 = new Label();
            lblStep1 = new Label();
            lblCurrentStatus = new Label();
            lblNoteCaption = new Label();
            txtNote = new TextBox();
            btnNext = new Button();
            btnBack = new Button();
            lblMessage = new Label();
            pnlTasks = new Panel();
            dgvTasks = new DataGridView();
            lblTasksTitle = new Label();
            pnlStatus.SuspendLayout();
            pnlTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // lblTaskTitle
            // 
            lblTaskTitle.BackColor = Color.Transparent;
            lblTaskTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTaskTitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblTaskTitle.Location = new Point(24, 16);
            lblTaskTitle.Name = "lblTaskTitle";
            lblTaskTitle.Size = new Size(580, 36);
            lblTaskTitle.TabIndex = 0;
            lblTaskTitle.Text = "Update status";
            // 
            // lblTaskDetails
            // 
            lblTaskDetails.BackColor = Color.Transparent;
            lblTaskDetails.ForeColor = Color.FromArgb(61, 68, 104);
            lblTaskDetails.Location = new Point(24, 54);
            lblTaskDetails.Name = "lblTaskDetails";
            lblTaskDetails.Size = new Size(580, 22);
            lblTaskDetails.TabIndex = 1;
            lblTaskDetails.Text = "Choose one of your tasks below.";
            // 
            // lblNeedsSupport
            // 
            lblNeedsSupport.BackColor = Color.FromArgb(27, 31, 107);
            lblNeedsSupport.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblNeedsSupport.ForeColor = Color.White;
            lblNeedsSupport.Location = new Point(628, 24);
            lblNeedsSupport.Name = "lblNeedsSupport";
            lblNeedsSupport.Size = new Size(124, 24);
            lblNeedsSupport.TabIndex = 2;
            lblNeedsSupport.Text = "NEEDS SUPPORT";
            lblNeedsSupport.TextAlign = ContentAlignment.MiddleCenter;
            lblNeedsSupport.Visible = false;
            // 
            // lblPriority
            // 
            lblPriority.BackColor = Color.FromArgb(228, 229, 234);
            lblPriority.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriority.ForeColor = Color.FromArgb(20, 26, 70);
            lblPriority.Location = new Point(760, 24);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(116, 24);
            lblPriority.TabIndex = 3;
            lblPriority.Text = "-";
            lblPriority.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlStatus
            // 
            pnlStatus.BackColor = Color.White;
            pnlStatus.Controls.Add(lblStep5);
            pnlStatus.Controls.Add(lblStep4);
            pnlStatus.Controls.Add(lblStep3);
            pnlStatus.Controls.Add(lblStep2);
            pnlStatus.Controls.Add(lblStep1);
            pnlStatus.Controls.Add(lblCurrentStatus);
            pnlStatus.Location = new Point(24, 88);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(852, 128);
            pnlStatus.TabIndex = 4;
            // 
            // lblStep5
            // 
            lblStep5.BackColor = Color.FromArgb(228, 229, 234);
            lblStep5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStep5.ForeColor = Color.FromArgb(20, 26, 70);
            lblStep5.Location = new Point(672, 44);
            lblStep5.Name = "lblStep5";
            lblStep5.Size = new Size(158, 68);
            lblStep5.TabIndex = 5;
            lblStep5.Text = "Completed \r\nNot yet";
            lblStep5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStep4
            // 
            lblStep4.BackColor = Color.FromArgb(228, 229, 234);
            lblStep4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStep4.ForeColor = Color.FromArgb(20, 26, 70);
            lblStep4.Location = new Point(508, 44);
            lblStep4.Name = "lblStep4";
            lblStep4.Size = new Size(158, 68);
            lblStep4.TabIndex = 4;
            lblStep4.Text = "Safe/Evacuated\r\nNot yet";
            lblStep4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStep3
            // 
            lblStep3.BackColor = Color.FromArgb(228, 229, 234);
            lblStep3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStep3.ForeColor = Color.FromArgb(20, 26, 70);
            lblStep3.Location = new Point(344, 44);
            lblStep3.Name = "lblStep3";
            lblStep3.Size = new Size(158, 68);
            lblStep3.TabIndex = 3;
            lblStep3.Text = "In Progress \r\nNot yet";
            lblStep3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStep2
            // 
            lblStep2.BackColor = Color.FromArgb(228, 229, 234);
            lblStep2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStep2.ForeColor = Color.FromArgb(20, 26, 70);
            lblStep2.Location = new Point(180, 44);
            lblStep2.Name = "lblStep2";
            lblStep2.Size = new Size(158, 68);
            lblStep2.TabIndex = 2;
            lblStep2.Text = "Accepted \r\nNot yet";
            lblStep2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStep1
            // 
            lblStep1.BackColor = Color.FromArgb(228, 229, 234);
            lblStep1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStep1.ForeColor = Color.FromArgb(20, 26, 70);
            lblStep1.Location = new Point(16, 44);
            lblStep1.Name = "lblStep1";
            lblStep1.Size = new Size(158, 68);
            lblStep1.TabIndex = 1;
            lblStep1.Text = "Pending\r\nNot yet";
            lblStep1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.BackColor = Color.Transparent;
            lblCurrentStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentStatus.ForeColor = Color.FromArgb(20, 26, 70);
            lblCurrentStatus.Location = new Point(16, 12);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(500, 24);
            lblCurrentStatus.TabIndex = 0;
            lblCurrentStatus.Text = "Current status:-";
            // 
            // lblNoteCaption
            // 
            lblNoteCaption.BackColor = Color.Transparent;
            lblNoteCaption.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNoteCaption.ForeColor = Color.FromArgb(20, 26, 70);
            lblNoteCaption.Location = new Point(24, 226);
            lblNoteCaption.Name = "lblNoteCaption";
            lblNoteCaption.Size = new Size(400, 22);
            lblNoteCaption.TabIndex = 5;
            lblNoteCaption.Text = "Note (saved to the Safety Log)";
            // 
            // txtNote
            // 
            txtNote.BackColor = Color.White;
            txtNote.BorderStyle = BorderStyle.FixedSingle;
            txtNote.ForeColor = Color.FromArgb(20, 26, 70);
            txtNote.Location = new Point(24, 250);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(852, 52);
            txtNote.TabIndex = 6;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(31, 138, 76);
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderColor = Color.FromArgb(31, 138, 76);
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(24, 314);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(260, 40);
            btnNext.TabIndex = 7;
            btnNext.Text = "Next status";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(139, 147, 181);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(20, 26, 7, 0);
            btnBack.Location = new Point(296, 314);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 40);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back to feed";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.Transparent;
            lblMessage.ForeColor = Color.FromArgb(61, 69, 104);
            lblMessage.Location = new Point(460, 322);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(416, 22);
            lblMessage.TabIndex = 9;
            // 
            // pnlTasks
            // 
            pnlTasks.BackColor = Color.White;
            pnlTasks.Controls.Add(dgvTasks);
            pnlTasks.Controls.Add(lblTasksTitle);
            pnlTasks.Location = new Point(24, 368);
            pnlTasks.Name = "pnlTasks";
            pnlTasks.Size = new Size(852, 240);
            pnlTasks.TabIndex = 10;
            // 
            // dgvTasks
            // 
            dgvTasks.AllowUserToAddRows = false;
            dgvTasks.AllowUserToDeleteRows = false;
            dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTasks.BackgroundColor = Color.White;
            dgvTasks.BorderStyle = BorderStyle.None;
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(10, 38);
            dgvTasks.MultiSelect = false;
            dgvTasks.Name = "dgvTasks";
            dgvTasks.ReadOnly = true;
            dgvTasks.RowHeadersVisible = false;
            dgvTasks.RowHeadersWidth = 51;
            dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTasks.Size = new Size(820, 188);
            dgvTasks.TabIndex = 1;
            dgvTasks.CurrentCellChanged += dgvTasks_CurrentCellChanged;
            dgvTasks.DataBindingComplete += dgvTasks_DataBindingComplete;
            dgvTasks.SelectionChanged += dgvTasks_SelectionChanged;
            // 
            // lblTasksTitle
            // 
            lblTasksTitle.BackColor = Color.Transparent;
            lblTasksTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTasksTitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblTasksTitle.Location = new Point(16, 10);
            lblTasksTitle.Name = "lblTasksTitle";
            lblTasksTitle.Size = new Size(300, 34);
            lblTasksTitle.TabIndex = 0;
            lblTasksTitle.Text = "My Tasks";
            // 
            // UpdateStatusPage
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(241, 242, 248);
            Controls.Add(pnlTasks);
            Controls.Add(lblMessage);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Controls.Add(txtNote);
            Controls.Add(lblNoteCaption);
            Controls.Add(pnlStatus);
            Controls.Add(lblPriority);
            Controls.Add(lblNeedsSupport);
            Controls.Add(lblTaskDetails);
            Controls.Add(lblTaskTitle);
            Name = "UpdateStatusPage";
            Size = new Size(1021, 733);
            pnlStatus.ResumeLayout(false);
            pnlTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTaskTitle;
        private Label lblTaskDetails;
        private Label lblNeedsSupport;
        private Label lblPriority;
        private Panel pnlStatus;
        private Label lblStep1;
        private Label lblCurrentStatus;
        private Label lblStep5;
        private Label lblStep4;
        private Label lblStep3;
        private Label lblStep2;
        private Label lblNoteCaption;
        private TextBox txtNote;
        private Button btnNext;
        private Button btnBack;
        private Label lblMessage;
        private Panel pnlTasks;
        private DataGridView dgvTasks;
        private Label lblTasksTitle;
    }
}
