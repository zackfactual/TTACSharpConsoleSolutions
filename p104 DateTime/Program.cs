using System;

namespace p104_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Prints the current date and time to the console.
            Console.WriteLine("It is currently " + DateTime.Now);

            // 2. Asks the user for a number.
            Console.WriteLine("Please enter an integer:");
            int input = Convert.ToInt32(Console.ReadLine());
            TimeSpan timeSpan = new TimeSpan(input, 0, 0);
            Console.WriteLine();

            // 3. Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            Console.WriteLine("In {0} hours it will {1}", input, DateTime.Now.Add(timeSpan));
            Console.ReadLine();
        }
    }
}
