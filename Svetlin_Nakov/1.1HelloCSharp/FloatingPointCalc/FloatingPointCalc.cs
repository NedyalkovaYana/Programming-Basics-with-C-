using System;


namespace FloatingPointCalc
{
    class FloatingPointCalc
    {
        static void Main()
        {
            double a = 1.0;
            double b = 0.33;
            double sum = 1.33;
            bool equal = (a + b == sum); // False!
            Console.WriteLine("a+b= {0} sum = {1} equal= {2}", a+b, sum, equal);
        }
    }
}
