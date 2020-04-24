using System;
using System.Runtime.InteropServices;

namespace CompactGUI
{
    internal static class NativeMethods
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("kernel32.dll")]
        public static extern uint GetCompressedFileSizeW([In()][MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.U4)] out uint lpFileSizeHigh);
    }
}