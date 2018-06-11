using System;

namespace p58_Classes_and_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. In the Main() program, ask the user what number they want to do the math operations on.

            Console.WriteLine("Please enter a whole number:");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Our Calculator class will now double, triple, and quadruple that number:");

            // 3. Call each method in turn, passing the user input to the method.Display the returned integer to the screen.

            Console.WriteLine(Calculator.Doubler(input));
            Console.WriteLine(Calculator.Tripler(input));
            Console.WriteLine(Calculator.Quadrupler(input));
            Console.ReadLine();
        }
    }
}
