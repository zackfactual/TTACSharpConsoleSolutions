using System;

namespace p33_Math_and_Comparison_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            double input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} * 50 = {1}", input, (input * 50));
            Console.WriteLine();

            Console.WriteLine("Please enter a number:");
            input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} + 25 = {1}", input, (input + 25));
            Console.WriteLine();

            Console.WriteLine("Please enter a number:");
            input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} / 12.5 = {1}", input, (input / 12.5));
            Console.WriteLine();

            Console.WriteLine("Please enter a number:");
            input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Is {0} > 50? {1}", input, (input > 50));
            Console.WriteLine();

            Console.WriteLine("Please enter a number:");
            input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} / 7 leaves a remainder of {1}", input, (input % 7));
            Console.ReadLine();
        }
    }
}
