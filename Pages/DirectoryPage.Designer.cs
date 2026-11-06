namespace ResQ.Pages
{
    partial class DirectoryPage
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
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnShelters = new Button();
            btnContacts = new Button();
            pnlDirectory = new Panel();
            dgvDirectory = new DataGridView();
            lblAdminNote = new Label();
            pnlDirectory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDirectory).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblTitle.Location = new Point(24, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(774, 67);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Shelters and emergency contacts";
            // 
            // lblSubtitle
            // 
            lblSubtitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblSubtitle.Location = new Point(24, 72);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(852, 40);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "One place for the numbers and places people need during a hazard.";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.AutoEllipsis = true;
            lblStatus.ForeColor = Color.FromArgb(20, 26, 70);
            lblStatus.Location = new Point(24, 644);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(852, 30);
            lblStatus.TabIndex = 2;
            // 
            // lblSearch
            // 
            lblSearch.ForeColor = Color.FromArgb(20, 26, 70);
            lblSearch.Location = new Point(21, 112);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(730, 39);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.ForeColor = Color.FromArgb(20, 26, 70);
            txtSearch.Location = new Point(24, 142);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(730, 43);
            txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(27, 31, 107);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(766, 140);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 45);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnShelters
            // 
            btnShelters.BackColor = Color.FromArgb(27, 31, 107);
            btnShelters.FlatStyle = FlatStyle.Flat;
            btnShelters.ForeColor = Color.White;
            btnShelters.Location = new Point(24, 202);
            btnShelters.Name = "btnShelters";
            btnShelters.Size = new Size(162, 44);
            btnShelters.TabIndex = 6;
            btnShelters.Text = "Shelters";
            btnShelters.UseVisualStyleBackColor = false;
            btnShelters.Click += btnShelters_Click;
            // 
            // btnContacts
            // 
            btnContacts.BackColor = Color.White;
            btnContacts.FlatStyle = FlatStyle.Flat;
            btnContacts.ForeColor = Color.FromArgb(20, 26, 70);
            btnContacts.Location = new Point(198, 202);
            btnContacts.Name = "btnContacts";
            btnContacts.Size = new Size(210, 44);
            btnContacts.TabIndex = 7;
            btnContacts.Text = "Contacts";
            btnContacts.UseVisualStyleBackColor = false;
            btnContacts.Click += btnContacts_Click;
            // 
            // pnlDirectory
            // 
            pnlDirectory.BackColor = Color.White;
            pnlDirectory.Controls.Add(dgvDirectory);
            pnlDirectory.Location = new Point(24, 264);
            pnlDirectory.Name = "pnlDirectory";
            pnlDirectory.Size = new Size(852, 260);
            pnlDirectory.TabIndex = 8;
            // 
            // dgvDirectory
            // 
            dgvDirectory.AllowUserToAddRows = false;
            dgvDirectory.AllowUserToDeleteRows = false;
            dgvDirectory.BackgroundColor = Color.White;
            dgvDirectory.BorderStyle = BorderStyle.None;
            dgvDirectory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDirectory.Location = new Point(12, 12);
            dgvDirectory.MultiSelect = false;
            dgvDirectory.Name = "dgvDirectory";
            dgvDirectory.RowHeadersVisible = false;
            dgvDirectory.RowHeadersWidth = 82;
            dgvDirectory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDirectory.Size = new Size(828, 236);
            dgvDirectory.TabIndex = 0;
            // 
            // lblAdminNote
            // 
            lblAdminNote.ForeColor = Color.FromArgb(61, 68, 104);
            lblAdminNote.Location = new Point(24, 540);
            lblAdminNote.Name = "lblAdminNote";
            lblAdminNote.Size = new Size(852, 44);
            lblAdminNote.TabIndex = 9;
            lblAdminNote.Text = "Only the administrator can add, edit or remove entries.";
            // 
            // DirectoryPage
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblAdminNote);
            Controls.Add(pnlDirectory);
            Controls.Add(btnContacts);
            Controls.Add(btnShelters);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(lblStatus);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "DirectoryPage";
            Padding = new Padding(28);
            Size = new Size(1783, 873);
            pnlDirectory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDirectory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblStatus;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnShelters;
        private Button btnContacts;
        private Panel pnlDirectory;
        private DataGridView dgvDirectory;
        private Label lblAdminNote;
    }
}