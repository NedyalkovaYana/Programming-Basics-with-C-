using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            int cupsCount = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());

            double workingHours = workersCount * workingDays * 8.0;
            double madedCups =Math.Floor(workingHours / 5);
            double losesCups = Math.Abs(cupsCount - madedCups) * 4.2;
        
            if (madedCups < cupsCount)
            {
                Console.WriteLine($"Losses: {losesCups:f2}");
            }
            else
            {
                Console.WriteLine($"{losesCups:f2} extra money");
            }

        }
    }
}
