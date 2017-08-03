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
            int groupCount = int.Parse(Console.ReadLine());
            double car = 0.0;
            double microbus = 0.0;
            double littleBus = 0.0;
            double bigBus = 0.0;
            double train = 0.0;
            double sumGroup = 0.0;

            for (int i = 0; i < groupCount; i++)
            {
                double numberOfPeopleInGroup = double.Parse(Console.ReadLine());
                sumGroup += numberOfPeopleInGroup;
                if (numberOfPeopleInGroup <= 5)
                {
                    car += numberOfPeopleInGroup;
                }
                else if (numberOfPeopleInGroup <= 12)
                {
                    microbus += numberOfPeopleInGroup;
                }
                else if (numberOfPeopleInGroup <= 25)
                {
                    littleBus += numberOfPeopleInGroup;
                }
                else if (numberOfPeopleInGroup <= 40)
                {
                    bigBus += numberOfPeopleInGroup;
                }
                else if (numberOfPeopleInGroup >= 41)
                {
                    train += numberOfPeopleInGroup;
                }              
            }
            double carProcent = (car / sumGroup) * 100;
            double microbusProcent = (microbus / sumGroup) * 100;
            double littleBusProcent = (littleBus/ sumGroup) *100;
            double bigBusProcent = (bigBus / sumGroup) * 100;
            double trainProcent = (train / sumGroup) * 100;

            Console.WriteLine($"{carProcent:f2}%");
            Console.WriteLine($"{microbusProcent:f2}%");
            Console.WriteLine($"{littleBusProcent:f2}%");
            Console.WriteLine($"{bigBusProcent:f2}%");
            Console.WriteLine($"{trainProcent:f2}%");
        }
    }
}
