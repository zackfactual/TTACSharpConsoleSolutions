using System;

namespace p77_Operator_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee zachary = new Employee { FirstName = "Zachary", LastName = "Velcoff", Id = 1 };
            Employee söze = new Employee { FirstName = "Keyser", LastName = "Söze", Id = 1 };
            Employee roberts = new Employee { FirstName = "The Dread Pirate", LastName = "Roberts", Id = 2 };

            Console.WriteLine("Am I the Dread Pirate Roberts?");
            bool pb = zachary == roberts ? true : false;
            Console.WriteLine(pb + ". I am not the Dread Pirate Roberts.");
            Console.WriteLine();

            Console.WriteLine("Was I actually Keyser Söze the whole time?");
            bool tus = zachary == söze ? true : false;
            Console.WriteLine(tus + ". And if you're smart, you figured it out before the end of the movie.");
            Console.ReadLine();
        }
    }
}
