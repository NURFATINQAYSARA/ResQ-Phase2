using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace ResQ.Forms
{
    public partial class VolunteerApprovalForm : Form
    {
        public VolunteerApprovalForm()
        {
            InitializeComponent();
            FatinWalkthroughUi.Setup(this);
            Shown += (_, _) => LoadVolunteers();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            ApproveSelected();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadVolunteers()
        {
            if (!FatinWalkthroughUi.Access(lblStatus, "Admin")) return;
            FatinWalkthroughUi.Run(lblStatus, () =>
            {
                var rows = Database.GetPendingVolunteers();
                dgvVolunteers.DataSource = rows;
                lblStatus.Text = rows.Rows.Count == 0 ? "No volunteers waiting." :
                    "Select the person to approve.";
            });
        }
        private void ApproveSelected()
        {
            if (!FatinWalkthroughUi.Access(lblStatus, "Admin")) return;
            var row = FatinWalkthroughUi.Selected(dgvVolunteers);
            if (row == null) { lblStatus.Text = "Select a volunteer row."; return; }
            if (MessageBox.Show("Approve " + row["FullName"] + "?", "ResQ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            FatinWalkthroughUi.Run(lblStatus, () =>
            {
                bool changed = Database.ApproveVolunteer(Convert.ToInt32(row["UserId"]));
                LoadVolunteers(); lblStatus.Text = changed ? "Volunteer approved." : "Already approved.";
            });
        }
    }
}
