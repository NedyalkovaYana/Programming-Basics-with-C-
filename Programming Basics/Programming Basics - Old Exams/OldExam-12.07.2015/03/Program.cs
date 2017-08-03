using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main()
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());

            int sideOfTriangle = Math.Abs(x2 - x3);
            int hightOfTriangle = Math.Abs(y2 - y1);
            double AreaOfTriangle = (double)(sideOfTriangle * hightOfTriangle) / 2;

            Console.WriteLine(AreaOfTriangle);
        }
    }
}
