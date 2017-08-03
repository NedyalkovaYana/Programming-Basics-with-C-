using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ReverseADigits
{
    class Program
    {
        private static void ReverseDigit(int n)
        {
            int left = n;
            int rev = 0;
            while (left > 0)
            {
                int r = left % 10;
                rev = rev * 10 + r;
                left = left / 10;
            }
            Console.WriteLine("Reverse No. is {0}", rev);
        }
        static void Main()
        {
            Console.Write("Please, enter a number: ");
            int n = int.Parse(Console.ReadLine());
            ReverseDigit(n);

        }

    }
}
