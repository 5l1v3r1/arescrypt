using System;
using System.Collections.Generic;

namespace arescrypt
{
    class Misc
    {
        // Concatenates 2 List<string> arrays, then converts to string[] array.
        public static string[] concatList(List<string> list1, List<string> list2)
        {
            string filesBeforeSplit = default(string);
            
            foreach (string dir in list1) // dirsToEncrypt.Distinct().ToList())
            {
                List<string> fileIndex = FileHandler.DirSearch(dir);
                foreach (string file in fileIndex)
                    filesBeforeSplit += ", " + file; // Concatenate the string
            }
            foreach (string dir in list2)
            {
                List<string> fileIndex = FileHandler.DirSearch(dir);
                foreach (string file in fileIndex)
                    filesBeforeSplit += ", " + file; // Concatenate the string
            }

            string[] fullFileIndex = filesBeforeSplit.Split(", ".ToCharArray());
            return fullFileIndex;
        }
    }
}
