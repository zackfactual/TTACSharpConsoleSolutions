﻿namespace p72_Abstract_Classes
{
    // 1. Create an abstract class called Person with two properties: string firstName and string lastName.
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // 2. Give it the method SayName().
        public abstract void SayName();
    }
}
