using System;


namespace _2.logicalOperators
{
    class LogicalOperators
    {
        static void Main()
        {
            bool a = true;
            bool b = false;
            Console.WriteLine(a&&b);
            Console.WriteLine(a||b);
            Console.WriteLine(a^b);
            Console.WriteLine(!b);
            Console.WriteLine(b || true);
            Console.WriteLine(b && true);
            Console.WriteLine(a|| true);
            Console.WriteLine(a&& true);
            Console.WriteLine(!a);
            Console.WriteLine((5>7) ^ (a==b));
        }
    }
}
