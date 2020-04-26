using CompactGUI.My.Resources;
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
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

#nullable enable

namespace CompactGUI
{
    public partial class Compact
    {
        private Process? MyProcess
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

        public List<string> GetWorkingList()
        {
            return workingList;
        }

        public void SetWorkingList(List<string> value)
        {
            workingList = value;
        }

        private void Compact_Load(object sender, EventArgs e)
        {
            LoadFromSettings();
            if (dirChooser.Text.Contains("Select Target Folder"))
            {
                TopBarPanel.Height = Height - 1;
                TopBarPanel.Anchor += (int)AnchorStyles.Bottom;
                {
                    Label withBlock = topbar_title;
                    withBlock.AutoSize = false;
                    withBlock.TextAlign = ContentAlignment.MiddleCenter;
                    withBlock.Font = new Font(topbar_title.Font.Name, 32, FontStyle.Regular);
                    withBlock.Width = TopBarPanel.Width;
                    withBlock.Height = topbar_title.Font.Height;
                    withBlock.Location = new Point(0, TopBarPanel.Height / 2 - 150);
                    withBlock.Anchor += (int)AnchorStyles.Right;
                }

                topbar_dirchooserContainer.Location = new Point(44, TopBarPanel.Height / 2 - 22);
            }

            comboChooseShutdown.SelectedItem = comboChooseShutdown.Items[0];
            RCMenu.WriteLocRegistry();
            VersionCheck.VC(Convert.ToString(version, culture));
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
            if (IsActive == false & IsQueryMode == false)
            {
                var folderChoice = new FileFolderDialog();
                folderChoice.ShowDialog();
                if (Directory.Exists(Convert.ToString(folderChoice.SelectedPath, Compact.culture)))
                {
                    SelectFolder(Convert.ToString(folderChoice.SelectedPath, Compact.culture), "button");
                }
                else if (File.Exists(Convert.ToString(folderChoice.SelectedPath, Compact.culture)))
                {
                    if (folderChoice.MultipleFiles is object)
                    {
                        MessageBox.Show(Resources.StrFilesSelected);
                    }
                    else
                    {
                        MessageBox.Show(Resources.StrFileSelected);
                    }
                }

                folderChoice.Dispose();
            }
        }

