using System;

namespace p62_More_with_Methods_III
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. In the Main() method of the console app, instantiate the class.
            Calculator calculator = new Calculator();

            // 3. Call the method in the class, passing in two numbers. 
            calculator.ShowMeTheMoneyJerry(3, 9000);

            // 4. Call the method in the class, specifying the parameters by name.
            calculator.ShowMeTheMoneyJerry(toTriple: 4, toDisplay: 12000);
            Console.ReadLine();
        }
    }
}
