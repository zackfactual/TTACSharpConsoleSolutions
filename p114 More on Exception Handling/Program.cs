using System;

namespace p114_More_on_Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Exceptions must be handled using "try .. catch".
            try
            {
                // 1. Ask the user for his age.
                Console.WriteLine("Please enter your age:");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age < 1)
                {
                    throw new InvalidAgeException();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("If your birthday already passed this year, you were born in {0}. Otherwise you were born in {1}.", 
                        DateTime.Now.Year - age, 
                        DateTime.Now.Year - age - 1);
                }
            }
            // 4. Display appropriate error messages if user enters zero or negative numbers.
            catch (InvalidAgeException)
            {
                Console.WriteLine();
                Console.WriteLine("You have entered an invalid age.");
            }
            // 5. Display a general message if exception caused by anything else.
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("The following error has occured: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