        private void SelectFolder(string selectedDir, string senderID = "")
        {
            Cursor.Current = Cursors.WaitCursor;
            OverrideCompressFolderButton = 0;
            if (selectedDir.Contains(System.Environment.SpecialFolder.Windows.ToString()))
            {
                ThrowError(Errors.ERR_WINDOWSDIRNOTALLOWED);   // Makes sure you're not trying to compact the Windows directory.
            }
            else if (selectedDir.EndsWith(@":\", StringComparison.CurrentCultureIgnoreCase))
            {
                ThrowError(Errors.ERR_WHOLEDRIVENOTALLOWED);
            }
            else if (selectedDir.Length >= 3)   // Makes sure the chosen folder isn't a null value or an exception
            {
                var DI_selectedDir = new DirectoryInfo(selectedDir);
                workingDir = DI_selectedDir.FullName.TrimEnd('\\', '/');
                ListOfFiles.Clear();
                AllFiles.Clear();
                TreeData.Clear();
                SelectedFiles.Items.Clear();
                DirectorysizeexceptionCount = 0;
                if (DI_selectedDir.Name.Length > 0)
                {
                    lblFolderName.Text = culture.TextInfo.ToTitleCase(DI_selectedDir.FullName);
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

                oldFolderSize = Convert.ToUInt64(DirectorySize(DI_selectedDir, true));
                string oldFolderSize_Formatted = GetOutputSize(Convert.ToInt64(oldFolderSize), true);
                GetFilesToCompress(workingDir, ListOfFiles, My.Settings.Default.SkipNonCompressable);
                foreach (string fileName in ListOfFiles)
                {
                    string fN_Listable = fileName.Replace(workingDir, "").Replace(@"\", " ❯ ");
                    //TODO: verify this works right
                    if (fN_Listable.Count(x => Convert.ToString(x, culture) == "❯") == 1)
                    {
                        fN_Listable = fN_Listable.Replace(" ❯ ", "");
                    }

                    SelectedFiles.Items.Add(fN_Listable);
                }

                CommmonActions.PrepareforCompact();
                UnfurlTransition.UnfurlControl(topbar_dirchooserContainer, topbar_dirchooserContainer.Width, Width - ActivityPanel.Width - 46, 100);
                WikiHandler.LocalFolderParse(DI_selectedDir, oldFolderSize_Formatted);
                {
                    Label withBlock = topbar_title;
                    withBlock.Anchor -= (int)AnchorStyles.Right;
                    withBlock.AutoSize = true;
                    withBlock.TextAlign = ContentAlignment.MiddleLeft;
                    withBlock.Font = new Font(topbar_title.Font.Name, 15.75F, FontStyle.Regular);
                    withBlock.Location = new Point(39, 20);
                }
            }
            else if (senderID.Contains("button"))
            {
                _ = MessageBox.Show(Resources.StrNotSelected);
                Console.Write(Resources.StrNotSelected);
            }
        }

        private void GetFilesToCompress(string targetDirectory, List<string> targetOutputList, bool LimitSelectedFiles)
        {
            var NonCompressableSet = new List<string>(Regex.Replace(My.Settings.Default.NonCompressableList, @"\s+", "").Split(';'));
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
            ConsoleOutput.Items.Clear();
            CalculateSaving();
        }

        private void BtnCompDecomp_Click(object sender, EventArgs e)
        {
            ConsoleOutput.Items.Clear();
            SetWorkingList(new List<string>(ListOfFiles));
            if (!isCompressed)
            {
                if (Convert.ToBoolean(GetWorkingList().Count > 0))
                {
                    CreateProcess(ActionMode.Compact);
                }
                else
                {
                    MessageBox.Show(Resources.StrCantComp);
                }
            }
            else
            {
                if (Convert.ToBoolean(GetWorkingList().Count > 0))
                {
                    CreateProcess(ActionMode.UnCompact);
                }
                else
                {
                    MessageBox.Show(Resources.StrCantComp);
                }
            }
        }

        private void BtnUncompress_Click(object sender, EventArgs e)             // Handles uncompressing. For now, uncompressing can only be done through the program only to revert a compression that's just been done.
        {
            CommmonActions.ActionBegun(ActionMode.UnCompact);
            FileIndex = 0;
            SetWorkingList(new List<string>(AllFiles));
            RunCompact(Convert.ToString(GetWorkingList()[0], Compact.culture), ActionMode.UnCompact);
        }

        private void OutputBufferDelegate()
        {
            if (Math.Round(Convert.ToDouble(intervaltime) + 0.1, 2) < Math.Round(DateTime.Now.TimeOfDay.TotalSeconds, 2))      // Buffers incoming strings, then outputs them to the listbox every 0.1s
            {
                base.Invoke(new Action(() =>
                {
                    ConsoleOutput.BeginUpdate();
                    foreach (string str in outputbuffer)
                    {
                        AppendOutputText(str);
                    }

                    outputbuffer.Clear();
                    intervaltime = Convert.ToDecimal(DateTime.Now.TimeOfDay.TotalSeconds);
                    ConsoleOutput.EndUpdate();
                }));
            }
        }

        // TODO: correctly determine compressing & decompressing
        private void ProcessExited(object sender, EventArgs e)
        {
            OutputBufferDelegate();
            FileIndex += 1;
            if (!Convert.ToBoolean(FileIndex < GetWorkingList().Count & GetWorkingList().Count > 1))
            {
                Console.WriteLine(Resources.StrDone);
                System.Threading.Thread.Sleep(100);
                outputbuffer.Add("Completed:" + "\t" + "Processed " + ListOfFiles.Count + " files");
                foreach (string str in outputbuffer)
                {
                    AppendOutputText(str);
                }

                outputbuffer.Clear();
                FileIndex = 0;
                if (Compact.isCompressed) base.Invoke(new Action(() => CompactProcessCompleted(ActionMode.Compact)));
                else base.Invoke(new Action(() => CompactProcessCompleted(ActionMode.UnCompact)));
            }
            else
            {
                if (GetWorkingList()[FileIndex].ToString(Compact.culture).Contains(workingDir))
                {
                    outputbuffer.Add("Compressing: " + "\t" + GetWorkingList()[FileIndex]);
                    RunCompact(Convert.ToString(GetWorkingList()[FileIndex], Compact.culture), ActionMode.Compact);
                }
                else
                {
                    MessageBox.Show("A file that is not contained within your selected folder has been queued for compression. To prevent damage to your system, the program will halt." + Environment.NewLine + "The file in question is: " + GetWorkingList()[FileIndex]);
                    IsActive = false;
                    base.Invoke(new Action(() => Close()));
                }
            }
        }

        private void AppendOutputText(string text)                                           // Attach output to the embedded console
        {
            _ = base.Invoke(new Action(() =>
              {
                  ConsoleOutput.Items.Insert(0, text);
                  ActivityProgressBar.Width = Convert.ToInt32(FileIndex / GetWorkingList().Count * 301);
                  lblProgressPercent.Text = Convert.ToString(Math.Round((double)(FileIndex / GetWorkingList().Count * 100), 0) + "%", Compact.culture);
              }));
        }

        //TODO: fix this
        private void CompactProcessCompleted(ActionMode CurrentMode)
        {
            if (CurrentMode.Equals(ActionMode.Compact))
            {
                CommmonActions.ActionCompleted(ActionMode.Compact);
                CalculateSaving();
            }
            else if (CurrentMode.Equals(ActionMode.UnCompact))
            {
                CommmonActions.ActionCompleted(ActionMode.UnCompact);
                CompSizeBar.Height = 113;
                wkPostSizeVal.Text = Resources.StrQuestion;
                wkPostSizeUnit.Text = "";
            }

            if (checkShutdownOnCompletion.Checked & !IsQueryMode)
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
            if (IsActive == true)
            {
                if (MessageBox.Show(Resources.StrWarnClose, Resources.StrWarning, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) != DialogResult.Yes)

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
            CommmonActions.ActionBegun(ActionMode.Analyze);
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

            ConsoleOutput.Items.Insert(0, "File" + new String(Convert.ToChar(" ", Compact.culture), conOutFileNamePadding - 4) + "\t" + "Size" + new String(Convert.ToChar(" ", Compact.culture), 16) + "Size on Disk");
            ConsoleOutput.Items.Insert(1, "");
            var AnalyzedPoorlyCompressedFiles = new List<string>();
            foreach (string fpath in AllFiles)
            {
                Application.DoEvents();
                ulong compval = Convert.ToUInt64(GetFileSizeOnDisk(fpath));
                ulong rawval = Convert.ToUInt64(new FileInfo(fpath).Length);
                if (rawval > FourGB)
                {
                    int Mod4K = (int)(Convert.ToInt64(rawval) / FourGB);
                    if (compval < 1.1 * Convert.ToDouble(rawval - Mod4K * FourGB))   // Checks if the compressed file is smaller than the adjustment consideration @ 4GB (with a 10% leeway)
                    {
                        compval = Convert.ToUInt64(Mod4K * FourGB + compval);
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

                string fpath_Output = fpath + new String(Convert.ToChar(" ", Compact.culture), conOutFileNamePadding - fpath.Length);
                string compval_fmt = GetOutputSize(Convert.ToInt64(compval), true);
                string rawval_fmt = GetOutputSize(Convert.ToInt64(rawval), true);
                outputbuffer.Add(fpath_Output + "\t" + "Size: " + rawval_fmt + new String(Convert.ToChar(" ", Compact.culture), 14 - rawval_fmt.Length) + "Size on Disk: " + compval_fmt);
                if (Math.Round(Convert.ToDouble(intervaltime) + 0.2, 2) < Math.Round(DateTime.Now.TimeOfDay.TotalSeconds, 2))      // Buffers incoming strings, then outputs them to the listbox every 0.1s
                {
                    base.Invoke(new Action(() =>
                    {
                        ConsoleOutput.BeginUpdate();
                        foreach (string str in outputbuffer)
                        {
                            ConsoleOutput.Items.Insert(2, str);
                        }

                        outputbuffer.Clear();
                        intervaltime = Convert.ToDecimal(DateTime.Now.TimeOfDay.TotalSeconds);
                        ConsoleOutput.EndUpdate();
                    }));
                }

                TreeData.Add(fpath + "|" + rawval + "|" + compval);
                SizeAfterCompression += compval;
                progressVal += 1 / (AllFiles.Count * 100);
                ActivityProgressBar.Width = (int)(Convert.ToDouble(progressVal) * 3.01);
                lblProgressPercent.Text = Math.Round(progressVal, 0) + "%";
            }

            foreach (string str in outputbuffer)
            {
                ConsoleOutput.Items.Insert(2, str);
            }

            IEnumerable<IGrouping<string, string>> groups = AnalyzedPoorlyCompressedFiles.GroupBy(value => value);
            Console.WriteLine(Resources.StrLblPoorlyComp);
            foreach (IGrouping<string, string> grp in groups)
            {
                Console.WriteLine("\t" + grp.ElementAtOrDefault(0) + ": " + grp.Count() + "/" + AllFiles.Where(value => (new FileInfo(value).Extension ?? "") == (grp.ElementAtOrDefault(0) ?? "")).Count());
            }

            newFolderSize = SizeAfterCompression;
            if (Convert.ToInt64(SizeBeforeCompression) - Convert.ToInt64(SizeAfterCompression) < 0 & IsQueryMode == true) // Checks if the Folder is NOT compressed
            {
                CommmonActions.ActionCompleted(ActionMode.Analyze, false);
            }
            else
            {
                origSizeLabel.Text = GetOutputSize(Convert.ToInt64(SizeBeforeCompression), true);
                string PrintOutSize = GetOutputSize(Convert.ToInt64(SizeBeforeCompression) - (Convert.ToInt64(SizeBeforeCompression) - Convert.ToInt64(SizeAfterCompression)), true);
                compressedSizeLabel.Text = PrintOutSize;
                wkPostSizeVal.Text = PrintOutSize.Split(' ')[0]; // SPLITTING ON A SPACE COULD LEAD TO FORMATTING BUGS WITH CULTURES
                wkPostSizeUnit.Text = PrintOutSize.Split(' ')[1];
                Size wkPostSizeVal_Len = TextRenderer.MeasureText(wkPostSizeVal.Text, wkPostSizeVal.Font);
                wkPostSizeUnit.Location = new Point(wkPostSizeVal.Location.X + wkPostSizeVal.Size.Width / 2 + (wkPostSizeVal_Len.Width / 2 - 8), wkPostSizeVal.Location.Y + 16);
                double compRatio = Math.Round((double)(SizeBeforeCompression / SizeAfterCompression), 1);
                spaceSavedLabel.Text = GetOutputSize(Convert.ToInt64(SizeBeforeCompression - SizeAfterCompression), true) + " Saved";
                ResultsCompressedBar.Text = numberFilesCompressed + " / " + AllFiles.Count + " files compressed";
                helpResultsFilesCompressed.Location = new Point(ResultsCompressedBar.Location.X + ResultsCompressedBar.Width + 2, ResultsCompressedBar.Location.Y + 1);
                try
                {
                    ResultsCompressedBar.Width = Convert.ToInt32(320 / compRatio);
                    CompSizeBar.Height = Convert.ToInt32(113 / compRatio);
                    CompSizeBar.Location = new Point(CompSizeBar.Location.X, 5 + 113 - CompSizeBar.Height);
                    Callpercent = Convert.ToDecimal(1 - (SizeAfterCompression / SizeBeforeCompression)) * 100;
                    if (My.Settings.Default.ShowNotifications)
                    {
                        TrayIcon.ShowBalloonTip(1, "Compressed: " + lblFolderName.Text, Environment.NewLine + "▸ " + spaceSavedLabel.Text + Environment.NewLine + "▸ " + Math.Round(Callpercent, 1) + "% Smaller", ToolTipIcon.None);
                    }
                }
                catch (OverflowException)
                {
                    ResultsCompressedBar.Width = 320;
                    CompSizeBar.Height = 113;
                }

                outputbuffer.Clear();
                CommmonActions.ActionCompleted(ActionMode.Analyze, true);
                Callpercent = Convert.ToDecimal(1 - (SizeAfterCompression / SizeBeforeCompression)) * 100;
                PaintPercentageTransition.PaintTarget(ResultsArc, (float)Callpercent, 5);
            }

            IsQueryMode = false;
        }

        public static decimal GetFileSizeOnDisk(string file)
        {
            var info = new FileInfo(file);
            ulong blockSize = 0;
            uint clusterSize;
            var searcher = new ManagementObjectSearcher("select BlockSize,NumberOfBlocks from Win32_Volume WHERE DriveLetter = '" + info.Directory.Root.FullName.TrimEnd('\\') + "'");
            foreach (ManagementObject vi in searcher.Get())
            {
                blockSize = Convert.ToUInt64(vi["BlockSize"], Compact.culture);
                break;
            }

            searcher.Dispose();
            clusterSize = Convert.ToUInt32(blockSize, Compact.culture);
            uint losize = NativeMethods.GetCompressedFileSizeW(file, lpFileSizeHigh: out uint hosize);
            long size = Convert.ToInt64(hosize) << 32 | losize;
            decimal bytes = ((size
                                       + clusterSize
                                       - 1) / clusterSize * clusterSize);
            return Convert.ToDecimal(bytes);
        }

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
                return (Math.Sign(byteCount) * num).ToString(Compact.culture) + suf[place];
            }
            else
            {
                return (Math.Sign(byteCount) * num).ToString(Compact.culture);
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
                //TODO: make sure this is the right comparison
                if (DirectorysizeexceptionCount == 1)
                {
                    OverrideCompressFolderButton = 1;
                    DirectorysizeexceptionCount += 1;
                    if (My.MyProject.User.IsInRole(Microsoft.VisualBasic.ApplicationServices.BuiltInRole.Administrator) == false)
                    {
                        ThrowError(Errors.ERR_UNAUTHORISEDREQUIRESADMIN);
                    }
                    else
                    {
                        ThrowError(Errors.ERR_UNAUTHORISEDREQUIRESSYSTEM);
                    }
                }
            }

            return default;
        }

        // ////////////////////TESTING////////////////////

        private void Saveconlog_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Resources.StrSaveConsoleOutput, null, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var reverseCon = new ArrayList();
                var sb = new StringBuilder();
                foreach (string ln in ConsoleOutput.Items)
                {
                    reverseCon.Add(ln.Trim());
                }

                reverseCon.Reverse();
                sb.AppendLine("CompactGUI: Log at " + DateTime.Now + Environment.NewLine + new String(Convert.ToChar("/", Compact.culture), 50));
                foreach (string ln in reverseCon)
                {
                    sb.AppendLine(ln);
                }

                sb.AppendLine("End Log at " + DateTime.Now + Environment.NewLine + new String(Convert.ToChar("/", Compact.culture), 100) + Environment.NewLine + Environment.NewLine);
                File.AppendAllText(Application.StartupPath + @"\CompactGUILog.txt", sb.ToString(), Encoding.UTF8);
                MessageBox.Show("Saved log to " + Application.StartupPath + @"\CompactGUILog.txt");
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

        private void Compress_CheckedChanged(object sender, EventArgs e)
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
            switch (My.Settings.Default.SavedCompressionOption)
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

        private void MoveForm()
        {
            NativeMethods.ReleaseCapture();
            _ = NativeMethods.SendMessage(Handle, 0xA1, 2, 0);
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

        private void ButtonCompress_Paint(object sender, PaintEventArgs e)
        {
            using var btn = (Button)sender;
            using var solidBrush = new SolidBrush(btn.ForeColor);
            using var sf = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            using var drawBrush = solidBrush;
            e.Graphics.DrawString("Compress Folder", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        private void Sb_AnalysisPanel_Paint(object sender, PaintEventArgs e)
        {
            using var p = new Pen(Brushes.DimGray, 1);
            e.Graphics.DrawLine(p, new Point(30, 0), new Point(303, 0));
        }

        private void Sb_ResultsPanel_Paint(object sender, PaintEventArgs e)
        {
            using var dotted = new Pen(Brushes.ForestGreen, 1)
            {
                DashPattern = new float[] { 3, 3, 3, 3 }
            };
            e.Graphics.DrawRectangle(dotted, 225, 5, 39, 112);
            dotted.Dispose();
        }

        private static decimal Callpercent;

        internal void ResultsArcPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            DrawProgress(e.Graphics, new Rectangle(21, 21, 203, 203), Convert.ToDecimal(PaintPercentageTransition.Callpercentstep), ColorTranslator.FromHtml("#3B668E"), ColorTranslator.FromHtml("#CFD8DC"));
        }

        private void DrawProgress(Graphics g, Rectangle rect, decimal percentage, Color percColor, Color remColor)
        {
            decimal progressAngle = (183 / 100 * (percentage));
            // var remainderAngle = (185 * percentage / Callpercent) - progressAngle;
            using var progressPen = new Pen(percColor, 41);
            using var remainderPen = new Pen(remColor, 41);
            using var fnt = new Font("Segoe UI Light", 22);
            using var fnt2 = new Font("Segoe UI Light", 9);
            using var fnt3 = new Font("Segoe UI Light", 10);
            using var fb = new SolidBrush(Color.FromArgb(48, 67, 84));
            g.DrawArc(remainderPen, rect, (float)progressAngle - 184, (float)((percentage / Callpercent) - progressAngle));
            g.DrawArc(progressPen, rect, -183, (float)progressAngle);
            string perc = Math.Round(percentage, 0).ToString(Compact.culture);
            var percSize = g.MeasureString(perc, fnt);
            var percPoint = new Point((int)(rect.Left + (rect.Width / 2) - (percSize.Width / 2)), (int)(rect.Top + (rect.Height / 2) - (percSize.Height * 1.25)));
            g.DrawString(perc, fnt, fb, percPoint);
            string sign = "%";
            var signPoint = new Point((int)(percPoint.X + percSize.Width - 5), percPoint.Y + 10);
            g.DrawString(sign, fnt2, fb, signPoint);
            var lblSize = g.MeasureString(Resources.StrLblSizeReduction, fnt3);
            var lblPoint = new Point((int)(rect.Left + (rect.Width / 2) - (lblSize.Width / 2)), (int)(rect.Top + (rect.Height / 2) - (lblSize.Height * 0.75)));
            g.DrawString(Resources.StrLblSizeReduction, fnt3, fb, lblPoint);
        }

        private void CompResultsPanel_Paint(object sender, PaintEventArgs e)
        {
            using var p = new Pen(Brushes.Silver, 1);
            e.Graphics.DrawLine(p, new Point(12, CompResultsPanel.Height - 1), new Point(ConsolePanel.Width - 12, CompResultsPanel.Height - 1));
        }

        private void UpdateBanner_Paint(object sender, PaintEventArgs e)
        {
            int x = updateBanner.Width;
            int y = updateBanner.Height;
            using var brush = new SolidBrush(Color.FromArgb(255, 47, 66, 83));
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
            using var p = new Pen(Brushes.Silver, 1);
            e.Graphics.DrawLine(p, new Point(15, 0), new Point(FilesPanel.Width, 0));
        }

        private void DirChooser_MouseEnter(object sender, EventArgs e)
        {
            dirChooser.LinkColor = Color.FromArgb(200, 200, 200);
        }

        private void DirChooser_MouseLeave(object sender, EventArgs e)
        {
            dirChooser.LinkColor = Color.White;
        }

        private void Seecompest_MouseHover(object sender, EventArgs e)
        {
            topbar_title.Select();
            WikiHandler.ShowWikiRes();
            isAlreadyFading = false;
        }

        private void HideWikiRes(object sender, EventArgs e)
        {
            if (isAlreadyFading == false)
            {
                FadeTransition.FadeForm(My.MyProject.Forms.WikiPopup, Convert.ToDouble(0.96M), 0, 200);
                isAlreadyFading = true;
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

        private void Sb_lblKnownIssues_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/ImminentFate/CompactGUI/wiki/Compression-Results:-Games");
        }

        private void DirChooser_DragDrop(object sender, DragEventArgs e)
        {
            object dropVar = e.Data.GetData(DataFormats.FileDrop);
            if (IsActive == false & IsQueryMode == false)
            {
                SelectFolder(Convert.ToString(dropVar, Compact.culture), "button");
            }
        }

        private void DirChooser_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                object dropVar = e.Data.GetData(DataFormats.FileDrop);
                if (Directory.Exists(Convert.ToString(dropVar, Compact.culture)))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else if (File.Exists(Convert.ToString(dropVar, Compact.culture)))
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

        private void ThrowError(Errors error)
        {
            switch (error)
            {
                case Errors.ERR_WHOLEDRIVENOTALLOWED: MessageBox.Show(Resources.StrProhibitDrive); return;
                case Errors.ERR_WINDOWSDIRNOTALLOWED: MessageBox.Show(Resources.StrProhibitWindows); return;
                case Errors.ERR_UNAUTHORISEDREQUIRESADMIN: AskRunAdmin(); return;
                case Errors.ERR_UNAUTHORISEDREQUIRESSYSTEM: MessageBox.Show("This directory contains a subfolder that you do not have permission To access." + Environment.NewLine + Environment.NewLine + "The subfolder is most likely protected by the System, and by design this program will refuse to let you proceed."); return;
            };
        }

        private void AskRunAdmin()
        {
            if (MessageBox.Show(Resources.StrAskForAdmin, Resources.StrErrorPerm, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                RCMenu.RunAsAdmin();
                Close();
            }
        }

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