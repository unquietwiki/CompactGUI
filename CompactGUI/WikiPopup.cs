using System.Drawing;
using System.Windows.Forms;

#nullable enable

namespace CompactGUI
{
    public partial class WikiPopup
    {
        public WikiPopup() => InitializeComponent();

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            // e.Graphics.DrawLine(p, 20, 100, GamesTable.Width + 10, 100)
            e.Graphics.FillRectangle(Brushes.White, 0, 100, Panel1.Width, Panel1.Height);
        }
    }
}