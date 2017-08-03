using System;


namespace _2.DivisibleByTreeAndFive
{
    class DivisibleByTreeAndFive
    {
        static void Main()
        {
            Console.Write("Enter n:");
            int n = int.Parse(Console.ReadLine());
         
            for (int a = 1; a <= n; a++)
            {

                if (a % 3 == 0)
                {
                    continue;
                }
                else
                {
                    if (a % 7 == 0)
                    continue;
                }
                Console.WriteLine("{0}", a);
            }
            Console.WriteLine();

        }
    }
}
