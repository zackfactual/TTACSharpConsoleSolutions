using System;

namespace p34_Math_and_Comparison_Operators_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine();

            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter Person 1's hourly rate:");
            double person1Wage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter Person 1's hours worked per week:");
            double person1WeeklyHours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter Person 2's hourly rate:");
            double person2Wage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter Person 2's hours worked per week:");
            double person2WeeklyHours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double person1Salary = person1Wage * person1WeeklyHours * 52;
            double person2Salary = person2Wage * person2WeeklyHours * 52;
            bool doesPerson1EarnMore = person1Salary > person2Salary;

            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine("{0:C}", person1Salary);
            Console.WriteLine();

            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine("{0:C}", person2Salary);
            Console.WriteLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(doesPerson1EarnMore);
            Console.ReadLine();
        }
    }
}
