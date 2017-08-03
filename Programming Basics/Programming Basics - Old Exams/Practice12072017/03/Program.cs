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
            string fruit = Console.ReadLine().ToLower();
            string liter = Console.ReadLine().ToLower();
            int numbersOfDrinks = int.Parse(Console.ReadLine());

            double smallDinq = 56.0;
            double bigDinq = 28.7;
            double smallMango = 36.66;
            double bigMango = 19.6;
            double smallAnanas = 42.1;
            double bigAnanas = 24.8;
            double smallMalina = 20.0;
            double bigMalina = 15.2;
            double priceForOneCoctail = 0;
            double coctailPrice = 0;

            switch (fruit)
            {
                case "watermelon":
                    switch (liter)
                    {
                        case "small":
                            priceForOneCoctail = smallDinq * 2;
                            coctailPrice = numbersOfDrinks * priceForOneCoctail; break;
                        case "big":
                            priceForOneCoctail = bigDinq * 5;
                            coctailPrice = numbersOfDrinks * priceForOneCoctail; break;
                    }
                    break;
                case "mango":
                    switch (liter)
                    {
                        case "small":
                            priceForOneCoctail = smallMango * 2;
                            coctailPrice = numbersOfDrinks * priceForOneCoctail; break;
                        case "big":
                            priceForOneCoctail = bigMango * 5;
                            coctailPrice = numbersOfDrinks * priceForOneCoctail; break;
                    }
                    break;
                case "pineapple":
                    switch (liter)
                    {
                        case "small":
                            priceForOneCoctail = smallAnanas * 2;
                            coctailPrice = numbersOfDrinks * priceForOneCoctail; break;
                        case "big":
                            priceForOneCoctail = bigAnanas * 5;
                            coctailPrice = numbersOfDrinks * priceForOneCoctail; break;
                    }
                    break;
                case "raspberry":
                    switch (liter)
                    {
                        case "small":
                            priceForOneCoctail = smallMalina * 2;
                            coctailPrice = numbersOfDrinks * priceForOneCoctail; break;
                        case "big":
                            priceForOneCoctail = bigMalina * 5;
                            coctailPrice = numbersOfDrinks * priceForOneCoctail; break;
                    }
                    break;

            }
            if (coctailPrice > 1000)
            {
                coctailPrice -= coctailPrice * 0.5;
            }
            else if (coctailPrice >= 400)
            {
                coctailPrice -= coctailPrice * 0.15;
            }

            Console.WriteLine($"{coctailPrice:f2} lv.");

        }
    }
}
