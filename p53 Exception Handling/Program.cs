using System;
using System.Collections.Generic;

namespace p53_Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 5. Now put the loop in a try/catch block. Below and outside of the try/catch block, 
            make the program display a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution. 
            In the catch block, display the error message to the screen. */
            try
            {
                /* 1. Create a list of integers. Ask the user for a number to divide each number in the list by. 
                Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen. */
                List<int> fibonacci = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };
                Console.WriteLine("Please enter a number by which to divide the first thirteen numbers in the Fibonacci sequence:");
                int divisor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                foreach (var number in fibonacci)
                {
                    Console.WriteLine(number / divisor);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("The following error has occured: " + ex.Message);
            }
            Console.WriteLine();
            Console.WriteLine("The program has emerged from the try-catch block and continued on with program execution.");
            Console.ReadLine();
        }
    }
}
