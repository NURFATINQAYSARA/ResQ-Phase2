using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace ResQ.Pages
{
    // OWNER: Nurfatin. Admin page.
    // Lists every area from AreaRisk and lets the admin change its risk level + note.
    // Writes back to the existing AreaRisk table — no new table.
    public partial class SetRiskLevelsPage : PageBase
    {
        public SetRiskLevelsPage()
        {
            InitializeComponent();
            Theme.StyleSecondary(btnRefresh);
            flowAreas.SizeChanged += (s, e) => ResizeAreaCards();
            btnRefresh.Click += (s, e) => LoadData();
            LoadData();
        }

        public override void LoadData()
        {
            flowAreas.Controls.Clear();

            var rows = new List<(string Area, string Level, string Note)>();
            try
            {
                string dbPath = System.IO.Path.Combine(AppContext.BaseDirectory, "resq.db");
                using var conn = new SqliteConnection("Data Source=" + dbPath);
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT Area, RiskLevel, COALESCE(Note,'') FROM AreaRisk ORDER BY Area";
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                    rows.Add((reader.GetString(0), reader.GetString(1), reader.GetString(2)));
            }
            catch (Exception ex)
            {
                ShowError("Couldn't load areas: " + ex.Message);
                return;
            }

            if (rows.Count == 0)
            {
                var empty = new Label
                {
                    Text = "No areas found in the database.",
                    Font = Theme.FontBody,
                    ForeColor = Theme.Muted,
                    AutoSize = true,
                    Padding = new Padding(8)
                };
                flowAreas.Controls.Add(empty);
                return;
            }

            foreach (var row in rows)
                flowAreas.Controls.Add(BuildAreaCard(row.Area, row.Level, row.Note));

            ResizeAreaCards();
        }

        private void ResizeAreaCards()
        {
            flowAreas.SuspendLayout();
            flowAreas.AutoScroll = false;
            foreach (Panel card in flowAreas.Controls.OfType<Panel>())
                card.Width = Math.Max(card.MinimumSize.Width,
                    flowAreas.Width -
                    SystemInformation.VerticalScrollBarWidth - 8);
            flowAreas.AutoScroll = true;
            flowAreas.ResumeLayout(true);
        }


        // One editable card per area: name + 3 radios + note textbox + Save.
        private Panel BuildAreaCard(string area, string currentLevel, string currentNote)
        {
            var card = Theme.Card();
            card.Width = flowAreas.ClientSize.Width - 20;
            card.Height = 110;
            card.Margin = new Padding(0, 0, 0, 10);

            var lblArea = new Label
            {
                Text = area,
                Font = Theme.FontHeading,
                ForeColor = Theme.Ink,
                AutoSize = true,
                Location = new Point(16, 12),
                BackColor = Color.Transparent
            };

            var rdoLow = new RadioButton
            {
                Text = "Low",
                Location = new Point(16, 46),
                AutoSize = true,
                Font = Theme.FontBody,
                Checked = currentLevel == "Low"
            };
            var rdoMedium = new RadioButton
            {
                Text = "Medium",
                Location = new Point(90, 46),
                AutoSize = true,
                Font = Theme.FontBody,
                Checked = currentLevel == "Medium"
            };
            var rdoHigh = new RadioButton
            {
                Text = "High",
                Location = new Point(190, 46),
                AutoSize = true,
                Font = Theme.FontBody,
                Checked = currentLevel == "High"
            };

            var lblNote = new Label
            {
                Text = "Note:",
                Font = Theme.FontBody,
                AutoSize = true,
                Location = new Point(280, 48),
                BackColor = Color.Transparent
            };
            var txtNote = new TextBox
            {
                Text = currentNote,
                Location = new Point(325, 44),
                Width = 300,
                Font = Theme.FontBody
            };
            Theme.StyleInput(txtNote);

            var btnSave = new Button
            {
                Text = "Save",
                Location = new Point(640, 42),
                Size = new Size(90, 34),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            Theme.StylePrimary(btnSave);

            btnSave.Click += (s, e) =>
            {
                string newLevel = rdoHigh.Checked ? "High" : rdoMedium.Checked ? "Medium" : "Low";
                string newNote = txtNote.Text?.Trim() ?? "";
                try
                {
                    string dbPath = System.IO.Path.Combine(AppContext.BaseDirectory, "resq.db");
                    using var conn = new SqliteConnection("Data Source=" + dbPath);
                    conn.Open();
                    using var cmd = conn.CreateCommand();
                    cmd.CommandText = @"UPDATE AreaRisk
                                        SET RiskLevel = $lvl, Note = $note, UpdatedAt = datetime('now','localtime')
                                        WHERE Area = $area";
                    cmd.Parameters.AddWithValue("$lvl", newLevel);
                    cmd.Parameters.AddWithValue("$note", newNote);
                    cmd.Parameters.AddWithValue("$area", area);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows == 1)
                        ShowInfo($"Saved {area} as {newLevel}.");
                    else
                        ShowError("No row updated. Try Refresh.");
                }
                catch (Exception ex)
                {
                    ShowError("Save failed: " + ex.Message);
                }
            };

            card.Controls.Add(lblArea);
            card.Controls.Add(rdoLow);
            card.Controls.Add(rdoMedium);
            card.Controls.Add(rdoHigh);
            card.Controls.Add(lblNote);
            card.Controls.Add(txtNote);
            card.Controls.Add(btnSave);
            // Use actual font widths instead of guessed horizontal positions.
            rdoMedium.Left = rdoLow.Right + 16;
            rdoHigh.Left = rdoMedium.Right + 16;
            lblNote.Left = rdoHigh.Right + 24;
            txtNote.Left = lblNote.Right + 12;
            card.MinimumSize = new Size(
                txtNote.Left + 120 + 16 + btnSave.Width + 16, 110);

            void LayoutCard()
            {
                btnSave.Left = card.ClientSize.Width - btnSave.Width - 16;
                txtNote.Width = btnSave.Left - txtNote.Left - 16;
            }
            card.SizeChanged += (s, e) => LayoutCard();
            LayoutCard();


            return card;
        }

        private void SetRiskLevelsPage_Load(object sender, EventArgs e)
        {

        }
    }
}