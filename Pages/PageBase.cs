using System.Windows.Forms;

namespace ResQ
{
    // Every page inside the main window inherits from this.
    // It gives each page the same padding and background so screens line up.
    public class PageBase : UserControl
    {
        public PageBase()
        {
            Dock = DockStyle.Fill;
            BackColor = Theme.Background;
            Padding = new Padding(24);
            AutoScroll = true;
        }

        // Called by MainShell each time the page is shown.
        // Teammates override this to reload their data.
        public virtual void LoadData()
        {
        }
    }
}