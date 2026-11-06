using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ResQ.Pages
{
    public partial class ReportIncidentPage : PageBase
    {
        public ReportIncidentPage()
        {
            InitializeComponent();

            WalkthroughUi.Setup(this, ["Resident", "Volunteer", "Admin"]);
            rdoTree.Checked = rdoLow.Checked = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendIncident();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ClearForm()
        {
            txtLocation.Clear();
            txtDescription.Clear();
            rdoTree.Checked = true;
            rdoLow.Checked = true;
        }

        private void SendIncident()
        {
            if (!WalkthroughUi.Access(lblStatus, "Resident", "Volunteer")) return;

            WalkthroughUi.Run(lblStatus, () =>
            {
                string hazard = rdoTree.Checked ? "Fallen tree" :
                                rdoRoad.Checked ? "Blocked road" :
                                rdoFlood.Checked ? "Flooding" : "";

                string priority = rdoHigh.Checked ? "High" :
                                  rdoMedium.Checked ? "Medium" :
                                  rdoLow.Checked ? "Low" : "";

                string? error = Validator.ValidateIncident(hazard, txtLocation.Text, priority, txtDescription.Text);
                if (error != null) throw new ArgumentException(error);

                long id = Database.SubmitIncident(hazard, txtLocation.Text, priority, txtDescription.Text);

                ClearForm();
                LoadData();

                lblStatus.Text = "Report #" + id + " sent. " + lblStatus.Text;
            });
        }

        public override void LoadData()
        {
            if (!WalkthroughUi.Access(lblStatus, "Resident", "Volunteer")) return;

            WalkthroughUi.Run(lblStatus, () =>
            {
                dgvMyReports.DataSource = Database.GetMyIncidents();
                lblStatus.Text = "Your own reports loaded. Review status updates after Refresh.";
            });
        }
    }
}
