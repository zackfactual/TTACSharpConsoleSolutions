using System;

namespace p72_Abstract_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Inside the Main() method, instantiate an Employee object with firstName "Sample" and lastName "Student". Call the SayName() method on the object.
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();
            Console.ReadLine();
        }
    }
}
