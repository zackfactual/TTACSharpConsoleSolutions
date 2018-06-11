using System;

namespace p61_More_with_Methods_II
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. In the Main() method of the console app, instantiate the class.
            Calculator calculator = new Calculator();

            // 3. Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number.
            Console.WriteLine("Please enter your hourly wage as a whole number.");
            int wage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please enter the number of hours you work per week as a whole number.");
            Console.WriteLine("If you don't enter a whole number, it will be assumed that you work 40 hours per week.");
            bool isInt = Int32.TryParse(Console.ReadLine(), out int hours);
            Console.WriteLine();

            // 4. Call the method in the class, passing in the one or two numbers entered.
            if (isInt)
            {
                Console.WriteLine("You make {0:c} per week before taxes.", calculator.calculateSalary(wage, hours));
            }
            else
            {
                Console.WriteLine("You make {0:c} per week before taxes.", calculator.calculateSalary(wage));
            }
            Console.ReadLine();
        }
    }
}
