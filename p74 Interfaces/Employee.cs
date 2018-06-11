using System;

namespace p74_Interfaces
{
    // 2. Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }

        public void Quit()
        {
            Console.WriteLine("Who's coming with me?");
        }
    }
}
