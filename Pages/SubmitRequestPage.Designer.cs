namespace ResQ.Pages
{
    partial class SubmitRequestPage
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
            lblHelpType = new Label();
            pnlHelpType = new Panel();
            rdoSupplies = new RadioButton();
            rdoSafety = new RadioButton();
            rdoMobility = new RadioButton();
            rdoEvacuation = new RadioButton();
            lblLocation = new Label();
            txtLocation = new TextBox();
            lblMobility = new Label();
            lblPeople = new Label();
            txtPeople = new TextBox();
            txtMobility = new TextBox();
            lblPriority = new Label();
            pnlPriority = new Panel();
            rdoHigh = new RadioButton();
            rdoMedium = new RadioButton();
            rdoLow = new RadioButton();
            lblExtra = new Label();
            txtExtra = new TextBox();
            lblMessage = new Label();
            btnSubmit = new Button();
            btnClear = new Button();
            pnlNext = new Panel();
            lblNext5Text = new Label();
            lblNext4Text = new Label();
            lblNext2Text = new Label();
            lblNext3Text = new Label();
            lblNext5 = new Label();
            lblNext4 = new Label();
            lblNext3 = new Label();
            lblNext2 = new Label();
            lblNext1Text = new Label();
            lblNext1 = new Label();
            lblNext = new Label();
            lblRefreshTip = new Label();
            pnlHelpType.SuspendLayout();
            pnlPriority.SuspendLayout();
            pnlNext.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblTitle.Location = new Point(24, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(852, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Submit a Request";
            // 
            // lblSubtitle
            // 
            lblSubtitle.ForeColor = Color.FromArgb(61, 68, 104);
            lblSubtitle.Location = new Point(24, 64);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(852, 26);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "A Volunteer from the Community Buddy feed will accept it.";
            // 
            // lblHelpType
            // 
            lblHelpType.ForeColor = Color.FromArgb(20, 26, 70);
            lblHelpType.Location = new Point(24, 104);
            lblHelpType.Name = "lblHelpType";
            lblHelpType.Size = new Size(560, 24);
            lblHelpType.TabIndex = 2;
            lblHelpType.Text = "Type of Help";
            // 
            // pnlHelpType
            // 
            pnlHelpType.Controls.Add(rdoSupplies);
            pnlHelpType.Controls.Add(rdoSafety);
            pnlHelpType.Controls.Add(rdoMobility);
            pnlHelpType.Controls.Add(rdoEvacuation);
            pnlHelpType.ForeColor = Color.FromArgb(20, 26, 70);
            pnlHelpType.Location = new Point(24, 130);
            pnlHelpType.Name = "pnlHelpType";
            pnlHelpType.Size = new Size(560, 60);
            pnlHelpType.TabIndex = 3;
            // 
            // rdoSupplies
            // 
            rdoSupplies.Appearance = Appearance.Button;
            rdoSupplies.Cursor = Cursors.Hand;
            rdoSupplies.FlatStyle = FlatStyle.Flat;
            rdoSupplies.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoSupplies.Location = new Point(426, 0);
            rdoSupplies.Name = "rdoSupplies";
            rdoSupplies.Padding = new Padding(10, 0, 0, 0);
            rdoSupplies.Size = new Size(134, 60);
            rdoSupplies.TabIndex = 3;
            rdoSupplies.TabStop = true;
            rdoSupplies.Text = "Supplies";
            rdoSupplies.TextAlign = ContentAlignment.MiddleCenter;
            rdoSupplies.UseVisualStyleBackColor = false;
            // 
            // rdoSafety
            // 
            rdoSafety.Appearance = Appearance.Button;
            rdoSafety.Cursor = Cursors.Hand;
            rdoSafety.FlatStyle = FlatStyle.Flat;
            rdoSafety.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoSafety.Location = new Point(284, 0);
            rdoSafety.Name = "rdoSafety";
            rdoSafety.Padding = new Padding(10, 0, 0, 0);
            rdoSafety.Size = new Size(134, 60);
            rdoSafety.TabIndex = 2;
            rdoSafety.TabStop = true;
            rdoSafety.Text = "Safety Check-in";
            rdoSafety.TextAlign = ContentAlignment.MiddleCenter;
            rdoSafety.UseVisualStyleBackColor = false;
            // 
            // rdoMobility
            // 
            rdoMobility.Appearance = Appearance.Button;
            rdoMobility.Cursor = Cursors.Hand;
            rdoMobility.FlatStyle = FlatStyle.Flat;
            rdoMobility.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoMobility.Location = new Point(142, 0);
            rdoMobility.Name = "rdoMobility";
            rdoMobility.Padding = new Padding(10, 0, 0, 0);
            rdoMobility.Size = new Size(134, 60);
            rdoMobility.TabIndex = 1;
            rdoMobility.TabStop = true;
            rdoMobility.Text = "Mobility Support";
            rdoMobility.TextAlign = ContentAlignment.MiddleCenter;
            rdoMobility.UseVisualStyleBackColor = false;
            // 
            // rdoEvacuation
            // 
            rdoEvacuation.Appearance = Appearance.Button;
            rdoEvacuation.Cursor = Cursors.Hand;
            rdoEvacuation.FlatStyle = FlatStyle.Flat;
            rdoEvacuation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoEvacuation.Location = new Point(0, 0);
            rdoEvacuation.Name = "rdoEvacuation";
            rdoEvacuation.Padding = new Padding(10, 0, 0, 0);
            rdoEvacuation.Size = new Size(134, 60);
            rdoEvacuation.TabIndex = 0;
            rdoEvacuation.TabStop = true;
            rdoEvacuation.Text = "Evacuation";
            rdoEvacuation.TextAlign = ContentAlignment.MiddleCenter;
            rdoEvacuation.UseVisualStyleBackColor = false;
            // 
            // lblLocation
            // 
            lblLocation.ForeColor = Color.FromArgb(20, 26, 70);
            lblLocation.Location = new Point(24, 204);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(560, 24);
            lblLocation.TabIndex = 4;
            lblLocation.Text = "Location";
            // 
            // txtLocation
            // 
            txtLocation.BorderStyle = BorderStyle.FixedSingle;
            txtLocation.ForeColor = Color.FromArgb(20, 26, 70);
            txtLocation.Location = new Point(24, 230);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(560, 30);
            txtLocation.TabIndex = 5;
            // 
            // lblMobility
            // 
            lblMobility.ForeColor = Color.FromArgb(20, 26, 70);
            lblMobility.Location = new Point(247, 278);
            lblMobility.Name = "lblMobility";
            lblMobility.Size = new Size(337, 24);
            lblMobility.TabIndex = 6;
            lblMobility.Text = "Mobility Requirement";
            // 
            // lblPeople
            // 
            lblPeople.ForeColor = Color.FromArgb(20, 26, 70);
            lblPeople.Location = new Point(24, 278);
            lblPeople.Name = "lblPeople";
            lblPeople.Size = new Size(205, 24);
            lblPeople.TabIndex = 7;
            lblPeople.Text = "People Needing Help";
            // 
            // txtPeople
            // 
            txtPeople.BorderStyle = BorderStyle.FixedSingle;
            txtPeople.ForeColor = Color.FromArgb(20, 26, 70);
            txtPeople.Location = new Point(24, 304);
            txtPeople.Name = "txtPeople";
            txtPeople.Size = new Size(205, 30);
            txtPeople.TabIndex = 8;
            // 
            // txtMobility
            // 
            txtMobility.BorderStyle = BorderStyle.FixedSingle;
            txtMobility.ForeColor = Color.FromArgb(20, 26, 70);
            txtMobility.Location = new Point(247, 304);
            txtMobility.Name = "txtMobility";
            txtMobility.Size = new Size(337, 30);
            txtMobility.TabIndex = 9;
            // 
            // lblPriority
            // 
            lblPriority.ForeColor = Color.FromArgb(20, 26, 70);
            lblPriority.Location = new Point(24, 352);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(560, 24);
            lblPriority.TabIndex = 10;
            lblPriority.Text = "Priority";
            // 
            // pnlPriority
            // 
            pnlPriority.Controls.Add(rdoHigh);
            pnlPriority.Controls.Add(rdoMedium);
            pnlPriority.Controls.Add(rdoLow);
            pnlPriority.ForeColor = Color.FromArgb(20, 26, 70);
            pnlPriority.Location = new Point(24, 378);
            pnlPriority.Name = "pnlPriority";
            pnlPriority.Size = new Size(560, 40);
            pnlPriority.TabIndex = 11;
            // 
            // rdoHigh
            // 
            rdoHigh.Appearance = Appearance.Button;
            rdoHigh.Cursor = Cursors.Hand;
            rdoHigh.FlatStyle = FlatStyle.Flat;
            rdoHigh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            rdoHigh.Location = new Point(220, 0);
            rdoHigh.Name = "rdoHigh";
            rdoHigh.Padding = new Padding(10, 0, 0, 0);
            rdoHigh.Size = new Size(100, 40);
            rdoHigh.TabIndex = 12;
            rdoHigh.TabStop = true;
            rdoHigh.Text = "High";
            rdoHigh.TextAlign = ContentAlignment.MiddleCenter;
            rdoHigh.UseVisualStyleBackColor = false;
            // 
            // rdoMedium
            // 
            rdoMedium.Appearance = Appearance.Button;
            rdoMedium.Cursor = Cursors.Hand;
            rdoMedium.FlatStyle = FlatStyle.Flat;
            rdoMedium.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            rdoMedium.Location = new Point(110, 0);
            rdoMedium.Name = "rdoMedium";
            rdoMedium.Padding = new Padding(10, 0, 0, 0);
            rdoMedium.Size = new Size(100, 40);
            rdoMedium.TabIndex = 13;
            rdoMedium.TabStop = true;
            rdoMedium.Text = "Medium";
            rdoMedium.TextAlign = ContentAlignment.MiddleCenter;
            rdoMedium.UseVisualStyleBackColor = false;
            // 
            // rdoLow
            // 
            rdoLow.Appearance = Appearance.Button;
            rdoLow.Cursor = Cursors.Hand;
            rdoLow.FlatStyle = FlatStyle.Flat;
            rdoLow.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            rdoLow.Location = new Point(0, 0);
            rdoLow.Name = "rdoLow";
            rdoLow.Padding = new Padding(10, 0, 0, 0);
            rdoLow.Size = new Size(100, 40);
            rdoLow.TabIndex = 0;
            rdoLow.TabStop = true;
            rdoLow.Text = "Low";
            rdoLow.TextAlign = ContentAlignment.MiddleCenter;
            rdoLow.UseVisualStyleBackColor = false;
            // 
            // lblExtra
            // 
            lblExtra.ForeColor = Color.FromArgb(20, 26, 70);
            lblExtra.Location = new Point(24, 432);
            lblExtra.Name = "lblExtra";
            lblExtra.Size = new Size(560, 24);
            lblExtra.TabIndex = 12;
            lblExtra.Text = "Extra information";
            // 
            // txtExtra
            // 
            txtExtra.BackColor = Color.White;
            txtExtra.BorderStyle = BorderStyle.FixedSingle;
            txtExtra.ForeColor = Color.FromArgb(20, 26, 70);
            txtExtra.Location = new Point(24, 458);
            txtExtra.Multiline = true;
            txtExtra.Name = "txtExtra";
            txtExtra.ScrollBars = ScrollBars.Vertical;
            txtExtra.Size = new Size(560, 30);
            txtExtra.TabIndex = 13;
            // 
            // lblMessage
            // 
            lblMessage.ForeColor = Color.FromArgb(217, 58, 43);
            lblMessage.Location = new Point(24, 534);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(852, 30);
            lblMessage.TabIndex = 14;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(217, 58, 43);
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.FlatAppearance.BorderColor = Color.FromArgb(217, 58, 43);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(24, 574);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(184, 40);
            btnSubmit.TabIndex = 15;
            btnSubmit.Text = "Submit Request";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(139, 147, 181);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(20, 26, 70);
            btnClear.Location = new Point(224, 574);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(104, 40);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // pnlNext
            // 
            pnlNext.BackColor = Color.White;
            pnlNext.BorderStyle = BorderStyle.FixedSingle;
            pnlNext.Controls.Add(lblNext5Text);
            pnlNext.Controls.Add(lblNext4Text);
            pnlNext.Controls.Add(lblNext2Text);
            pnlNext.Controls.Add(lblNext3Text);
            pnlNext.Controls.Add(lblNext5);
            pnlNext.Controls.Add(lblNext4);
            pnlNext.Controls.Add(lblNext3);
            pnlNext.Controls.Add(lblNext2);
            pnlNext.Controls.Add(lblNext1Text);
            pnlNext.Controls.Add(lblNext1);
            pnlNext.Controls.Add(lblNext);
            pnlNext.ForeColor = Color.FromArgb(20, 26, 70);
            pnlNext.Location = new Point(620, 100);
            pnlNext.Name = "pnlNext";
            pnlNext.Size = new Size(256, 338);
            pnlNext.TabIndex = 17;
            // 
            // lblNext5Text
            // 
            lblNext5Text.Font = new Font("Segoe UI", 10F);
            lblNext5Text.Location = new Point(54, 274);
            lblNext5Text.Name = "lblNext5Text";
            lblNext5Text.Size = new Size(180, 48);
            lblNext5Text.TabIndex = 10;
            lblNext5Text.Text = "The task is completed and logged";
            // 
            // lblNext4Text
            // 
            lblNext4Text.Font = new Font("Segoe UI", 10F);
            lblNext4Text.Location = new Point(54, 212);
            lblNext4Text.Name = "lblNext4Text";
            lblNext4Text.Size = new Size(180, 48);
            lblNext4Text.TabIndex = 9;
            lblNext4Text.Text = "You are marked Safe or Evacuated";
            // 
            // lblNext2Text
            // 
            lblNext2Text.Font = new Font("Segoe UI", 10F);
            lblNext2Text.Location = new Point(54, 112);
            lblNext2Text.Name = "lblNext2Text";
            lblNext2Text.Size = new Size(180, 48);
            lblNext2Text.TabIndex = 8;
            lblNext2Text.Text = "A volunteer clicks accept";
            // 
            // lblNext3Text
            // 
            lblNext3Text.Font = new Font("Segoe UI", 10F);
            lblNext3Text.Location = new Point(54, 162);
            lblNext3Text.Name = "lblNext3Text";
            lblNext3Text.Size = new Size(180, 48);
            lblNext3Text.TabIndex = 7;
            lblNext3Text.Text = "They help you: In progress";
            // 
            // lblNext5
            // 
            lblNext5.BackColor = Color.FromArgb(27, 31, 107);
            lblNext5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNext5.ForeColor = Color.White;
            lblNext5.Location = new Point(16, 274);
            lblNext5.Name = "lblNext5";
            lblNext5.Size = new Size(28, 28);
            lblNext5.TabIndex = 6;
            lblNext5.Text = "5";
            lblNext5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNext4
            // 
            lblNext4.BackColor = Color.FromArgb(31, 138, 76);
            lblNext4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNext4.ForeColor = Color.White;
            lblNext4.Location = new Point(16, 212);
            lblNext4.Name = "lblNext4";
            lblNext4.Size = new Size(28, 28);
            lblNext4.TabIndex = 5;
            lblNext4.Text = "4";
            lblNext4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNext3
            // 
            lblNext3.BackColor = Color.FromArgb(217, 58, 43);
            lblNext3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNext3.ForeColor = Color.White;
            lblNext3.Location = new Point(16, 162);
            lblNext3.Name = "lblNext3";
            lblNext3.Size = new Size(28, 28);
            lblNext3.TabIndex = 4;
            lblNext3.Text = "3";
            lblNext3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNext2
            // 
            lblNext2.BackColor = Color.FromArgb(240, 176, 64);
            lblNext2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNext2.ForeColor = Color.FromArgb(90, 58, 0);
            lblNext2.Location = new Point(16, 112);
            lblNext2.Name = "lblNext2";
            lblNext2.Size = new Size(28, 28);
            lblNext2.TabIndex = 3;
            lblNext2.Text = "2";
            lblNext2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNext1Text
            // 
            lblNext1Text.Font = new Font("Segoe UI", 10F);
            lblNext1Text.Location = new Point(54, 62);
            lblNext1Text.Name = "lblNext1Text";
            lblNext1Text.Size = new Size(180, 48);
            lblNext1Text.TabIndex = 2;
            lblNext1Text.Text = "Your request is pending in the feed";
            // 
            // lblNext1
            // 
            lblNext1.BackColor = Color.FromArgb(110, 110, 110);
            lblNext1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNext1.ForeColor = Color.White;
            lblNext1.Location = new Point(16, 62);
            lblNext1.Name = "lblNext1";
            lblNext1.Size = new Size(28, 28);
            lblNext1.TabIndex = 1;
            lblNext1.Text = "1";
            lblNext1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNext
            // 
            lblNext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNext.Location = new Point(16, 16);
            lblNext.Name = "lblNext";
            lblNext.Size = new Size(222, 32);
            lblNext.TabIndex = 0;
            lblNext.Text = "What Happens Next";
            // 
            // lblRefreshTip
            // 
            lblRefreshTip.BackColor = Color.FromArgb(220, 221, 243);
            lblRefreshTip.ForeColor = Color.FromArgb(27, 31, 107);
            lblRefreshTip.Location = new Point(620, 458);
            lblRefreshTip.Name = "lblRefreshTip";
            lblRefreshTip.Padding = new Padding(14, 10, 14, 10);
            lblRefreshTip.Size = new Size(256, 89);
            lblRefreshTip.TabIndex = 18;
            lblRefreshTip.Text = "Press Refresh On My Requests to see the latest update";
            // 
            // SubmitRequestPage
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblRefreshTip);
            Controls.Add(pnlNext);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(lblMessage);
            Controls.Add(txtExtra);
            Controls.Add(lblExtra);
            Controls.Add(pnlPriority);
            Controls.Add(lblPriority);
            Controls.Add(txtMobility);
            Controls.Add(txtPeople);
            Controls.Add(lblPeople);
            Controls.Add(lblMobility);
            Controls.Add(txtLocation);
            Controls.Add(lblLocation);
            Controls.Add(pnlHelpType);
            Controls.Add(lblHelpType);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Name = "SubmitRequestPage";
            Size = new Size(1062, 777);
            pnlHelpType.ResumeLayout(false);
            pnlPriority.ResumeLayout(false);
            pnlNext.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblHelpType;
        private Panel pnlHelpType;
        private RadioButton rdoSafety;
        private RadioButton rdoMobility;
        private RadioButton rdoEvacuation;
        private RadioButton rdoSupplies;
        private Label lblLocation;
        private TextBox txtLocation;
        private Label lblNext;
        private Label lblPeople;
        private TextBox txtExtra;
        private TextBox txtMobility;
        private Label lblPriority;
        private Panel pnlPriority;
        private RadioButton rdoLow;
        private TextBox txtPeople;
        private Label lblMobility;
        private RadioButton rdoHigh;
        private RadioButton rdoMedium;
        private Label lblExtra;
        private Label lblMessage;
        private Button btnSubmit;
        private Button btnClear;
        private Panel pnlNext;
        private Label label4;
        private Label label3;
        private Label lblNext3;
        private Label lblNext2;
        private Label lblNext1Text;
        private Label lblNext1;
        private Label lblNext5Text;
        private Label lblNext4Text;
        private Label lblNext2Text;
        private Label lblNext3Text;
        private Label lblNext4;
        private Label lblNext5;
        private Label lblRefreshTip;
    }
}
