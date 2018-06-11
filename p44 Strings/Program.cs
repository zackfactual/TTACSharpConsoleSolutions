using System;
using System.Text;

namespace p44_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "Earth, ";
            string string2 = "Jupiter, ";
            string string3 = "Mars";
            Console.WriteLine("Here are three strings:");
            Console.WriteLine(string1);
            Console.WriteLine(string2);
            Console.WriteLine(string3);
            Console.WriteLine();

            // 1. Concatenate three strings.
            string result = string1 + string2 + string3;
            Console.WriteLine("Here are those three strings concatenated:");
            Console.WriteLine(result);
            Console.WriteLine();

            // 2. Convert a string to uppercase.
            Console.WriteLine("Here is that concatenated string converted to upper case:");
            Console.WriteLine(result.ToUpper());
            Console.WriteLine();

            // 3. Create a Stringbuilder and build a paragraph of text, one sentence at a time.
            StringBuilder sb = new StringBuilder();
            sb.Append("You have my sword. ");
            sb.Append("And you have my bow. ");
            sb.Append("And my axe! ");
            Console.WriteLine("Here is an example of a StringBuilder: ");
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
