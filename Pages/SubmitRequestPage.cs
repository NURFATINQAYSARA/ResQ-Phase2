using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ResQ.Pages
{
    public partial class SubmitRequestPage : PageBase
    {
        public SubmitRequestPage()
        {
            InitializeComponent();
            Theme.StylePrimary(btnSubmit);
            Theme.StyleSecondary(btnClear);

            lblNext1.BackColor = Theme.Grey;
            lblNext2.BackColor = Theme.Amber;
            lblNext3.BackColor = Theme.Red;
            lblNext4.BackColor = Theme.Green;
            lblNext5.BackColor = Theme.Navy;

            rdoEvacuation.CheckedChanged += rdoChoice_CheckedChanged;
            rdoMobility.CheckedChanged += rdoChoice_CheckedChanged;
            rdoSafety.CheckedChanged += rdoChoice_CheckedChanged;
            rdoSupplies.CheckedChanged += rdoChoice_CheckedChanged;

            rdoLow.CheckedChanged += rdoChoice_CheckedChanged;
            rdoMedium.CheckedChanged += rdoChoice_CheckedChanged;
            rdoHigh.CheckedChanged += rdoChoice_CheckedChanged;

            UpdateChoices();
        }

        private void rdoChoice_CheckedChanged(object? sender, EventArgs e)
        {
            UpdateChoices();
        }

        // Called by MainShell each time the page is shown.
        public override void LoadData()
        {
            if (!IsResident())
                ShowMessage("Please sign in as a resident to submit a request.", false);
        }

        private static bool IsResident() =>
            Session.IsLoggedIn && Session.Role == "Resident";

        private void ShowMessage(string message, bool success)
        {
            lblMessage.ForeColor = success ? Theme.Green : Theme.Red;
            lblMessage.Text = message;
        }

        private void UpdateChoices()
        {
            StyleChoice(rdoEvacuation, Theme.Red);
            StyleChoice(rdoMobility, Theme.Amber);
            StyleChoice(rdoSafety, Theme.Green);
            StyleChoice(rdoSupplies, Theme.Navy);

            StyleChoice(rdoLow, Theme.Green);
            StyleChoice(rdoMedium, Theme.Amber);
            StyleChoice(rdoHigh, Theme.Red);
        }

        private static void StyleChoice(RadioButton radio, Color accent)
        {
            Color tint = Color.FromArgb(
                (accent.R + 4 * 255) / 5,
                (accent.G + 4 * 255) / 5,
                (accent.B + 4 * 255) / 5);

            radio.FlatAppearance.BorderSize = radio.Checked ? 2 : 1;
            radio.FlatAppearance.BorderColor =
                radio.Checked ? accent : Theme.Border;

            radio.FlatAppearance.CheckedBackColor = tint;
            radio.BackColor = radio.Checked ? tint : Color.White;
            radio.ForeColor = Theme.Ink;
        }

        private string SelectedHelpType() =>
            rdoEvacuation.Checked ? "Evacuation"
            : rdoMobility.Checked ? "Mobility support"
            : rdoSafety.Checked ? "Safety check-in"
            : rdoSupplies.Checked ? "Supplies"
            : "";

        private string SelectedPriority() =>
            rdoLow.Checked ? "Low"
            : rdoMedium.Checked ? "Medium"
            : rdoHigh.Checked ? "High"
            : "";

        private void SubmitCurrentRequest()
        {
            if (!IsResident())
            {
                ShowMessage(
                    "Please sign in as a resident to submit a request.",
                    false);
                return;
            }

            bool countOk =
                Validator.TryParsePositiveInt(
                    txtPeople.Text,
                    out int people);

            string? problem =
                Validator.ValidateRequest(
                    SelectedHelpType(),
                    txtLocation.Text,
                    countOk ? people : 1,
                    txtMobility.Text,
                    SelectedPriority(),
                    txtExtra.Text);

            if (problem == null && !countOk)
                problem =
                    "People count must be a whole number of at least 1.";

            if (problem != null)
            {
                ShowMessage(problem, false);
                return;
            }

            try
            {
                long id =
                    Database.SubmitRequest(
                        SelectedHelpType(),
                        txtLocation.Text,
                        people,
                        txtMobility.Text,
                        SelectedPriority(),
                        txtExtra.Text);

                ClearForm();

                ShowMessage(
                    $"Request #{id} submitted. It is now Pending in the volunteer feed.",
                    true);
            }
            catch (UnauthorizedAccessException ex)
            {
                ShowMessage(ex.Message, false);
            }
            catch (ArgumentException ex)
            {
                ShowMessage(ex.Message, false);
            }
            catch (Exception)
            {
                ShowMessage(
                    "Your request could not be saved. Please try again.",
                    false);
            }
        }

        private void ClearForm()
        {
            rdoEvacuation.Checked = false;
            rdoMobility.Checked = false;
            rdoSafety.Checked = false;
            rdoSupplies.Checked = false;

            rdoLow.Checked = false;
            rdoMedium.Checked = false;
            rdoHigh.Checked = false;

            txtLocation.Clear();
            txtPeople.Clear();
            txtMobility.Clear();
            txtExtra.Clear();

            lblMessage.Text = "";

            UpdateChoices();

            txtLocation.Focus();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SubmitCurrentRequest();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void SubmitRequestPage_Load(object? sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
                LoadData();
        }
    }
}
