using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

#nullable enable

namespace CompactGUI
{
    internal class WikiHandler
    {
        private static IEnumerable<XElement>? InputFromGitHub;
        internal static List<Result> allResults = new List<Result>();
        private static string workingname = "testdir";
        private static readonly string DBZipFileLoc = Path.GetTempPath() + "CompactGUI.zxm";

        private static void WikiParser()
        {
            // FIXME: this needs debugging for the Console writes & null settings
            // Console.WriteLine("Working Name: " + workingname);
            // Console.WriteLine(DBZipFileLoc);
            allResults.Clear();
            // Console.WriteLine(My.Settings.Default.ResultsDB_Date);
            try
            {
                if (InputFromGitHub is null && My.Settings.Default.ResultsDB is object && (DateTime.Now < My.Settings.Default.ResultsDB_Date.AddHours(12)))
                {
                    // Console.WriteLine("Using existing DB");
                    InitialiseInputFromGithub();
                }
                else if (InputFromGitHub is null)
                {
                    // Console.WriteLine("Fetching New DB");
                    using var wc = new WebClient() { Encoding = Encoding.UTF8 };
                    try
                    {
                        wc.DownloadFile("https://raw.githubusercontent.com/ImminentFate/CompactGUI/master/Wiki/Database.zip", DBZipFileLoc);
                        using var x = System.IO.Compression.ZipFile.OpenRead(DBZipFileLoc);
                        using var stre = new StreamReader(x.Entries[0].Open());
                        My.Settings.Default.ResultsDB = stre.ReadToEnd();
                        My.Settings.Default.ResultsDB_Date = DateTime.Now;
                        InitialiseInputFromGithub();
                    }
                    catch (WebException)
                    {
                        My.MyProject.Forms.Compact.sb_lblGameIssues.Text = "! No Internet Connection";
                        My.MyProject.Forms.Compact.sb_lblGameIssues.Visible = true;
                        My.MyProject.Forms.Compact.ToolTipFilesCompressed.SetToolTip(My.MyProject.Forms.Compact.sb_lblGameIssues, "");
                        My.MyProject.Forms.Compact.wkPostSizeVal.Text = "?";
                        My.MyProject.Forms.Compact.wkPostSizeUnit.Text = "";
                        My.MyProject.Forms.Compact.wkPostSizeUnit.Location = new Point(My.MyProject.Forms.Compact.wkPostSizeVal.Location.X + My.MyProject.Forms.Compact.wkPostSizeVal.Size.Width, My.MyProject.Forms.Compact.wkPostSizeVal.Location.Y);
                        My.MyProject.Forms.Compact.sb_Panel.Show();
                    }
                }
                else
                {
                    // Console.WriteLine("Using Memory DB");
                    ParseData();
                }
            }
            catch
            {
            }
        }

        private static void InitialiseInputFromGithub()
        {
            XElement SRC;
            SRC = XElement.Parse(My.Settings.Default.ResultsDB);
            InputFromGitHub = SRC.Elements();
            ParseData();
        }

