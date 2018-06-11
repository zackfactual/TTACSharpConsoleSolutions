namespace p61_More_with_Methods_II
{
    // 1. Create a class. In that class, create a method that takes two integers as parameters. Make one of them optional. Have the method do a math operation and return a integer result.
    class Calculator
    {
        public int calculateSalary(int wage, int hours = 40)
        {
            return wage * hours;
        }
    }
}
