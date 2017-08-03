using System;

namespace _14.ExchangeBitToUnsignetInteger
{
    class ExchangeBitToUnsignetInteger
    {
        static void Main()
        {
            uint n;
            byte p, q, k;
            Console.WriteLine("Enter the unsignet integer number n:");
            bool isnInt = uint.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Enter the start position of the first bit sequence p:");
            bool ispByte = byte.TryParse(Console.ReadLine(), out p);
            Console.WriteLine("Enter the start position of the second bit sequence q:");
            bool isqByte = byte.TryParse(Console.ReadLine(), out q);
            Console.WriteLine("Enter the lenght of the sequence k:");
            bool iskByte = byte.TryParse(Console.ReadLine(), out k);

            if (isnInt & ispByte & isqByte & iskByte)
            {
                if ((p + k) < 31 && (q + k) < 31 && (Math.Abs(p - k) >= k))
                {
                    if (p > k)
                    {
                        byte temp = q;
                        q = p;
                        p = temp;
                    }
                    Console.WriteLine("Binary initial n:");
                    Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

                    n = ((~(((uint)Math.Pow(2, k) - 1) << q | ((uint)Math.Pow(2, k) - 1 << p)) & n) | (((n & (((uint)Math.Pow(2, k) - 1 << p)) << (Math.Abs(p - q))) | ((n & ((uint)Math.Pow(2, k) - 1) << q)) >> (Math.Abs(p - q)))));
                    Console.WriteLine("Binary new n: ");
                    Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
                }
                else
                {
                    Console.WriteLine("Not a valid entry!");
                }
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}
