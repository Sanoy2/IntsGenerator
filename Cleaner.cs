using System;
using System.IO;

namespace IntsGenerator
{
    public static class Cleaner
    {
        public static void CleanFilesInDirectory(string pathToDirectory)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(pathToDirectory);

            foreach (var file in directoryInfo.GetFiles())
            {
                file.Delete();
            }
        }

        public static void CleanEverythingUnderDirectory(string pathToDirectory)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(pathToDirectory);

            CleanFilesInDirectory(pathToDirectory);

            foreach (var directory in directoryInfo.GetDirectories())
            {
                try
                {
                    CleanEverythingUnderDirectory(directory.FullName + "/");
                    directory.Delete();
                }
                catch(Exception e)
                {
                    System.Console.WriteLine($"Couldn't remove directory {directory.FullName}");
                    System.Console.WriteLine(e.Message);
                    System.Console.WriteLine(e.StackTrace);
                }
            }
        }
    }
}