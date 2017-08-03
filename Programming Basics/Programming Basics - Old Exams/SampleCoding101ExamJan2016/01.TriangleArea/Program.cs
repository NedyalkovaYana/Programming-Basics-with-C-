using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //x1, y1, x2, y2, x3, y3
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
             y2 = y3;

            double sideA = Math.Abs(x2 - x3);
            double h = Math.Abs(y2 - y1);
            double triangleArea = (sideA * h) / 2;
            Console.WriteLine(triangleArea);

        }
    }
}
