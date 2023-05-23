using BfevLibrary;

namespace BfevflConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide the path to the file or directory.");
                Console.WriteLine("You can also drag and drop files or folders onto this program.");
                Console.ReadLine();
                return;
            }

            string[] files = GetDroppedFiles(args);
            foreach (string file in files)
            {
                ConvertFile(file);
            }

            Console.WriteLine("Conversion complete!");
            Console.ReadLine();
        }

        static string[] GetDroppedFiles(string[] args)
        {
            List<string> files = new List<string>();
            foreach (string arg in args)
            {
                if (File.Exists(arg))
                {
                    files.Add(arg);
                }
                else if (Directory.Exists(arg))
                {
                    string[] directoryFiles = Directory.GetFiles(arg, "*", SearchOption.AllDirectories);
                    files.AddRange(directoryFiles);
                }
            }
            return files.ToArray();
        }

        static void ConvertFile(string filePath)
        {
            string extension = Path.GetExtension(filePath);
            if (extension == ".json")
            {
                ConvertJsonToBfev(filePath);
            }
            else if (extension == ".bfevfl")
            {
                ConvertBfevToJSON(filePath);
            }
            else
            {
                Console.WriteLine($"Unsupported file format: {extension}");
            }
        }

        static void ConvertJsonToBfev(string jsonFilePath)
        {
            try
            {
                // Read JSON file contents
                string json = File.ReadAllText(jsonFilePath);

                // Convert JSON to BfevFile
                BfevFile bfev = BfevFile.FromJson(json);

                // Generate BFEV file path
                string bfevFilePath = Path.ChangeExtension(jsonFilePath, ".bfevfl");

                // Convert BfevFile to BFEV format
                bfev.ToBinary(bfevFilePath);

                Console.WriteLine($"Successfully converted '{jsonFilePath}' to BFEVFL.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error converting file {jsonFilePath}: {ex.Message}");
            }
        }

        static void ConvertBfevToJSON(string bfevFilePath)
        {
            try
            {
                // Read BFEV file contents using a Stream
                using FileStream fs = File.OpenRead(bfevFilePath);
                BfevFile bfev = new BfevFile(fs);

                // Generate JSON file path
                string jsonFilePath = Path.ChangeExtension(bfevFilePath, ".json");

                // Convert BfevFile to JSON format
                string json = bfev.ToJson(format: true);
                File.WriteAllText(jsonFilePath, json);

                Console.WriteLine($"Successfully converted '{bfevFilePath}' to JSON.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error converting file {bfevFilePath}: {ex.Message}");
            }
        }
    }
}
