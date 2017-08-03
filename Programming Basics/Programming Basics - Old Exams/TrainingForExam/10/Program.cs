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
            int tuhliCount = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            int vmestimostKolicka = int.Parse(Console.ReadLine());

            int kursNaRabotnici = workersCount * vmestimostKolicka;
            double obshtoKursove = Math.Ceiling((double)tuhliCount / kursNaRabotnici);
            Console.WriteLine(obshtoKursove);
        }
    }
}
