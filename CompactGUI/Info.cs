using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

#nullable enable

namespace CompactGUI
{
    public partial class Info
    {
        public Info() => InitializeComponent();

        /* TODO ERROR: Skipped RegionDirectiveTrivia */

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void MoveForm()
        {
            ReleaseCapture();
            _ = SendMessage(Handle, 0xA1, 2, 0);
        }

        private void Panel_header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MoveForm();
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */

        private void Info_Load(object sender, EventArgs e)
        {
            semVersion.Text = "V " + Compact.Version;
            if (My.Settings.Default.IsContextMenuEnabled == true)
            {
                checkEnableRCMenu.Checked = true;
            }

            if (My.Settings.Default.MinimisetoTray == true)
            {
                checkMinimisetoTray.Checked = true;
            }

            if (My.Settings.Default.ShowNotifications == true)
            {
                checkShowNotifications.Checked = true;
            }

            if (My.Settings.Default.SkipNonCompressable == true)
            {
                checkEnableNonCompressable.Checked = true;
            }

            PopulateNonCompressable();
        }

        private void GithubLinks(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (sender == LblCheckUpdates)
            {
                Process.Start("https://github.com/ImminentFate/CompactGUI/releases");
            }

            if (sender == link_Github)
            {
                Process.Start("https://github.com/ImminentFate/CompactGUI");
            }
        }

        private void CheckEnableRCMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEnableRCMenu.Checked == true)
            {
                RCMenu.WriteRCMenuRegistry();
            }
            else if (checkEnableRCMenu.Checked == false)
            {
                RCMenu.DeleteRCMenuRegistry();
            }
        }

        private void CheckMinimisetoTray_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMinimisetoTray.Checked)
            {
                My.Settings.Default.MinimisetoTray = true;
            }
            else
            {
                My.Settings.Default.MinimisetoTray = false;
            }
        }

        private void CheckShowNotifications_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowNotifications.Checked)
            {
                My.Settings.Default.ShowNotifications = true;
            }
            else
            {
                My.Settings.Default.ShowNotifications = false;
            }
        }

        private void CheckEnableNonCompressable_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEnableNonCompressable.Checked)
            {
                My.Settings.Default.SkipNonCompressable = true;
            }
            else
            {
                My.Settings.Default.SkipNonCompressable = false;
            }
        }

        private void Btn_options_Click(object sender, EventArgs e)
        {
            switch (true)
            {
                case object _ when sender == Btnoptions:
                    {
                        InfoTabControl.SelectedTab = Tab_Features;
                        break;
                    }

                case object _ when sender == Btnlicenses:
                    {
                        InfoTabControl.SelectedTab = Tab_Licenses;
                        break;
                    }

                case object _ when sender == Btnhelp:
                    {
                        InfoTabControl.SelectedTab = Tab_Help;
                        break;
                    }
            }

            foreach (Button b in Panel1.Controls)
            {
                if (b != sender)
                {
                    b.BackColor = Color.FromArgb(255, 43, 60, 75);
                }
                else if (b == sender)
                {
                    b.BackColor = Color.FromArgb(255, 102, 121, 138);
                }
            }
        }

        private void Btn_Mainexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSaveNonCompressable_Click(object sender, EventArgs e)
        {
            My.Settings.Default.NonCompressableList = Regex.Replace(TxtBoxNonCompressable.Text, @"\s+", ";").Replace(".", "").ToUpperInvariant();
            PopulateNonCompressable();
        }

        private void BtnDefaultNonCompressable_Click(object sender, EventArgs e)
        {
            My.Settings.Default.NonCompressableList = "dl_; gif; jpg; jpeg; bmp; png; wmf; mkv; mp4; wmv; avi; bik; flv; ogg; mpg; m2v; m4v; vob; mp3; aac; wma; flac; zip; xap; rar; 7z; cab; lzx; docx; xlsx; pptx; vssx; vstx; onepkg";
            PopulateNonCompressable();
        }

        private void PopulateNonCompressable()
        {
            TxtBoxNonCompressable.Text = "";
            foreach (string i in My.Settings.Default.NonCompressableList.Replace(" ", "").Split(';'))
            {
                TxtBoxNonCompressable.Text += i + "\t";
            }
            TxtBoxNonCompressable.Text = TxtBoxNonCompressable.Text.Trim();
        }

        private void Btn_Paint(object sender, PaintEventArgs e)
        {
            Button senderNamed = (Button)sender;
            if (senderNamed.BackColor == Color.FromArgb(255, 102, 121, 138))
            {
                PointF[] trianglePtsArray = new[] { new PointF(Convert.ToSingle(senderNamed.Width - 1), 10), new PointF(Convert.ToSingle(senderNamed.Width - 1), Convert.ToSingle(senderNamed.Height - 10)), new PointF(Convert.ToSingle(senderNamed.Width - 10), Convert.ToSingle(senderNamed.Height / 2)), new PointF(Convert.ToSingle(senderNamed.Width - 1), 10) };
                using var gp = new System.Drawing.Drawing2D.GraphicsPath(System.Drawing.Drawing2D.FillMode.Alternate);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                gp.AddLines(trianglePtsArray);
                gp.CloseFigure();
                e.Graphics.FillPath(Brushes.White, gp);
                e.Graphics.DrawLines(Pens.White, trianglePtsArray);
            }
        }

        private void Tab_Features_Paint(object sender, PaintEventArgs e)
        {
            TabPage senderNamed = (TabPage)sender;
            using var p = new Pen(Color.LightGray);
            e.Graphics.DrawLine(p, new Point(46, 220), new Point(Convert.ToInt32(senderNamed.Width - 46), 220));
        }
    }
}