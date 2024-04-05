All things python
using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string folderPath = @"C:\YourFolder"; // Specify your source folder path
        string outputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Output.txt"); // Output file path on Desktop

        foreach (var file in new DirectoryInfo(folderPath).GetFiles())
        {
            string content = File.ReadAllText(file.FullName); // Reading each file
            // Remove all forms of whitespace including spaces, tabs, and newlines
            string processedContent = Regex.Replace(content, @"\s+", "");

            // Split the processedContent into chunks of 1900 characters
            for (int i = 0; i < processedContent.Length; i += 1900)
            {
                string chunk = processedContent.Substring(i, Math.Min(1900, processedContent.Length - i));
                // Ensure each chunk is prefixed correctly and add two newlines for separation
                string outputLine = $"translate this to plain english{chunk}\n\n"; 
                File.AppendAllText(outputPath, outputLine); // Writing to file
            }
        }
    }
}
