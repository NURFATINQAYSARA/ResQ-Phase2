using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using Microsoft.Data.Sqlite;
namespace ResQ;

public interface IFatinWalkthroughNavigation
{
    event Action<string>? NavigationRequested;
}
// Styles existing manually drawn controls; does not build the page layout.
internal static class FatinWalkthroughUi
{
    public static void Setup(Control surface)
    {
        void Style(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is DataGridView g)
                {
                    Theme.StyleGrid(g); g.AutoGenerateColumns = true;
                    g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    g.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    g.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    g.DataBindingComplete += (_, _) => DisplayColumns(g);
                    g.CellFormatting += (_, e) =>
                    {
                        if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
                        string key = g.Columns[e.ColumnIndex].Name;
                        if (key is "Priority" or "RequestStatus")
                        {
                            var colors = key == "Priority" ?
                            Theme.PriorityColours(e.Value?.ToString()) :
                            Theme.StatusColours(e.Value?.ToString());
                            e.CellStyle!.BackColor = colors.Back;
                            e.CellStyle.ForeColor = colors.Fore;
                            e.CellStyle.SelectionBackColor = colors.Back;
                            e.CellStyle.SelectionForeColor = colors.Fore;
                        }
                    };
                }
                if (c is Panel panel && c is not FlowLayoutPanel && panel.Width > 100)
                {
                    void Round()
                    {
                        if (panel.Width < 20 || panel.Height < 20) return;
                        using var path = new GraphicsPath(); int d = 16;
                        path.AddArc(0, 0, d, d, 180, 90);
                        path.AddArc(panel.Width - d - 1, 0, d, d, 270, 90);
                        path.AddArc(panel.Width - d - 1, panel.Height - d - 1, d, d, 0, 90);
                        path.AddArc(0, panel.Height - d - 1, d, d, 90, 90);
                        path.CloseFigure();
                        var old = panel.Region; panel.Region = new Region(path); old?.Dispose();
                    }
                    panel.Resize += (_, _) => Round(); Round();
                }
                Style(c);
            }
        }
        Style(surface);
        if (surface is PageBase page)
            page.Load += (_, _) =>
            {
                if (LicenseManager.UsageMode != LicenseUsageMode.Designtime &&
                page.Site?.DesignMode != true && Session.IsLoggedIn) page.LoadData();
            };
    }
    private static void DisplayColumns(DataGridView grid)
    {
        string[] show = grid.Name switch
        {
            "dgvRecent" => ["RequestId", "HelpType", "Priority", "RequestStatus"],
            "dgvRequests" => ["RequestId", "ResidentName", "HelpType", "Priority",
 "RequestStatus", "VolunteerName", "RowAction"],
            "dgvVolunteers" => ["FullName", "Username", "Area", "Phone"],
            _ => []
        };
        if (show.Length > 0)
            foreach (DataGridViewColumn c in grid.Columns) c.Visible = show.Contains(c.Name);
        var titles = new Dictionary<string, string>
        {
            ["RequestId"] = "ID",
            ["ResidentName"] = "RESIDENT",
            ["HelpType"] = "TYPE",
            ["Priority"] = "PRIORITY",
            ["RequestStatus"] = "STATUS",
            ["VolunteerName"] = "VOLUNTEER",
            ["RowAction"] = "ACTION"
        };
        foreach (var key in titles.Keys)
            if (grid.Columns.Contains(key)) grid.Columns[key]!.HeaderText = titles[key];
        string[] order = grid.Name == "dgvRequests" ?
        ["RequestId", "ResidentName", "HelpType", "Priority", "RequestStatus",
 "VolunteerName", "RowAction"] : grid.Name == "dgvRecent" ?
        ["RequestId", "HelpType", "Priority", "RequestStatus"] : [];
        for (int i = 0; i < order.Length; i++)
            if (grid.Columns.Contains(order[i])) grid.Columns[order[i]]!.DisplayIndex = i;
        if (grid.Columns.Contains("RequestId")) grid.Columns["RequestId"]!.FillWeight = 50;
        if (grid.Columns.Contains("Priority")) grid.Columns["Priority"]!.FillWeight = 85;
        grid.ClearSelection();
    }
    public static bool Access(Label status, params string[] roles)
    {
        if (!Session.IsLoggedIn) { status.Text = "Please sign in first."; return false; }
        if (!roles.Contains(Session.Role)) { status.Text = "Wrong account role."; return false; }
        return true;
    }
    public static bool Run(Label status, Action action)
    {
        try { action(); return true; }
        catch (ArgumentException e) { status.Text = e.Message; }
        catch (UnauthorizedAccessException) { status.Text = "Sign in with an approved account."; }
        catch (SqliteException) { status.Text = "Database action failed. Refresh/retry."; }
        return false;
    }
    public static DataRowView? Selected(DataGridView grid) =>
    grid.SelectedRows.Count > 0 ? grid.SelectedRows[0].DataBoundItem as DataRowView : null;
    public static Panel CopyCard(Panel source)
    {
        var card = new Panel
        {
            Size = source.Size,
            BackColor = source.BackColor,
            Margin = source.Margin,
            Padding = source.Padding
        };
        foreach (Label label in source.Controls.OfType<Label>())
            card.Controls.Add(new Label
            {
                Name = label.Name,
                Text = label.Text,
                Size = label.Size,
                Location = label.Location,
                AutoSize = false,
                BackColor = label.BackColor,
                ForeColor = label.ForeColor,
                Font = label.Font,
                TextAlign = label.TextAlign
            });
        if (source.Region != null) card.Region = source.Region.Clone();
        return card;
    }
}