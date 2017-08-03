using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            int left = Math.Min(first, second);
            int right = Math.Max(first, second);

            int distanceLeft = Math.Abs(left - point);
            int distanseRight = Math.Abs(point - right);

            int minDistance = Math.Min(distanceLeft, distanseRight);

            if (point >= left && point <= right)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
            Console.WriteLine(minDistance);
        }
    }
}
