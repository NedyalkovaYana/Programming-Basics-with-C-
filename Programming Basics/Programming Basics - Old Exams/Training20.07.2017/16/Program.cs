using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count2 = 0;
            var count3 = 0;
            var count4 = 0;

            for (var i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number % 2 == 0) count2++;
                if (number % 3 == 0) count3++;
                if (number % 4 == 0) count4++;
            }

            
            Console.WriteLine($"{(count2 / (double)n) * 100:f2}%");
            Console.WriteLine($"{(count3 /(double)n) * 100:f2}%");
            Console.WriteLine($"{(count4 / (double)n) * 100:f2}%");
        }
    }
}
