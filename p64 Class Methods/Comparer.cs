namespace p64_Class_Methods
{
    // 6. Declare a class to be static.
    public static class Comparer
    {
        // 4. Create a method with output parameters.
        public static void IsPositive(int input, out bool isPositive, out string description)
        {
            if (input > 0)
            {
                isPositive = true;
                description = ", that integer is positive";
            }
            else
            {
                isPositive = false;
                description = ", that integer is not positive";
            }
        }

        // 5. Overload a method.
        public static void IsPositive(double input, out bool isPositive, out string description)
        {
            if (input > 0)
            {
                isPositive = true;
                description = ", that double is positive";
            }
            else
            {
                isPositive = false;
                description = ", that double is not positive";
            }
        }
    }
}
