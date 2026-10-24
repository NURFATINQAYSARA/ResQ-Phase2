using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;
using System.Drawing;
using System.Windows.Forms;

namespace ResQ.Pages
{
    public partial class AreaRiskPage : PageBase
    {
        private Label titleLabel = null!;
        private Label subtitleLabel = null!;
        private Button btnRefresh = null!;
        private FlowLayoutPanel riskContainer = null!;

        public AreaRiskPage()
        {
            SetupLayout();
            LoadAreaRisks();
        }

        private void SetupLayout()
        {
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(245, 247, 250);

            // Title
            titleLabel = new Label()
            {
                Text = "Area risk dashboard",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                Location = new Point(30, 25),
                AutoSize = true
            };

            // Subtitle
            subtitleLabel = new Label()
            {
                Text = "Latest levels set by the administrator. Shown by colour and by text",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.Gray,
                Location = new Point(33, 60),
                AutoSize = true
            };

            // Refresh Button
            btnRefresh = new Button()
            {
                Text = "Refresh",
                Location = new Point(750, 45),
                Size = new Size(100, 35),
                BackColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnRefresh.Click += (s, e) => LoadAreaRisks();

            // Risk Container (List of areas)
            riskContainer = new FlowLayoutPanel()
            {
                Location = new Point(30, 100),
                Size = new Size(840, 450),
                FlowDirection = FlowDirection.TopDown,
                AutoScroll = true,
                WrapContents = false
            };

            this.Controls.Add(titleLabel);
            this.Controls.Add(subtitleLabel);
            this.Controls.Add(btnRefresh);
            this.Controls.Add(riskContainer);
        }

        private void LoadAreaRisks()
        {
            riskContainer.Controls.Clear();

            try
            {
                string connectionString = "Data Source=resq.db;";
                string query = "SELECT AreaName, RiskLevel, Notes, LastUpdated FROM AreaRisk";

                using (var conn = new SqliteConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new SqliteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        bool hasRows = false;
                        while (reader.Read())
                        {
                            hasRows = true;
                            string area = reader["AreaName"]?.ToString() ?? "";
                            string risk = reader["RiskLevel"]?.ToString() ?? "";
                            string notes = reader["Notes"]?.ToString() ?? "";
                            string updated = reader["LastUpdated"]?.ToString() ?? "";

                            riskContainer.Controls.Add(CreateRiskCard(area, risk, notes, updated));
                        }

                        if (!hasRows)
                        {
                            AddFallbackData();
                        }
                    }
                }
            }
            catch (Exception)
            {
                AddFallbackData();
            }
        }

        private void AddFallbackData()
        {
            riskContainer.Controls.Add(CreateRiskCard("Taman Melati (your area)", "HIGH", "Heavy rain expected.", "today, 09:15", true));
            riskContainer.Controls.Add(CreateRiskCard("Jalan Bunga", "HIGH", "River level rising.", "today, 10:02", false));
            riskContainer.Controls.Add(CreateRiskCard("Lorong Cempaka", "MEDIUM", "Watch for road closures.", "yesterday", false));
            riskContainer.Controls.Add(CreateRiskCard("Bandar Utara", "LOW", "No hazards reported.", "yesterday", false));
        }

        private void InitializeComponent()
        {

        }

        private Panel CreateRiskCard(string area, string riskLevel, string notes, string lastUpdated, bool isUserArea = false)
        {
            Panel card = new Panel()
            {
                Size = new Size(810, 80),
                BackColor = Color.White,
                Margin = new Padding(0, 0, 0, 10)
            };

            if (isUserArea)
            {
                card.BorderStyle = BorderStyle.FixedSingle;
            }

            Label lblArea = new Label()
            {
                Text = area,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(20, 15),
                AutoSize = true
            };

            Label lblNotes = new Label()
            {
                Text = $"{notes} Updated {lastUpdated}",
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.Gray,
                Location = new Point(20, 45),
                AutoSize = true
            };

            // Color coding and text for Risk Level
            Color badgeColor = Color.Green;
            if (riskLevel.Equals("HIGH", StringComparison.OrdinalIgnoreCase)) badgeColor = Color.Red;
            else if (riskLevel.Equals("MEDIUM", StringComparison.OrdinalIgnoreCase)) badgeColor = Color.Orange;

            Label lblRisk = new Label()
            {
                Text = $"▲ {riskLevel.ToUpper()}",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = badgeColor,
                Location = new Point(680, 25),
                AutoSize = true
            };

            card.Controls.Add(lblArea);
            card.Controls.Add(lblNotes);
            card.Controls.Add(lblRisk);

            return card;
        }
    }
}