using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ResQ.Pages
{
    public partial class RequestMonitorPage : PageBase
    {
        private string? filterStatus;
        public RequestMonitorPage()
        {
            InitializeComponent();
            FatinWalkthroughUi.Setup(this);
            dgvRequests.Columns.Add(new DataGridViewLinkColumn
            {
                Name = "RowAction",
                DataPropertyName = "ActionText",
                UseColumnTextForLinkValue = false,
                LinkColor = Theme.Navy,
                TrackVisitedState = false
            });
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            filterStatus = null; LoadData();
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            filterStatus = "Pending"; LoadData();
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            filterStatus = "In Progress"; LoadData();
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            filterStatus = "Completed"; LoadData();
        }

        private void dgvRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RequestAction(e);
        }
        public override void LoadData()
        {
            if (!FatinWalkthroughUi.Access(lblStatus, "Admin")) return;
            FatinWalkthroughUi.Run(lblStatus, () =>
            {
                var rows = Database.GetAllRequests(filterStatus);
                rows.Columns.Add("ActionText", typeof(string));
                foreach (DataRow row in rows.Rows)
                {
                    if (row["ResidentStatus"].ToString() == "Needs Support")
                        row["ResidentName"] = row["ResidentName"] + " NS";
                    if (row["VolunteerName"] == DBNull.Value) row["VolunteerName"] = "Not assigned";
                    string status = row["RequestStatus"].ToString()!;
                    row["ActionText"] = status == "Pending" ? "Assign volunteer" :
                        status == "Completed" && Convert.ToInt32(row["Verified"]) == 0
                        ? "Verify completion" : "View";
                }
                dgvRequests.DataSource = rows;
                foreach (var button in new[] { btnAll, btnPending, btnProgress, btnCompleted })
                {
                    bool active = button == btnAll ? filterStatus == null :
                        button == btnPending ? filterStatus == "Pending" :
                        button == btnProgress ? filterStatus == "In Progress" :
                        filterStatus == "Completed";
                    button.BackColor = active ? Theme.Navy : Theme.Surface;
                    button.ForeColor = active ? Color.White : Theme.Ink;
                }
                btnAll.Text = "All (" + Database.GetAllRequests().Rows.Count + ")";
                lblStatus.Text = rows.Rows.Count == 0 ? "No matching requests." :
                    "Showing " + rows.Rows.Count + " actual saved requests.";
            });
        }

        private void RequestAction(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 ||
                dgvRequests.Columns[e.ColumnIndex].Name != "RowAction") return;
            FatinWalkthroughUi.Run(lblStatus, () =>
            {
                var row = (DataRowView)dgvRequests.Rows[e.RowIndex].DataBoundItem!;
                int id = Convert.ToInt32(row["RequestId"]);
                string action = row["ActionText"].ToString()!;
                if (action == "Assign volunteer")
                {
                    using var dialog = new ResQ.Forms.AssignVolunteerForm();
                    dialog.RequestId = id; dialog.ShowDialog(this); LoadData();
                }
                else if (action == "Verify completion")
                {
                    if (!Confirm("Verify completed request RQ-" + id + "?")) return;
                    bool changed = Database.VerifyCompletion(id);
                    LoadData(); lblStatus.Text = changed ? "Completion verified and logged." :
                        "No change: already verified or no longer eligible.";
                }
                else MessageBox.Show("RQ-" + id + " | " + row["ResidentName"] +
                    "\n" + row["Location"] + "\nStatus: " + row["RequestStatus"] +
                    "\nInformation: " + row["ExtraInfo"], "Request details");
            });
        }
    }
}
