using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PointOnSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double point = double.Parse(Console.ReadLine());

            double dist1 = Math.Abs(first - point);
            double dist2 = Math.Abs(second - point);
            double distance = Math.Min(dist1, dist2);

            if (point >= Math.Min(first, second) && point <= Math.Max(first, second))
            {
                Console.WriteLine("in");
                Console.WriteLine("{0}", distance);

            }
            else
            {
                Console.WriteLine("out");
                Console.WriteLine("{0}", distance);
            }
        }
    }
}
