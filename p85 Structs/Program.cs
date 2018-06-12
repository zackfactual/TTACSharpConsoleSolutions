using System;

namespace p85_Structs
{
    class Program
    {
        // 1. Create a struct called Number and give it the property "Amount" and have it be of data type decimal.
        public struct Number
        {
            public decimal Amount { get; set; }
        }

        static void Main(string[] args)
        {
            // 2. In the Main() method, create an object of data type Number and assign an amount to it.
            Number number = new Number() { Amount = 9.99m };

            // 3. Print this amount to the console.
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
