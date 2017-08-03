using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SvetovenRekordPoPluvane
{
    class Program
    {
        static void Main()
        {
            double rekord = double.Parse(Console.ReadLine());
            double metriRazstoqnie = double.Parse(Console.ReadLine());
            double neededTime = double.Parse(Console.ReadLine());

            double spentSum = metriRazstoqnie * neededTime;
            double zabavqne = Math.Floor((metriRazstoqnie / 15) * 12.5);
            double totalTime = spentSum + zabavqne;

            if (totalTime <= rekord)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds.", totalTime);
            }
            else
            {
                double izostavane = totalTime - rekord;
                Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", izostavane);
            }
        }
    }
}
