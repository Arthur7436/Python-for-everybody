All things python


using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Specify the path to the source file and the output file.
        string sourceFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "source.txt");
        string outputFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "string.txt");

        try
        {
            // Read all text from the file.
            string text = File.ReadAllText(sourceFilePath);

            // Remove spaces from the text.
            string processedText = text.Replace(" ", "");

            // Write the processed text to a new file.
            File.WriteAllText(outputFilePath, processedText);

            Console.WriteLine("Processing complete. Check your Desktop for the 'string.txt' file.");
        }
        catch (Exception ex)
        {
            // Output any errors.
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}

