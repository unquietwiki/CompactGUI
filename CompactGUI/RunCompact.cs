using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace CompactGUI
{
    public partial class Compact
    {
        public Compact()
        {
            InitializeComponent();
        }

        private Encoding CP;

        private void CreateProcess(string TargetMode)
        {
            if (CP is null)
            {
                CP = GetEncoding();
            }

            RunCompact(Conversions.ToString(GetWorkingList()[0]));
            outputbuffer.Add("Compressing: " + Constants.vbTab + GetWorkingList()[0]);
            CommmonActions.ActionBegun(TargetMode);
        }

        private string compactArgs;

        private void RunCompact(string desiredFile)
        {
            if ((CurrentMode1 ?? "") == "compact")
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
            else if ((CurrentMode1 ?? "") == "uncompact")
            {
                outputbuffer.Add("Uncompressing: " + Constants.vbTab + desiredFile);
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
            using Process CPGet = new Process();
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
            string Res = CPGet.StandardOutput.ReadLine();
            int CPa = int.Parse(Regex.Replace(Res, @"[^\d]", ""));
            CPGet.StandardInput.WriteLine("exit");
            CPGet.StandardInput.Flush();
            CPGet.WaitForExit();
            return Encoding.GetEncoding(CPa);
        }
    }
}