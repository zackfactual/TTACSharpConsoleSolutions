using System;
using System.Collections.Generic;

namespace p79_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            // 3. Instantiate an Employee object with type "string" as its generic parameter. Assign a list of strings as the property value of Things.
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string> { "Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma" };
            foreach (var thing in employee.Things)
            {
                Console.WriteLine(thing);
            }
            Console.WriteLine();

            // 4. Instantiate an Employee object with type "int" as its generic parameter. Assign a list of integers as the property value of Things.
            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int> { random.Next(3,18), random.Next(3, 18), random.Next(3, 18), random.Next(3, 18), random.Next(3, 18), random.Next(3, 18) };
            foreach (var thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
