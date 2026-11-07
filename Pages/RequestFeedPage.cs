using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ResQ.Pages
{
    public partial class RequestFeedPage : PageBase
    {
        private DataTable requests = new();
        private string filter = "All";
        private bool binding;
        public RequestFeedPage()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            SetFilter("All");
        }

        private void btnHigh_Click(object sender, EventArgs e)
        {
            SetFilter("High");
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            SetFilter("Medium");
        }

        private void btnLow_Click(object sender, EventArgs e)
        {
            SetFilter("Low");
        }

        private void chkAvailable_CheckedChanged(object sender, EventArgs e)
        {
            SaveAvailability();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            AcceptCard(sender);
        }
        public override void LoadData()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            if (!Session.IsLoggedIn)
                return;

            try
            {
                binding = true;
                chkAvailable.Checked = Database.GetVolunteerAvailability();
                requests = Database.GetPendingRequests();
            }
            catch (Exception ex)
            {
                requests = new DataTable();
                lblMessage.Text = "Could not load the feed: " + ex.Message;
            }
            finally
            {
                binding = false;
            }

            ShowCards();
        }
        private void ShowCards()
        {
            pnlCardTemplate.Visible = false;
            foreach (var old in flpRequests.Controls.OfType<Panel>()
                .Where(p => p != pnlCardTemplate).ToList())
            {
                flpRequests.Controls.Remove(old);
                old.Dispose();
            }

            btnAll.Text = "All (" + requests.Rows.Count + ")";
            foreach (var tab in new[] { btnAll, btnHigh, btnMedium, btnLow })
            {
                bool active = tab.Name == "btn" + filter;
                tab.BackColor = active ? Theme.AmberDark : Theme.Surface;
                tab.ForeColor = active ? Color.White : Theme.Ink;
            }

            foreach (DataRow row in requests.Rows)
                if (filter == "All" || JasmineUi.Text(row["Priority"]) == filter)
                    flpRequests.Controls.Add(MakeCard(row));
        }
        private Panel MakeCard(DataRow row)
        {
            int id = Convert.ToInt32(row["RequestId"]);
            Panel card = JasmineUi.CloneCard(pnlCardTemplate, "_" + id);
            card.Tag = id;
            string priority = JasmineUi.Text(row["Priority"]);
            string mobility = JasmineUi.Text(row["Mobility"]);
            int people = Convert.ToInt32(row["PeopleCount"]);

            Part(card, "pnlStripe").BackColor = priority == "High" ? Theme.Red
                : priority == "Medium" ? Theme.Amber : Theme.Green;
            Part(card, "lblCardTitle").Text = JasmineUi.Text(row["HelpType"]);
            Part(card, "lblNeedsSupport").Visible =
                JasmineUi.Text(row["ResidentStatus"]) == "Needs Support";
            Part(card, "lblCardDetails").Text = JasmineUi.Text(row["Location"]) + " · "
                + people + (people == 1 ? " person" : " people")
                + (mobility == "" ? "" : " · " + mobility);
            JasmineUi.Pill((Label)Part(card, "lblCardPriority"),
                Theme.PriorityColours(priority), priority);
            string status = JasmineUi.Text(row["RequestStatus"]);
            JasmineUi.Pill((Label)Part(card, "lblCardStatus"),
                Theme.StatusColours(status), status);
            var accept = (Button)Part(card, "btnAccept");
            JasmineUi.Enable(accept, chkAvailable.Checked, Theme.Amber,
                Color.FromArgb(59, 39, 0));
            accept.Click += btnAccept_Click;
            return card;
        }

        private static Control Part(Panel card, string name) =>
            card.Controls[name + "_" + card.Tag]!;

        private void SetFilter(string priority)
        {
            filter = priority;
            ShowCards();
        }

        private void SaveAvailability()
        {
            if (binding)
                return;

            bool wanted = chkAvailable.Checked;

            try
            {
                if (!Database.SetVolunteerAvailability(wanted))
                    throw new InvalidOperationException("account not updated");

                lblMessage.Text = wanted
                    ? "You are available to accept requests."
                    : "You are unavailable.";
            }
            catch (Exception ex)
            {
                binding = true;
                chkAvailable.Checked = !wanted;
                binding = false;

                lblMessage.Text =
                    "Could not save availability: " + ex.Message;
            }

            ShowCards();
        }

        private void AcceptCard(object? sender)
        {
            if (sender is not Button { Parent.Tag: int id }) return;
            if (!chkAvailable.Checked) return;
            string message;
            try
            {
                message = Database.AcceptRequest(id)
                    ? "Accepted " + JasmineUi.RequestCode(id)
                        + ". Open Update Status in the sidebar."
                    : "That request was already taken or changed.";
            }
            catch (Exception ex) { message = "Could not accept: " + ex.Message; }
            LoadData();
            lblMessage.Text = message;
        }
    }
}
