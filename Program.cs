using BfevLibrary;
using System;
using System.IO;

// Copyright (c) 2023 Cod3xDev. All rights reserved.

namespace BfevflConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide the path to the JSON file or the directory containing JSON files.");
                return;
            }

            string path = args[0];

            if (File.Exists(path))
            {
                ConvertJsonToBfev(path);
            }
            else if (Directory.Exists(path))
            {
                string[] jsonFiles = Directory.GetFiles(path, "*.json", SearchOption.AllDirectories);
                foreach (string jsonFile in jsonFiles)
                {
                    ConvertJsonToBfev(jsonFile);
                }
            }
            else
            {
                Console.WriteLine("Invalid path specified.");
            }

            Console.WriteLine("Conversion complete!");
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
    }
}
