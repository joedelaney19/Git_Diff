using System;
using System.IO;

namespace Git_Diff
{
    class Program
    {
        static void Main(string[] args)
        {
            Command c = new Command();
            Console.WriteLine(@"Enter path of files (both files must be in same path, do not including trailing \): ");
            string path = Console.ReadLine();

            // Note that the .txt extention must be included when entering file names
            Console.WriteLine("Enter file name 1: ");
            string file1 = Console.ReadLine();
            Console.WriteLine("Enter file name 2: ");
            string file2 = Console.ReadLine();

            Console.WriteLine("\n" + c.Diff(file1, file2, path));
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadLine();
        }
    }
}
