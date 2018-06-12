using System;
using System.IO;

namespace p102_File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Ask a user for a number.
            Console.WriteLine("Please enter a number:");
            string input = Console.ReadLine();
            Console.WriteLine();

            if (Double.TryParse(input, out double inputAsDouble))
            {
                // 2. Log that number to a text file.
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), @"log.txt");
                File.WriteAllText(filePath, input);

                // 3. Print the text file back to the user.
                Console.WriteLine("You entered the number: " + File.ReadAllText(filePath));
            }
            else
            {
                Console.WriteLine("That's not a number!");
            }
            Console.ReadLine();
        }
    }
}
