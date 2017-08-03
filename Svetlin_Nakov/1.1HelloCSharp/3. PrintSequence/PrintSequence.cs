using System;


namespace _3.PrintSequence
{
    class PrintSequence
    {
        static void Main()
        {
            for (int i = 0, k = 1; i < 100; i++, k *= -1) Console.Write((i + 2) * k + ", ");
        }
    }
}
