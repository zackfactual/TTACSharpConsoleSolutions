namespace p77_Operator_Overloading
{
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public abstract void SayName();
    }
}
