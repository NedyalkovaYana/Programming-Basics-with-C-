using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FlowerShop
{
    class Program
    {
        static void Main()
        {
            double magnoliiNumber = double.Parse(Console.ReadLine());
            double ziumbiuliNumber = double.Parse(Console.ReadLine());
            double roziNumber = double.Parse(Console.ReadLine());
            double kaktusiNumber = double.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double magnoliiPrice = magnoliiNumber * 3.25d;
            double ziumbiuliPrice = ziumbiuliNumber * 4.0d;
            double roziPrice = roziNumber * 3.50;
            double kaktusiPrice = kaktusiNumber * 8.0;

            double sumFlowers = magnoliiPrice + ziumbiuliPrice +
                roziPrice + kaktusiPrice;
            double payDanuk = (sumFlowers * 5)/ 100;
            double MoneyForPresent = sumFlowers - payDanuk;
            

            if (MoneyForPresent >= presentPrice)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(MoneyForPresent - presentPrice));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(presentPrice - MoneyForPresent));
            }



        }
    }
}
