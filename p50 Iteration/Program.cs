using System;
using System.Collections.Generic;

namespace p50_Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Create a one-dimensional Array of strings. Ask the user to input some text. Create a loop that 
            goes through each string in the Array, adding the user’s text to the string. Then create a loop 
            that prints off each string in the Array on a separate line. */

            string[] planets = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
            Console.WriteLine("Please enter some text to have it added to an array of planets: ");
            string input = Console.ReadLine();

            for (int i = 0; i < planets.Length; i++)
            {
                planets[i] += " " + input;
            }

            foreach (var planet in planets)
            {
                Console.WriteLine(planet);
            }
            Console.WriteLine();

            // 2. Create an infinite loop.
            //for (int i = 0; i < 9; i--)
            //{
            //    Console.WriteLine("Pluto is not a planet.");
            //}

            // 3. Fix the infinite loop so it will execute.
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Pluto is not a planet.");
            }
            Console.WriteLine();

            // 4. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Can I have a little more?");

            // 5. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            for (int i = 5; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("I love you!");
            Console.WriteLine();

            /* 6. Create a List of strings where each item in the list is unique. Ask the user to select text to 
            search for in the List. Create a loop that iterates through the loop and then displays the 
            index of the List that contains matching text on the screen. */
            List<string> ledZeppelin = new List<string> { "robert plant", "jimmy page", "john bonham", "john paul jones" };
            Console.WriteLine("Please enter the name of one of the band members of Led Zeppelin:");
            string input2 = Console.ReadLine(); 
            for (int i = 0; i < ledZeppelin.Count; i++)
            {
                if (input2.ToLower() == ledZeppelin[i])
                {
                    Console.WriteLine("{0} is at index {1} in our List.", System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input2), i);
                    // 8. Add code to that above loop that stops it from executing once a match has been found.
                    break;
                }
                // 7. Add code to that above loop that tells a user if they put in text that isn’t in the List.
                else if (!ledZeppelin.Contains(input2.ToLower()))
                {
                    Console.WriteLine("{0} is not a member of Led Zeppelin.", input2);
                    break;
                }
            }
            Console.WriteLine();

            /* 9. Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List. Create a loop that iterates through the    
            loop and then displays the indices of the array that contain matching text on the screen. */
            List<string> badgers = new List<string> { "badger", "badger", "badger", "badger", "badger", "badger", "badger", "badger", "badger", "badger", "badger", "mushroom", "mushroom" };
            Console.WriteLine("Please enter the word 'badger' or 'mushroom'");
            string input3 = Console.ReadLine();
            // 10. Add code to that above loop that tells a user if they put in text that isn’t in the List.
            for (int i = 0; i < badgers.Count; i++)
            {
                if (badgers[i] == input3)
                {
                    Console.WriteLine("{0} appears at index {1} in our List", input3, i);
                }
                else if (!badgers.Contains(input3.ToLower()))
                {
                    Console.WriteLine("{0} is neither a badger nor a mushroom.", input3);
                    break;
                }
            }
            Console.WriteLine();

            /* 11. Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the list, and displays a message showing the
            string and whether or not it has already appeared in the list.*/
            List<string> potatoPotahto = new List<string> { "You like potato and I like potato", "You like tomato and I like tomahto", "Potato", "Potato", "Tomato", "Tomato", "Let's call the whole thing off" };
            List<string> tomatoTomahto = new List<string>();
            foreach (var vegetable in potatoPotahto)
            {
                if (!tomatoTomahto.Contains(vegetable))
                {
                    tomatoTomahto.Add(vegetable);
                    Console.WriteLine("{0} has not yet appeared in the list.", vegetable);
                }
                else
                {
                    Console.WriteLine("{0} has already appeared in the list.", vegetable);
                }
            }
            Console.ReadLine();
        }
    }
}
