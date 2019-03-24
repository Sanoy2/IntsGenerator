using System.IO;

namespace IntsGenerator
{
    public static class Creator
    {
        public static void CreateDirectory(string mainDirectory, string newDirectoryName)
        {
            var fullPathToDirectory = $"{mainDirectory}{newDirectoryName}/";
            CreateDirectory(fullPathToDirectory);
        }  
        public static void CreateDirectory(string fullPathToDirectory)
        {
            FileInfo file = new FileInfo(fullPathToDirectory);
            file.Directory.Create();
        }   
    }
}