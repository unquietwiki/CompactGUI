using System;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

#nullable enable

namespace CompactGUI
{
    public partial class Compact
    {
        public Compact() => InitializeComponent();

        private Encoding? CP;

        private void CreateProcess(ActionMode TargetMode)
        {
            if (CP is null)
            {
                CP = GetEncoding();
            }

            RunCompact(Convert.ToString(GetWorkingList()[0], Compact.culture));
            outputbuffer.Add("Compressing: " + "\t" + GetWorkingList()[0]);
            CommmonActions.ActionBegun(TargetMode);
        }

        private string? compactArgs;

        private void RunCompact(string desiredFile)
        {
            if (CurrentMode.Equals(ActionMode.Compact))
            {
                compactArgs = "/C /I";

                // If checkRecursiveScan.Checked = True Then compactArgs &= " /S"
                if (checkForceCompression.Checked == true)
                {
                    compactArgs += " /F";
                }

                if (checkHiddenFiles.Checked == true)
                {
                    compactArgs += " /A";
                }

                if (compressX4.Checked == true)
                {
                    compactArgs += " /EXE:XPRESS4K";
                }

                if (compressX8.Checked == true)
                {
                    compactArgs += " /EXE:XPRESS8K";
                }

                if (compressX16.Checked == true)
                {
                    compactArgs += " /EXE:XPRESS16K";
                }

                if (compressLZX.Checked == true)
                {
                    compactArgs += " /EXE:LZX";
                }

                RunCompact_ProcessGen(compactArgs, desiredFile);
            }
            else if (CurrentMode.Equals(ActionMode.UnCompact))
            {
                outputbuffer.Add("Uncompressing: " + "\t" + desiredFile);
                compactArgs = "/U /EXE /I";
                if (checkForceCompression.Checked == true)
                {
                    compactArgs += " /F";
                }

                if (checkHiddenFiles.Checked == true)
                {
                    compactArgs += " /A";
                }

                RunCompact_ProcessGen(compactArgs, desiredFile);
            }
        }

        private void RunCompact_ProcessGen(string passthroughArgs, string fileTarget)
        {
            MyProcess = new Process();
            {
                ProcessStartInfo withBlock = MyProcess.StartInfo;
                withBlock.FileName = "compact.exe";
                withBlock.WorkingDirectory = workingDir;
                withBlock.Arguments = passthroughArgs + " " + "\"" + fileTarget + "\"";
                withBlock.StandardOutputEncoding = CP;
                withBlock.StandardErrorEncoding = CP;
                withBlock.UseShellExecute = false;
                withBlock.CreateNoWindow = true;
                withBlock.RedirectStandardInput = true;
                withBlock.RedirectStandardOutput = true;
                withBlock.RedirectStandardError = true;
            }

            MyProcess.Start();
            MyProcess.PriorityClass = ProcessPriorityClass.BelowNormal;
            MyProcess.EnableRaisingEvents = true;
            MyProcess.BeginErrorReadLine();
            MyProcess.BeginOutputReadLine();
        }

        private Encoding GetEncoding()
        {
            using var CPGet = new Process();
            ProcessStartInfo withBlock = CPGet.StartInfo;
            withBlock.FileName = "cmd.exe";
            withBlock.Arguments = "/c chcp";
            withBlock.UseShellExecute = false;
            withBlock.CreateNoWindow = true;
            withBlock.StandardOutputEncoding = Encoding.Default;
            withBlock.StandardErrorEncoding = Encoding.Default;
            withBlock.WorkingDirectory = workingDir;
            withBlock.RedirectStandardInput = true;
            withBlock.RedirectStandardOutput = true;
            withBlock.RedirectStandardError = true;
            CPGet.Start();
            var Res = CPGet.StandardOutput.ReadLine();
            var CPa = int.Parse(Regex.Replace(Res, @"[^\d]", ""), Compact.culture);
            CPGet.StandardInput.WriteLine("exit");
            CPGet.StandardInput.Flush();
            CPGet.WaitForExit();
            return Encoding.GetEncoding(CPa);
        }
    }
}