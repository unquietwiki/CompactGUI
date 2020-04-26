using CompactGUI.My.Resources;
using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

#nullable enable

namespace CompactGUI
{
    public class FileFolderDialog : CommonDialog
    {
        public OpenFileDialog Dg { get; set; } = new OpenFileDialog();

        public new DialogResult ShowDialog() => ShowDialog(Compact.ActiveForm);

        public new DialogResult ShowDialog(IWin32Window owner)
        {
            if (owner != null)
            {
                OpenFileDialog withBlock = Dg;
                withBlock.ValidateNames = false;
                withBlock.CheckFileExists = false;
                withBlock.CheckPathExists = true;
                withBlock.Multiselect = true;
                withBlock.FileName = "#Folder";
                withBlock.Title = Resources.StrSelectFiles;
                withBlock.Filter = Resources.StrFileDialogFilter;
            }
            return Dg.ShowDialog(owner ?? null);
        }

        public string SelectedPath
        {
            get
            {
                if (Dg.FileName.EndsWith("#Folder", StringComparison.CurrentCultureIgnoreCase))
                {
                    return Path.GetDirectoryName(Dg.FileName);
                }
                else if (File.Exists(Dg.FileName) == true)
                {
                    return Dg.FileName;
                }
                else
                {
                    return Path.GetDirectoryName(Dg.FileName);
                }
            }

            set
            {
                if (value is object && !string.IsNullOrEmpty(value))
                {
                    Dg.FileName = value;
                }
            }
        }

        public ArrayList? MultipleFiles
        {
            get
            {
                if (Dg.FileNames is object && Dg.FileNames.Length > 1)
                {
                    var sb = new ArrayList();
                    foreach (string fileName in Dg.FileNames)
                    {
                        if (File.Exists(fileName))
                        {
                            sb.Add(fileName);
                        }
                    }

                    return sb;
                }
                else
                {
                    return null;
                }
            }
        }

        public override void Reset()
        {
            Dg.Reset();
        }

        protected override bool RunDialog(IntPtr hwndOwner)
        {
            return true;
        }
    }

    public class GraphicsPanel : Panel
    {
        private const int WS_EX_COMPOSITED = 0x2000000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_COMPOSITED;
                return cp;
            }
        }

        public GraphicsPanel() => DoubleBuffered = true;
    }
}