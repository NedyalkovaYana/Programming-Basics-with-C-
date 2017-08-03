using System;


namespace _04
{
    class Program
    {
        static void Main()
        {
            int stadionCapacity = int.Parse(Console.ReadLine());
            double fansCount = double.Parse(Console.ReadLine());
            string fans = string.Empty;
            int sectorA = 0;
            int sectorB = 0;
            int sectorV = 0;
            int sectorG = 0;

            for (int i = 0; i < fansCount; i++)
            {
                fans = Console.ReadLine().ToLower();

                switch (fans)
                {
                    case "a": sectorA++; break;
                    case "b": sectorB++; break;
                    case "v": sectorV++; break;
                    case "g": sectorG++; break;
                }
            }

            double sectorAFans = (sectorA / fansCount) * 100.0;
            double sectorBFans = (sectorB / fansCount) * 100.0;
            double sectorVFans = (sectorV / fansCount) * 100.0;
            double sectorGFans = (sectorG / fansCount) * 100.0;
            double allFance = (fansCount / stadionCapacity) * 100.0;

            Console.WriteLine($"{sectorAFans:f2}%");
            Console.WriteLine($"{sectorBFans:f2}%");
            Console.WriteLine($"{sectorVFans:f2}%");
            Console.WriteLine($"{sectorGFans:f2}%");
            Console.WriteLine($"{allFance:f2}%");


        }
    }
}
