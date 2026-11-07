using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ResQ.Pages
{
    public partial class UpdateStatusPage : PageBase
    {
        // MainShell (Fatin) subscribes and opens the named page.
        public event Action<string>? NavigationRequested;
        private DataTable tasks = new();
        private int shownId;
        public UpdateStatusPage()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SaveNextStatus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RequestFeed();
        }

        private void dgvTasks_CurrentCellChanged(object sender, EventArgs e)
        {
            ShowSelected();
        }

        private void dgvTasks_SelectionChanged(object sender, EventArgs e)
        {
            ShowSelected();
        }

        private void dgvTasks_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            StyleTaskGrid();
        }
        public override void LoadData()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
            if (!Session.IsLoggedIn) return;
            int keep = shownId;
            try
            {
                DataTable all = Database.GetVolunteerTasks();
                all.Columns.Add("Code", typeof(string));
                foreach (DataRow r in all.Rows)
                    r["Code"] = JasmineUi.RequestCode(r["RequestId"]);
                tasks = all.DefaultView.ToTable(false, "RequestId", "Code", "HelpType",
                    "Location", "RequestStatus", "Priority", "PeopleCount", "Mobility",
                    "ResidentStatus");
            }
            catch (Exception ex)
            {
                tasks = new DataTable();
                lblMessage.Text = "Could not load tasks: " + ex.Message;
            }
            dgvTasks.DataSource = tasks;
            SelectTask(keep);
            ShowSelected();
        }

        private void StyleTaskGrid()
        {
            Theme.StyleGrid(dgvTasks);
            foreach (DataGridViewColumn column in dgvTasks.Columns)
                column.Visible = column.Name is "Code" or "HelpType" or "Location"
                    or "RequestStatus";
            SetHeader("Code", "ID");
            SetHeader("HelpType", "TYPE");
            SetHeader("Location", "LOCATION");
            SetHeader("RequestStatus", "STATUS");
        }

        private void SetHeader(string column, string text)
        {
            if (dgvTasks.Columns[column] is { } c) c.HeaderText = text;
        }

        // Selects a visible cell so CurrentCell never lands on a hidden column.
        private void SelectTask(int requestId)
        {
            if (dgvTasks.Rows.Count == 0 || dgvTasks.Columns["Code"] is null) return;
            DataGridViewRow row = dgvTasks.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(r =>
                    Convert.ToInt32(r.Cells["RequestId"].Value) == requestId)
                ?? dgvTasks.Rows[0];
            dgvTasks.CurrentCell = row.Cells["Code"];
        }

        private DataRow? Selected() =>
            (dgvTasks.CurrentRow?.DataBoundItem as DataRowView)?.Row;
        private void ShowSelected()
        {
            DataRow? row = Selected();
            if (row == null) { ShowEmpty(); return; }
            shownId = Convert.ToInt32(row["RequestId"]);
            string status = JasmineUi.Text(row["RequestStatus"]);
            lblTaskTitle.Text = JasmineUi.Text(row["Code"]) + " · "
                + JasmineUi.Text(row["HelpType"]);
            string mobility = JasmineUi.Text(row["Mobility"]);
            lblTaskDetails.Text = JasmineUi.Text(row["Location"]) + " · "
                + JasmineUi.Text(row["PeopleCount"]) + " people"
                + (mobility == "" ? "" : " · " + mobility);
            string resident = JasmineUi.Text(row["ResidentStatus"]);
            lblNeedsSupport.Visible = resident == "Needs Support";
            string priority = JasmineUi.Text(row["Priority"]);
            JasmineUi.Pill(lblPriority, Theme.PriorityColours(priority), priority);
            lblCurrentStatus.Text = "Current status: " + status;
            JasmineUi.ShowSteps(Steps(), status, "Current");
            string? next = NextStatus(status);
            btnNext.Enabled = next != null;
            btnNext.Text = next == null ? status : "Mark as " + next;
            btnNext.BackColor = next == null ? Theme.Grey : JasmineUi.StepColour(next);
            btnNext.FlatAppearance.BorderColor = btnNext.BackColor;
            txtNote.Enabled = next != null;
        }

        private void ShowEmpty()
        {
            shownId = 0;
            lblTaskTitle.Text = "Update status";
            lblTaskDetails.Text = "You have no assigned tasks. "
                + "Accept one from Request Feed.";
            lblNeedsSupport.Visible = false;
            JasmineUi.Pill(lblPriority, Theme.StatusColours(""), "-");
            lblCurrentStatus.Text = "Current status: -";
            JasmineUi.ShowSteps(Steps(), null, "Current");
            btnNext.Enabled = false;
            btnNext.Text = "Next status";
            btnNext.BackColor = Theme.Grey;
            txtNote.Enabled = false;
        }

        private static string? NextStatus(string status) => status switch
        {
            "Accepted" => "In Progress",
            "In Progress" => "Safe / Evacuated",
            "Safe / Evacuated" => "Completed",
            _ => null
        };
        // Request row and Safety Log note commit together inside the database method.
        private void SaveNextStatus()
        {
            DataRow? row = Selected();
            if (row == null) return;
            string? next = NextStatus(JasmineUi.Text(row["RequestStatus"]));
            if (next == null) return;
            try
            {
                if (Database.UpdateRequestStatus(shownId, next, txtNote.Text))
                {
                    txtNote.Clear();
                    lblMessage.Text = "Saved: " + next + ".";
                }
                else lblMessage.Text = "This task has changed. The latest status is shown.";
            }
            catch (Exception ex) { lblMessage.Text = "Could not save: " + ex.Message; }
            LoadData();
        }

        private void RequestFeed()
        {
            if (NavigationRequested == null)
                lblMessage.Text = "Fatin must connect this shortcut; "
                    + "use Request Feed in sidebar.";
            else NavigationRequested("Request Feed");
        }

        private Label[] Steps() => [lblStep1, lblStep2, lblStep3, lblStep4, lblStep5];
    }
}
