using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int cookers = int.Parse(Console.ReadLine());
            int cakesCount = int.Parse(Console.ReadLine());
            int gofretiCount = int.Parse(Console.ReadLine());
            int pancakeCount = int.Parse(Console.ReadLine());

            double cakePrice = 45.0;
            double gofretaPrice = 5.8;
            double pancakePrice = 3.2;

            double sumFromOneDay = (cakePrice * cakesCount +
                                   gofretaPrice * gofretiCount +
                                   pancakePrice * pancakeCount) * cookers;

            double sumFromCompany = sumFromOneDay * days;
            sumFromCompany -= sumFromCompany * (1.0 / 8.0);

            Console.WriteLine($"{sumFromCompany:f2}");

        }
    }
}
