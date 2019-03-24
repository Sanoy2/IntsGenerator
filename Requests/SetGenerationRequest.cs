using System.Collections.Generic;
using System.Linq;
namespace IntsGenerator.Requests
{
    public class SetGenerationRequest
    {
        public static List<GenerationRequest> GetCreationRequests(string mainDirectoryPath, int numberOfFiles, int[] numberOfInts)
        {
            var list = new List<GenerationRequest>();

            foreach (var intsNumber in numberOfInts.OrderBy(n => n).Distinct())
            {
                list.Add(new GenerationRequest(mainDirectoryPath, numberOfFiles, intsNumber));
            }

            return list;
        }
    }
}