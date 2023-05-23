# BfevflConverter

[![License](https://img.shields.io/badge/License-AGPL%20v3.0-blue.svg)](LICENSE.txt)
[![Downloads](https://img.shields.io/github/downloads/Cod3xDev/BFEVFL-To-JSON/total)](https://github.com/Cod3xDev/BFEVFL-To-JSON/releases)

## Description

BfevflConverter is a command-line tool for converting BFEVFL files to JSON format and vice versa. It utilizes the BfevLibrary developed by @ArchLeaders to handle the conversions.

## Usage

To use BfevflConverter, follow the steps below:

1. Ensure that the BFEVFL files have been decompressed using [Totk.ZStdTool](https://github.com/TotkMods/Totk.ZStdTool).
2. Open a command prompt or terminal.
3. Navigate to the directory where the `BfevflConverter` executable is located.
4. Run the following commands:

   - To convert BFEVFL files to JSON:
   
     ```
     BfevflConverter <directoryPath>
     ```
  
     Replace `<directoryPath>` with the path to the directory containing the BFEVFL files. Alternatively, you can drag and drop the folder onto the `BfevflConverter` executable.
  
     For example:
  
     ```
     BfevflConverter C:\TOTK\romfs\Event\EventFlow
     ```
  
     The tool will convert each BFEVFL file found in the specified directory and its subdirectories to JSON format. The resulting JSON files will be saved with the same name and path as the original BFEVFL files.
     
   - To convert JSON files to BFEVFL:
   
     ```
     BfevflConverter <jsonFilePath>
     ```
     
     Replace `<jsonFilePath>` with the path to the JSON file you want to convert to BFEVFL. Alternatively, you can drag and drop the JSON file onto the `BfevflConverter` executable.
  
     For example:
  
     ```
     BfevflConverter C:\TOTK\romfs\Event\EventFlow\example.json
     ```
  
     The tool will convert the specified JSON file to BFEVFL format. The resulting BFEVFL file will be saved with the same name and path as the original JSON file, but with the extension changed to `.bfevfl`.

## License

This project is licensed under the [GNU Affero General Public License v3.0](LICENSE.txt). Refer to the license file for more details.

## Contact

For any questions, feedback, or inquiries, please contact me on Discord at Cod3xDev#0001.
