using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CompactGUI
{
    public partial class Compact
    {
        private static object version = "2.7.0";

        private Process MyProcess
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get => MyProcess1;

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (MyProcess1 != null)
                {
                    MyProcess1.Exited -= ProcessExited;
                }

                MyProcess1 = value;
                if (MyProcess1 != null)
                {
                    MyProcess1.Exited += ProcessExited;
                }
            }
        }

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

        public Process MyProcess1 { get; set; }
        public string CurrentMode1 { get; set; }
        public object OverrideCompressFolderButton { get; set; } = 0;
        public int DirectorysizeexceptionCount { get; set; } = 0;
        public static object Version { get => version; set => version = value; }
        public bool IsQueryMode { get => IsQueryMode1; set => IsQueryMode1 = value; }
        public bool IsActive { get => IsActive1; set => IsActive1 = value; }

        private List<string> workingList = new List<string>();

        public List<string> GetWorkingList()
        {
            return workingList;
        }

        public void SetWorkingList(List<string> value)
        {
            workingList = value;
        }

        public List<string> ListOfFiles { get; } = new List<string>();
        public List<string> AllFiles { get; } = new List<string>();
        public List<string> TreeData { get; } = new List<string>();
        public bool IsQueryMode1 { get; set; } = false;
        public bool IsActive1 { get; set; } = false;

        private decimal intervaltime;
        private readonly ArrayList outputbuffer = new ArrayList();
        private ulong newFolderSize;
        private ulong oldFolderSize;
        internal string workingDir = "";

        private void Compact_Load(object sender, EventArgs e)
        {
            LoadFromSettings();
            if ((dirChooser.Text ?? "") == "❯   Select Target Folder")
            {
                panel_topBar.Height = Height - 1;
                panel_topBar.Anchor += (int)AnchorStyles.Bottom;
                {
                    Label withBlock = topbar_title;
                    withBlock.AutoSize = false;
                    withBlock.TextAlign = ContentAlignment.MiddleCenter;
                    withBlock.Font = new Font(topbar_title.Font.Name, 32, FontStyle.Regular);
                    withBlock.Width = panel_topBar.Width;
                    withBlock.Height = topbar_title.Font.Height;
                    withBlock.Location = new Point(0, panel_topBar.Height / 2 - 150);
                    withBlock.Anchor += (int)AnchorStyles.Right;
                }

                topbar_dirchooserContainer.Location = new Point(44, panel_topBar.Height / 2 - 22);
            }

            comboChooseShutdown.SelectedItem = comboChooseShutdown.Items[0];
            RCMenu.WriteLocRegistry();
            VersionCheck.VC(Conversions.ToString(version));
            foreach (string arg in My.MyProject.Application.CommandLineArgs)
            {
                if (Directory.Exists(arg))
                {
                    SelectFolder(arg, "cmdlineargs");
                }
            }
        }

        private void SelectFolderToCompress(object sender, EventArgs e)
        {
            if (IsActive1 == false & IsQueryMode1 == false)
            {
                FileFolderDialog folderChoice = new FileFolderDialog();
                folderChoice.ShowDialog();
                if (Directory.Exists(Conversions.ToString(folderChoice.SelectedPath)))
                {
                    SelectFolder(Conversions.ToString(folderChoice.SelectedPath), "button");
                }
                else if (File.Exists(Conversions.ToString(folderChoice.SelectedPath)))
                {
                    if (folderChoice.MultipleFiles is object)
                    {
                        Interaction.MsgBox("Multiple Files Selected");
                    }
                    else
                    {
                        Interaction.MsgBox("File selected");
                    }
                }

                folderChoice.Dispose();
            }
        }

        private void SelectFolder(string selectedDir, string senderID)
        {
            Cursor.Current = Cursors.WaitCursor;
            OverrideCompressFolderButton = 0;
            if (selectedDir.Contains(@"C:\Windows"))
            {
                ThrowError(ERR_WINDOWSDIRNOTALLOWED);                                    // Makes sure you're not trying to compact the Windows directory. I should Regex this to catch all possible drives hey?
            }
            else if (selectedDir.EndsWith(@":\"))
            {
                ThrowError(ERR_WHOLEDRIVENOTALLOWED);
            }
            else if (selectedDir.Length >= 3)                                                                                    // Makes sure the chosen folder isn't a null value or an exception
            {
                DirectoryInfo DI_selectedDir = new DirectoryInfo(selectedDir);
                workingDir = DI_selectedDir.FullName.TrimEnd('\\', '/');
                ListOfFiles.Clear();
                AllFiles.Clear();
                TreeData.Clear();
                SelectedFiles.Items.Clear();
                DirectorysizeexceptionCount = 0;
                if (DI_selectedDir.Name.Length > 0)
                {
                    sb_FolderName.Text = Strings.StrConv(DI_selectedDir.Name, VbStrConv.ProperCase);
                }

                if (Directory.GetParent(DI_selectedDir.Parent.FullName) is object)
                {
                    dirChooser.Text = "❯ " + DI_selectedDir.Parent.Parent.Name.Replace(@":\", "") + " ❯ " + DI_selectedDir.Parent.Name + " ❯ " + DI_selectedDir.Name;
                }
                else if (Directory.GetParent(DI_selectedDir.FullName) is object)
                {
                    dirChooser.Text = "❯ " + DI_selectedDir.Parent.Name.Replace(@":\", " ❯ ") + DI_selectedDir.Name;
                }
                else
                {
                    dirChooser.Text = "❯ " + DI_selectedDir.Parent.Name.Replace(@":\", " ❯ ") + DI_selectedDir.Name;
                }

                oldFolderSize = Conversions.ToULong(DirectorySize(DI_selectedDir, true));
                string oldFolderSize_Formatted = GetOutputSize(Conversions.ToLong(oldFolderSize), true);
                GetFilesToCompress(workingDir, ListOfFiles, My.Settings.Default.SkipNonCompressable);
                foreach (string fileName in ListOfFiles)
                {
                    string fN_Listable = fileName.Replace(workingDir, "").Replace(@"\", " ❯ ");
                    if (fN_Listable.Count(x => Conversions.ToString(x) == "❯") == 1)
                    {
                        fN_Listable = fN_Listable.Replace(" ❯ ", "");
                    }

                    SelectedFiles.Items.Add(fN_Listable);
                }

                CommmonActions.PrepareforCompact();
                UnfurlTransition.UnfurlControl(topbar_dirchooserContainer, topbar_dirchooserContainer.Width, Width - sb_Panel.Width - 46, 100);
                WikiHandler.LocalFolderParse(DI_selectedDir, oldFolderSize_Formatted);
                {
                    Label withBlock = topbar_title;
                    withBlock.Anchor -= (int)AnchorStyles.Right;
                    withBlock.AutoSize = true;
                    withBlock.TextAlign = ContentAlignment.MiddleLeft;
                    withBlock.Font = new Font(topbar_title.Font.Name, 15.75F, FontStyle.Regular);
                    withBlock.Location = new Point(39, 20);
                }

                if (Conversions.ToBoolean(!Operators.ConditionalCompareObjectEqual(OverrideCompressFolderButton, 0, false)))
                {
                    btnCompress.Enabled = false;               // Used as a security measure to stop accidental compression of folders that should not be compressed - even though the compact.exe process will throw an error if you try, I'd prefer to catch it here anyway.
                }
            }
            else if ((senderID ?? "") == "button")
            {
                Console.Write("No folder selected");
            }
        }

        private int FileIndex = 0;

        private void GetFilesToCompress(string targetDirectory, List<string> targetOutputList, bool LimitSelectedFiles)
        {
            List<string> NonCompressableSet = new List<string>(Regex.Replace(My.Settings.Default.NonCompressableList, @"\s+", "").Split(';'));
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries) // Process the list of files found in the directory.
            {
                if (LimitSelectedFiles == true)
                {
                    if (string.IsNullOrEmpty(Path.GetExtension(fileName)) || NonCompressableSet.Contains(Path.GetExtension(fileName).TrimStart('.').ToUpperInvariant()) == false)
                    {
                        targetOutputList.Add(fileName);
                    }
                }
                else
                {
                    targetOutputList.Add(fileName);
                }
            }

            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);     // Recurse into subdirectories
            foreach (string subdirectory in subdirectoryEntries)
            {
                GetFilesToCompress(subdirectory, targetOutputList, LimitSelectedFiles);
            }
        }

        private void BtnAnalyze_Click(object sender, EventArgs e)
        {
            conOut.Items.Clear();
            CalculateSaving();
        }

        private void BtnCompress_Click(object sender, EventArgs e)
        {
            conOut.Items.Clear();
            SetWorkingList(new List<string>(ListOfFiles));
            if (Conversions.ToBoolean(GetWorkingList().Count > 0))
            {
                CurrentMode1 = "compact";
                CreateProcess("C");
            }
            else
            {
                Interaction.MsgBox("There are no compressable files in this folder. Check the CompactGUI settings to see if you have chosen to ignore certain files from being compressed.");
            }
        }

        private void BtnUncompress_Click(object sender, EventArgs e)             // Handles uncompressing. For now, uncompressing can only be done through the program only to revert a compression that's just been done.
        {
            CommmonActions.ActionBegun("U");
            FileIndex = 0;
            CurrentMode1 = "uncompact";
            SetWorkingList(new List<string>(AllFiles));
            RunCompact(Conversions.ToString(GetWorkingList()[0]));
        }

        private void OutputBufferDelegate()
        {
            if (Math.Round(Conversions.ToDouble(intervaltime) + 0.1, 2) < Math.Round(DateTime.Now.TimeOfDay.TotalSeconds, 2))      // Buffers incoming strings, then outputs them to the listbox every 0.1s
            {
                base.Invoke(new Action(() =>
                {
                    conOut.BeginUpdate();
                    foreach (string str in outputbuffer)
                    {
                        AppendOutputText(str);
                    }

                    outputbuffer.Clear();
                    intervaltime = Conversions.ToDecimal(DateTime.Now.TimeOfDay.TotalSeconds);
                    conOut.EndUpdate();
                }));
            }
        }

        private void ProcessExited(object sender, EventArgs e)
        {
            OutputBufferDelegate();
            FileIndex += 1;
            if (!Conversions.ToBoolean(FileIndex < GetWorkingList().Count & GetWorkingList().Count > 1))
            {
                Console.WriteLine("Done");
                System.Threading.Thread.Sleep(100);
                outputbuffer.Add("Completed:" + Constants.vbTab + "Processed " + ListOfFiles.Count + " files");
                foreach (string str in outputbuffer)
                {
                    AppendOutputText(str);
                }

                outputbuffer.Clear();
                FileIndex = 0;
                base.Invoke(new Action(() => CompactProcessCompleted()));
            }
            else
            {
                if (GetWorkingList()[FileIndex].ToString().Contains(workingDir))
                {
                    outputbuffer.Add("Compressing: " + Constants.vbTab + GetWorkingList()[FileIndex]);
                    RunCompact(Conversions.ToString(GetWorkingList()[FileIndex]));
                }
                else
                {
                    Interaction.MsgBox("A file that is not contained within your selected folder has been queued for compression. To prevent damage to your system, the program will halt." + Constants.vbCrLf + "The file in question is: " + GetWorkingList()[FileIndex]);
                    IsActive1 = false;
                    base.Invoke(new Action(() => Close()));
                }
            }
        }

        protected void SxSCompactIterator(int SxSCount)
        {
            for (int v = 1, loopTo = SxSCount; v <= loopTo; v++)
            {
                if (Conversions.ToBoolean(FileIndex >= GetWorkingList().Count))
                {
                    break;
                }

                RunCompact(Conversions.ToString(GetWorkingList()[FileIndex]));
                v += 1;
            }
        }

        private void AppendOutputText(string text)                                           // Attach output to the embedded console
        {
            _ = base.Invoke(new Action(() =>
              {
                  conOut.Items.Insert(0, text);
                  sb_progressbar.Width = Conversions.ToInteger(FileIndex / GetWorkingList().Count * 301);
                  sb_progresspercent.Text = Conversions.ToString(Math.Round((double)(FileIndex / GetWorkingList().Count * 100), 0) + "%");
              }));
        }

        private void CompactProcessCompleted()
        {
            if ((CurrentMode1 ?? "") == "compact")
            {
                CommmonActions.ActionCompleted("C");
                CalculateSaving();
            }
            else if ((CurrentMode1 ?? "") == "uncompact")
            {
                CommmonActions.ActionCompleted("U");
                sb_compressedSizeVisual.Height = 113;
                wkPostSizeVal.Text = "?";
                wkPostSizeUnit.Text = "";
            }

            if (checkShutdownOnCompletion.Checked & !IsQueryMode1)
            {
                My.MyProject.Forms.ShutdownDialog.SDProcIntent.Text = comboChooseShutdown.Text;
                FadeTransition.FadeForm(My.MyProject.Forms.ShutdownDialog, 0, Convert.ToDouble(0.98M), 300, true);
            }
        }

        private void ReturnArrow_Click(object sender, EventArgs e)                       // Returns you to the first screen and cleans up some stuff
        {
            CommmonActions.PrepareforCompact();
        }

        private void MyForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (IsActive1 == true)
            {
                if (MessageBox.Show("Are you sure you want to exit?" + Constants.vbCrLf + Constants.vbCrLf + "Quitting now will finish compressing the current file, then quit safely." + Constants.vbCrLf + Constants.vbCrLf + "If you do decide to quit now, you can resume compression by repeating the process later." + Constants.vbCrLf + "Click Yes to continue exiting the program.", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) != DialogResult.Yes)

                {
                    e.Cancel = true;
                }
                else if (MyProcess is object && MyProcess.HasExited == false)
                {
                    MyProcess.Kill();
                }
            }
            else if (MyProcess is object && MyProcess.HasExited == false)
            {
                MyProcess.Kill();
            }
        }

        // /////////////FUNCTIONS//////////////

        private const decimal FourGB = 4294967296;

        private void CalculateSaving()   // Calculations for all the relevant information after compression is completed. All the data is parsed from the console ouput using basic strings, but because that occurs on a different thread, information is stored to variables first (The Status Monitors at the top) then those values are used.
        {
            CommmonActions.ActionBegun("A");
            int numberFilesCompressed = 0;
            ulong SizeAfterCompression = default;
            ulong SizeBeforeCompression = oldFolderSize;
            decimal progressVal = default;
            GetFilesToCompress(workingDir, AllFiles, false);
            Console.WriteLine("Total Files in Dir: " + AllFiles.Count);
            int conOutFileNamePadding = default;
            foreach (string fl in AllFiles)
            {
                if (fl.Length > conOutFileNamePadding)
                {
                    conOutFileNamePadding = fl.Length;
                }
            }

            conOut.Items.Insert(0, "File" + Strings.StrDup(conOutFileNamePadding - 4, " ") + Constants.vbTab + "Size" + Strings.StrDup(16, " ") + "Size on Disk");
            conOut.Items.Insert(1, "");
            List<string> AnalyzedPoorlyCompressedFiles = new List<string>();
            foreach (string fpath in AllFiles)
            {
                Application.DoEvents();
                ulong compval = Conversions.ToULong(GetFileSizeOnDisk(fpath));
                ulong rawval = Conversions.ToULong(new FileInfo(fpath).Length);
                if (rawval > FourGB)
                {
                    int Mod4K = (int)(Conversions.ToLong(rawval) / FourGB);
                    if (compval < 1.1 * Conversions.ToDouble(rawval - Mod4K * FourGB))   // Checks if the compressed file is smaller than the adjustment consideration @ 4GB (with a 10% leeway)
                    {
                        compval = Conversions.ToULong(Mod4K * FourGB + compval);
                    }
                }

                if (compval < rawval)
                {
                    numberFilesCompressed += 1;
                }
                else
                {
                    AnalyzedPoorlyCompressedFiles.Add(new FileInfo(fpath).Extension);
                }

                string fpath_Output = fpath + Strings.StrDup(conOutFileNamePadding - fpath.Length, " ");
                string compval_fmt = GetOutputSize(Conversions.ToLong(compval), true);
                string rawval_fmt = GetOutputSize(Conversions.ToLong(rawval), true);
                outputbuffer.Add(fpath_Output + Constants.vbTab + "Size: " + rawval_fmt + Strings.StrDup(14 - rawval_fmt.Length, " ") + "Size on Disk: " + compval_fmt);
                if (Math.Round(Conversions.ToDouble(intervaltime) + 0.2, 2) < Math.Round(DateTime.Now.TimeOfDay.TotalSeconds, 2))      // Buffers incoming strings, then outputs them to the listbox every 0.1s
                {
                    base.Invoke(new Action(() =>
                    {
                        conOut.BeginUpdate();
                        foreach (string str in outputbuffer)
                        {
                            conOut.Items.Insert(2, str);
                        }

                        outputbuffer.Clear();
                        intervaltime = Conversions.ToDecimal(DateTime.Now.TimeOfDay.TotalSeconds);
                        conOut.EndUpdate();
                    }));
                }

                TreeData.Add(fpath + "|" + rawval + "|" + compval);
                SizeAfterCompression += compval;
                progressVal += 1 / (AllFiles.Count * 100);
                sb_progressbar.Width = (int)(Conversions.ToDouble(progressVal) * 3.01);
                sb_progresspercent.Text = Math.Round(progressVal, 0) + "%";
            }

            foreach (string str in outputbuffer)
            {
                conOut.Items.Insert(2, str);
            }

            IEnumerable<IGrouping<string, string>> groups = AnalyzedPoorlyCompressedFiles.GroupBy(value => value);
            Console.WriteLine("Poorly Compressed Extensions:");
            foreach (IGrouping<string, string> grp in groups)
            {
                Console.WriteLine(Constants.vbTab + grp.ElementAtOrDefault(0) + ": " + grp.Count() + "/" + AllFiles.Where(value => (new FileInfo(value).Extension ?? "") == (grp.ElementAtOrDefault(0) ?? "")).Count());
            }

            newFolderSize = SizeAfterCompression;
            if (Conversions.ToLong(SizeBeforeCompression) - Conversions.ToLong(SizeAfterCompression) < 0 & IsQueryMode1 == true) // Checks if the Folder is NOT compressed
            {
                CommmonActions.ActionCompleted("A", false);
            }
            else
            {
                origSizeLabel.Text = GetOutputSize(Conversions.ToLong(SizeBeforeCompression), true);
                string PrintOutSize = GetOutputSize(Conversions.ToLong(SizeBeforeCompression) - (Conversions.ToLong(SizeBeforeCompression) - Conversions.ToLong(SizeAfterCompression)), true);
                compressedSizeLabel.Text = PrintOutSize;
                wkPostSizeVal.Text = PrintOutSize.Split(' ')[0]; // SPLITTING ON A SPACE COULD LEAD TO FORMATTING BUGS WITH CULTURES
                wkPostSizeUnit.Text = PrintOutSize.Split(' ')[1];
                Size wkPostSizeVal_Len = TextRenderer.MeasureText(wkPostSizeVal.Text, wkPostSizeVal.Font);
                wkPostSizeUnit.Location = new Point(wkPostSizeVal.Location.X + wkPostSizeVal.Size.Width / 2 + (wkPostSizeVal_Len.Width / 2 - 8), wkPostSizeVal.Location.Y + 16);
                double compRatio = Math.Round((double)(SizeBeforeCompression / SizeAfterCompression), 1);
                spaceSavedLabel.Text = GetOutputSize(Conversions.ToLong(SizeBeforeCompression - SizeAfterCompression), true) + " Saved";
                labelFilesCompressed.Text = numberFilesCompressed + " / " + AllFiles.Count + " files compressed";
                help_resultsFilesCompressed.Location = new Point(labelFilesCompressed.Location.X + labelFilesCompressed.Width + 2, labelFilesCompressed.Location.Y + 1);
                try
                {
                    compressedSizeVisual.Width = Conversions.ToInteger(320 / compRatio);
                    sb_compressedSizeVisual.Height = Conversions.ToInteger(113 / compRatio);
                    sb_compressedSizeVisual.Location = new Point(sb_compressedSizeVisual.Location.X, 5 + 113 - sb_compressedSizeVisual.Height);
                    Callpercent = Conversions.ToDecimal(1 - (SizeAfterCompression / SizeBeforeCompression)) * 100;
                    if (My.Settings.Default.ShowNotifications)
                    {
                        TrayIcon.ShowBalloonTip(1, "Compressed: " + sb_FolderName.Text, Constants.vbCrLf + "▸ " + spaceSavedLabel.Text + Constants.vbCrLf + "▸ " + Math.Round(Callpercent, 1) + "% Smaller", ToolTipIcon.None);
                    }
                }
                catch (OverflowException)
                {
                    compressedSizeVisual.Width = 320;
                    sb_compressedSizeVisual.Height = 113;
                }

                outputbuffer.Clear();
                CommmonActions.ActionCompleted("A", true);
                Callpercent = Conversions.ToDecimal(1 - (SizeAfterCompression / SizeBeforeCompression)) * 100;
                PaintPercentageTransition.PaintTarget(results_arc, (float)Callpercent, 5);
            }

            IsQueryMode1 = false;
        }

        public static decimal GetFileSizeOnDisk(string file)
        {
            FileInfo info = new FileInfo(file);
            ulong blockSize = 0;
            uint clusterSize;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select BlockSize,NumberOfBlocks from Win32_Volume WHERE DriveLetter = '" + info.Directory.Root.FullName.TrimEnd('\\') + "'");
            foreach (ManagementObject vi in searcher.Get())
            {
                blockSize = Conversions.ToULong(vi["BlockSize"]);
                break;
            }

            searcher.Dispose();
            clusterSize = Conversions.ToUInteger(blockSize);
            uint losize = GetCompressedFileSizeW(file, lpFileSizeHigh: out uint hosize);
            long size = Conversions.ToLong(hosize) << 32 | losize;
            decimal bytes = ((size
                                       + clusterSize
                                       - 1) / clusterSize * clusterSize);
            return Conversions.ToDecimal(bytes);
        }

        [DllImport("kernel32.dll")]
        private static extern uint GetCompressedFileSizeW([In()][MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.U4)] out uint lpFileSizeHigh);

        public static string GetOutputSize(long byteCount, bool showSizeType = false)            // Function for converting from Bytes into various units
        {
            string[] suf = new[] { " B", " KB", " MB", " GB", " TB", " PB", " EB" };
            if (byteCount == 0)
            {
                return "0" + suf[0];
            }

            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            if (showSizeType == true)
            {
                return (Math.Sign(byteCount) * num).ToString() + suf[place];
            }
            else
            {
                return (Math.Sign(byteCount) * num).ToString();
            }
        }

        private long DirectorySize(DirectoryInfo dInfo, bool includeSubdirectories)
        {
            try
            {
                long totalSize = dInfo.EnumerateFiles().Sum(file => file.Length);
                if (includeSubdirectories)
                {
                    totalSize += dInfo.EnumerateDirectories().Sum(dir => DirectorySize(dir, true));
                }

                return totalSize;
            }
            catch (UnauthorizedAccessException)
            {
                DirectorysizeexceptionCount += 1;
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(DirectorysizeexceptionCount, 1, false)))
                {
                    OverrideCompressFolderButton = 1;
                    DirectorysizeexceptionCount += 1;
                    if (My.MyProject.User.IsInRole(Microsoft.VisualBasic.ApplicationServices.BuiltInRole.Administrator) == false)
                    {
                        ThrowError(ERR_UNAUTHORISEDREQUIRESADMIN);
                    }
                    else
                    {
                        ThrowError(ERR_UNAUTHORISEDREQUIRESSYSTEM);
                    }
                }
            }
            catch (Exception)
            {
            }

            return default;
        }

        // ///////EXTRA FUNCTIONS/////////////

        public static string Between(string value, string a, string b)
        {
            if (value.IndexOf(a) == -1)
            {
                return "";
            }

            if (value.LastIndexOf(b) == -1)
            {
                return "";
            }

            if (value.IndexOf(a) + a.Length >= value.LastIndexOf(b))
            {
                return "";
            }

            return value.Substring(value.IndexOf(a) + a.Length, value.LastIndexOf(b) - (value.IndexOf(a) + a.Length));
        }

        public static string Before(string value, string a)
        {
            int posA = value.IndexOf(a);
            if (posA == -1)
            {
                return "";
            }

            return value.Substring(0, posA);
        }

        public static string After(string value, string a)
        {
            int posA = value.LastIndexOf(a);
            if (posA == -1)
            {
                return "";
            }

            int adjustedPosA = posA + a.Length;
            if (adjustedPosA >= value.Length)
            {
                return "";
            }

            return value.Substring(adjustedPosA);
        }

        // ////////////////////TESTING////////////////////

        private void Saveconlog_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("Save console output?", MsgBoxStyle.YesNo) == MsgBoxResult.Yes)
            {
                ArrayList reverseCon = new ArrayList();
                StringBuilder sb = new StringBuilder();
                foreach (string ln in conOut.Items)
                {
                    reverseCon.Add(ln.Trim());
                }

                reverseCon.Reverse();
                sb.AppendLine("CompactGUI: Log at " + DateTime.Now + Constants.vbCrLf + Strings.StrDup(50, "/"));
                foreach (string ln in reverseCon)
                {
                    sb.AppendLine(ln);
                }

                sb.AppendLine("End Log at " + DateTime.Now + Constants.vbCrLf + Strings.StrDup(100, "/") + Constants.vbCrLf + Constants.vbCrLf);
                File.AppendAllText(Application.StartupPath + @"\CompactGUILog.txt", sb.ToString(), Encoding.UTF8);
                Interaction.MsgBox("Saved log to " + Application.StartupPath + @"\CompactGUILog.txt");
                Process.Start(Application.StartupPath + @"\CompactGUILog.txt");
            }
        }

        private void SubmitToWiki_Click(object sender, EventArgs e)
        {
            WikiSubmission.Folder_Submit = new DirectoryInfo(workingDir).Name;
            if (compressX4.Checked == true)
            {
                WikiSubmission.CompMode_Submit = "X4";
            }

            if (compressX8.Checked == true)
            {
                WikiSubmission.CompMode_Submit = "X8";
            }

            if (compressX16.Checked == true)
            {
                WikiSubmission.CompMode_Submit = "X16";
            }

            if (compressLZX.Checked == true)
            {
                WikiSubmission.CompMode_Submit = "LZX";
            }

            WikiSubmission.BeforeSize_Submit = oldFolderSize;
            WikiSubmission.AfterSize_Submit = newFolderSize;
            Console.WriteLine(WikiSubmission.Folder_Submit);
            Console.WriteLine(WikiSubmission.CompMode_Submit);
            Console.WriteLine(WikiSubmission.BeforeSize_Submit);
            Console.WriteLine(WikiSubmission.AfterSize_Submit);
            My.MyProject.Forms.WikiSubmission.Show();
        }

        private void CompressX8_CheckedChanged(object sender, EventArgs e)
        {
            if (compressX4.Checked)
            {
                My.Settings.Default.SavedCompressionOption = 0;
            }

            if (compressX8.Checked)
            {
                My.Settings.Default.SavedCompressionOption = 1;
            }

            if (compressX16.Checked)
            {
                My.Settings.Default.SavedCompressionOption = 2;
            }

            if (compressLZX.Checked)
            {
                My.Settings.Default.SavedCompressionOption = 3;
            }
        }

        private void LoadFromSettings()
        {
            int switchExpr = My.Settings.Default.SavedCompressionOption;
            switch (switchExpr)
            {
                case 0:
                    {
                        compressX4.Checked = true;
                        break;
                    }

                case 1:
                    {
                        compressX8.Checked = true;
                        break;
                    }

                case 2:
                    {
                        compressX16.Checked = true;
                        break;
                    }

                case 3:
                    {
                        compressLZX.Checked = true;
                        break;
                    }
            }
        }

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

        private void Panel_topBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left & isMaximised == false)
            {
                MoveForm();
            }
        }

        private void Btn_Mainexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Mainmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            if (My.Settings.Default.MinimisetoTray == true)
            {
                Hide();
            }
        }

        private bool isMaximised = false;

        private void Btn_Mainmax_Click(object sender, EventArgs e)
        {
            if (isMaximised == false)
            {
                base.MaximumSize = Screen.FromControl(this).WorkingArea.Size;
                Bounds = Screen.GetWorkingArea(this);
                isMaximised = true;
            }
            else if (isMaximised == true)
            {
                Height = 652;
                Width = 1002;
                CenterToScreen();
                isMaximised = false;
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        /* TODO ERROR: Skipped RegionDirectiveTrivia */

        private void ButtonCompress_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            SolidBrush drawBrush = new SolidBrush(btn.ForeColor);
            StringFormat sf = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            btnCompress.Text = string.Empty;
            e.Graphics.DrawString("Compress Folder", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        private void Sb_AnalysisPanel_Paint(object sender, PaintEventArgs e)
        {
            using Pen p = new Pen(Brushes.DimGray, 1);
            e.Graphics.DrawLine(p, new Point(30, 0), new Point(303, 0));
        }

        private void Sb_ResultsPanel_Paint(object sender, PaintEventArgs e)
        {
            using Pen dotted = new Pen(Brushes.ForestGreen, 1)
            {
                DashPattern = new float[] { 3, 3, 3, 3 }
            };
            e.Graphics.DrawRectangle(dotted, 225, 5, 39, 112);
            dotted.Dispose();
        }

        private static decimal Callpercent;

        public void Results_arc_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            DrawProgress(e.Graphics, new Rectangle(21, 21, 203, 203), Conversions.ToDecimal(PaintPercentageTransition.Callpercentstep), ColorTranslator.FromHtml("#3B668E"), ColorTranslator.FromHtml("#CFD8DC"));
        }

        private void DrawProgress(Graphics g, Rectangle rect, decimal percentage, Color percColor, Color remColor)
        {
            decimal progressAngle = 183 / (100 * percentage);
            decimal remainderAngle = (185 * percentage) / Callpercent - progressAngle;
            using Pen pen = new Pen(percColor, 41);
            using Pen remainderPen = new Pen(remColor, 41);
            using Font fnt = new Font("Segoe UI Light", 22);
            using Font fnt2 = new Font("Segoe UI Light", 9);
            using Font fnt3 = new Font("Segoe UI Light", 10);
            using SolidBrush fb = new SolidBrush(Color.FromArgb(48, 67, 84));
            g.DrawArc(remainderPen, rect, (float)progressAngle - 184, (float)remainderAngle);
            g.DrawArc(pen, rect, -183, (float)progressAngle);
            string perc = Math.Round(percentage, 0).ToString();
            SizeF percSize = g.MeasureString(perc, fnt);
            Point percPoint = new Point((int)(rect.Left + (rect.Width / 2) - (percSize.Width / 2)), (int)(rect.Top + (rect.Height / 2) - (percSize.Height * 1.25)));
            g.DrawString(perc, fnt, fb, percPoint);
            string sign = "%";
            Point signPoint = new Point((int)(percPoint.X + percSize.Width - 5), percPoint.Y + 10);
            g.DrawString(sign, fnt2, fb, signPoint);
            string lbl = "Reduction in size";
            SizeF lblSize = g.MeasureString(lbl, fnt3);
            Point lblPoint = new Point((int)(rect.Left + (rect.Width / 2) - (lblSize.Width / 2)), (int)(rect.Top + (rect.Height / 2) - (lblSize.Height * 0.75)));
            g.DrawString(lbl, fnt3, fb, lblPoint);
        }

        private void CompResultsPanel_Paint(object sender, PaintEventArgs e)
        {
            using Pen p = new Pen(Brushes.Silver, 1);
            e.Graphics.DrawLine(p, new Point(12, CompResultsPanel.Height - 1), new Point(panel_console.Width - 12, CompResultsPanel.Height - 1));
        }

        private void UpdateBanner_Paint(object sender, PaintEventArgs e)
        {
            int x = updateBanner.Width;
            int y = updateBanner.Height;
            using SolidBrush brush = new SolidBrush(Color.FromArgb(255, 47, 66, 83));
            e.Graphics.FillPolygon(brush, new PointF[] { new Point(0, 0), new Point(0, y), new Point(y, y) });
            e.Graphics.FillPolygon(brush, new PointF[] { new Point(x, 0), new Point(x, y), new Point(x - y, y) });
        }

        private void ListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString(SelectedFiles.Items[e.Index].ToString(), SelectedFiles.Font, Brushes.Gray, e.Bounds.Left, (e.Bounds.Height - SelectedFiles.Font.Height) / 2 + e.Bounds.Top);
        }

        private void ListBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 22;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            using Pen p = new Pen(Brushes.Silver, 1);
            e.Graphics.DrawLine(p, new Point(15, 0), new Point(Panel1.Width, 0));
        }

        private void DirChooser_MouseEnter(object sender, EventArgs e)
        {
            dirChooser.LinkColor = Color.FromArgb(200, 200, 200);
        }

        private void DirChooser_MouseLeave(object sender, EventArgs e)
        {
            dirChooser.LinkColor = Color.White;
        }

        private object isAlreadyFading = 2;

        private void Seecompest_MouseHover(object sender, EventArgs e)
        {
            topbar_title.Select();
            WikiHandler.ShowWikiRes();
            isAlreadyFading = 0;
        }

        private void HideWikiRes(object sender, EventArgs e)
        {
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(isAlreadyFading, 0, false)))
            {
                FadeTransition.FadeForm(My.MyProject.Forms.WikiPopup, Convert.ToDouble(0.96M), 0, 200);
                isAlreadyFading = 1;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            InputPage.Focus();
        }

        private void ButtonCompress_EnabledChanged(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = btn.Enabled ? Color.White : Color.Silver;
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */

        private void Sb_lblGameIssues_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/ImminentFate/CompactGUI/wiki/Compression-Results:-Games");
        }

        private void DirChooser_DragDrop(object sender, DragEventArgs e)
        {
            object dropVar = e.Data.GetData(DataFormats.FileDrop);
            if (IsActive1 == false & IsQueryMode1 == false)
            {
                SelectFolder(Conversions.ToString(dropVar), "button");
            }
        }

        private void DirChooser_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                object dropVar = e.Data.GetData(DataFormats.FileDrop);
                if (Directory.Exists(Conversions.ToString(dropVar)))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else if (File.Exists(Conversions.ToString(dropVar)))
                {
                    // For use in file handling
                }
            }
        }

        private void DlUpdateLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/ImminentFate/CompactGUI/releases");
        }

        private void ShowInfoPopup_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Info.Show();
        }

        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        private const int ERR_WINDOWSDIRNOTALLOWED = 515;
        private const int ERR_WHOLEDRIVENOTALLOWED = 516;
        private const int ERR_UNAUTHORISEDREQUIRESADMIN = 517;
        private const int ERR_UNAUTHORISEDREQUIRESSYSTEM = 518;

        private void ThrowError(int e)
        {
            switch (e)
            {
                case ERR_WHOLEDRIVENOTALLOWED:
                    {
                        Interaction.MsgBox("Compressing an entire drive with this tool is not allowed");
                        break;
                    }

                case ERR_WINDOWSDIRNOTALLOWED:
                    {
                        Interaction.MsgBox("Compressing items in the Windows folder using this program " + "is not recommended. Please use the command line instead");
                        break;
                    }

                case ERR_UNAUTHORISEDREQUIRESADMIN:
                    {
                        if (MessageBox.Show("This directory contains a subfolder that you do not have permission to access. Please try running the program again as an Administrator." + Constants.vbCrLf + Constants.vbCrLf + "If the problem persists, the subfolder is most likely protected by the System, and by design this program will refuse to let you proceed." + Constants.vbCrLf + Constants.vbCrLf + "Would you like to restart the program as an Administrator?", "Permission Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            RCMenu.RunAsAdmin();
                            Close();
                        }

                        break;
                    }

                case ERR_UNAUTHORISEDREQUIRESSYSTEM:
                    {
                        Interaction.MsgBox("This directory contains a subfolder that you do not have permission To access." + Constants.vbCrLf + Constants.vbCrLf + "The subfolder is most likely protected by the System, and by design this program will refuse to let you proceed.");
                        break;
                    }
            }
        }

        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */

        private void TrayIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            Show();
            TopMost = true;
            Focus();
            WindowState = FormWindowState.Normal;
            TopMost = false;
        }
    }
}