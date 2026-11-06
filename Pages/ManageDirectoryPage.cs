using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace ResQ.Pages
{
    public partial class ManageDirectoryPage : PageBase
    {
        private int? entryId;
        public ManageDirectoryPage()
        {
            InitializeComponent();

            WalkthroughUi.Setup(this, ["Resident", "Volunteer", "Admin"]);
            cmbKind.SelectedIndexChanged += (_, _) => EntryStatuses();
            cmbKind.SelectedIndex = 0; EntryStatuses();
            dgvDirectory.Columns.Add(new DataGridViewLinkColumn
            {
                Name = "EditAction",
                Text = "Edit",
                UseColumnTextForLinkValue = true,
                LinkColor = Theme.Navy
            });
            dgvDirectory.Columns.Add(new DataGridViewLinkColumn
            {
                Name = "RemoveAction",
                Text = "Remove",
                UseColumnTextForLinkValue = true,
                LinkColor = Theme.Red
            });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveEntry();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearEntry();
        }

        private void dgvDirectory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DirectoryAction(e);
        }

        private void EntryStatuses()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(cmbKind.Text == "Shelter" ?
                new object[] { "Open", "Closed" } : new object[] { "Active" });
            cmbStatus.SelectedIndex = 0;
        }

        private void ClearEntry()
        {
            entryId = null; txtName.Clear(); txtArea.Clear(); txtPhone.Clear();
            lblError.Text = ""; lblEntryTitle.Text = "Add entry";
            cmbKind.SelectedIndex = 0; EntryStatuses();
        }

        private void DirectoryAction(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 ||
                !WalkthroughUi.Access(lblStatus, "Admin")) return;
            WalkthroughUi.Run(lblStatus, () =>
            {
                var row = (DataRowView)dgvDirectory.Rows[e.RowIndex].DataBoundItem!;
                int id = Convert.ToInt32(row["EntryId"]);
                string column = dgvDirectory.Columns[e.ColumnIndex].Name;
                if (column == "RemoveAction")
                {
                    if (!Confirm("Remove " + row["Name"] + "?")) return;
                    bool changed = Database.DeleteDirectoryEntry(id);
                    LoadData(); lblStatus.Text = changed ? "Entry removed." : "Already removed.";
                }
                else if (column == "EditAction")
                {
                    entryId = id; txtName.Text = row["Name"].ToString();
                    txtArea.Text = row["Area"].ToString(); txtPhone.Text = row["Phone"].ToString();
                    cmbKind.SelectedItem = row["Kind"].ToString(); EntryStatuses();
                    cmbStatus.SelectedItem = row["Status"].ToString();
                    lblEntryTitle.Text = "Edit entry"; lblError.Text = "";
                }
            });
        }

        private void SaveEntry()
        {
            if (!WalkthroughUi.Access(lblStatus, "Admin")) return;
            lblError.Text = Validator.ValidateDirectoryEntry(txtName.Text, cmbKind.Text,
                txtArea.Text, txtPhone.Text, cmbStatus.Text) ?? "";
            if (lblError.Text.Length > 0) return;
            WalkthroughUi.Run(lblStatus, () =>
            {
                if (entryId.HasValue)
                {
                    if (!Database.UpdateDirectoryEntry(entryId.Value, txtName.Text,
                        cmbKind.Text, txtArea.Text, txtPhone.Text, cmbStatus.Text))
                        throw new ArgumentException("Entry no longer exists. Refresh.");
                }
                else Database.AddDirectoryEntry(txtName.Text, cmbKind.Text,
                    txtArea.Text, txtPhone.Text, cmbStatus.Text);
                ClearEntry(); LoadData(); lblStatus.Text = "Directory saved.";
            });
        }

        public override void LoadData()
        {
            if (!WalkthroughUi.Access(lblStatus, "Admin")) return;
            WalkthroughUi.Run(lblStatus, () =>
            {
                dgvDirectory.DataSource = Database.GetDirectoryEntries();
                lblStatus.Text = "Use Edit / Remove links; Save writes the form.";
            });
        }
    }
}
