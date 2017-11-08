using System;
using System.Collections.Generic;

namespace arescrypt
{
    class Misc
    {
        // Concatenates 2 List<string> arrays, then converts to string[] array.
        public static List<string> concatList(List<string> List1, List<string> List2)
        {
            var fullIndex = new List<string> { };
            foreach (string element in List1)
                fullIndex.Add(element);
            foreach (string element in List2)
                fullIndex.Add(element);
            return fullIndex;
        }

        // Converts List<string> to string
    }
}
