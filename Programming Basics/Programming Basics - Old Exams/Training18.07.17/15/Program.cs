using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnoliiCount = int.Parse(Console.ReadLine());
            int zumbuliCount = int.Parse(Console.ReadLine());
            int roziCount = int.Parse(Console.ReadLine());
            int kaktusiCount = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double magnoliiPrice = 3.25;
            double zumbuliPrice = 4.0;
            double roziPrice = 3.5;
            double kaktusiPrice = 8.0;

            double totalSum = magnoliiCount * magnoliiPrice +
                               zumbuliCount * zumbuliPrice +
                               roziCount * roziPrice +
                               kaktusiCount * kaktusiPrice;

            double sumAfterTakses = totalSum - (totalSum * 0.05);
           
            if (sumAfterTakses >= presentPrice)
            {
                double leftMoney = Math.Floor(sumAfterTakses - presentPrice);
                Console.WriteLine($"She is left with {leftMoney} leva.");
            }
            else
            {
                double leftMoney = Math.Ceiling(presentPrice - sumAfterTakses);
                Console.WriteLine($"She will have to borrow {leftMoney} leva.");
            }
        }
    }
}