        private static void ParseData()
        {
            if (InputFromGitHub != null)
            {
                foreach (XElement? result in InputFromGitHub)
                {
                    var itemName = result.Element("itemName").Value;
                    var itemFolder = result.Element("itemFolder").Value;
                    var itemSteamID = result.Element("itemSteamID").Value;
                    var itemAlgorithm = result.Element("itemAlgorithm").Value;
                    var itemBeforeSize = Conversions.ToULong(result.Element("itemBefore").Value);
                    var itemAfterSize = Conversions.ToULong(result.Element("itemAfter").Value);
                    var res = new Result(itemName, itemFolder, Conversions.ToInteger(itemSteamID), itemAlgorithm, itemBeforeSize, itemAfterSize);
                    allResults.Add(res);
                }

                var gcount = new List<Result>();
                int matches = 0;
                foreach (Result r in allResults)
                {
                    if (r.Folder.Equals(workingname))
                    {
                        gcount.Add(r);
                        matches += 1;
                    }
                }

                Console.WriteLine(Constants.vbCrLf);
                if (matches == 0)
                {
                    foreach (Result r in allResults)
                    {
                        if (workingname.Length > 2 && r.NameSanitized.StartsWith(workingname))
                        {
                            gcount.Add(r);
                            matches += 1;
                        }
                    }
                }

                decimal ratioavg = 1;
                firstGame = 0;
                PrepareTable();
                foreach (Result r in gcount)
                {
                    FillTable(r);
                    ratioavg += decimal.Parse(r.Ratio.ToString());
                    My.MyProject.Forms.Compact.sb_lblGameIssues.Visible = false;   // Add check for game issues at later date
                }

                My.MyProject.Forms.Compact.sb_labelCompressed.Text = "Estimated Compressed";
                if (gcount.Count != default)
                {
                    ratioavg = (ratioavg - 1) / gcount.Count;
                    My.MyProject.Forms.Compact.wkPostSizeVal.Text = Conversions.ToString(Math.Round(folderSize * ratioavg, 1));
                    My.MyProject.Forms.Compact.wkPostSizeUnit.Text = Conversions.ToString(suffix);
                    Size wkPostSizeVal_Len = TextRenderer.MeasureText(My.MyProject.Forms.Compact.wkPostSizeVal.Text, My.MyProject.Forms.Compact.wkPostSizeVal.Font);
                    My.MyProject.Forms.Compact.wkPostSizeUnit.Location = new Point(My.MyProject.Forms.Compact.wkPostSizeVal.Location.X + My.MyProject.Forms.Compact.wkPostSizeVal.Size.Width / 2 + (wkPostSizeVal_Len.Width / 2 - 8), My.MyProject.Forms.Compact.wkPostSizeVal.Location.Y + 16);
                    My.MyProject.Forms.Compact.wkPostSizeUnit.Visible = true;
                }
                else
                {
                    My.MyProject.Forms.Compact.wkPostSizeVal.Text = "?";
                    My.MyProject.Forms.Compact.wkPostSizeUnit.Text = "";
                    Size wkPostSizeVal_Len = TextRenderer.MeasureText(My.MyProject.Forms.Compact.wkPostSizeVal.Text, My.MyProject.Forms.Compact.wkPostSizeVal.Font);
                    My.MyProject.Forms.Compact.wkPostSizeUnit.Location = new Point(My.MyProject.Forms.Compact.wkPostSizeVal.Location.X + My.MyProject.Forms.Compact.wkPostSizeVal.Size.Width / 2 + (wkPostSizeVal_Len.Width / 2 - 8), My.MyProject.Forms.Compact.wkPostSizeVal.Location.Y + 16);
                }

                if (My.MyProject.Forms.WikiPopup.GamesTable.RowCount > 1)
                {
                    My.MyProject.Forms.Compact.seecompest.Visible = true;
                }
                else
                {
                    My.MyProject.Forms.Compact.seecompest.Visible = false;
                }

                My.MyProject.Forms.WikiPopup.GamesTable.Visible = true;
                My.MyProject.Forms.Compact.sb_Panel.Show();
            }
        }

        private static void PrepareTable()
        {
            My.MyProject.Forms.WikiPopup.GamesTable.Visible = false;
            My.MyProject.Forms.WikiPopup.GamesTable.Controls.Clear();
            My.MyProject.Forms.WikiPopup.GamesTable.RowCount = 0;
            using var GName = new Label() { Text = "Game" };
            using var GSizeU = new Label() { Text = "Before" };
            using var GSizeC = new Label() { Text = "After" };
            using var GCompR = new Label() { Text = "Ratio" };
            using var GCompAlg = new Label() { Text = "Algorithm" };
            Console.WriteLine(My.MyProject.Forms.WikiPopup.GamesTable.RowCount);
            My.MyProject.Forms.WikiPopup.GamesTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));
            My.MyProject.Forms.WikiPopup.GamesTable.RowCount += 1;
            My.MyProject.Forms.WikiPopup.GamesTable.Controls.Add(GName, 0, My.MyProject.Forms.WikiPopup.GamesTable.RowCount - 1);
            My.MyProject.Forms.WikiPopup.GamesTable.Controls.Add(GSizeU, 1, My.MyProject.Forms.WikiPopup.GamesTable.RowCount - 1);
            My.MyProject.Forms.WikiPopup.GamesTable.Controls.Add(GSizeC, 2, My.MyProject.Forms.WikiPopup.GamesTable.RowCount - 1);
            My.MyProject.Forms.WikiPopup.GamesTable.Controls.Add(GCompR, 3, My.MyProject.Forms.WikiPopup.GamesTable.RowCount - 1);
            My.MyProject.Forms.WikiPopup.GamesTable.Controls.Add(GCompAlg, 4, My.MyProject.Forms.WikiPopup.GamesTable.RowCount - 1);
            foreach (Label WikiHeader in My.MyProject.Forms.WikiPopup.GamesTable.Controls)
            {
                WikiHeader.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                WikiHeader.Dock = DockStyle.Right;
            }

