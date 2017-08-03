using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysForTraining = int.Parse(Console.ReadLine());
            int dancerCount = int.Parse(Console.ReadLine());
            double energy = 0.0;

            for (int i = 1; i <=daysForTraining; i++)
            {
                int hoursForTraining = int.Parse(Console.ReadLine( ));
                if (i % 2 ==0)
                {
                    if (hoursForTraining % 2 == 0)
                    {
                        energy += 68 * dancerCount; 
                    }
                    else
                    {
                        energy += 65 * dancerCount;
                    }

                }
                else
                {
                    if (hoursForTraining % 2 ==0 )
                    {
                        energy += 49 * dancerCount;
                    }
                    else
                    {
                        energy += 30 * dancerCount;
                    }
                }
                

            }

            double totalEnergyBeforeTraining = 100 * daysForTraining * dancerCount;
            double neizhabenaEnergiqZaVsichkiDni = totalEnergyBeforeTraining - energy;
            double neizhabenaEnergiqOtEdin = neizhabenaEnergiqZaVsichkiDni / daysForTraining / dancerCount;

            if (neizhabenaEnergiqOtEdin >= 50)
            {
                Console.WriteLine($"They feel good! Energy left: {neizhabenaEnergiqOtEdin:f2}");
            }
            else
            {
                Console.WriteLine($"They are wasted! Energy left: {neizhabenaEnergiqOtEdin:f2}");
            }
        }
    }
}
