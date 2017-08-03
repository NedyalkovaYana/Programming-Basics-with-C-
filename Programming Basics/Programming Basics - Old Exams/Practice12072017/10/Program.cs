using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            double stadionCapacity = double.Parse(Console.ReadLine());
            double allFansCount = double.Parse(Console.ReadLine());
            double sectorA = 0;
            double sectorB = 0;
            double sectorG = 0;
            double sectorV = 0;

            for (int i = 1; i <= allFansCount; i++)
            {
                string sectorsFans = Console.ReadLine().ToLower();
                switch (sectorsFans)
                {
                    case "a": sectorA++; break;
                    case "b": sectorB++; break;
                    case "v": sectorV++; break;
                    case "g": sectorG++; break;
                }
            }
            double fansA = sectorA / allFansCount * 100.0;
            double fansB = (sectorB / allFansCount) * 100.0;
            double fansV = (sectorV / allFansCount) * 100.0;
            double fansG = (sectorG / allFansCount) * 100.0;

            double allFansPrecent = (allFansCount / stadionCapacity) * 100;
            Console.WriteLine($"{fansA:f2}%");
            Console.WriteLine($"{fansB:f2}%");
            Console.WriteLine($"{fansV:f2}%");
            Console.WriteLine($"{fansG:f2}%");
            Console.WriteLine($"{allFansPrecent:f2}%");

        }
    }
}
