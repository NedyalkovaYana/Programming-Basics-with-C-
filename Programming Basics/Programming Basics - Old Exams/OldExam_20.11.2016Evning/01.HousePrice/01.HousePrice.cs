using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HousePrice
{
    class Program
    {
        static void Main()
        {
            double smallestRoomArea = double.Parse(Console.ReadLine());
            double kitchenArea = double.Parse(Console.ReadLine());
            double priceSquareMeter = double.Parse(Console.ReadLine());

            double secondRoomArea = smallestRoomArea + (smallestRoomArea * 10)/ 100;
            double thirdRoomArea = secondRoomArea + (secondRoomArea * 10) / 100;
            double toaletRoomArea = smallestRoomArea / 2;
            double totalApartmentArea = smallestRoomArea + secondRoomArea + thirdRoomArea
                + kitchenArea + toaletRoomArea;
            double addFloorArea = totalApartmentArea * 5/ 100;
            double sumApartment = totalApartmentArea + addFloorArea;

            double apartmentPrice = sumApartment * priceSquareMeter;
            Console.WriteLine("{0:f2}", apartmentPrice);

        }
    }
}
