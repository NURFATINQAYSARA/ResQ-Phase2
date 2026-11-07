using System.Drawing;
using System.Windows.Forms;
namespace ResQ
{
    // Jasmine's style/stepper/clone helpers. No page layout is built here.
    internal static class JasmineUi
    {
        public static readonly string[] Steps =
            ["Pending", "Accepted", "In Progress", "Safe / Evacuated", "Completed"];
        public static readonly Color Future = Color.FromArgb(0xE4, 0xE5, 0xEA);
        public static readonly Color FutureText = Color.FromArgb(0x5A, 0x5F, 0x75);

        public static Color StepColour(string step) => step switch
        {
            "Pending" => Theme.Grey,
            "Accepted" => Theme.Amber,
            "In Progress" => Theme.Red,
            "Safe / Evacuated" => Theme.Green,
            _ => Theme.Navy
        };

        // Colour and words both show the current step. Cancelled has no current step.
        public static void ShowSteps(Label[] tiles, string? status, string currentWord)
        {
            int current = Array.IndexOf(Steps, status ?? "");
            bool cancelled = status == "Cancelled";
            for (int i = 0; i < tiles.Length; i++)
            {
                string caption = cancelled ? (i == 0 ? "Submitted" : "Not reached")
                    : i < current ? "Done" : i == current ? currentWord
                    : i == current + 1 && current >= 0 ? "Next" : "Not yet";
                bool reached = cancelled ? i == 0 : current >= 0 && i <= current;
                tiles[i].Text = Steps[i] + "\n" + caption;
                tiles[i].BackColor = reached ? StepColour(Steps[i]) : Future;
                tiles[i].ForeColor = !reached ? FutureText
                    : Steps[i] == "Accepted" ? Theme.Ink : Color.White;
                tiles[i].BorderStyle = i == current ? BorderStyle.FixedSingle
                    : BorderStyle.None;
            }
        }

        // Flat buttons keep their colour when disabled, so show the state explicitly.
        public static void Enable(Button button, bool enabled, Color back, Color fore)
        {
            button.Enabled = enabled;
            button.BackColor = enabled ? back : Future;
            button.ForeColor = enabled ? fore : Theme.Grey;
        }

        public static void Pill(Label label, (Color Back, Color Fore) colours, string text)
        {
            label.Text = text;
            label.BackColor = colours.Back;
            label.ForeColor = colours.Fore;
        }

        public static string Text(object? value) =>
            value == null || value == DBNull.Value ? "" : value.ToString() ?? "";

        public static string RequestCode(object? id) => "RQ-" + Text(id).PadLeft(3, '0');

        public static string Initials(string name) => string.Concat(name
            .Split(' ', StringSplitOptions.RemoveEmptyEntries).Take(2)
            .Select(word => char.ToUpperInvariant(word[0])));

        // Copies ONE designed card and its children, keeping every designed bound.
        public static Panel CloneCard(Panel template, string suffix)
        {
            var card = (Panel)CopyLook(template, new Panel(), suffix);
            card.Margin = template.Margin;
            foreach (Control child in template.Controls)
                card.Controls.Add(CopyLook(child,
                    (Control)Activator.CreateInstance(child.GetType())!, suffix));
            return card;
        }

        private static Control CopyLook(Control from, Control to, string suffix)
        {
            to.Name = from.Name + suffix;
            to.Bounds = from.Bounds;
            to.Text = from.Text;
            to.Font = from.Font;
            to.BackColor = from.BackColor;
            to.ForeColor = from.ForeColor;
            to.Visible = true;
            if (from is Label a && to is Label b)
            {
                b.AutoSize = a.AutoSize;
                b.TextAlign = a.TextAlign;
            }
            if (from is Button c && to is Button d)
            {
                d.FlatStyle = c.FlatStyle;
                d.UseVisualStyleBackColor = false;
                d.FlatAppearance.BorderColor = c.FlatAppearance.BorderColor;
                d.FlatAppearance.BorderSize = c.FlatAppearance.BorderSize;
                d.Cursor = c.Cursor;
            }
            return to;
        }
    }
}