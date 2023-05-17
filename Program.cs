using BfevLibrary;

// Copyright (c) 2023 Cod3xDev. All rights reserved.

namespace BfevToJsonConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check if directory path argument is provided
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide the directory path where your BFEV files are located.");
                return;
            }

            // Get directory path from command-line argument
            string directoryPath = args[0];

            // Get all files in the specified directory and its subdirectories
            string[] fileEntries = Directory.GetFiles(directoryPath, "*.bfevfl", SearchOption.AllDirectories);

            // Loop through each file and convert to JSON format
            foreach (string filePath in fileEntries)
            {
                try
                {
                    // Read BfevFile from file path
                    BfevFile bfev = BfevFile.FromBinary(filePath);

                    // Convert BfevFile to JSON format
                    string json = bfev.ToJson();

                    // Save JSON file with same name and path as the original BFEV file
                    string jsonFilePath = Path.ChangeExtension(filePath, ".json");
                    File.WriteAllText(jsonFilePath, json);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error converting file {filePath}: {ex.Message}");
                }
            }

            Console.WriteLine("Conversion complete!");
        }
    }
}