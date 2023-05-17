# BfevflConverter

[![License](https://img.shields.io/badge/License-AGPL%20v3.0-blue.svg)](LICENSE.txt)
[![Downloads](https://img.shields.io/github/downloads/Cod3xDev/BFEVFL-To-JSON/total)](https://github.com/Cod3xDev/BFEVFL-To-JSON/releases)

## Description

BfevToJsonConverter is a command-line tool for converting BFEVFL files to JSON format and vice versa. It uses the BfevLibrary by ArchLeaders to perform the conversions.

## Usage

To use BfevToJsonConverter, follow these steps:

1. Ensure BFEVFL Files Have Been Decompressed With [Totk.ZStdTool](https://github.com/TotkMods/Totk.ZStdTool).
2. Open a command prompt or terminal.
3. Navigate to the directory where the `BfevToJsonConverter` executable is located.
4. Run the following command:

   - Convert BFEVFL to JSON:
   
     BfevToJsonConverter `<directoryPath>`
  
     Replace `<directoryPath>` with the path to the directory where your BFEVFL files are located.
  
     For example:
  
     `BfevToJsonConverter C:\TOTK\romfs\Event\EventFlow`
  
     The tool will convert each BFEVFL file found in the specified directory and its subdirectories to JSON format. The resulting JSON files will be saved with the same name and path as the original BFEVFL files.
     
   - Convert JSON to BFEVFL:
   
     BfevToJsonConverter `<jsonFilePath>`
     
     Replace `<jsonFilePath>` with the path to the JSON file you want to convert to BFEVFL.
  
     For example:
  
     `BfevToJsonConverter C:\TOTK\romfs\Event\EventFlow\example.json`
  
     The tool will convert the specified JSON file to BFEVFL format. The resulting BFEVFL file will be saved with the same name and path as the original JSON file, but with the extension changed to `.bfevfl`.

## License

This project is licensed under the [GNU Affero General Public License v3.0](LICENSE.txt). Refer to the license file for more information.

## Contact

For any questions, feedback, or inquiries, please contact me at Cod3xDev#1414 on Discord.
