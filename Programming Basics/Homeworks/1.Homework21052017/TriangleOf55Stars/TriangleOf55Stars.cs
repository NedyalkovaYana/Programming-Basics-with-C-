using System;


namespace TriangleOf55Stars
{
    class TriangleOf55Stars
    {
        static void Main()
        {

            int number = 10;
            int i, j, k;
            for (i = 1; i <= number; i++)
            {
                for (j = 1; j <= number - i; j++)
                {
                    Console.Write("");
                }

                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

        }
    }
}
