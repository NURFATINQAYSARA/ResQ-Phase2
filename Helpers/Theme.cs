using System.Drawing;
using System.Windows.Forms;

namespace ResQ
{
    // OWNER: Cwen (style) with Nurfatin. Every screen takes its colours, fonts and buttons from here,
    // so the whole app looks the same. Colours come from the ResQ walkthrough.
    internal static class Theme
    {
        // Brand colours.
        public static readonly Color Red = Color.FromArgb(0xD9, 0x3A, 0x2B);
        public static readonly Color RedDark = Color.FromArgb(0x7B, 0x1A, 0x14);
        public static readonly Color Amber = Color.FromArgb(0xF0, 0xB0, 0x40);
        public static readonly Color AmberDark = Color.FromArgb(0x5A, 0x3A, 0x00);
        public static readonly Color Navy = Color.FromArgb(0x1B, 0x1F, 0x6B);
        public static readonly Color NavyDark = Color.FromArgb(0x14, 0x18, 0x5A);
        public static readonly Color Green = Color.FromArgb(0x1F, 0x8A, 0x4C);
        public static readonly Color Grey = Color.FromArgb(0x6E, 0x6E, 0x6E);

        // Page colours.
        public static readonly Color Background = Color.FromArgb(0xF1, 0xF2, 0xF8);
        public static readonly Color Surface = Color.White;
        public static readonly Color Ink = Color.FromArgb(0x14, 0x1A, 0x46);
        public static readonly Color Muted = Color.FromArgb(0x3D, 0x44, 0x68);
        public static readonly Color Border = Color.FromArgb(0xC9, 0xCD, 0xDF);
        public static readonly Color CardBorder = Color.FromArgb(0xE1, 0xE4, 0xEF);
        public static readonly Color RowAlt = Color.FromArgb(0xF7, 0xF8, 0xFC);

        // Fonts.
        public static readonly Font FontBody = new("Segoe UI", 10F);
        public static readonly Font FontBold = new("Segoe UI", 10F, FontStyle.Bold);
        public static readonly Font FontSmall = new("Segoe UI", 9F);
        public static readonly Font FontPill = new("Segoe UI", 9F, FontStyle.Bold);
        public static readonly Font FontHeading = new("Segoe UI", 12F, FontStyle.Bold);
        public static readonly Font FontTitle = new("Segoe UI", 20F, FontStyle.Bold);

        // Side menu colour and accent colour for each role.
        public static Color SidebarColor(string? role) =>
            role == "Volunteer" ? AmberDark : role == "Admin" ? NavyDark : RedDark;

        public static Color AccentColor(string? role) =>
            role == "Volunteer" ? Amber : role == "Admin" ? Navy : Red;

        // ---------- buttons ----------
        public static void StylePrimary(Button b) => StyleButton(b, Red, Color.White, Red);
        public static void StyleNavy(Button b) => StyleButton(b, Navy, Color.White, Navy);
        public static void StyleSuccess(Button b) => StyleButton(b, Green, Color.White, Green);
        public static void StyleAmber(Button b) => StyleButton(b, Amber, Color.FromArgb(0x3B, 0x27, 0x00), Amber);
        public static void StyleSecondary(Button b) =>
            StyleButton(b, Color.White, Ink, Color.FromArgb(0x8B, 0x93, 0xB5));
        public static void StyleDanger(Button b) =>
            StyleButton(b, Color.White, Color.FromArgb(0x8F, 0x1D, 0x17), Color.FromArgb(0xB3, 0x26, 0x1E));

        private static void StyleButton(Button b, Color back, Color fore, Color border)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.UseVisualStyleBackColor = false;
            b.BackColor = back;
            b.ForeColor = fore;
            b.FlatAppearance.BorderColor = border;
            b.FlatAppearance.BorderSize = 1;
            b.Font = FontBold;
            b.Cursor = Cursors.Hand;
            if (b.Height < 38) b.Height = 38;
        }

        // Style a textbox / combobox the same way across the app.
        public static void StyleInput(Control input)
        {
            input.Font = FontBody;
            input.ForeColor = Ink;
            input.BackColor = Surface;
            if (input is TextBox tb)
            {
                tb.BorderStyle = BorderStyle.FixedSingle;
                if (tb.Height < 30) tb.Height = 30;
            }
        }

