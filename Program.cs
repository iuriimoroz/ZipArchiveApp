using System;
using System.IO.Compression;

namespace ZipArchiveApp
{
    class Program
    {
        static void Main()
        {
            string startPath;
            string zipPath;

            Console.WriteLine("Input a directory path to make a zip archive of the directory and press [Enter] button:");
            startPath = Console.ReadLine();
            Console.WriteLine("Input a directory path where your zip archive will be stored with an archive name in the end of the path string and press [Enter] button:");
            zipPath = Console.ReadLine();

            try
            {
                ZipFile.CreateFromDirectory(startPath, zipPath);
                Console.WriteLine($"Zip archive successfully created. The path to zip file is {zipPath}");
                Console.WriteLine("Press any key to close the screen...");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Something went wrong. Try again.");
                Main();
            }
        }
    }
}
