using System;
using System.Globalization;
using System.Threading;


namespace _2.SignOfNumbers
{
    class SignOfNumbers
    {
        static void Main()
        {
            int a, b, c, negativeCount = 0;
            Console.WriteLine("Please enter int a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter int b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter int c:");
            c = Convert.ToInt32(Console.ReadLine());

            if (a<0)
            {
                negativeCount++;
            }
            if (b < 0)
            {
                negativeCount++;
            }
            if (c < 0)
            {
                negativeCount++;
            }
            if (negativeCount > 1)
            {
                Console.WriteLine("The product of numbers {0}, {1} and {2} is with - sign!!!", a, b, c);
            }
            else
            {
                Console.WriteLine("The product of numbers {0}, {1} and {2} is with + sign!!!", a, b, c);
            }
            }


        }
    }

