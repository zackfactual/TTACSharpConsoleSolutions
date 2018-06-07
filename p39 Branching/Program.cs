using System;

namespace p39_Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            double packageWeight = Convert.ToDouble(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                double packageWidth = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                double packageHeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                double packageLength = Convert.ToDouble(Console.ReadLine());
                double packageVolume = packageWidth * packageHeight * packageLength;
                if (packageVolume > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                }
                else
                {
                    double quote = packageVolume * packageWeight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: {0:C}", quote);
                    Console.WriteLine("Thank you.");
                }
            }
            Console.ReadLine();
        }
    }
}
