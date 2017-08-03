using System;


namespace _10.BooleanExpressionTrueFalse
{
    class BooleanExpressionTrueFalse
    {
        static void Main()
        {
            bool isDigit1 = false;
            byte p;
            int v;
            Console.WriteLine("Enter the position of the bit p:");
            bool ispByte = byte.TryParse(Console.ReadLine(), out p);
            Console.WriteLine("Enter the integer number v:");
            bool isvInt = int.TryParse(Console.ReadLine(), out v);

            if (isvInt && ispByte && p > 32)
            {
                int mask = 1 << p;
                if ((v & mask) == mask)
                {
                    isDigit1 = true;
                }
                Console.WriteLine("Is bit {0} of integer {1} is equal to 1?: {2}", p, v, isDigit1);
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}
