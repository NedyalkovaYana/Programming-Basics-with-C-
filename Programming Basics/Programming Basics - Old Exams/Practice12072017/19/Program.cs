using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            double houseHight = double.Parse(Console.ReadLine());
            double widthOnWall = double.Parse(Console.ReadLine());
            double hightOnTriangleWall = double.Parse(Console.ReadLine());

            //Steni
            double stranichnaStenaArea = houseHight * widthOnWall;
            double windowsArea = 1.5 * 1.5;
            double twoWallsArea = (stranichnaStenaArea * 2) - (2 * windowsArea);
            double backWall = houseHight * houseHight;
            double vhod = 1.2 * 2;
            double totalFrontAndBackWall = 2 * backWall - vhod;
            double totalArea = twoWallsArea + totalFrontAndBackWall;
            double greenPaint = totalArea / 3.4;

            //Pokriv
            double twoRectangles = 2 * (houseHight * widthOnWall);
            double twoTriangles = 2 * (hightOnTriangleWall * houseHight / 2);
            double totalRoofArea = twoRectangles + twoTriangles;
            double redPaint = totalRoofArea / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
