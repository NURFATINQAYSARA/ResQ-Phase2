using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ResQ.Pages
{
    public partial class MyRequestsPage : PageBase
    {
        private bool binding;
        public MyRequestsPage()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelSelected();
        }

        private void cboRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSelected();
        }
        public override void LoadData()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
            if (!Session.IsLoggedIn) return;
            object? keep = cboRequests.SelectedValue;
            try
            {
                DataTable rows = Database.GetResidentRequests();
                rows.Columns.Add("Display", typeof(string));
                foreach (DataRow r in rows.Rows)
                    r["Display"] = JasmineUi.RequestCode(r["RequestId"])
                        + " · " + r["HelpType"];
                binding = true;
                cboRequests.DisplayMember = "Display";
                cboRequests.ValueMember = "RequestId";
                cboRequests.DataSource = rows;
                cboRequests.SelectedIndex = -1;
                if (keep != null && rows.Select("RequestId = " + keep).Length == 1)
                    cboRequests.SelectedValue = keep;
                else if (rows.Rows.Count > 0) cboRequests.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Could not load requests: " + ex.Message;
            }
            finally { binding = false; }
            ShowSelected();
        }

        private DataRow? Selected() => (cboRequests.SelectedItem as DataRowView)?.Row;

        private void ShowSelected()
        {
            if (binding) return;
            DataRow? row = Selected();
            if (row == null) { ShowEmpty(); return; }
            string status = JasmineUi.Text(row["RequestStatus"]);
            lblRequestTitle.Text = JasmineUi.RequestCode(row["RequestId"]) + " · "
                + JasmineUi.Text(row["HelpType"]);
            lblLocation.Text = JasmineUi.Text(row["Location"]);
            JasmineUi.Pill(lblStatus, Theme.StatusColours(status), status);
            JasmineUi.ShowSteps(Steps(), status, "You are here");
            CancelEnabled(status == "Pending" && row["VolunteerId"] == DBNull.Value);
            string volunteer = JasmineUi.Text(row["VolunteerName"]);
            lblVolunteerName.Text = volunteer == "" ? "Not assigned yet" : volunteer;
            lblVolunteerRole.Text = volunteer == "" ? "Waiting for a volunteer"
                : "Community Volunteer";
            lblInitials.Text = volunteer == "" ? "--" : JasmineUi.Initials(volunteer);
            string priority = JasmineUi.Text(row["Priority"]);
            JasmineUi.Pill(lblPriority, Theme.PriorityColours(priority), priority);
            lblPeople.Text = JasmineUi.Text(row["PeopleCount"]);
            string mobility = JasmineUi.Text(row["Mobility"]);
            lblMobility.Text = mobility == "" ? "None given" : mobility;
            ShowActivity(Convert.ToInt32(row["RequestId"]));
        }
        private void ShowActivity(int requestId)
        {
            lstActivity.Items.Clear();
            try
            {
                foreach (DataRow log in Database.GetResidentRequestActivity(requestId).Rows)
                {
                    string note = JasmineUi.Text(log["Note"]);
                    lstActivity.Items.Add(JasmineUi.Text(log["LoggedAt"]) + "  "
                        + JasmineUi.Text(log["NewStatus"]) + " by "
                        + JasmineUi.Text(log["ChangedByName"])
                        + (note == "" ? "" : " - " + note));
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Could not load activity: " + ex.Message;
            }
        }

        private void ShowEmpty()
        {
            lblRequestTitle.Text = "My requests";
            lblLocation.Text = "You have no requests yet.";
            JasmineUi.Pill(lblStatus, Theme.StatusColours(""), "No request");
            JasmineUi.ShowSteps(Steps(), null, "You are here");
            CancelEnabled(false);
            lstActivity.Items.Clear();
            lblVolunteerName.Text = "Not assigned yet";
            lblVolunteerRole.Text = "Waiting for a volunteer";
            lblInitials.Text = "--";
            JasmineUi.Pill(lblPriority, Theme.StatusColours(""), "-");
            lblPeople.Text = "-";
            lblMobility.Text = "-";
        }

        // Direct action (no modal); the database only cancels own unassigned Pending.
        private void CancelSelected()
        {
            DataRow? row = Selected();
            if (row == null) return;
            try
            {
                bool done = Database.CancelRequest(Convert.ToInt32(row["RequestId"]));
                lblMessage.Text = done ? "Request cancelled."
                    : "This request has changed and can no longer be cancelled.";
            }
            catch (Exception ex) { lblMessage.Text = "Could not cancel: " + ex.Message; }
            LoadData();
        }

        private void CancelEnabled(bool enabled) => JasmineUi.Enable(btnCancel, enabled,
            Theme.Surface, Color.FromArgb(143, 29, 23));

        private Label[] Steps() => [lblStep1, lblStep2, lblStep3, lblStep4, lblStep5];
    } 
}
