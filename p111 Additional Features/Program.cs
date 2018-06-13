using System;

namespace p111_Additional_Features
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a const variable
            const string myName = "Zachary Leighton Velcoff";

            // 2. Create a variable using the keyword "var".
            var myAge = 26;

            Introduction introduction = new Introduction(myName, myAge);
            Console.WriteLine("I, {0}, age {1}, am introducing myself.", introduction.Name, introduction.Age);
            Console.WriteLine();

            Introduction chainedIntroduction = new Introduction(myName);
            Console.WriteLine("I, {0}, age {1}, am introducing myself.", chainedIntroduction.Name, chainedIntroduction.Age);
            
            Console.ReadLine();
        }
    }
}
