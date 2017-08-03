using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int numberNights = int.Parse(Console.ReadLine());
            double studio = 0.0;
            double apartment = 0.0;

            switch (month)
            {
                case "may":
                case "october":  studio = 50.0; apartment = 65.00; break;
                case "june":
                case "september": studio = 75.2; apartment = 68.7; break;
                case "july":
                case "august": studio = 76.0; apartment = 77.0; break;
            }

            double priceForNightStudio = studio * numberNights;
            double priceForNightApartment = apartment * numberNights;

           
            if (month == "may" || month == "october")
            {
                if (numberNights > 14)
                {
                    priceForNightStudio *= 0.7;
                }
                
            }
            if ( month == "june" || month == "september")
            {
                if (numberNights > 14)
                {
                    priceForNightStudio *= 0.8;
                }
            }
            if (numberNights > 14)
            {
                priceForNightApartment *= 0.9;
            }
            if (month == "may" || month == "october")
            {
                if (numberNights > 7 && numberNights < 14)
                {
                    priceForNightStudio *= 0.95;
                }   
            }

            Console.WriteLine($"Apartment: {priceForNightApartment:f2} lv.");
            Console.WriteLine($"Studio: {priceForNightStudio:f2} lv.");

        }
    }
}
