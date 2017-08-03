using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hungry_Garfield
{
    class Program
    {
        static void Main()
        {
            decimal moneyInDollars = decimal.Parse(Console.ReadLine());
            decimal dollarExchangeRate = decimal.Parse(Console.ReadLine());
            decimal pizzaPriceLeva = decimal.Parse(Console.ReadLine());
            decimal lasagnaPriceLeva = decimal.Parse(Console.ReadLine());
            decimal sandwichPriceLeva = decimal.Parse(Console.ReadLine());
            decimal pizzaQuantity = decimal.Parse(Console.ReadLine());
            decimal lasagnaQuantity = decimal.Parse(Console.ReadLine());
            decimal sandwichQuantity = decimal.Parse(Console.ReadLine());

            decimal usingMoney = (pizzaPriceLeva / dollarExchangeRate) * pizzaQuantity +
                                 (lasagnaPriceLeva / dollarExchangeRate) * lasagnaQuantity +
                                 (sandwichPriceLeva / dollarExchangeRate) * sandwichQuantity;

            decimal total = Math.Abs(moneyInDollars - usingMoney);

            if (usingMoney <= moneyInDollars)
            {
                Console.WriteLine($"Garfield is well fed, John is awesome. Money left: ${total:f2}.");
            }
            else
            {
                Console.WriteLine($"Garfield is hungry. John is a badass. Money needed: ${total:f2}.");
            }

        }
    }
}
