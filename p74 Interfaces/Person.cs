﻿namespace p74_Interfaces
{
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public abstract void SayName();
    }
}
