using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            int lekciiCount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double jelev = 0;
            double royal = 0;
            double roli = 0;
            double trifon = 0;
            double sino = 0;
            double gostLektori = 0;

            double salary = budget / lekciiCount;
            for (int i = 1; i <= lekciiCount; i++)
            {
                string lectorName = Console.ReadLine().ToLower();
                switch (lectorName)
                {
                    case "jelev":  jelev += salary;   break;
                    case "royal":  royal += salary;   break;
                    case "roli":   roli += salary;    break;
                    case "trofon": trifon += salary;  break;
                    case "sino":   sino += salary;    break;
                    default:       gostLektori += salary; break;
                }

            }
            Console.WriteLine($"Jelev salary: {jelev:f2} lv");
            Console.WriteLine($"RoYaL salary: {royal:f2} lv");
            Console.WriteLine($"Roli salary: {roli:f2} lv");
            Console.WriteLine($"Trofon salary: {trifon:f2} lv");
            Console.WriteLine($"Sino salary: {sino:f2} lv");
            Console.WriteLine($"Others salary: {gostLektori:f2} lv");

        }
    }
}
