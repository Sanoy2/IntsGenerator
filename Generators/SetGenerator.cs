using System.Collections.Generic;
using System.Threading.Tasks;
using IntsGenerator.Requests;

namespace IntsGenerator.Generators
{
    public class SetGenerator
    {
        public void Generate(string mainDirectoryPath, int numberOfFiles, int[] numberOfInts)
        {
            Generate(SetGenerationRequest.GetCreationRequests(mainDirectoryPath, numberOfFiles, numberOfInts));
        }
        public void Generate(List<GenerationRequest> bunchOfRequests)
        {
            foreach (var request in bunchOfRequests)
            {
                var generator = new Generator();
                generator.Generate(request);
            }
        }

        public void GenerateByTasks(List<GenerationRequest> bunchOfRequests)
        {
            var taskList = new List<Task>();
            foreach (var request in bunchOfRequests)
            {
                var task = Task.Run(() =>
                {
                    var generator = new Generator();
                    generator.Generate(request);
                });
                taskList.Add(task);
            }

            Task.WaitAll(taskList.ToArray());
        }
    }
}