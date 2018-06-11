using System;

namespace p62_More_with_Methods_III
{
    /* 1. Create a class. In that class, create a void method that takes two integers as parameters. 
    Have the method do a math operation on the first integer and display the second integer to the screen. */
    class Calculator
    {
        public void ShowMeTheMoneyJerry(int toTriple, int toDisplay)
        {
            toTriple *= 3;
            Console.WriteLine("{0:c}", toDisplay);
        }
    }
}
