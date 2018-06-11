namespace p58_Classes_and_Methods
{
    /* 1. Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer. 
     * The methods should do some math operation on the received parameter. 
     * Put this class in a separate .cs file in the application.*/
    static class Calculator
    {
        public static int Doubler(int input)
        {
            return input *= 2;
        }

        public static int Tripler(int input)
        {
            return input *= 3;
        }

        public static int Quadrupler(int input)
        {
            return input *= 4;
        }
    }
}
