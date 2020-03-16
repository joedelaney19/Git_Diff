using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Git_Diff
{
    class Command
    {
        // Method to take two file names as strings and compare them
        public string Diff(string file1, string file2, string path)
        {
            string file1_path = path + @"\" + file1;
            string file2_path = path + @"\" + file2;
            try
            {
                // Attempt to read all lines in files into separate string arrays
                string[] lines1 = System.IO.File.ReadAllLines(file1_path);
                string[] lines2 = System.IO.File.ReadAllLines(file2_path);

                // Check arrays have same number of lines
                if (lines1.Length == lines2.Length)
                {
                    // Compare each line in each file to each other
                    for (int i = 0; i < lines1.Length; i++)
                    {
                        if (lines1[i] != lines2[i])
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            return $"{file1} and {file2} are different";
                        }
                    }
                    // Files are only verified as being the same if this for loop successfully exits 
                    Console.ForegroundColor = ConsoleColor.Green;
                    return $"{file1} and {file2} are not different";
                }
                // If arrays do not have same length
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    return $"{file1} and {file2} are different";
                }
            }
            catch (FileNotFoundException)
            {
                return "Error: Specified files not found (did you enter the right path?)";
            }
        }
    }
}
