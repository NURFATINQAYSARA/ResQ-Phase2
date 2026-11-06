using ResQ.Pages;
using System.Reflection;
namespace ResQ
{
    // OWNER: Nurfatin. Keeps one sidebar and loads the installed role pages.
    public class MainShell : Form
    {
        private readonly Panel pnlSide = new() { Dock = DockStyle.Left, Width = 220 };
        private readonly Panel pnlHeader = new() { Dock = DockStyle.Top, Height = 64 };
        private readonly Panel pnlBody = new() { Dock = DockStyle.Fill };
        private readonly Label lblRole = new() { AutoSize = true };
        private readonly Label lblWho = new() { AutoSize = true };
        public MainShell()
        {
            Text = "ResQ - simulation only";
            ClientSize = new Size(1140, 720);
            MinimumSize = new Size(1000, 620);
            StartPosition = FormStartPosition.CenterScreen;
            pnlSide.Width = 240;
            BackColor = Theme.Background;
            pnlSide.BackColor = Theme.SidebarColor(Session.Role);
            pnlBody.BackColor = Theme.Background;
            BuildSide();
            lblRole.Text = Session.Role.ToUpperInvariant();
            lblRole.Font = Theme.FontPill;
            lblRole.ForeColor = Theme.AccentColor(Session.Role);
            lblWho.Text = Session.FullName + " | " + Session.Area;
            lblWho.Font = Theme.FontBold;
            lblWho.ForeColor = Theme.Ink;
            lblRole.Location = new Point(20, 10);
            lblWho.Location = new Point(20, 30);
            pnlHeader.BackColor = Theme.Surface;
            pnlHeader.Controls.Add(lblWho);
            pnlHeader.Controls.Add(lblRole);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSide);
            Shown += (_, _) => Navigate(Session.Role == "Volunteer" ? "Request Feed" : "Home");
        }
        private string[] MenuLabels() => Session.Role switch
        {
            "Resident" => ["Home", "Submit Request", "My Requests", "Area Risk",
 "Report Incident", "Shelters and Contacts"],
            "Volunteer" => ["Request Feed", "Update Status", "Area Risk",
 "Shelters and Contacts"],
            "Admin" => ["Home", "Request Monitor", "Set Risk Levels", "Review Incidents",
 "Manage Directory", "Safety Log and Report"],
            _ => []
        };
        private void BuildSide()
        {
            pnlSide.Controls.Add(new Label
            {
                Text = "ResQ",
                AutoSize = true,
                Font = new Font("Segoe UI", 22, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(18, 20)
            });
            int y = 90;
            foreach (string label in MenuLabels())
            {
                string destination = label;
                var button = new Button
                {
                    Text = label,
                    Left = 12,
                    Top = y,
                    Width = pnlSide.Width - 24, // Automatically leaves 12px margin on left and right
                    Height = 42,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = pnlSide.BackColor,
                    ForeColor = Color.White,
                    Font = Theme.FontBold,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(10, 0, 0, 0)
                };
                button.FlatAppearance.BorderSize = 0;
                button.Click += (_, _) => Navigate(destination);
                pnlSide.Controls.Add(button);
                y += 46;
            }
            var logout = new Button
            {
                Text = "Log out",
                Dock = DockStyle.Bottom,
                Height = 45,
                BackColor = pnlSide.BackColor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = Theme.FontBold
            };
            logout.Click += (_, _) => { Session.End(); Close(); };
            pnlSide.Controls.Add(logout);
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // MainShell
            // 
            ClientSize = new Size(278, 244);
            Name = "MainShell";
            Load += MainShell_Load;
            ResumeLayout(false);

        }

        private void Navigate(string label)
        {
            // Only menu destinations for the current role are accepted.
            if (!MenuLabels().Contains(label)) return;
            string? name = label switch
            {
                "Home" => Session.Role == "Admin" ? "AdminHomePage" : "ResidentHomePage",
                "Submit Request" => "SubmitRequestPage",
                "My Requests" => "MyRequestsPage",
                "Request Feed" => "RequestFeedPage",
                "Update Status" => "UpdateStatusPage",
                "Area Risk" => "AreaRiskPage",
                "Report Incident" => "ReportIncidentPage",
                "Shelters and Contacts" => "DirectoryPage",
                "Request Monitor" => "RequestMonitorPage",
                "Set Risk Levels" => "SetRiskLevelsPage",
                "Review Incidents" => "ReviewIncidentsPage",
                "Manage Directory" => "ManageDirectoryPage",
                "Safety Log and Report" => "SafetyLogPage",
                _ => null
            };
            PageBase? page = null;
            try
            {
                Type? type = typeof(MainShell).Assembly.GetType("ResQ.Pages." + name);
                if (type == null)
                {
                    MessageBox.Show(label + " has not been added yet. " +
                    "Merge its owner's page before using this menu.", "ResQ");
                    return;
                }
                if (!typeof(PageBase).IsAssignableFrom(type))
                    throw new InvalidOperationException("Page must inherit PageBase.");
                page = (PageBase)Activator.CreateInstance(type)!;
                if (page is IFatinWalkthroughNavigation links)
                    links.NavigationRequested += Navigate;
                foreach (Control old in pnlBody.Controls.Cast<Control>().ToArray()) old.Dispose();
                pnlBody.Controls.Clear();
                page.Dock = DockStyle.Fill;
                pnlBody.Controls.Add(page);
                page.LoadData();
            }
            catch (Exception ex) when (ex is TargetInvocationException or
            InvalidOperationException or ArgumentException or UnauthorizedAccessException or
            Microsoft.Data.Sqlite.SqliteException)
            {
                if (page != null && !pnlBody.Controls.Contains(page)) page.Dispose();
                MessageBox.Show("Could not open this page. Check its build and database setup.",
                "ResQ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MainShell_Load(object sender, EventArgs e)
        {

        }
    }
}