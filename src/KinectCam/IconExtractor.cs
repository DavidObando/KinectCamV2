namespace KinectCam
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Runtime.InteropServices;

    public class IconExtractor
    {

        public static Icon Extract(int number, bool largeIcon)
        {
            IntPtr large;
            IntPtr small;
            var file = Path.Combine(Environment.SystemDirectory, "shell32.dll");
            ExtractIconEx(file, number, out large, out small, 1);
            try
            {
                return Icon.FromHandle(largeIcon ? large : small);
            }
            catch
            {
                return null;
            }

        }
        [DllImport("Shell32.dll", EntryPoint = "ExtractIconExW", CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        private static extern int ExtractIconEx(string sFile, int iIndex, out IntPtr piLargeVersion, out IntPtr piSmallVersion, int amountIcons);

    }
}
