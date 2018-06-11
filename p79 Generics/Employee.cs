using System;
using System.Collections.Generic;

namespace p79_Generics
{
    // 1. Make the Employee class take a generic type parameter.
    class Employee<T> : Person
    {
        public int Id { get; set; }

        // 2. Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.
        public List<T> Things { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}
