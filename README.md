All things python

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string folderPath = @"C:\YourFolder"; // Specify your source folder path
        // Adjust the outputPath to save on the Desktop of the current user
        string outputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Output.txt");

        foreach (var file in new DirectoryInfo(folderPath).GetFiles())
        {
            string content = File.ReadAllText(file.FullName); // Reading each file
            // Assuming content is already in JSON format or convert it here

            for (int i = 0; i < content.Length; i += 1900)
            {
                string chunk = content.Substring(i, Math.Min(1900, content.Length - i)).Replace(" ", ""); // Remove whitespace within chunk
                string outputLine = $"translate this to plain english{chunk}\n\n"; // Formatting output
                File.AppendAllText(outputPath, outputLine); // Writing to file
            }
        }
    }
}

