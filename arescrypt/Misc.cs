using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace arescrypt
{
    class Misc
    {
        // Concatenates 2 List<string> arrays, then converts to string[] array.
        public static List<string> concatList(List<string> List1, List<string> List2)
        {
            var fullIndex = new List<string> { };
            foreach (string element in List1)
                fullIndex.Add(element);
            foreach (string element in List2)
                fullIndex.Add(element);
            return fullIndex;
        }
        
        public static void HideWindow()
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_SHOW = 1;
        const int SW_HIDE = 0;
    }
}
