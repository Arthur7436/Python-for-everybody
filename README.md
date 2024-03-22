using System;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        string folderPath = @"C:\Your\Path\Here"; // Hardcoded path
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string outputPath = Path.Combine(desktopPath, "output.txt");

        using (StreamWriter outputFile = new StreamWriter(outputPath))
        {
            ProcessDirectory(folderPath, outputFile);
        }
    }

    static void ProcessDirectory(string targetDirectory, StreamWriter outputFile)
    {
        // Process the list of files found in the directory.
        string[] fileEntries = Directory.GetFiles(targetDirectory, "*.json");
        foreach (string fileName in fileEntries)
            ProcessFile(fileName, outputFile);

        // Recurse into subdirectories of this directory.
        string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
        foreach (string subdirectory in subdirectoryEntries)
            ProcessDirectory(subdirectory, outputFile);
    }

    static void ProcessFile(string path, StreamWriter outputFile)
    {
        string jsonContent = File.ReadAllText(path);
        var jsonElement = JsonDocument.Parse(jsonContent).RootElement;
        outputFile.WriteLine(Path.GetFileName(path));
        outputFile.WriteLine(JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = false }));
    }
}

static void ProcessFile(string path, StreamWriter outputFile)
{
    string jsonContent = File.ReadAllText(path);
    var jsonElement = JsonDocument.Parse(jsonContent).RootElement;
    outputFile.WriteLine(Path.GetFileName(path));
    outputFile.WriteLine(JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = false }));
    outputFile.WriteLine("\n"); // Adds an extra newline for double spacing
}

