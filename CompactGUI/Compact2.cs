using System.Globalization;

namespace CompactGUI
{
    public partial class Compact
    {
        internal enum ActionMode
        {
            Compact,
            UnCompact,
            Analyze
        }

        static internal CultureInfo culture = CultureInfo.CurrentCulture;
    }
}