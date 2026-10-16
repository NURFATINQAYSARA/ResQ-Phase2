using System.Drawing;
using System.Windows.Forms;

namespace ResQ.Forms
{
    // OWNER: Nurfatin. Temporary foundation register: replaced by the Designer register
    // from "Login and Register Design Sheets.html" in the next step.
    public class RegisterForm : Form
    {
        private readonly TextBox txtFullName = new() { Width = 260 };
        private readonly TextBox txtPhone = new() { Width = 260 };
        private readonly TextBox txtUsername = new() { Width = 260 };
        private readonly TextBox txtArea = new() { Width = 260 };
        private readonly TextBox txtPassword = new() { Width = 260, UseSystemPasswordChar = true };
        private readonly TextBox txtConfirm = new() { Width = 260, UseSystemPasswordChar = true };
        private readonly RadioButton rdoResident = new() { Text = "Resident", Checked = true, AutoSize = true };
        private readonly RadioButton rdoVolunteer = new() { Text = "Volunteer", AutoSize = true };
        private readonly RadioButton rdoStandard = new() { Text = "Standard", Checked = true, AutoSize = true };
        private readonly RadioButton rdoNeedsSupport = new() { Text = "Needs Support", AutoSize = true };
        private readonly CheckBox chkHelper = new() { Text = "A helper is filling this in on my behalf", AutoSize = true };
        private readonly Button btnRegister = new() { Text = "Register", Width = 260, Height = 42 };

        public RegisterForm()
        {
            Text = "ResQ - Registration";
            ClientSize = new Size(340, 620);
            StartPosition = FormStartPosition.CenterParent;
            BackColor = Theme.Surface;
            Font = Theme.FontBody;

            int y = 20;
            void Add(string label, Control c)
            {
                var l = new Label { Text = label, AutoSize = true, Font = Theme.FontBold, ForeColor = Theme.Ink, Location = new Point(40, y) };
                Controls.Add(l);
                c.Location = new Point(40, y + 22);
                c.Width = 260;
                c.Font = Theme.FontBody;
                Controls.Add(c);
                y += 60;
            }

            Add("Full name", txtFullName);
            Add("Phone number", txtPhone);
            Add("Username", txtUsername);
            Add("Area / Taman", txtArea);
            Add("Password", txtPassword);
            Add("Confirm password", txtConfirm);

            var lRole = new Label { Text = "I am registering as", AutoSize = true, Font = Theme.FontBold, ForeColor = Theme.Ink, Location = new Point(40, y) };
            Controls.Add(lRole);
            rdoResident.Location = new Point(40, y + 24);
            rdoVolunteer.Location = new Point(140, y + 24);
            Controls.Add(rdoResident);
            Controls.Add(rdoVolunteer);
            y += 60;

            var lStatus = new Label { Text = "Resident status", AutoSize = true, Font = Theme.FontBold, ForeColor = Theme.Ink, Location = new Point(40, y) };
            Controls.Add(lStatus);
            rdoStandard.Location = new Point(40, y + 24);
            rdoNeedsSupport.Location = new Point(140, y + 24);
            Controls.Add(rdoStandard);
            Controls.Add(rdoNeedsSupport);
            y += 60;

            chkHelper.Location = new Point(40, y);
            Controls.Add(chkHelper);
            y += 34;

            Theme.StylePrimary(btnRegister);
            btnRegister.Location = new Point(40, y);
            Controls.Add(btnRegister);

            rdoResident.CheckedChanged += (s, e) => UpdateStatusVisibility();
            rdoVolunteer.CheckedChanged += (s, e) => UpdateStatusVisibility();

            AcceptButton = btnRegister;
            btnRegister.Click += (s, e) => DoRegister();
        }

        private void UpdateStatusVisibility()
        {
            bool resident = rdoResident.Checked;
            rdoStandard.Enabled = resident;
            rdoNeedsSupport.Enabled = resident;
        }

        private void DoRegister()
        {
            string role = rdoVolunteer.Checked ? "Volunteer" : "Resident";
            string status = role == "Resident" && rdoNeedsSupport.Checked ? "Needs Support" : "Standard";

            string? problem = Validator.ValidateRegistration(
                txtFullName.Text, txtUsername.Text, txtPhone.Text, txtArea.Text,
                txtPassword.Text, txtConfirm.Text, role, status);
            if (problem != null) { Warn(problem); return; }

            try
            {
                if (Database.UsernameExists(txtUsername.Text))
                {
                    Warn("That username is taken. Try another.");
                    return;
                }
                bool approved = role == "Resident";
                Database.AddUser(txtFullName.Text, txtUsername.Text, txtPassword.Text, txtPhone.Text,
                    txtArea.Text, role, status, approved, chkHelper.Checked);

                MessageBox.Show(approved
                        ? "Your account is ready. You can log in now."
                        : "Your volunteer account is created. An administrator must approve it before you can log in.",
                    "ResQ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                Warn("Something went wrong: " + ex.Message);
            }
        }

        private static void Warn(string m) =>
            MessageBox.Show(m, "ResQ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}