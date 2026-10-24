using ResQ.Pages;
using System.Drawing;
using System.Windows.Forms;

namespace ResQ
{
    // OWNER: Nurfatin. The main window after login.
    // The side menu is built from the role, so each role sees only its own buttons.
    public class MainShell : Form
    {
        private readonly Panel pnlSide = new() { Dock = DockStyle.Left, Width = 220 };
        private readonly Panel pnlHeader = new() { Dock = DockStyle.Top, Height = 64 };
        private readonly Panel pnlBody = new() { Dock = DockStyle.Fill };
        private readonly Label lblRole = new() { AutoSize = true };
        private readonly Label lblWho = new() { AutoSize = true };

        public MainShell()
        {
            Text = "ResQ";
            ClientSize = new Size(1100, 700);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Theme.Background;
            pnlSide.BackColor = Theme.SidebarColor(Session.Role);
            pnlBody.BackColor = Theme.Background;

            BuildSide();

            lblRole.Text = Session.Role.ToUpperInvariant();
            lblRole.Font = Theme.FontPill;
            lblRole.ForeColor = Theme.AccentColor(Session.Role);

            lblWho.Text = Session.FullName + "  ·  " + Session.Area;
            lblWho.Font = Theme.FontBold;
            lblWho.ForeColor = Theme.Ink;

            pnlHeader.BackColor = Theme.Surface;
            pnlHeader.Padding = new Padding(20, 12, 20, 12);
            pnlHeader.Controls.Add(lblWho);
            pnlHeader.Controls.Add(lblRole);

            // Stack the two header labels on the left.
            pnlHeader.Resize += (s, e) =>
            {
                lblRole.Location = new Point(20, 10);
                lblWho.Location = new Point(20, 30);
            };

            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSide);
        }

        private void BuildSide()
        {
            var brand = new Label
            {
                Text = "ResQ",
                Font = new Font("Segoe UI", 22F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(18, 20)
            };
            pnlSide.Controls.Add(brand);

            int y = 90;
            foreach (string label in MenuLabels())
                AddMenu(label, ref y);

            AddLogout(ref y);
        }

        private string[] MenuLabels() => Session.Role switch
        {
            "Resident" => new[]
            {
                "Home", "Submit Request", "My Requests",
                "Area Risk", "Report Incident", "Shelters and Contacts"
            },
            "Volunteer" => new[]
            {
                "Request Feed", "Update Status",
                "Area Risk", "Shelters and Contacts"
            },
            "Admin" => new[]
            {
                "Home", "Request Monitor", "Set Risk Levels",
                "Review Incidents", "Manage Directory", "Safety Log and Report"
            },
            _ => new[] { "Home" }
        };

        private void AddMenu(string label, ref int y)
        {
            var b = new Button
            {
                Text = label,
                Width = pnlSide.Width - 24,
                Height = 40,
                Left = 12,
                Top = y,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(12, 0, 0, 0),
                FlatStyle = FlatStyle.Flat,
                BackColor = pnlSide.BackColor,
                ForeColor = Color.White,
                Font = Theme.FontBold,
                Cursor = Cursors.Hand
            };
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 255, 255, 255);
            b.Click += (s, e) => ShowPlaceholder(label);
            pnlSide.Controls.Add(b);
            y += 44;
        }

        private void AddLogout(ref int y)
        {
            var b = new Button
            {
                Text = "Log out",
                Width = pnlSide.Width - 24,
                Height = 40,
                Left = 12,
                Top = pnlSide.Height - 60,
                Anchor = AnchorStyles.Left | AnchorStyles.Bottom,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(12, 0, 0, 0),
                FlatStyle = FlatStyle.Flat,
                BackColor = pnlSide.BackColor,
                ForeColor = Color.White,
                Font = Theme.FontBold,
                Cursor = Cursors.Hand
            };
            b.FlatAppearance.BorderSize = 0;
            b.Click += (s, e) => Close();
            pnlSide.Controls.Add(b);
        }

        // Temporary page: teammates replace each menu item with their real page.
        private void ShowPlaceholder(string label)
        {
            pnlBody.Controls.Clear();
            var page = new PageBase();
            var title = Theme.Title(label);
            title.Location = new Point(24, 24);
            page.Controls.Add(title);
            var note = Theme.Subtitle("This screen is built by the modules assigned to each role.");
            note.Location = new Point(24, 70);
            page.Controls.Add(note);
            pnlBody.Controls.Add(page);
        }
        private void btnAreaRisk_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            var areaRiskPage = new AreaRiskPage();
            pnlBody.Controls.Add(areaRiskPage);
            areaRiskPage.Dock = DockStyle.Fill;
        }
    }
}
