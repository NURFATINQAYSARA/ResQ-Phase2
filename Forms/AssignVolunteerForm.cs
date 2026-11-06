using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ResQ.Forms
{
    public partial class AssignVolunteerForm : Form
    {
        public int RequestId;
        public AssignVolunteerForm()
        {
            InitializeComponent();
            FatinWalkthroughUi.Setup(this);
            Shown += (_, _) => LoadVolunteers();
        }

        private void AssignVolunteerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            AssignSelected();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadVolunteers()
        {
            if (!FatinWalkthroughUi.Access(lblStatus, "Admin")) return;
            FatinWalkthroughUi.Run(lblStatus, () =>
            {
                lblRequest.Text = "Request RQ-" + RequestId;
                cmbVolunteer.DataSource = Database.GetAssignableVolunteers();
                cmbVolunteer.DisplayMember = "FullName"; cmbVolunteer.ValueMember = "UserId";
                cmbVolunteer.SelectedIndex = -1;
            });
        }

        private void AssignSelected()
        {
            if (!FatinWalkthroughUi.Access(lblStatus, "Admin")) return;
            if (cmbVolunteer.SelectedIndex < 0)
            { lblStatus.Text = "Choose an approved volunteer."; return; }
            FatinWalkthroughUi.Run(lblStatus, () =>
            {
                bool changed = Database.AssignVolunteer(RequestId,
                    Convert.ToInt32(cmbVolunteer.SelectedValue));
                if (!changed) { lblStatus.Text = "No change: already assigned/not Pending."; return; }
                DialogResult = DialogResult.OK; Close();
            });
        }
    }
}