        // Style a DataGridView the same way across the app.
        public static void StyleGrid(DataGridView g)
        {
            g.BackgroundColor = Surface;
            g.BorderStyle = BorderStyle.None;
            g.GridColor = CardBorder;
            g.EnableHeadersVisualStyles = false;
            g.ColumnHeadersDefaultCellStyle.BackColor = RowAlt;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Ink;
            g.ColumnHeadersDefaultCellStyle.Font = FontBold;
            g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            g.ColumnHeadersHeight = 36;
            g.DefaultCellStyle.Font = FontBody;
            g.DefaultCellStyle.ForeColor = Ink;
            g.DefaultCellStyle.BackColor = Surface;
            g.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0xE4, 0xE8, 0xF5);
            g.DefaultCellStyle.SelectionForeColor = Ink;
            g.AlternatingRowsDefaultCellStyle.BackColor = RowAlt;
            g.RowHeadersVisible = false;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.ReadOnly = true;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.MultiSelect = false;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            g.RowTemplate.Height = 32;
        }

        // ---------- small building blocks ----------
        public static Label Title(string text) => new Label
        {
            Text = text,
            Font = FontTitle,
            ForeColor = Ink,
            AutoSize = true,
            BackColor = Color.Transparent
        };

        public static Label Subtitle(string text) => new Label
        {
            Text = text,
            Font = FontBody,
            ForeColor = Muted,
            AutoSize = true,
            BackColor = Color.Transparent
        };

        public static Label Heading(string text) => new Label
        {
            Text = text,
            Font = FontHeading,
            ForeColor = Ink,
            AutoSize = true,
            BackColor = Color.Transparent
        };

        // A coloured label such as "High" or "Pending".
        public static Label Pill((Color Back, Color Fore) colours, string text) => new Label
        {
            Text = text,
            AutoSize = true,
            BackColor = colours.Back,
            ForeColor = colours.Fore,
            Font = FontPill,
            Padding = new Padding(8, 3, 8, 3),
            TextAlign = ContentAlignment.MiddleCenter,
            Margin = new Padding(0, 3, 6, 3)
        };

        // A white panel with a thin border, like the cards in the walkthrough.
        public static Panel Card()
        {
            var panel = new Panel { BackColor = Surface, Padding = new Padding(16) };
            panel.Paint += (s, e) =>
            {
                using var pen = new Pen(CardBorder);
                e.Graphics.DrawRectangle(pen, 0, 0, panel.Width - 1, panel.Height - 1);
            };
            panel.Resize += (s, e) => panel.Invalidate();
            return panel;
        }

        // A big coloured number-tile for Admin Home / Request Monitor summary rows.
        public static Panel StatTile(string label, string value, Color accent)
        {
            var card = Card();
            card.Height = 90;
            card.Width = 180;

            var lblValue = new Label
            {
                Text = value,
                Font = new Font("Segoe UI", 22F, FontStyle.Bold),
                ForeColor = accent,
                AutoSize = true,
                Location = new Point(16, 10),
                BackColor = Color.Transparent
            };
            var lblCaption = new Label
            {
                Text = label,
                Font = FontBody,
                ForeColor = Muted,
                AutoSize = true,
                Location = new Point(16, 54),
                BackColor = Color.Transparent
            };
            card.Controls.Add(lblValue);
            card.Controls.Add(lblCaption);
            return card;
        }

        // ---------- colours for words ----------
        public static (Color Back, Color Fore) PriorityColours(string? priority) => priority switch
        {
            "High" => (Color.FromArgb(0xF8, 0xD7, 0xD3), Color.FromArgb(0x8F, 0x1D, 0x17)),
            "Medium" => (Color.FromArgb(0xFB, 0xE9, 0xC8), Color.FromArgb(0x6B, 0x4A, 0x07)),
            _ => (Color.FromArgb(0xDD, 0xF0, 0xE3), Color.FromArgb(0x14, 0x56, 0x2F))
        };

        public static (Color Back, Color Fore) StatusColours(string? status) => status switch
        {
            "Accepted" => (Color.FromArgb(0xFB, 0xE9, 0xC8), Color.FromArgb(0x6B, 0x4A, 0x07)),
            "In Progress" => (Color.FromArgb(0xF8, 0xD7, 0xD3), Color.FromArgb(0x8F, 0x1D, 0x17)),
            "Safe / Evacuated" => (Color.FromArgb(0xDD, 0xF0, 0xE3), Color.FromArgb(0x14, 0x56, 0x2F)),
            "Completed" => (Color.FromArgb(0xDC, 0xDD, 0xF3), Navy),
            "Verified" => (Color.FromArgb(0xDD, 0xF0, 0xE3), Color.FromArgb(0x14, 0x56, 0x2F)),
            "Rejected" => (Color.FromArgb(0xF8, 0xD7, 0xD3), Color.FromArgb(0x8F, 0x1D, 0x17)),
            _ => (Color.FromArgb(0xE4, 0xE5, 0xEA), Color.FromArgb(0x33, 0x33, 0x33))   // Pending, Cancelled, Open...
        };

        // Solid colours for the risk levels. Always show the word too, not only the colour.
        public static (Color Back, Color Fore) RiskColours(string? level) => level switch
        {
            "High" => (Red, Color.White),
            "Medium" => (Amber, Color.FromArgb(0x3B, 0x27, 0x00)),
            _ => (Green, Color.White)
        };
    }
}