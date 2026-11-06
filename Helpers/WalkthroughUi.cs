using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace ResQ
{
    // Styling and data-card repetition only. All layouts originate in the Designer.
    internal static class WalkthroughUi
    {
        public static void Setup(PageBase page, string[] roleNames)
        {
            page.Dock = DockStyle.Fill;
            page.BackColor = Theme.Background;

            void Style(Control parent)
            {
                foreach (Control c in parent.Controls)
                {
                    if (c is DataGridView g)
                    {
                        Theme.StyleGrid(g);
                        g.AutoGenerateColumns = true;
                        g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        g.ColumnHeadersDefaultCellStyle.BackColor = Theme.RowAlt;
                        g.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                        g.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        g.DataBindingComplete += (_, _) => Columns(g);
                    }

                    if (c is Panel card && c is not FlowLayoutPanel &&
                        (card.Name.StartsWith("pnlRisk") && card.Name != "pnlRiskBand" ||
                         card.Name is "pnlMyReports" or "pnlDirectory" or "pnlEntry" or
                         "pnlIncidentTemplate" or "pnlDetails" or "pnlLog" or "pnlSummary"))
                    {
                        void Round()
                        {
                            if (card.Width < 20 || card.Height < 20) return;
                            using var path = new GraphicsPath();
                            int d = 16;
                            path.AddArc(0, 0, d, d, 180, 90);
                            path.AddArc(card.Width - d - 1, 0, d, d, 270, 90);
                            path.AddArc(card.Width - d - 1, card.Height - d - 1, d, d, 0, 90);
                            path.AddArc(0, card.Height - d - 1, d, d, 90, 90);
                            path.CloseFigure();
                            var old = card.Region;
                            card.Region = new Region(path);
                            old?.Dispose();
                        }
                        card.Resize += (_, _) => Round();
                        Round();
                    }

                    if (c is RadioButton r)
                    {
                        r.CheckedChanged += (_, _) => ChoiceColour(r);
                        ChoiceColour(r);
                    }

                    Style(c);
                }
            }

            Style(page);

            page.Load += (_, _) =>
            {
                if (LicenseManager.UsageMode != LicenseUsageMode.Designtime &&
                    page.Site?.DesignMode != true && Session.IsLoggedIn)
                {
                    page.LoadData();
                }
            };
        }

        private static void Columns(DataGridView grid)
        {
            string[]? visible = grid.Name switch
            {
                "dgvMyReports" => ["HazardType", "Location", "ReviewStatus"],
                "dgvDirectory" => ["Name", "Area", "Phone", "Status", "EditAction", "RemoveAction"],
                "dgvSafetyLog" => ["LoggedAt", "RequestId", "ChangedByName", "NewStatus", "Note"],
                _ => null
            };

            if (visible != null)
            {
                foreach (DataGridViewColumn c in grid.Columns)
                {
                    c.Visible = visible.Contains(c.Name);
                }
            }

            foreach (DataGridViewColumn c in grid.Columns)
            {
                c.MinimumWidth = 55;
                c.HeaderText = c.Name switch
                {
                    "HazardType" => "HAZARD",
                    "Name" => "NAME",
                    "Location" => "LOCATION",
                    "ReviewStatus" => "REVIEW",
                    "Area" => "AREA",
                    "Phone" => "PHONE",
                    "Status" => "STATUS",
                    "LoggedAt" => "TIME",
                    "RequestId" => "REQUEST",
                    "ChangedByName" => "CHANGED BY",
                    "NewStatus" => "NEW STATUS",
                    "Note" => "NOTE",
                    "EditAction" => "",
                    "RemoveAction" => "",
                    _ => c.HeaderText
                };
            }
            grid.ClearSelection();
        }

        public static void ChoiceColour(RadioButton r)
        {
            r.BackColor = r.Checked ? Color.FromArgb(248, 215, 211) : Theme.Surface;
            r.FlatAppearance.BorderColor = r.Checked ? Theme.Red : Theme.Border;
            r.FlatAppearance.BorderSize = r.Checked ? 2 : 1;

            if (r.Name == "rdoLow") r.BackColor = Color.FromArgb(221, 240, 227);
            if (r.Name == "rdoMedium") r.BackColor = Color.FromArgb(251, 233, 200);
            if (r.Name == "rdoHigh") r.BackColor = Color.FromArgb(248, 215, 211);
        }

        public static bool Access(Label status, params string[] roles)
        {
            if (!Session.IsLoggedIn) { status.Text = "Please sign in first."; return false; }
            if (!roles.Contains(Session.Role)) { status.Text = "This page is not for your role."; return false; }
            return true;
        }

        public static bool Run(Label status, Action action)
        {
            try { action(); return true; }
            catch (ArgumentException ex) { status.Text = ex.Message; }
            catch (UnauthorizedAccessException) { status.Text = "Access denied. Check your account."; }
            catch (SqliteException) { status.Text = "Database action failed. Please refresh/retry."; }
            catch (IOException) { status.Text = "Could not save the file. Check the chosen path."; }
            return false;
        }

        public static Panel CopyCard(Panel source)
        {
            Control Copy(Control s)
            {
                var c = (Control)Activator.CreateInstance(s.GetType())!;
                c.Name = s.Name;
                c.Text = s.Text;
                c.Size = s.Size;
                c.Location = s.Location;
                c.Font = s.Font;
                c.BackColor = s.BackColor;
                c.ForeColor = s.ForeColor;
                c.Margin = s.Margin;
                c.Padding = s.Padding;

                if (c is Label l && s is Label sl)
                {
                    l.AutoSize = false;
                    l.TextAlign = sl.TextAlign;
                    l.AutoEllipsis = sl.AutoEllipsis;
                }

                foreach (Control child in s.Controls)
                {
                    c.Controls.Add(Copy(child));
                }
                return c;
            }

            var result = (Panel)Copy(source);
            if (source.Region != null)
            {
                result.Region = source.Region.Clone();
            }
            return result;
        }

        public static T Child<T>(Control card, string name) where T : Control
        {
            return (T)card.Controls.Find(name, true).Single();
        }

        public static void ClearCopies(FlowLayoutPanel flow, Panel template)
        {
            foreach (Control c in flow.Controls.Cast<Control>().Where(c => c != template).ToArray())
            {
                flow.Controls.Remove(c);
                c.Dispose();
            }
            template.Visible = false;
        }

        public static void ClickCard(Control card, Action action)
        {
            card.Cursor = Cursors.Hand;
            card.Click += (_, _) => action();
            foreach (Control child in card.Controls)
            {
                ClickCard(child, action);
            }
        }
    }

    // Extension/fallback definitions for Theme class to resolve missing references
    public static partial class Theme
    {
        public static Color RowAlt => Color.FromArgb(240, 241, 245);

        public static void StyleGrid(DataGridView g)
        {
            g.BackgroundColor = Color.White;
            g.BorderStyle = BorderStyle.None;
            g.RowHeadersVisible = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.MultiSelect = false;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.ReadOnly = true;
        }
    }
}