using System;
using System.IO;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Security.Principal;

namespace arescrypt
{
    class FileHandler
    {
        public static string sessionDomain = Environment.UserDomainName; // get current sessions domain
        public static string sessionUsername = Environment.UserName; // get current sessions username

        // Recursivly list files in a given directory
        public static List<string> DirSearch(string sDir)
        {
            var fileIndex = new List<string> { };
            try
            {
                foreach (string dir in Directory.GetDirectories(sDir))
                {
                    foreach (string file in Directory.GetFiles(dir))
                        fileIndex.Add(file);
                    // Search subdirectories
                    DirSearch(dir);
                }
            }
            catch (Exception)
            { }

            return fileIndex;
        }
    }
}
