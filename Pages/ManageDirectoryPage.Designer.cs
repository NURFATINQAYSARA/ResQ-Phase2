namespace ResQ.Pages
{
    partial class ManageDirectoryPage
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
            pnlDirectory = new Panel();
            dgvDirectory = new DataGridView();
            pnlEntry = new Panel();
            btnClear = new Button();
            btnSave = new Button();
            lblError = new Label();
            cmbStatus = new ComboBox();
            lblEntryStatus = new Label();
            cmbKind = new ComboBox();
            lblKind = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtArea = new TextBox();
            lblArea = new Label();
            txtName = new TextBox();
            lblName = new Label();
            lblEntryTitle = new Label();
            pnlEntryBand = new Panel();
            pnlDirectory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDirectory).BeginInit();
            pnlEntry.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblTitle.Location = new Point(24, 20);
            lblTitle.Margin = new Padding(1, 0, 1, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(650, 44);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manage contacts and shelters";
            // 
            // lblSubtitle
            // 
            lblSubtitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblSubtitle.Location = new Point(24, 72);
            lblSubtitle.Margin = new Padding(1, 0, 1, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(852, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Add, edit or remove entries. Phone numbers and required fields are checked.\r\n";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.AutoEllipsis = true;
            lblStatus.ForeColor = Color.FromArgb(20, 26, 70);
            lblStatus.Location = new Point(11, 1115);
            lblStatus.Margin = new Padding(1, 0, 1, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(1229, 14);
            lblStatus.TabIndex = 2;
            // 
            // pnlDirectory
            // 
            pnlDirectory.BackColor = Color.White;
            pnlDirectory.Controls.Add(dgvDirectory);
            pnlDirectory.Location = new Point(24, 112);
            pnlDirectory.Margin = new Padding(1);
            pnlDirectory.Name = "pnlDirectory";
            pnlDirectory.Size = new Size(508, 420);
            pnlDirectory.TabIndex = 3;
            // 
            // dgvDirectory
            // 
            dgvDirectory.AllowUserToAddRows = false;
            dgvDirectory.AllowUserToDeleteRows = false;
            dgvDirectory.BackgroundColor = Color.White;
            dgvDirectory.BorderStyle = BorderStyle.None;
            dgvDirectory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDirectory.Location = new Point(12, 12);
            dgvDirectory.Margin = new Padding(1);
            dgvDirectory.MultiSelect = false;
            dgvDirectory.Name = "dgvDirectory";
            dgvDirectory.ReadOnly = true;
            dgvDirectory.RowHeadersVisible = false;
            dgvDirectory.RowHeadersWidth = 82;
            dgvDirectory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDirectory.Size = new Size(484, 396);
            dgvDirectory.TabIndex = 0;
            dgvDirectory.CellContentClick += dgvDirectory_CellContentClick;
            // 
            // pnlEntry
            // 
            pnlEntry.BackColor = Color.White;
            pnlEntry.Controls.Add(btnClear);
            pnlEntry.Controls.Add(btnSave);
            pnlEntry.Controls.Add(lblError);
            pnlEntry.Controls.Add(cmbStatus);
            pnlEntry.Controls.Add(lblEntryStatus);
            pnlEntry.Controls.Add(cmbKind);
            pnlEntry.Controls.Add(lblKind);
            pnlEntry.Controls.Add(txtPhone);
            pnlEntry.Controls.Add(lblPhone);
            pnlEntry.Controls.Add(txtArea);
            pnlEntry.Controls.Add(lblArea);
            pnlEntry.Controls.Add(txtName);
            pnlEntry.Controls.Add(lblName);
            pnlEntry.Controls.Add(lblEntryTitle);
            pnlEntry.Controls.Add(pnlEntryBand);
            pnlEntry.Location = new Point(548, 112);
            pnlEntry.Margin = new Padding(1);
            pnlEntry.Name = "pnlEntry";
            pnlEntry.Size = new Size(328, 460);
            pnlEntry.TabIndex = 4;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.FromArgb(20, 26, 70);
            btnClear.Location = new Point(162, 398);
            btnClear.Margin = new Padding(1);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 40);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(27, 31, 107);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(18, 398);
            btnSave.Margin = new Padding(1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 40);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.FromArgb(217, 58, 43);
            lblError.Location = new Point(18, 332);
            lblError.Margin = new Padding(1, 0, 1, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(292, 48);
            lblError.TabIndex = 12;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Open", "Closed" });
            cmbStatus.Location = new Point(174, 290);
            cmbStatus.Margin = new Padding(1);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(136, 25);
            cmbStatus.TabIndex = 11;
            // 
            // lblEntryStatus
            // 
            lblEntryStatus.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEntryStatus.ForeColor = Color.FromArgb(20, 26, 70);
            lblEntryStatus.Location = new Point(174, 264);
            lblEntryStatus.Margin = new Padding(1, 0, 1, 0);
            lblEntryStatus.Name = "lblEntryStatus";
            lblEntryStatus.Size = new Size(136, 22);
            lblEntryStatus.TabIndex = 10;
            lblEntryStatus.Text = "Status";
            // 
            // cmbKind
            // 
            cmbKind.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKind.FormattingEnabled = true;
            cmbKind.Items.AddRange(new object[] { "Shelter", "Emergency contact" });
            cmbKind.Location = new Point(18, 290);
            cmbKind.Margin = new Padding(1);
            cmbKind.Name = "cmbKind";
            cmbKind.Size = new Size(140, 25);
            cmbKind.TabIndex = 9;
            // 
            // lblKind
            // 
            lblKind.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKind.ForeColor = Color.FromArgb(20, 26, 70);
            lblKind.Location = new Point(18, 264);
            lblKind.Margin = new Padding(1, 0, 1, 0);
            lblKind.Name = "lblKind";
            lblKind.Size = new Size(140, 22);
            lblKind.TabIndex = 8;
            lblKind.Text = "Kind";
            // 
            // txtPhone
            // 
            txtPhone.ForeColor = Color.FromArgb(20, 26, 70);
            txtPhone.Location = new Point(18, 222);
            txtPhone.Margin = new Padding(1);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(292, 25);
            txtPhone.TabIndex = 7;
            // 
            // lblPhone
            // 
            lblPhone.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.FromArgb(20, 26, 70);
            lblPhone.Location = new Point(18, 196);
            lblPhone.Margin = new Padding(1, 0, 1, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(292, 22);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone number";
            // 
            // txtArea
            // 
            txtArea.ForeColor = Color.FromArgb(20, 26, 70);
            txtArea.Location = new Point(18, 154);
            txtArea.Margin = new Padding(1);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(292, 25);
            txtArea.TabIndex = 5;
            // 
            // lblArea
            // 
            lblArea.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArea.ForeColor = Color.FromArgb(20, 26, 70);
            lblArea.Location = new Point(18, 128);
            lblArea.Margin = new Padding(1, 0, 1, 0);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(292, 22);
            lblArea.TabIndex = 4;
            lblArea.Text = "Area";
            // 
            // txtName
            // 
            txtName.ForeColor = Color.FromArgb(20, 26, 70);
            txtName.Location = new Point(18, 86);
            txtName.Margin = new Padding(1);
            txtName.Name = "txtName";
            txtName.Size = new Size(292, 25);
            txtName.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(20, 26, 70);
            lblName.Location = new Point(18, 60);
            lblName.Margin = new Padding(1, 0, 1, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(292, 22);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblEntryTitle
            // 
            lblEntryTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntryTitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblEntryTitle.Location = new Point(18, 18);
            lblEntryTitle.Margin = new Padding(1, 0, 1, 0);
            lblEntryTitle.Name = "lblEntryTitle";
            lblEntryTitle.Size = new Size(292, 28);
            lblEntryTitle.TabIndex = 1;
            lblEntryTitle.Text = "Add entry";
            // 
            // pnlEntryBand
            // 
            pnlEntryBand.BackColor = Color.FromArgb(27, 31, 107);
            pnlEntryBand.Location = new Point(0, 0);
            pnlEntryBand.Margin = new Padding(1);
            pnlEntryBand.Name = "pnlEntryBand";
            pnlEntryBand.Size = new Size(328, 5);
            pnlEntryBand.TabIndex = 0;
            // 
            // ManageDirectoryPage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlEntry);
            Controls.Add(pnlDirectory);
            Controls.Add(lblStatus);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Margin = new Padding(1);
            Name = "ManageDirectoryPage";
            Padding = new Padding(13);
            Size = new Size(981, 673);
            pnlDirectory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDirectory).EndInit();
            pnlEntry.ResumeLayout(false);
            pnlEntry.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblStatus;
        private Panel pnlDirectory;
        private DataGridView dgvDirectory;
        private Panel pnlEntry;
        private Panel pnlEntryBand;
        private Label lblEntryTitle;
        private TextBox txtName;
        private Label lblName;
        private ComboBox cmbKind;
        private Label lblKind;
        private TextBox txtPhone;
        private Label lblPhone;
        private TextBox txtArea;
        private Label lblArea;
        private Button btnSave;
        private Label lblError;
        private ComboBox cmbStatus;
        private Label lblEntryStatus;
        private Button btnClear;
    }
}