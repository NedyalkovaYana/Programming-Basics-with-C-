using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double electricityBill = 0.0;
            double totalSumElectrisity = 0.0;
            double waterBill = 20.0;
            double internetBill = 15.0;
            double otherBill = 0.0;
            double totalOtherBill = 0.0;
            for (int i = 1; i <= months; i++)
            {
                electricityBill = double.Parse(Console.ReadLine());
                totalSumElectrisity += electricityBill;
                otherBill = (waterBill + internetBill + electricityBill) +
                            ((waterBill + internetBill + electricityBill) * 0.2);
                totalOtherBill += otherBill;
            }
            waterBill *= months;
            internetBill *= months;
            double average = (waterBill + internetBill + totalSumElectrisity + totalOtherBill) / months;
            Console.WriteLine($"Electricity: {totalSumElectrisity:f2} lv");
            Console.WriteLine($"Water: {waterBill:f2} lv");
            Console.WriteLine($"Internet: {internetBill:f2} lv");
            Console.WriteLine($"Other: {totalOtherBill:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");



        }
    }
}
