namespace IntsGenerator.Requests
{
    public class GenerationRequest
    {
        public string MainDirectoryPath { get; set; }
        public int NumberOfFiles { get; set; }
        public int NumberOfInts { get; set; }

        public string FolderOfResults { get => GetDirectoryOfResults(); }

        private string GetDirectoryOfResults()
        {
            return $"{MainDirectoryPath}{NumberOfInts}/";
        }

        public GenerationRequest(){}
        public GenerationRequest(string mainDirectoryPath, int numberOfFiles, int numberOfInts)
        {
            MainDirectoryPath = mainDirectoryPath;
            NumberOfFiles = numberOfFiles;
            NumberOfInts = numberOfInts;
        }
    }
}