            GName.Dock = DockStyle.Left;
        }

        private static int firstGame = 0;

        private static void FillTable(Result ps)
        {
            if (firstGame == 0)
            {
                My.MyProject.Forms.Compact.sb_FolderName.Text = ps.Name;
                firstGame = 1;
            }

            using (var GName = new Label()
            {
                Text = ps.Name,
                ForeColor = Color.DimGray,
                Dock = DockStyle.Left,
                Font = new Font("Segoe UI", 11, FontStyle.Regular)
            })
            {
                using var GSizeC = new Label()
                {
                    Text = ps.AfterSizeFormatted,
                    ForeColor = Color.DimGray,
                    Dock = DockStyle.Right,
                    Font = new Font("Segoe UI", 10, FontStyle.Regular)
                };
                using var GCompR = new Label()
                {
                    Text = ps.Ratio.ToString(),
                    ForeColor = Color.DimGray,
                    Dock = DockStyle.Right,
                    Font = new Font("Segoe UI", 10, FontStyle.Regular)
                };
                using var GCompAlg = new Label()
                {
                    Text = ps.Algorithm,
                    ForeColor = Color.DimGray,
                    Dock = DockStyle.Right,
                    Font = new Font("Segoe UI", 10, FontStyle.Regular)
                };
                _ = My.MyProject.Forms.WikiPopup.GamesTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));
                My.MyProject.Forms.WikiPopup.GamesTable.RowCount += 1;
                My.MyProject.Forms.WikiPopup.GamesTable.Controls.Add(GName, 0, My.MyProject.Forms.WikiPopup.GamesTable.RowCount - 1);
                using var GSizeU = new Label()
                {
                    Text = ps.BeforeSizeFormatted,
                    ForeColor = Color.DimGray,
                    Dock = DockStyle.Right,
                    Font = new Font("Segoe UI", 10, FontStyle.Regular)
                };
                My.MyProject.Forms.WikiPopup.GamesTable.Controls.Add(GSizeU, 1, My.MyProject.Forms.WikiPopup.GamesTable.RowCount - 1);
                My.MyProject.Forms.WikiPopup.GamesTable.Controls.Add(GSizeC, 2, My.MyProject.Forms.WikiPopup.GamesTable.RowCount - 1);
                My.MyProject.Forms.WikiPopup.GamesTable.Controls.Add(GCompR, 3, My.MyProject.Forms.WikiPopup.GamesTable.RowCount - 1);
                My.MyProject.Forms.WikiPopup.GamesTable.Controls.Add(GCompAlg, 4, My.MyProject.Forms.WikiPopup.GamesTable.RowCount - 1);
            }
            foreach (Label ConC in My.MyProject.Forms.WikiPopup.GamesTable.Controls)
            {
                ConC.AutoSize = true;
                ConC.Padding = new Padding(2, 4, 0, 0);
            }
        }

        private static decimal folderSize;
        private static string? suffix;

        public static void LocalFolderParse(DirectoryInfo DIwDString, string rawPreSize)
        {
            string wnpatch = Regex.Replace(DIwDString.Name.ToString(), @"\s+", "").ToLower(CultureInfo.CurrentUICulture).Trim();
            workingname = wnpatch;
            folderSize = Math.Round(decimal.Parse(rawPreSize.Split(' ')[0]), 2);
            suffix = rawPreSize.Split(' ')[1];
            try
            {
                My.MyProject.Forms.Compact.wkPreSizeVal.Text = Conversions.ToString(Math.Round(folderSize, 1));
                My.MyProject.Forms.Compact.wkPreSizeUnit.Text = Conversions.ToString(suffix);
                Size wkPreSizeVal_Len = TextRenderer.MeasureText(My.MyProject.Forms.Compact.wkPreSizeVal.Text, My.MyProject.Forms.Compact.wkPreSizeVal.Font);
                My.MyProject.Forms.Compact.wkPreSizeUnit.Location = new Point(My.MyProject.Forms.Compact.wkPreSizeVal.Location.X + My.MyProject.Forms.Compact.wkPreSizeVal.Size.Width / 2 + (wkPreSizeVal_Len.Width / 2 - 8), My.MyProject.Forms.Compact.wkPreSizeVal.Location.Y + 16);
            }

            // I still have no idea why this catch is needed but I'm scared to delete it
            catch (DivideByZeroException)
            {
                My.MyProject.Forms.Compact.wkPreSizeVal.Text = "?";
                My.MyProject.Forms.Compact.wkPreSizeUnit.Text = "";
                Size wkPreSizeVal_Len = TextRenderer.MeasureText(My.MyProject.Forms.Compact.wkPreSizeVal.Text, My.MyProject.Forms.Compact.wkPreSizeVal.Font);
                My.MyProject.Forms.Compact.wkPreSizeUnit.Location = new Point(My.MyProject.Forms.Compact.wkPreSizeVal.Location.X + My.MyProject.Forms.Compact.wkPreSizeVal.Size.Width / 2 + (wkPreSizeVal_Len.Width / 2 - 8), My.MyProject.Forms.Compact.wkPreSizeVal.Location.Y + 16);
            }

            WikiParser();
        }

        public static void ShowWikiRes()
        {
            int w = My.MyProject.Forms.WikiPopup.GamesTable.Width + 35;
            int h = My.MyProject.Forms.WikiPopup.GamesTable.Height + 100;
            int sc_w = Screen.PrimaryScreen.Bounds.Width;
            var screenpos = My.MyProject.Forms.Compact.PointToScreen(new Point(My.MyProject.Forms.Compact.seecompest.Location.X + 670, My.MyProject.Forms.Compact.seecompest.Location.Y + 135));

            // Checks to make sure the popup isn't going to go offscreen.
            if (screenpos.X + w < sc_w)
            {
                My.MyProject.Forms.WikiPopup.SetBounds(screenpos.X, screenpos.Y, w, h);
            }
            else
            {
                My.MyProject.Forms.WikiPopup.SetBounds(screenpos.X - (w - (sc_w - screenpos.X)), screenpos.Y + 15, w, h);
            }

            FadeTransition.FadeForm(My.MyProject.Forms.WikiPopup, 0, Convert.ToDouble(0.96M), 200);
        }
    }

    public class Result
    {
        public string? Name { get; set; }
        public string NameSanitized { get; set; }
        public string? Folder { get; set; }
        public int SteamID { get; set; }
        public string? Algorithm { get; set; }
        public ulong BeforeSize { get; set; }
        public string BeforeSizeFormatted { get; set; }
        public ulong AfterSize { get; set; }
        public string AfterSizeFormatted { get; set; }
        public decimal Ratio { get; set; }

        public object AllData => Name + Folder + SteamID + Algorithm + AfterSize;

        public Result(string nm, string fl, int stID, string alg, ulong bef, ulong aft)
        {
            Name = nm;
            NameSanitized = Regex.Replace(nm.ToLower(CultureInfo.CurrentUICulture), @"[^\p{L}a-zA-Z0-90]", "");
            Folder = Regex.Replace(fl.ToLower(CultureInfo.CurrentUICulture), @"\s+", "");
            SteamID = stID;
            Algorithm = alg;
            BeforeSize = bef;
            BeforeSizeFormatted = Compact.GetOutputSize(Conversions.ToLong(bef), true);
            AfterSize = aft;
            AfterSizeFormatted = Compact.GetOutputSize(Conversions.ToLong(aft), true);
            Ratio = Conversions.ToDecimal(Math.Round((double)(AfterSize / BeforeSize), 2));
        }
    }
}