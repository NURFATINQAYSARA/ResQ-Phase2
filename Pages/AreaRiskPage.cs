using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ResQ.Pages
{
    public partial class AreaRiskPage : PageBase
    {
        public AreaRiskPage()
        {
            InitializeComponent();

            WalkthroughUi.Setup(this, ["Resident", "Volunteer", "Admin"]);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public override void LoadData()
        {
            if (!WalkthroughUi.Access(lblStatus, "Resident", "Volunteer", "Admin")) return;
            WalkthroughUi.Run(lblStatus, () =>
            {
                var rows = Database.GetAreaRisks();
                WalkthroughUi.ClearCopies(flowRisks, pnlRiskTemplate);
                foreach (DataRow row in rows.Rows)
                {
                    
                    var card = WalkthroughUi.CopyCard(pnlRiskTemplate);
                    string area = row["Area"].ToString()!;
                    string risk = row["RiskLevel"].ToString()!;
                    var colours = Theme.RiskColours(risk);
                    WalkthroughUi.Child<Label>(card, "lblAreaName").Text = area +
                    (string.Equals(area, Session.Area, StringComparison.OrdinalIgnoreCase)
                    ? " (your area)" : "");
                    WalkthroughUi.Child<Label>(card, "lblRiskNote").Text =
                    row["Note"] + " Updated " + row["UpdatedAt"];
                    var badge = WalkthroughUi.Child<Label>(card, "lblRiskBadge");
                    badge.Text = risk.ToUpperInvariant(); badge.BackColor = colours.Back;
                    badge.ForeColor = colours.Fore;
                    WalkthroughUi.Child<Panel>(card, "pnlRiskBand").BackColor = colours.Back;
                    card.Width = Math.Max(640, flowRisks.ClientSize.Width - 24);
                    flowRisks.Controls.Add(card); card.Visible = true;
                }
                lblStatus.Text = rows.Rows.Count == 0 ? "No risk levels recorded." :
                "Loaded " + rows.Rows.Count + " saved areas.";
            });
        }
    }
}
