using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using IntsGenerator.Requests;

namespace IntsGenerator.Generators
{
    public class Generator
    {
        private Random random;
        public int MaxInt { get; set; }
        public int MinInt { get; set; }

        public Generator()
        {
            random = new Random();
            MaxInt = int.MaxValue / 4;
            MinInt = int.MinValue / 4;
        }

        public void CleanAndGenerate(GenerationRequest request)
        {
            Cleaner.CleanFilesInDirectory(request.FolderOfResults);
            Generate(request);
        }

        public void Generate(GenerationRequest request)
        {
            Creator.CreateDirectory(request.FolderOfResults);

            for (int i = 0; i < request.NumberOfFiles; i++)
            {
                CreateFile(GetPathToFile(request, i), request.NumberOfInts);
            }
        }

        private void CreateFile(string pathToFile, int numberOfInts)
        {
            using (StreamWriter file = new StreamWriter(pathToFile))
            {
                for (int i = 0; i < numberOfInts; i++)
                {
                    file.WriteLine(GetInt());
                }
            }
        }

        private string GetPathToFile(GenerationRequest request, int fileIndex)
        {
            return $"{request.FolderOfResults}/{fileIndex}.txt";
        }

        private int GetInt()
        {
            return random.Next(MinInt, MaxInt);
        }
    }
}