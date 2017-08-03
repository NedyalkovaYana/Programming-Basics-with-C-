using System;


namespace _3.FloatingPoint
{
    class FloatingPoint
    {
        static void Main()
        {
            decimal a = 5.3m;
            decimal b = 6.01m;
            Console.WriteLine("Is a==b: {0}", (Math.Round(a, 6) == Math.Round(b, 6)));

            decimal c = 5.00000001m;
            decimal d = 5.00000003m;
            Console.WriteLine("Is c==d: {0}", (Math.Round(c, 6) == Math.Round(d, 6)));
        }
    }
}







