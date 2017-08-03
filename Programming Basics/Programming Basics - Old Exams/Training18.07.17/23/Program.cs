using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            double oldPeopleCount = double.Parse(Console.ReadLine());
            double studentsCount = double.Parse(Console.ReadLine());
            double numberNights = double.Parse(Console.ReadLine());
            string typeTransport = Console.ReadLine().ToLower();
            double numberTurist = 0;
            switch (typeTransport)
            {
                case "train":
                    numberTurist = oldPeopleCount + studentsCount;
                    oldPeopleCount *= 24.99 * 2;
                    studentsCount *= 14.99 * 2;
                    break;
                case "bus":
                    oldPeopleCount *= 32.5 * 2;
                    studentsCount *= 28.5 * 2;
                    break;
                case "boat":
                    oldPeopleCount *= 42.99 * 2;
                    studentsCount *= 39.99 * 2;
                    break;
                case "airplane":
                    oldPeopleCount *= 70.0 * 2;
                    studentsCount *= 50.0 * 2;
                    break;
            }
            if (numberTurist >= 50)
            {
               double priceAllGroup = oldPeopleCount + studentsCount;
                double otstupka = priceAllGroup - (priceAllGroup * 0.5);
                double razhodZaHotel1 = numberNights * 82.99;
                double komisionna1 = (razhodZaHotel1 + otstupka) * 0.1;
                double allSum = otstupka + razhodZaHotel1 + komisionna1;
                Console.WriteLine($"{allSum:f2}");
                return;
            }
            else
            {
                double razhodZaTransport = oldPeopleCount + studentsCount;
                double razhodZaHotel = numberNights * 82.99;
                double komisionna = (razhodZaHotel + razhodZaTransport) * 0.1;
                double sum = razhodZaTransport + razhodZaHotel + komisionna;

                Console.WriteLine($"{sum:f2}");
            }
           
        }
    }
}
