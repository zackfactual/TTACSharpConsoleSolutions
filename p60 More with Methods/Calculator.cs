using System;

namespace p60_More_with_Methods
{
    /* 1. Create a class. In that class, create a method that will take in an integer, do a math operation to it and then 
    return the answer as an integer. */
    class Calculator
    {
        public int Multiplier(int input)
        {
            return input *= 2;
        }

        // 3. Add a second method to the class, with the same name, that will take in a decimal, do a different math operation to it and then return the answer as an integer.
        public int Multiplier(decimal input2)
        {
            return Convert.ToInt32(input2 *= 4);
        }

        /* 5. Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, 
        do a different math operation to it and then return the answer as an integer. */
        public int Multiplier(string input3)
        {
            bool isInt = Int32.TryParse(input3, out int input3AsInt);
            if (isInt)
            {
                return input3AsInt * 6;
            }
            else
            {
                return 0;
            }
        }
    }
}
