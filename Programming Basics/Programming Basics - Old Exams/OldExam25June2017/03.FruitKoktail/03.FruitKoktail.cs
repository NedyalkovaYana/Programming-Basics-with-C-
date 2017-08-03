using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FruitKoktail
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string litters = Console.ReadLine().ToLower();
            int drinks = int.Parse(Console.ReadLine());
            double priceDrinks = 0.0;
           
            double priceForAllCoktails = 0.0;
            double otstupkaSmall = 0.0;
            double otstupkaBig = 0.0;
            double finalPrice = 0.0;

            if (fruit == "watermelon")
            {
                if (litters == "small")
                {
                    priceDrinks = 2 * 56;
                    priceForAllCoktails = drinks * priceDrinks;
                    if (priceForAllCoktails >= 400 && priceForAllCoktails <=1000)
                    {
                        otstupkaSmall = priceForAllCoktails * 0.15;
                        finalPrice = priceForAllCoktails - otstupkaSmall;
                        Console.WriteLine("{0:f2} lv.", finalPrice);
                        return;
                    }
                    else if (priceForAllCoktails > 1000)
                    {
                        otstupkaBig = priceForAllCoktails * 0.5;
                        finalPrice = priceForAllCoktails - otstupkaBig;
                        Console.WriteLine("{0:f2} lv.", finalPrice);
                        return;
                    }
                    Console.WriteLine("{0:f2} lv.", priceForAllCoktails);
                }
                else if (litters == "big")
                {
                    priceDrinks = 5 * 28.70;
                    priceForAllCoktails = drinks * priceDrinks;
                    if (priceForAllCoktails >= 400 && priceForAllCoktails <= 1000)
                    {
                        otstupkaSmall = priceForAllCoktails * 0.15;
                        finalPrice = priceForAllCoktails - otstupkaSmall;
                        Console.WriteLine("{0:f2} lv.", finalPrice);
                        return;
                    }
                    else if (priceForAllCoktails > 1000)
                    {
                        otstupkaBig = priceForAllCoktails * 0.5;
                        finalPrice = priceForAllCoktails - otstupkaBig;
                        Console.WriteLine("{0:f2} lv.", finalPrice);
                        return;
                    }
                    Console.WriteLine("{0:f2} lv.", priceForAllCoktails);
                }
            }
            else if (fruit == "mango")
            {
                if (litters == "small")
                {
                    priceDrinks = 2 * 36.66;
                    priceForAllCoktails = drinks * priceDrinks;
                    if (priceForAllCoktails >= 400 && priceForAllCoktails <= 1000)
                    {
                        otstupkaSmall = priceForAllCoktails * 0.15;
                        finalPrice = priceForAllCoktails - otstupkaSmall;
                        Console.WriteLine("{0:f2} lv.", finalPrice);
                        return;
                    }
                    else if (priceForAllCoktails > 1000)
                    {
                        otstupkaBig = priceForAllCoktails * 0.5;
                        finalPrice = priceForAllCoktails - otstupkaBig;
                        Console.WriteLine("{0:f2} lv.", finalPrice);
                        return;
                    }
                    Console.WriteLine("{0:f2} lv.", priceForAllCoktails);
                }
                else if (litters == "big")
                {
                    priceDrinks = 5 * 19.60;
                    priceForAllCoktails = drinks * priceDrinks;
                    if (priceForAllCoktails >= 400 && priceForAllCoktails <= 1000)
                    {
                        otstupkaSmall = priceForAllCoktails * 0.15;
                        finalPrice = priceForAllCoktails - otstupkaSmall;
                        Console.WriteLine("{0:f2} lv.", finalPrice);
                        return;
                    }
                    else if (priceForAllCoktails > 1000)
                    {
                        otstupkaBig = priceForAllCoktails * 0.5;
                        finalPrice = priceForAllCoktails - otstupkaBig;
                        Console.WriteLine("{0:f2} lv.", finalPrice);
                        return;
                    }
                    Console.WriteLine("{0:f2} lv.", priceForAllCoktails);
                }
            }
            else if (fruit == "pineapple")
            {
                if (litters == "small")
                {
                    priceDrinks = 2 * 42.10;
                    priceForAllCoktails = drinks * priceDrinks;
                    if (priceForAllCoktails >= 400 && priceForAllCoktails <= 1000)
                    {
                        otstupkaSmall = priceForAllCoktails * 0.15;
                        finalPrice = priceForAllCoktails - otstupkaSmall;
                        Console.WriteLine("{0:f2} lv.", finalPrice);
                        return;
                    }
                    else if (priceForAllCoktails > 1000)
                    {
                        otstupkaBig = priceForAllCoktails * 0.5;
                        finalPrice = priceForAllCoktails - otstupkaBig;
                        Console.WriteLine("{0:f2} lv.", finalPrice);
                        return;
                    }
                    Console.WriteLine("{0:f2} lv.", priceForAllCoktails);
                }
                else if (litters == "big")
                {
                    priceDrinks = 5 * 24.80;
                    priceForAllCoktails = drinks * priceDrinks;
                    if (priceForAllCoktails >= 400 && priceForAllCoktails <= 1000)
                    {
                        otstupkaSmall = priceForAllCoktails * 0.15;
                        finalPrice = priceForAllCoktails - otstupkaSmall;
                        Console.WriteLine("{0:f2} lv.", finalPrice);
                        return;
                    }
                    else if (priceForAllCoktails > 1000)
                    {
                        otstupkaBig = priceForAllCoktails * 0.5;
                        finalPrice = priceForAllCoktails - otstupkaBig;
                        Console.WriteLine("{0:f2} lv.", finalPrice);
                        return;
                    }
                    Console.WriteLine("{0:f2} lv.", priceForAllCoktails);
                }
            }
            else if (fruit == "raspberry")
            {
                if (litters == "small")
                {
                    priceDrinks = 2 * 20.0;
                    priceForAllCoktails = drinks * priceDrinks;
                    if (priceForAllCoktails >= 400 && priceForAllCoktails <= 1000)
                    {
                        otstupkaSmall = priceForAllCoktails * 0.15;
                        finalPrice = priceForAllCoktails - otstupkaSmall;
                        Console.WriteLine("{0:f2} lv.", finalPrice);
                        return;
                    }
                    else if (priceForAllCoktails > 1000)
                    {
                        otstupkaBig = priceForAllCoktails * 0.5;
                        finalPrice = priceForAllCoktails - otstupkaBig;
                        Console.WriteLine("{0:f2} lv.", finalPrice);
                        return;
                    }
                    Console.WriteLine("{0:f2} lv.", priceForAllCoktails);
                }
                else if (litters == "big")
                {
                    priceDrinks = 5 * 15.20;
                    priceForAllCoktails = drinks * priceDrinks;
                    if (priceForAllCoktails >= 400 && priceForAllCoktails <= 1000)
                    {
                        otstupkaSmall = priceForAllCoktails * 0.15;
                        finalPrice = priceForAllCoktails - otstupkaSmall;
                        Console.WriteLine("{0:f2} lv.", finalPrice);
                        return;
                    }
                    else if (priceForAllCoktails > 1000)
                    {
                        otstupkaBig = priceForAllCoktails * 0.5;
                        finalPrice = priceForAllCoktails - otstupkaBig;
                        Console.WriteLine("{0:f2} lv.", finalPrice);
                        return;
                    }
                    Console.WriteLine("{0:f2} lv.", priceForAllCoktails);
                }
            }


        }
    }
}
