using System;
using System.Drawing;
using System.IO;
using System.Management;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;

#nullable enable

namespace CompactGUI
{
    public partial class WikiSubmission
    {
        public WikiSubmission() => InitializeComponent();

        internal static string? Name_Submit;
        internal static string SteamID_Submit = "0";
        internal static string? Type_Submit;
        internal string? UniqueID_Submit;
        internal static string? folder_Submit;
        internal static string? compMode_Submit;
        internal static ulong? BeforeSize_Submit;
        internal static ulong? AfterSize_Submit;

        private void WikiSubmission_Paint(object sender, PaintEventArgs e)
        {
            using var pen = new Pen(Color.White);
            e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, Panel1.Width - 1, Panel1.Height + 1));
        }

        private void ParseforSteamData()
        {
            int steamID = 0;
            string steamName = "";
            FileInfo? targetACFFile = GetParseACFFiles();
            if (targetACFFile is object)
            {
                string[] ACFText = File.ReadAllText(targetACFFile.FullName).Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string l in ACFText)
                {
                    string lf = l.TrimStart();
                    if (lf.StartsWith("\"" + "appid" + "\"", StringComparison.CurrentCultureIgnoreCase))
                    {
                        steamID = Convert.ToInt32(lf.Substring(lf.LastIndexOf("\t", StringComparison.CurrentCultureIgnoreCase) + 1).Replace("\"", ""), Compact.culture);
                    }

                    if (lf.StartsWith("\"" + "name" + "\"", StringComparison.CurrentCultureIgnoreCase))
                    {
                        steamName = lf.Substring(lf.LastIndexOf("\t", StringComparison.CurrentCultureIgnoreCase) + 1).Replace("\"", "");
                        goto Assignment;
                    }
                }
            }

            Assignment:
            ;
            var rx = new Regex(@"[\?&|%™®©]");
            TxtBoxName.Text = rx.Replace(steamName, "");
            TxtBoxSteamID.Value = steamID;
        }

        private static FileInfo? GetParseACFFiles()
        {
            var dI = new DirectoryInfo(My.MyProject.Forms.Compact.workingDir);
            if (Directory.GetParent(dI.Parent.FullName) is object && (Directory.GetParent(dI.Parent.FullName).Name ?? "").Contains("steamapps"))
            {
                foreach (FileInfo f in Directory.GetParent(dI.Parent.FullName).GetFiles())
                {
                    if (f.Extension.Contains(".acf"))
                    {
                        string[] ACFText = File.ReadAllText(f.FullName).Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string l in ACFText)
                        {
                            string lf = l.TrimStart();
                            if (lf.StartsWith("\"" + "installdir" + "\"", StringComparison.CurrentCultureIgnoreCase) && (Folder_Submit ?? "") == (lf.Substring(lf.LastIndexOf("\t", StringComparison.CurrentCultureIgnoreCase) + 1).Replace("\"", "") ?? ""))
                            {
                                return f;
                            }
                        }
                    }
                }
            }

            return default;
        }

        private void Btn_NextPage_Click(object sender, EventArgs e)
        {
            if (TabControl1.SelectedTab == Page1)
            {
                if (Radio_Game.Checked)
                {
                    ParseforSteamData();
                    Type_Submit = "Game";
                    PanelSteamID.Visible = true;
                    LblGameorProgram.Text = "Game Name:";
                    TabControl1.SelectedTab = Page2;
                }
                else if (Radio_Program.Checked)
                {
                    Type_Submit = "Program";
                    PanelSteamID.Visible = false;
                    LblGameorProgram.Text = "Program Name:";
                    TabControl1.SelectedTab = Page2;
                }
            }
            else if (TabControl1.SelectedTab == Page2)
            {
                var rx = new Regex(@"[\?&|%™®©]");
                if (rx.Match(TxtBoxName.Text).Success)
                {
                    MessageBox.Show("Name cannot contain '?', '&', '|', '%', '™', '®', or '©'");
                }
                else
                {
                    PrepareSubmission();
                }
            }
            else if (TabControl1.SelectedTab == Page3)
            {
                Close();
            }
        }

        private void PrepareSubmission()
        {
            bool alreadyExists = default;
            foreach (Result res in WikiHandler.allResults)
            {
                if (Convert.ToInt32(TxtBoxSteamID.Value) == (res.SteamID == 0 ? 999999 : res.SteamID) || (Folder_Submit ?? "") == (res.Folder ?? "") || (TxtBoxName.Text.Trim() ?? "") == (res.Name ?? ""))
                {
                    if ((CompMode_Submit ?? "") == (res.Algorithm ?? ""))
                    {
                        if (BeforeSize_Submit >= res.BeforeSize * 0.92 && BeforeSize_Submit <= res.BeforeSize * 1.08)
                        {
                            alreadyExists = true;
                        }
                    }
                }
            }

            Name_Submit = HttpUtility.UrlPathEncode(TxtBoxName.Text.Trim());
            Folder_Submit = HttpUtility.UrlPathEncode(Folder_Submit);
            SteamID_Submit = TxtBoxSteamID.Text;
            UniqueID_Submit = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(GetMacAddress()));
            FillDataCollection();
            if (alreadyExists == false)
            {
                string URL_First = "https://docs.google.com/forms/d/e/1FAIpQLSfAzlQAhyPEueFyQiTEmpudcKaVLnpRPmzrIuBZxnR8f7PjPg/formResponse?&ifq&entry.630201004=%3CCompactGUI%3E";
                string URL_Last = "&submit=Submit";
                string URL_All = URL_First + UniqueID_Submit + "%7C" + Type_Submit + "%7C" + Name_Submit + "%7C" + Folder_Submit + "%7C" + SteamID_Submit + "%7C" + CompMode_Submit + "%7C" + BeforeSize_Submit + "%7C" + AfterSize_Submit + URL_Last;
                LblTitle.Text = "Sending Results";
                Panel1.Refresh();
                SendPageRequest(URL_All);
            }
            else
            {
            }

            LblTitle.Text = "Results Sent";
            TabControl1.SelectedTab = Page3;
            BtnNextPage.Text = "Close";
            BtnCancel.Visible = false;
        }

        private void SendPageRequest(string URL)
        {
            //TODO: migrate to https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netframework-4.8
            try
            {
                System.Net.HttpWebRequest webReq = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(URL);
                using System.Net.HttpWebResponse webResp = (System.Net.HttpWebResponse)webReq.GetResponse();
                // Get the response, then close it as we don't actually need anything but to send the request.
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("An internet connection could not be established. Please try again later.");
                Close();
            }
        }

        private void FillDataCollection()
        {
            string output = "UID: " + UniqueID_Submit + @"
Name: " + HttpUtility.UrlDecode(Name_Submit) + @"
Type: " + Type_Submit + @"
Folder: " + HttpUtility.UrlDecode(Folder_Submit) + @"
Compression Mode: " + CompMode_Submit + @"
Size Before: " + BeforeSize_Submit + @"
Size After: " + AfterSize_Submit;
            string[] ite = output.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (string i in ite)
            {
                string[] splitp = i.Split(new char[] { ':' }, 2);
                ListView1.Items.Add(new ListViewItem(splitp));
            }
        }

        public static string GetMacAddress()
        {
            using var mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            var moc = mc.GetInstances();
            foreach (var mo in moc)
            {
                if ((string.Empty ?? "") == (string.Empty ?? "") & (bool)(mo.Properties["IPEnabled"].Value) == true)
                {
                    _ = mo.Properties["MacAddress"].Value.ToString();
                }
            }
            return string.Empty;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000;                                                  // &H20000 = WS_MINIMIZEBOX
                cp.ClassStyle = cp.ClassStyle | CS_DROPSHADOW | 0x8;                           // &H8 = CS_DBLCLKS
                return cp;
            }
        }

        internal static string? Folder_Submit { get => folder_Submit; set => folder_Submit = value; }
        internal static string? CompMode_Submit { get => compMode_Submit; set => compMode_Submit = value; }

        private void MoveForm()
        {
            NativeMethods.ReleaseCapture();
            _ = NativeMethods.SendMessage(Handle, 0xA1, 2, 0);
        }

        private void Panel_topBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MoveForm();
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}