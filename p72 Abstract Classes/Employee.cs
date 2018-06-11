﻿using System;

namespace p72_Abstract_Classes
{
    // 3. Create another class called Employee and have it inherit from the Person class.
    class Employee : Person
    {
        // 4. Implement the SayName() method inside of the Employee class.
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}
