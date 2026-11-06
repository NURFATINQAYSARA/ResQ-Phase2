namespace ResQ.Pages
{
    partial class ResidentHomePage
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
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblTitle.Location = new Point(24, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(650, 44);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome back";
            lblTitle.Click += label1_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.ForeColor = Color.FromArgb(20, 26, 70);
            lblSubtitle.Location = new Point(24, 72);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(852, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Status and area load after login.";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(32, 80);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 34);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // ResidentHomePage
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            BackColor = Color.FromArgb(241, 242, 248);
            Controls.Add(btnRefresh);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F);
            Name = "ResidentHomePage";
            Size = new Size(900, 620);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Button btnRefresh;
    }
}
