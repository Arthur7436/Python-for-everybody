using System;
using System.Text.RegularExpressions;

namespace JsonCondenser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter JSON segment or press 'q' to quit:");

            while (true)
            {
                string input = Console.ReadLine();

                // Check if the input is the quit command
                if (input.Trim().ToLower() == "q")
                {
                    break; // Exit the loop, thereby exiting the program
                }

                // Condense the JSON input into one long string by removing all whitespace characters
                string condensedJson = Regex.Replace(input, @"\s+", "");

                Console.WriteLine($"Condensed JSON: {condensedJson}");
                Console.WriteLine("Enter another JSON segment or press 'q' to quit:");
            }
        }
    }
}
