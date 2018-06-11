using System;
using System.Collections.Generic;

namespace p47_Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a one-dimensional Array of strings.Ask the user to select an index of the Array and then display the string at that index on the screen.
            string[] rings = { "Three Rings for the Elven-kings under the sky", "Seven for the Dwarf-lords in halls of stone", "Nine for Mortal Men, doomed to die", "One for the Dark Lord on his dark throne", "In the Land of Mordor where the Shadows lie", "One Ring to rule them all, One Ring to find them", "One Ring to bring them all and in the darkness bind them", "In the Land of Mordor where the Shadows lie" };
            Console.WriteLine("Please enter a whole number between 0 and 7");
            bool isInt = Int32.TryParse(Console.ReadLine(), out int chosenIndex);

            if (isInt && chosenIndex >= 0 && chosenIndex < rings.Length)
            {
                Console.WriteLine(rings[chosenIndex]);
            }
            // 3. Add in a message that displays when the user selects an index that doesn’t exist.
            else
            {
                Console.WriteLine("Your selected index was invalid.");
            }
            Console.WriteLine();

            // 2. Create a one-dimensional Array of integers.Ask the user to select an index of the Array and then display the integer at that index on the screen.
            int[] intRings = { 3, 7, 9, 1 };
            Console.WriteLine("Please enter a whole number between 0 and 3");
            bool isInt2 = Int32.TryParse(Console.ReadLine(), out int chosenIndex2);

            if (isInt2 && chosenIndex2 >= 0 && chosenIndex2 < intRings.Length)
            {
                Console.WriteLine(intRings[chosenIndex2]);
            }
            // see #3
            else
            {
                Console.WriteLine("Fool of a Took! Your selected index was invalid.");
            }
            Console.WriteLine();

            //4. Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.
            List<string> fellowshipOfTheRing = new List<string> { "Frodo", "Sam", "Merry", "Pippin", "Aragorn", "Boromir", "Legolas", "Gimli", "Gandalf" };
            Console.WriteLine("Please enter a whole number between 0 and 8");
            bool isInt3 = Int32.TryParse(Console.ReadLine(), out int chosenIndex3);

            if (isInt3 && chosenIndex3 >= 0 && chosenIndex3 < fellowshipOfTheRing.Count)
            {
                Console.WriteLine(fellowshipOfTheRing[chosenIndex3]);
            }
            // see #3
            else
            {
                Console.WriteLine("Fool of a Took! Your selected index was invalid.");
            }
            Console.ReadLine();

        }
    }
}
