using System;

namespace p60_More_with_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. In the Main() method of the console app, instantiate the class and call the one method, passing in an integer. Display the result to the screen.
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Multiplier(4));

            // 4. In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display the result to the screen.
            Console.WriteLine(calculator.Multiplier(2.5m));

            // 6. In the Main() method of the console app, instantiate the class and call the third method, passing in a string that equates to an integer. Display the result to the screen.
            Console.WriteLine(calculator.Multiplier("5"));
            Console.ReadLine();
        }
    }
}
