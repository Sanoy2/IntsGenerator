using System;
using IntsGenerator.Generators;
using IntsGenerator.Requests;

namespace IntsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "~/Thesis/Ints/";
            int numberOfFiles = 100;
        
            var numberOfInts = new int[]
            {
                10, 25, 50, 100, 250, 500, 1000, 2500, 5000, 7500, 10000, 25000, 50000, 75000, 100000, 
                150000, 250000, 500000, 750000, 1000000
            };

            Cleaner.CleanEverythingUnderDirectory(path);
            var requests = SetGenerationRequest.GetCreationRequests(path, numberOfFiles, numberOfInts);

            var generator = new SetGenerator();
            generator.Generate(requests);
        }
    }
}
