using System;

namespace p74_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Use polymorphism to create an object of type IQuittable and call the Quit() method on it. Hint: an object can be of an interface type if it implements that specific interface.
            IQuittable JerryMaguire = new Employee() { FirstName = "Jerry", LastName = "Maguire" };
            JerryMaguire.Quit();
            Console.ReadLine();
        }
    }
}
