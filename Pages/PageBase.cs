using System.Drawing;
using System.Windows.Forms;

namespace ResQ
{
    // OWNER: Nurfatin (leader). Base class every page in MainShell inherits from.
    // Gives each page the same padding, background, and a reusable header strip
    // (title + subtitle + action buttons on the right) so screens line up.
    public class PageBase : UserControl
    {
        // Top strip. Teammates don't have to use it; if they do, every screen matches.
        protected Panel HeaderStrip { get; } = new Panel
        {
            Dock = DockStyle.Top,
            Height = 72,
            BackColor = Color.Transparent,
            Padding = new Padding(0, 0, 0, 12)
        };

        private readonly Label _titleLabel = new Label
        {
            AutoSize = true,
            Location = new Point(0, 2),
            BackColor = Color.Transparent
        };

        private readonly Label _subtitleLabel = new Label
        {
            AutoSize = true,
            Location = new Point(0, 34),
            BackColor = Color.Transparent
        };

        private readonly FlowLayoutPanel _actions = new FlowLayoutPanel
        {
            Dock = DockStyle.Right,
            FlowDirection = FlowDirection.RightToLeft,
            AutoSize = true,
            BackColor = Color.Transparent,
            WrapContents = false,
            Padding = new Padding(0, 8, 0, 0)
        };

        public PageBase()
        {
            Dock = DockStyle.Fill;
            BackColor = Theme.Background;
            Padding = new Padding(24);
            AutoScroll = true;
            Font = Theme.FontBody;

            _titleLabel.Font = Theme.FontTitle;
            _titleLabel.ForeColor = Theme.Ink;
            _subtitleLabel.Font = Theme.FontBody;
            _subtitleLabel.ForeColor = Theme.Muted;

            HeaderStrip.Controls.Add(_titleLabel);
            HeaderStrip.Controls.Add(_subtitleLabel);
            HeaderStrip.Controls.Add(_actions);
        }

        // Call from a page's constructor to show a title + optional subtitle at the top,
        // and optional buttons on the right (Refresh, Export, etc.).
        protected void SetHeader(string title, string? subtitle = null, params Button[] actionButtons)
        {
            _titleLabel.Text = title ?? string.Empty;
            _subtitleLabel.Text = subtitle ?? string.Empty;
            _subtitleLabel.Visible = !string.IsNullOrWhiteSpace(subtitle);

            _actions.Controls.Clear();
            foreach (var b in actionButtons)
                _actions.Controls.Add(b);

            if (!Controls.Contains(HeaderStrip))
                Controls.Add(HeaderStrip);
            HeaderStrip.BringToFront();
        }

        // Called by MainShell every time the page is shown.
        // Override to reload data.
        public virtual void LoadData() { }

        // Short message helpers so teammates don't repeat MessageBox code.
        protected static void ShowError(string message) =>
            MessageBox.Show(message, "ResQ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        protected static void ShowInfo(string message) =>
            MessageBox.Show(message, "ResQ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        protected static bool Confirm(string message) =>
            MessageBox.Show(message, "ResQ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes;
    }
}