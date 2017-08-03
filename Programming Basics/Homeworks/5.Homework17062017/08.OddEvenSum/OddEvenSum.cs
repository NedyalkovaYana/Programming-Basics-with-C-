using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.OddEvenSum
{
    class OddEvenSum
    {
        static void Main()
        {
            var numbers = int.Parse(Console.ReadLine());
            var oddNumbers = 0;
            var evenNumbers = 0;
            for (var i = 0; i < numbers; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (i % 2 ==0)
                {
                    evenNumbers += num;
                }
                else
                {
                    oddNumbers += num;
                }
            }
            if (oddNumbers == evenNumbers)
            {
                Console.WriteLine("Yes, sum = {0}", oddNumbers);
            }
            else
            {
                int diff = Math.Abs(oddNumbers - evenNumbers);
                Console.WriteLine("No, diff = {0}", diff);
            }
        }
    }
}
