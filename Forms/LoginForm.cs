using System.Drawing;
using System.Windows.Forms;

namespace ResQ.Forms
{
    // OWNER: Nurfatin. Temporary foundation login: replaced by the Designer login
    // from "Login and Register Design Sheets.html" in the next step.
    public class LoginForm : Form
    {
        private readonly TextBox txtUsername = new() { Width = 260, Font = Theme.FontBody };
        private readonly TextBox txtPassword = new() { Width = 260, Font = Theme.FontBody, UseSystemPasswordChar = true };
        private readonly Button btnLogin = new() { Text = "Log in", Width = 260, Height = 42 };
        private readonly Button btnRegister = new() { Text = "Register", Width = 260, Height = 42 };

        public LoginForm()
        {
            Text = "ResQ";
            ClientSize = new Size(420, 360);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Theme.Surface;
            Font = Theme.FontBody;

            var title = Theme.Title("ResQ");
            title.Location = new Point(40, 30);

            var hint = Theme.Subtitle("Community Emergency Response and Support Application");
            hint.Location = new Point(40, 76);
            hint.MaximumSize = new Size(340, 0);

            var lUser = Theme.Heading("Username");
            lUser.Location = new Point(40, 120);
            txtUsername.Location = new Point(40, 146);

            var lPass = Theme.Heading("Password");
            lPass.Location = new Point(40, 186);
            txtPassword.Location = new Point(40, 212);

            Theme.StylePrimary(btnLogin);
            Theme.StyleSecondary(btnRegister);
            btnLogin.Location = new Point(40, 262);
            btnRegister.Location = new Point(40, 310);

            AcceptButton = btnLogin;

            btnLogin.Click += (s, e) => DoLogin();
            btnRegister.Click += (s, e) => { using var f = new RegisterForm(); f.ShowDialog(this); };

            Controls.AddRange(new Control[]
            {
                title, hint, lUser, txtUsername, lPass, txtPassword, btnLogin, btnRegister
            });
        }

        private void DoLogin()
        {
            if (txtUsername.Text.Trim().Length == 0 || txtPassword.Text.Length == 0)
            {
                Warn("Enter your username and password.");
                return;
            }
            try
            {
                User? user = Database.Authenticate(txtUsername.Text, txtPassword.Text, out string error);
                if (user == null) { Warn(error); return; }

                Session.Start(user);
                txtPassword.Clear();
                Hide();

                var shell = new MainShell();
                shell.FormClosed += (s, e) =>
                {
                    Session.End();
                    Show();
                    txtUsername.Focus();
                };
                shell.Show();
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