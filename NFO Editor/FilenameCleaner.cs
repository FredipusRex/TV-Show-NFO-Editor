using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NFOApplication
{
    /// <summary>
    /// Cleans file and path names by removing or replacing characters that are not allowed in Windows file and path names.
    /// 
    /// "clean" tends to replace problematic characters with a space or specific replacement character. "scrub" simply removes
    /// the problematic characters.
    /// </summary>
    public class FilenameCleaner
    {
        #region Invalid Character Properties

        private readonly static char[] invalidPathChars;
        private readonly static char[] invalidFileNameChars;

        public static char[] InvalidPathChars { get { return invalidPathChars; } }
        public static char[] InvalidFileNameChars { get { return invalidFileNameChars; } }

        // Static constructor for populating the invalid character properties
        static FilenameCleaner()
        {
            invalidFileNameChars = System.IO.Path.GetInvalidFileNameChars();
            invalidPathChars = System.IO.Path.GetInvalidPathChars();

            // We'll use a binary search later for speed, so sort the invalid characters
            Array.Sort(invalidFileNameChars);
            Array.Sort(invalidPathChars);
        }

        #endregion

        #region Path and Filename Cleaners and Scrubbers

        // Replace any invalid characters with blanks
        public static string cleanPath(string path)
        {
            return clean(path, InvalidPathChars, ' ');
        }

        // Remove any invalid characters
        public static string scrubPath(string path)
        {
            return clean(path, InvalidPathChars, (char) 0);
        }

        // Replace ':' with '-', get rid of any other bad characters
        public static string cleanFilename(string filename)
        {
            return clean(filename.Replace(':', '-'), InvalidFileNameChars, (char) 0);
        }

        // Simply remove the invalid characters
        public static string scrubFilename(string filename)
        {
            return clean(filename, InvalidFileNameChars, (char)0);
        }

        #endregion

        // Does the actual cleaning/scrubbing
        private static string clean(string str, char[] invalidChars, char replaceChar)
        {
            if (str == null)
                return String.Empty;

            StringBuilder result = new StringBuilder();

            // Iterate over all the characters in the string 
            foreach (var ch in str)
            {
                // See if it's invalid
                if (Array.BinarySearch(invalidChars, ch) >= 0)
                {
                    // If it is, see if we replace or remove
                    if (replaceChar != 0)
                        result.Append(replaceChar);
                }
                else
                    result.Append(ch);
            }

            return result.ToString();
        }
    }
}
