using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Bills
{
    class Program
    {
        static void Main()
        {
            int months = int.Parse(Console.ReadLine());
            double totalSumOtherBills = 0.0;
            double electricityForMonths = 0.0;
            double waterForMonths = months * 20;
            double NetForMonths = months * 15;
           

            for (int i = 1; i <= months; i++)
            {
                double electricityPrice = double.Parse(Console.ReadLine());
                electricityForMonths += electricityPrice;
                double sum = electricityPrice + 20 + 15;
                double sumOtherBills = sum + ((sum * 20) / 100);
                totalSumOtherBills += sumOtherBills;

            }
            double average = (electricityForMonths + waterForMonths + NetForMonths + totalSumOtherBills) / months;
            Console.WriteLine("Electricity: {0:f2} lv", electricityForMonths);
            Console.WriteLine("Water: {0:f2} lv", waterForMonths);
            Console.WriteLine("Internet: {0:f2} lv", NetForMonths);
            Console.WriteLine("Other: {0:f2} lv", totalSumOtherBills);
            Console.WriteLine("Average: {0:f2} lv", average);



        }
    }
}
