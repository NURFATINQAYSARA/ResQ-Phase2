using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ResQ.Pages
{
    public partial class AdminHomePage : PageBase, IFatinWalkthroughNavigation
    {
        public event Action<string>? NavigationRequested;
        public AdminHomePage()
        {
            InitializeComponent();
            FatinWalkthroughUi.Setup(this);
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            NavigationRequested?.Invoke("Review Incidents");
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            OpenApprovals();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            NavigationRequested?.Invoke("Request Monitor");
        }
        public override void LoadData()
        {
            if (!FatinWalkthroughUi.Access(lblStatus, "Admin")) return;
            FatinWalkthroughUi.Run(lblStatus, () =>
            {
                var summary = Database.GetRequestSummary();
                var admin = Database.GetAdminHomeSummary().Rows[0];
                var incidents = Database.GetPendingIncidents();
                var requests = Database.GetAllRequests("Pending");
                long Total(string status) => summary.AsEnumerable().Where(r =>
                r["Category"].ToString() == "Status" && r["Label"].ToString() == status)
                .Sum(r => Convert.ToInt64(r["Total"]));
                countPending.Text = Total("Pending").ToString();
                countAccepted.Text = Total("Accepted").ToString();
                countProgress.Text = Total("In Progress").ToString();
                countSafe.Text = Total("Safe / Evacuated").ToString();
                countCompleted.Text = Total("Completed").ToString();
                int high = incidents.AsEnumerable().Count(r => r["Priority"].ToString() == "High");
                lblIncidents.Text = high + " high-priority incident reports to verify";
                lblVolunteers.Text = admin["PendingVolunteers"] +
                " volunteer account(s) waiting for approval";
                lblPendingRequest.Text = requests.Rows.Count == 0 ? "No Pending requests." :
                "RQ-" + requests.Rows[0]["RequestId"] + " is still Pending. Open monitor.";
                var areas = Database.GetAreaRisks();
                foreach (Control c in flowAreaRisks.Controls.Cast<Control>()
                .Where(c => c != pnlAreaTemplate).ToArray())
                { flowAreaRisks.Controls.Remove(c); c.Dispose(); }
                pnlAreaTemplate.Visible = false;
                foreach (DataRow row in areas.Rows)
                {
                    var card = FatinWalkthroughUi.CopyCard(pnlAreaTemplate);
                    ((Label)card.Controls["lblAreaName"]!).Text = row["Area"].ToString();
                    var badge = (Label)card.Controls["lblAreaBadge"]!;
                    badge.Text = row["RiskLevel"].ToString();
                    var colors = Theme.PriorityColours(badge.Text);
                    badge.BackColor = colors.Back; badge.ForeColor = colors.Fore;
                    flowAreaRisks.Controls.Add(card); card.Visible = true;
                }
                lblStatus.Text = "Actual request totals, attention items and area risks loaded.";
            });
        }
        private void OpenApprovals()
        {
            using var dialog = new ResQ.Forms.VolunteerApprovalForm();
            dialog.ShowDialog(this); LoadData();
        }

    }
}
