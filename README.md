using System;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        string folderPath = @"C:\Your\Path\Here"; // Hardcoded path
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string outputPath = Path.Combine(desktopPath, "folder_structure.txt");

        using (StreamWriter outputFile = new StreamWriter(outputPath))
        {
            ProcessDirectory(folderPath, outputFile, 0); // Start with depth 0
        }
    }

    static void ProcessDirectory(string targetDirectory, StreamWriter outputFile, int depth)
    {
        // Write the current directory with indentation based on depth
        string indentation = new String(' ', depth * 4); // 4 spaces per level of depth
        outputFile.WriteLine($"{indentation}Directory: {Path.GetFileName(targetDirectory)}");

        // Process the list of files found in the directory.
        string[] fileEntries = Directory.GetFiles(targetDirectory, "*.json");
        foreach (string fileName in fileEntries)
            ProcessFile(fileName, outputFile, depth + 1);

        // Recurse into subdirectories of this directory.
        string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
        foreach (string subdirectory in subdirectoryEntries)
            ProcessDirectory(subdirectory, outputFile, depth + 1); // Increment depth for subdirectories
    }

    static void ProcessFile(string path, StreamWriter outputFile, int depth)
    {
        // Use indentation for files similar to directories
        string indentation = new String(' ', depth * 4);
        string jsonContent = File.ReadAllText(path);
        var jsonElement = JsonDocument.Parse(jsonContent).RootElement;
        outputFile.WriteLine($"{indentation}File: {Path.GetFileName(path)}");
        // Optionally write file content or just the name
        // outputFile.WriteLine($"{indentation}{JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = false })}");
        outputFile.WriteLine("\n"); // Adds a double space (two newlines) after each file entry for separation
    }
}
