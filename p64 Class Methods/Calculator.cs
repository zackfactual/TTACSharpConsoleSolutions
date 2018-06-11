namespace p64_Class_Methods
{
    // 1. Create a class. In that class, create a void method that outputs an integer. Have the method divide the data passed to it by 2.
    class Calculator
    {
        public void Halver(int toHalve, out int halved)
        {
            halved = toHalve / 2;
        }
    }
}
