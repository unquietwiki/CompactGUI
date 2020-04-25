using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Diagnostics;
using System.Windows.Forms;

namespace CompactGUI
{
    public partial class Compact
    {
        // ========== Common Variables ==========

        internal enum ActionMode
        {
            Compact,
            UnCompact,
            Analyze
        }

        // 515-518
        internal enum Errors
        {
            ERR_WINDOWSDIRNOTALLOWED,
            ERR_WHOLEDRIVENOTALLOWED,
            ERR_UNAUTHORISEDREQUIRESADMIN,
            ERR_UNAUTHORISEDREQUIRESSYSTEM
        }

        private static object version = "3.0.0";
        static internal CultureInfo culture = CultureInfo.CurrentCulture;
        private bool isMaximised = false;
        private bool isAlreadyFading = false;
        public Process MyProcess1 { get; set; }
        internal ActionMode CurrentMode { get; set; }
        internal object OverrideCompressFolderButton { get; set; } = 0;
        internal int DirectorysizeexceptionCount { get; set; } = 0;
        internal static object Version { get => version; set => version = value; }
        private List<string> workingList = new List<string>();
        internal List<string> ListOfFiles { get; } = new List<string>();
        internal List<string> AllFiles { get; } = new List<string>();
        internal List<string> TreeData { get; } = new List<string>();
        internal bool IsQueryMode = false;
        internal bool IsActive = false;
        private decimal intervaltime;
        private readonly ArrayList outputbuffer = new ArrayList();
        private ulong newFolderSize;
        private ulong oldFolderSize;
        internal string workingDir = "";

    }
}