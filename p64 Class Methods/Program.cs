using System;

namespace p64_Class_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. In the Main() method, instantiate that class.
            Calculator calculator = new Calculator();

            // 3. Have the user enter a number. Call the method on that number. Display the output to the screen. It should be the entered number, divided by two. 
            Console.WriteLine("Please enter an integer and I'll divide it by 2.");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            calculator.Halver(input, out int halfInput);
            Console.WriteLine("{0} / 2 = {1}", input, halfInput);
            Console.WriteLine();

            // Testing requirements #4, #5, and #6 from Compararer.cs
            Console.WriteLine("Please enter an integer or double, and I'll tell you if it's positive.");
            var input2 = Console.ReadLine();
            if (Int32.TryParse(input2, out int input2AsInt))
            {
                Comparer.IsPositive(input2AsInt, out bool isPositive, out string description);
                Console.WriteLine(isPositive + description);
            }
            else if (Double.TryParse(input2, out double input2AsDouble))
            {
                Comparer.IsPositive(input2AsDouble, out bool isPositive, out string description);
                Console.WriteLine(isPositive + description);
            }
            else
            {
                Console.WriteLine("Your input was neither an integer nor a double. Good day.");
            }
            Console.ReadLine();
        }
    }
}
