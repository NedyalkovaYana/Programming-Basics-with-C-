using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            double littlestRoomArea = double.Parse(Console.ReadLine());
            double kitchenArea = double.Parse(Console.ReadLine());
            double priceKvM = double.Parse(Console.ReadLine());

            double bathRoomArea = littlestRoomArea / 2;
            double secondRoomArea = littlestRoomArea + 
                                    (littlestRoomArea * 0.1);
            double thirdRoomArea = secondRoomArea +
                                   (secondRoomArea * 0.1);
            double apartmentArea = bathRoomArea +
                                   littlestRoomArea +
                                   secondRoomArea + thirdRoomArea
                                   + kitchenArea;
            apartmentArea = apartmentArea + (apartmentArea * 0.05);
            double apartmentPrice = apartmentArea * priceKvM;
            Console.WriteLine($"{apartmentPrice:f2}");
        }
    }
}
