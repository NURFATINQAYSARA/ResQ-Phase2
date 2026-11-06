namespace ResQ.Pages
{
    partial class SetRiskLevelsPage
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
            flowAreas = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(278, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Set risk levels";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(24, 72);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(1078, 48);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Choose Low, Medium or High for each area. Click Save to apply changes.\n";
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Location = new Point(986, 24);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(116, 38);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // flowAreas
            // 
            flowAreas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowAreas.AutoScroll = true;
            flowAreas.BackColor = Color.Transparent;
            flowAreas.FlowDirection = FlowDirection.TopDown;
            flowAreas.Location = new Point(24, 132);
            flowAreas.Name = "flowAreas";
            flowAreas.Size = new Size(1078, 328);
            flowAreas.TabIndex = 3;
            flowAreas.WrapContents = false;
            // 
            // SetRiskLevelsPage
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowAreas);
            Controls.Add(btnRefresh);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Location = new Point(24, 110);
            Name = "SetRiskLevelsPage";
            Padding = new Padding(0);
            Size = new Size(1126, 484);
            Load += SetRiskLevelsPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Button btnRefresh;
        private FlowLayoutPanel flowAreas;
    }
}
