using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PlatesRepair
{
    class PlatesRepair
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double o = double.Parse(Console.ReadLine());

            double playground = n * n;
            double bench = m * o;
            double plate = l * w;

            double аrеа = playground - bench;
            double result = аrеа / plate;
            double time = result * 0.2;
            Console.WriteLine("{0:F2}", result);
            Console.WriteLine("{0:F2}", time);
        }
    }
}
