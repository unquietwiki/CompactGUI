﻿using CompactGUI.My.Resources;
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
        internal static List<Result>? allResults = new List<Result>();
        private static string workingname = "testdir";
        private static readonly string DBZipFileLoc = Path.GetTempPath() + "CompactGUI.zxm";

        private static void WikiParser()
        {
            // TODO: this needs debugging for the Console writes & null settings
            Console.WriteLine("Working Name: " + workingname);
            Console.WriteLine(DBZipFileLoc);
            if (InputFromGitHub is null)
            {
                if (allResults != null) allResults.Clear();
                Console.WriteLine(Resources.StrDBFetch);
                try
                {
                    using var wc = new WebClient() { Encoding = Encoding.UTF8 };
                    wc.DownloadFile("https://raw.githubusercontent.com/ImminentFate/CompactGUI/master/Wiki/Database.zip", DBZipFileLoc);
                    using var x = System.IO.Compression.ZipFile.OpenRead(DBZipFileLoc);
                    using var stre = new StreamReader(x.Entries[0].Open());
                    My.Settings.Default.ResultsDB = stre.ReadToEnd();
                    My.Settings.Default.ResultsDB_Date = DateTime.Now;
                    Console.WriteLine(Resources.StrDBNew);
                    InitialiseInputFromGithub();
                }
                catch (WebException)
                {
                    My.MyProject.Forms.Compact.lblGameIssues.Text = Resources.StrErrorInternet;
                    My.MyProject.Forms.Compact.lblGameIssues.Visible = true;
                    My.MyProject.Forms.Compact.ToolTipFilesCompressed.SetToolTip(My.MyProject.Forms.Compact.lblGameIssues, "");
                    My.MyProject.Forms.Compact.wkPostSizeVal.Text = Resources.StrQuestion;
                    My.MyProject.Forms.Compact.wkPostSizeUnit.Text = "";
                    My.MyProject.Forms.Compact.wkPostSizeUnit.Location = new Point(My.MyProject.Forms.Compact.wkPostSizeVal.Location.X + My.MyProject.Forms.Compact.wkPostSizeVal.Size.Width, My.MyProject.Forms.Compact.wkPostSizeVal.Location.Y);
                    My.MyProject.Forms.Compact.ActivityPanel.Show();
                }
            }
            else
            {
                Console.WriteLine(Resources.StrDBExist);
                ParseData();
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
            if ((InputFromGitHub != null) && (allResults != null))
            {
                foreach (XElement? result in InputFromGitHub)
                {
                    var itemName = result.Element("itemName").Value;
                    var itemFolder = result.Element("itemFolder").Value;
                    var itemSteamID = result.Element("itemSteamID").Value;
                    var itemAlgorithm = result.Element("itemAlgorithm").Value;
                    var itemBeforeSize = Convert.ToUInt64(result.Element("itemBefore").Value, Compact.culture);
                    var itemAfterSize = Convert.ToUInt64(result.Element("itemAfter").Value, Compact.culture);
                    allResults.Add(new Result(itemName, itemFolder, Convert.ToInt32(itemSteamID, Compact.culture), itemAlgorithm, itemBeforeSize, itemAfterSize));
                }

                //FIXME: there was some weird looping here; tried to narrow it
                var gcount = new List<Result>();
                int matches = 0;
                foreach (Result r in allResults)
                {
                    if (r.Folder != null)
                    {
                        if (r.Folder.Equals(workingname, StringComparison.CurrentCultureIgnoreCase))
                        {
                            gcount.Add(r);
                            matches += 1;
                        }
                        if (matches == 0)
                        {
                            if (workingname.Length > 2 && r.NameSanitized.StartsWith(workingname, StringComparison.CurrentCultureIgnoreCase))
                            {
                                gcount.Add(r);
                                matches += 1;
                            }
                        }
                    }
                }
                Console.WriteLine(Environment.NewLine);

                decimal ratioavg = 1;
                firstGame = 0;
                PrepareTable();
                foreach (Result r in gcount)
                {
                    FillTable(r);
                    ratioavg += decimal.Parse(r.Ratio.ToString(Compact.culture), Compact.culture);
                    My.MyProject.Forms.Compact.lblGameIssues.Visible = false;   // Add check for game issues at later date
                }

                My.MyProject.Forms.Compact.lblCompressed.Text = Resources.StrEstComp;
                if (gcount.Count != default)
                {
                    ratioavg = (ratioavg - 1) / gcount.Count;
                    My.MyProject.Forms.Compact.wkPostSizeVal.Text = Convert.ToString(Math.Round(folderSize * ratioavg, 1), Compact.culture);
                    My.MyProject.Forms.Compact.wkPostSizeUnit.Text = Convert.ToString(suffix, Compact.culture);
                    Size wkPostSizeVal_Len = TextRenderer.MeasureText(My.MyProject.Forms.Compact.wkPostSizeVal.Text, My.MyProject.Forms.Compact.wkPostSizeVal.Font);
                    My.MyProject.Forms.Compact.wkPostSizeUnit.Location = new Point(My.MyProject.Forms.Compact.wkPostSizeVal.Location.X + My.MyProject.Forms.Compact.wkPostSizeVal.Size.Width / 2 + (wkPostSizeVal_Len.Width / 2 - 8), My.MyProject.Forms.Compact.wkPostSizeVal.Location.Y + 16);
                    My.MyProject.Forms.Compact.wkPostSizeUnit.Visible = true;
                }
                else
                {
                    My.MyProject.Forms.Compact.wkPostSizeVal.Text = Resources.StrQuestion;
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
                My.MyProject.Forms.Compact.ActivityPanel.Show();
            }
        }

        private static void PrepareTable()
        {
            My.MyProject.Forms.WikiPopup.GamesTable.Visible = false;
            My.MyProject.Forms.WikiPopup.GamesTable.Controls.Clear();
            My.MyProject.Forms.WikiPopup.GamesTable.RowCount = 0;
            using var GName = new Label() { Text = Resources.StrLblGame };
            using var GSizeU = new Label() { Text = Resources.StrLblBefore };
            using var GSizeC = new Label() { Text = Resources.StrLblAfter };
            using var GCompR = new Label() { Text = Resources.StrLblRatio };
            using var GCompAlg = new Label() { Text = Resources.StrLblAlgo };
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
                My.MyProject.Forms.Compact.lblFolderName.Text = ps.Name;
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
                    Text = ps.Ratio.ToString(Compact.culture),
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
            string wnpatch = Regex.Replace(DIwDString.Name.ToString(Compact.culture), @"\s+", "").ToLower(CultureInfo.CurrentUICulture).Trim();
            workingname = wnpatch;
            folderSize = Math.Round(decimal.Parse(rawPreSize.Split(' ')[0], Compact.culture), 2);
            suffix = rawPreSize.Split(' ')[1];
            try
            {
                My.MyProject.Forms.Compact.wkPreSizeVal.Text = Convert.ToString(Math.Round(folderSize, 1), Compact.culture);
                My.MyProject.Forms.Compact.wkPreSizeUnit.Text = Convert.ToString(suffix, Compact.culture);
                Size wkPreSizeVal_Len = TextRenderer.MeasureText(My.MyProject.Forms.Compact.wkPreSizeVal.Text, My.MyProject.Forms.Compact.wkPreSizeVal.Font);
                My.MyProject.Forms.Compact.wkPreSizeUnit.Location = new Point(My.MyProject.Forms.Compact.wkPreSizeVal.Location.X + My.MyProject.Forms.Compact.wkPreSizeVal.Size.Width / 2 + (wkPreSizeVal_Len.Width / 2 - 8), My.MyProject.Forms.Compact.wkPreSizeVal.Location.Y + 16);
            }

            // I still have no idea why this catch is needed but I'm scared to delete it
            catch (DivideByZeroException)
            {
                My.MyProject.Forms.Compact.wkPreSizeVal.Text = Resources.StrQuestion;
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

        internal Result(string nm, string fl, int stID, string alg, ulong bef, ulong aft)
        {
            Name = nm;
            NameSanitized = Regex.Replace(nm.ToLower(CultureInfo.CurrentUICulture), @"[^\p{L}a-zA-Z0-90]", "");
            Folder = Regex.Replace(fl.ToLower(CultureInfo.CurrentUICulture), @"\s+", "");
            SteamID = stID;
            Algorithm = alg;
            BeforeSize = bef;
            BeforeSizeFormatted = Compact.GetOutputSize(Convert.ToInt64(bef), true);
            AfterSize = aft;
            AfterSizeFormatted = Compact.GetOutputSize(Convert.ToInt64(aft), true);
            Ratio = Convert.ToDecimal(Math.Round((double)(AfterSize / BeforeSize), 2));
        }
    }
}