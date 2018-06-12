using System;
using System.Collections.Generic;
using System.Linq;

namespace p88_Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. In the Main() method, create a list of at least 10 employees. Each employee should have a first and last name, as well as an Id. At least two employees should have the first name "Joe".
            List<Employee> employees = new List<Employee>
            {
                new Employee { FirstName = "Joe", LastName = "Pesci", Id = 1 },
                new Employee { FirstName = "Catherine", LastName = "Scorsese", Id = 2 },
                new Employee { FirstName = "Robert", LastName = "De Niro", Id = 3 },
                new Employee { FirstName = "Sharon", LastName = "Stone", Id = 4 },
                new Employee { FirstName = "Don", LastName = "Rickles", Id = 5 },
                new Employee { FirstName = "Joe", LastName = "Gordon-Levitt", Id = 6 },
                new Employee { FirstName = "Ellen", LastName = "Page", Id = 7 },
                new Employee { FirstName = "Leonardo", LastName = "DiCaprio", Id = 8 },
                new Employee { FirstName = "Marion", LastName = "Cotillard", Id = 9 },
                new Employee { FirstName = "Tom", LastName = "Hardy", Id = 10 }
            };

            // 2. Using a foreach loop, create a new list of all employees with the first name "Joe".
            List<Employee> joeList = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joeList.Add(employee);
                }
            }

            foreach (Employee employee in joeList)
            {
                Console.WriteLine("{0} {1}, Employee #{2}", employee.FirstName, employee.LastName, employee.Id);
            }
            Console.WriteLine();

            // 3. Do the same thing again, but this time with a lambda expression.
            List<Employee> joeList2 = employees.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee employee in joeList2)
            {
                Console.WriteLine("{0} {1}, Employee #{2}", employee.FirstName, employee.LastName, employee.Id);
            }
            Console.WriteLine();

            // 4. Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> overFives = employees.Where(x => x.Id > 5).ToList();

            foreach (Employee employee in overFives)
            {
                Console.WriteLine("{0} {1}, Employee #{2}", employee.FirstName, employee.LastName, employee.Id);
            }
            Console.ReadLine();
        }
    }
}
