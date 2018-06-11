using System;
using System.Globalization;

namespace p82_Enums
{
    class Program
    {
        // 1. Create an enum for the days of the week.
        public enum Day
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void Main(string[] args)
        {
            // 4. Wrap the statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.
            try
            {
                // 2. Prompt the user to enter the current day of the week.
                Console.WriteLine("Please enter a day of the week:");
                var input = Console.ReadLine();
                input = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input);

                // 3. Assign the value to a variable of that enum data type you just created.
                Day today = (Day)Enum.Parse(typeof(Day), input);
                
                Console.WriteLine("{0} is a good day to have a good day!", today);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }

        
    }
}
