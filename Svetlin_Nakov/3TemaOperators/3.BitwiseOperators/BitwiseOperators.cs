using System;


namespace _3.BitwiseOperators
{
    class BitwiseOperators
    {
        static void Main()
        {
            ushort a = 3;
            ushort b = 5;
            Console.WriteLine(a | b);
            Console.WriteLine(a & b);
            Console.WriteLine(a^b);
            Console.WriteLine(a<<1);
            Console.WriteLine(a>>1);
            Console.WriteLine(a << 2);
            Console.WriteLine (a<<2) ;
            Console.WriteLine(Convert.ToString(128,2));
            Console.WriteLine(~a&b);
            Console.WriteLine(~a);
            Console.WriteLine((ushort)~a);
        }
    }
}
