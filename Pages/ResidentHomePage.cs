using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace ResQ.Pages
{
    public partial class ResidentHomePage : PageBase, IFatinWalkthroughNavigation
    {
        public event Action<string>? NavigationRequested;
        public ResidentHomePage()
        {
            InitializeComponent();
            FatinWalkthroughUi.Setup(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            NavigationRequested?.Invoke("Submit Request");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            NavigationRequested?.Invoke("Report Incident");
        }

        private void btnShelter_Click(object sender, EventArgs e)
        {
            NavigationRequested?.Invoke("Shelters and Contacts");
        }
        public override void LoadData()
        {
            if (!FatinWalkthroughUi.Access(lblStatus, "Resident")) return;
            FatinWalkthroughUi.Run(lblStatus, () =>
            {
                DataTable risks = Database.GetAreaRisks();
                DataTable rows = Database.GetResidentRequests();
                lblTitle.Text = "Welcome, " + Session.FullName.Split(' ')[0];
                lblSubtitle.Text = "Status: " + Session.Status + " | Area: " + Session.Area;
                var risk = risks.AsEnumerable().FirstOrDefault(r => string.Equals(
                    r["Area"].ToString(), Session.Area, StringComparison.OrdinalIgnoreCase));
                string level = risk?["RiskLevel"].ToString() ?? "Not listed";
                var colors = risk == null ? (Theme.Surface, Theme.Muted) :
                    Theme.PriorityColours(level);
                pnlRiskAlert.BackColor = colors.Item1;
                lblAlertTitle.BackColor = lblAlertUpdated.BackColor = lblRiskBadge.BackColor =
                    colors.Item1;
                lblAlertTitle.ForeColor = lblAlertUpdated.ForeColor = lblRiskBadge.ForeColor =
                    colors.Item2;
                lblAlertTitle.Text = risk == null ? "Your area has no recorded risk level." :
                    risk["Note"].ToString();
                lblAlertUpdated.Text = risk == null ? "Ask an administrator for an update." :
                    "Updated by the administrator: " + risk["UpdatedAt"];
                lblRiskBadge.Text = risk == null ? "NOT LISTED" : level.ToUpper() + " RISK";
                DataTable recent = rows.Clone();
                foreach (DataRow row in rows.Rows.Cast<DataRow>().Take(3)) recent.ImportRow(row);
                dgvRecent.DataSource = recent;
                lblStatus.Text = "Your saved area information and latest requests loaded.";
            });
        }
    }
}
