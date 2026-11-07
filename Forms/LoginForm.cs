using System;
using System.Drawing;
using System.Windows.Forms;

namespace ResQ.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            Theme.StylePrimary(this.btnLogin);
            Theme.StyleSecondary(this.btnRegister);

            AcceptButton = btnLogin;

            rdoResident.CheckedChanged += (s, e) => UpdateRoleButtons();
            rdoVolunteer.CheckedChanged += (s, e) => UpdateRoleButtons();
            rdoAdmin.CheckedChanged += (s, e) => UpdateRoleButtons();

            UpdateRoleButtons();
        }

        private string SelectedRole() =>
            rdoVolunteer.Checked
                ? "Volunteer"
                : rdoAdmin.Checked
                    ? "Admin"
                    : "Resident";

        private void UpdateRoleButtons()
        {
            SetRoleStyle(rdoResident, Theme.Red, Color.White);
            SetRoleStyle(rdoVolunteer, Theme.Amber, Theme.AmberDark);
            SetRoleStyle(rdoAdmin, Theme.Navy, Color.White);
        }

        private static void SetRoleStyle(
            RadioButton radio,
            Color colour,
            Color textOnColour)
        {
            radio.Appearance = Appearance.Button;
            radio.FlatStyle = FlatStyle.Flat;
            radio.TextAlign = ContentAlignment.MiddleCenter;
            radio.Font = Theme.FontBold;
            radio.Cursor = Cursors.Hand;
            radio.UseVisualStyleBackColor = false;

            radio.FlatAppearance.BorderSize = 2;
            radio.FlatAppearance.BorderColor = colour;
            radio.FlatAppearance.CheckedBackColor = colour;

            radio.BackColor = radio.Checked ? colour : Color.White;
            radio.ForeColor = radio.Checked
                ? textOnColour
                : (colour == Theme.Amber ? Theme.AmberDark : colour);
        }

        private void rdoVolunteer_CheckedChanged(object? sender, EventArgs e) =>
            UpdateRoleButtons();

        private void rdoAdmin_CheckedChanged(object? sender, EventArgs e) =>
            UpdateRoleButtons();

        private void btnLogin_Click(object? sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();


            if (username.Length == 0 || txtPassword.Text.Length == 0)
            {
                Warn("Enter your username and password.");
                return;
            }

            try
            {
                User? user = Database.Authenticate(
                    username,
                    txtPassword.Text,
                    out string error);

                if (user == null)
                {
                    Warn(error);
                    return;
                }

                if (user.Role != SelectedRole())
                {
                    Warn(
                        "This account is a " + user.Role +
                        ". Choose " + user.Role + " above, then log in.");
                    return;
                }

                Session.Start(user);
                txtPassword.Clear();

                var shell = new MainShell();

                shell.FormClosed += (s, ev) =>
                {
                    Session.End();
                    Show();
                    txtUsername.Focus();
                    shell.Dispose();
                };

                Hide();
                shell.Show();
            }
            catch (Exception ex)
            {
                Session.End();

                if (!Visible)
                    Show();

                Warn("Something went wrong: " + ex.Message);
            }
        }

        private void btnRegister_Click(object? sender, EventArgs e)
        {
            using var form = new RegisterForm();
            form.ShowDialog(this);
        }

        private static void Warn(string message) =>
            MessageBox.Show(
                message,
                "ResQ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}