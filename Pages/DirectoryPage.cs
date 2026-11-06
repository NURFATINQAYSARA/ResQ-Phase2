using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ResQ.Pages
{
    public partial class DirectoryPage : PageBase
    {
        private string directoryKind = "Shelter";

        public DirectoryPage()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            WalkthroughUi.Setup(this, ["Resident", "Volunteer", "Admin"]);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnShelters_Click(object sender, EventArgs e)
        {
            directoryKind = "Shelter"; LoadData();
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            directoryKind = "Emergency contact"; LoadData();
        }

        public override void LoadData()
        {
            if (!WalkthroughUi.Access(lblStatus, "Resident", "Volunteer", "Admin")) return;

            WalkthroughUi.Run(lblStatus, () =>
            {
                Color accent = Theme.AccentColor(Session.Role);
                btnSearch.BackColor = accent;
                btnSearch.ForeColor = Session.Role == "Volunteer" ? Theme.AmberDark : Color.White;

                foreach (var button in new[] { btnShelters, btnContacts })
                {
                    bool active = button == btnShelters ? directoryKind == "Shelter" :
                                  directoryKind == "Emergency contact";
                    button.BackColor = active ? Theme.SidebarColor(Session.Role) : Theme.Surface;
                    button.ForeColor = active ? Color.White : Theme.Ink;
                }

                var rows = Database.GetDirectoryEntries(directoryKind, txtSearch.Text);
                dgvDirectory.DataSource = rows;
                lblStatus.Text = rows.Rows.Count == 0 ? "No matching entries." :
                                 "Loaded " + rows.Rows.Count + " entries.";
            });
        }
    }
}
