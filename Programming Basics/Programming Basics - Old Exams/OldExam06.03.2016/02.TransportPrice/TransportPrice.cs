using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TransportPrice
{
    class TransportPrice
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string partOfaDay = Console.ReadLine();

            if ((partOfaDay == "day") && (n < 20))
            {
                double onlyTaxi = 0.70 + (n * 0.79);
                Console.WriteLine(onlyTaxi);
            }
            else if ((partOfaDay == "night") && (n < 20))
            {
                double onlyTaxi = 0.70 + (n * 0.90);
                Console.WriteLine(onlyTaxi);
            }
            if ((n >= 20) && (n < 100))
            {
                double onlyBus = n * 0.09;
                Console.WriteLine(onlyBus);
            }
            else if (n >= 100)
            {
                double onlyTrain = n * 0.06;
                Console.WriteLine(onlyTrain);
            }
        }
    }
}
