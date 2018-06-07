using System;

namespace p41_While_and_Do_While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Do a boolean comparison using a while statement.
            Console.WriteLine("Do you want to play a game?");
            bool doYouWantToPlayAGame = Console.ReadLine().ToLower() == "yes";
            while (!doYouWantToPlayAGame)
            {
                Console.WriteLine("How 'bout now?");
                doYouWantToPlayAGame = Console.ReadLine().ToLower() == "yes";
            }
            Console.WriteLine();

            // 2. Do a boolean comparison using a do while statement.
            Console.WriteLine("Do you want to play another game?");
            bool doYouWantToPlayAnotherGame = false;
            do
            {
                Console.WriteLine("Let's play!");
                doYouWantToPlayAnotherGame = Console.ReadLine().ToLower() == "yes";
            } while (!doYouWantToPlayAnotherGame);
        }
    }
}
