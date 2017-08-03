using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.OddEvenPosition
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var oddSum = 0.00;
            var oddMin = double.MaxValue;
            var oddMax = double.MinValue;
            var evenSum = 0.00;
            var evenMin = double.MaxValue;
            var evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (num < evenMin) evenMin = num;
                    else if (num > evenMax) evenMax = num;
                    if (evenMin > evenMax) evenMax = evenMin;
                }
                else
                {
                    oddSum += num;
                    if (num < oddMin) oddMin = num;
                    else if (num > oddMax) oddMax = num;
                    if (oddMin > oddMax) oddMax = oddMin;
                }
            }
            Console.WriteLine("OddSum=" + oddSum);
            if (oddMin != double.MaxValue) Console.WriteLine("OddMin=" + oddMin);
            else Console.WriteLine("OddMin=No");
            if (oddMax != double.MinValue) Console.WriteLine("OddMax=" + oddMax);
            else Console.WriteLine("OddMax=No");
            Console.WriteLine("EvenSum=" + evenSum);
            if (evenMin != double.MaxValue) Console.WriteLine("EvenMin=" + evenMin);
            else Console.WriteLine("EvenMin=No");
            if (evenMax != double.MinValue) Console.WriteLine("EvenMax=" + evenMax);
            else Console.WriteLine("EvenMax=No");

        }
    }
}
