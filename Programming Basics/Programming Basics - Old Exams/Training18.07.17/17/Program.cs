using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            int tovariCount = int.Parse(Console.ReadLine());
            double microbus = 0.0;
            double truck = 0.0;
            double train = 0.0;
            double tovariSum = 0.0;

            for (int i = 0; i < tovariCount; i++)
            {
                double tonajNaTovara = double.Parse(Console.ReadLine());
                tovariSum += tonajNaTovara;
                if (tonajNaTovara <= 3)
                {
                    microbus+= tonajNaTovara;
                }
                else if (tonajNaTovara >= 4 && tonajNaTovara <=11)
                {
                    truck += tonajNaTovara;
                }
                else if (tonajNaTovara >=12 )
                {
                    train += tonajNaTovara;
                }
            }
            double averageOnTon =((microbus * 200) +
                                  (truck * 175) +
                                  (train * 120))/tovariSum;
            double withMicrobus = (microbus/tovariSum)*100;
            double withTruck = (truck / tovariSum) * 100;
            double withTrain = (train / tovariSum) * 100;
            Console.WriteLine($"{averageOnTon:f2}");
            Console.WriteLine($"{withMicrobus:f2}%");
            Console.WriteLine($"{withTruck:f2}%");
            Console.WriteLine($"{withTrain:f2}%");
        }
    }
}
