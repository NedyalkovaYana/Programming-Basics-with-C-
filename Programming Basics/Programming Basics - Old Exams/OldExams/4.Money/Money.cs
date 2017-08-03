using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Money
{
    class Money
    {
        static void Main()
        {
            double bi = double.Parse(Console.ReadLine());
            double chi = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            double biitkon = bi * 1168;
            double chiense = chi * 0.15;
            double dollar = chiense * 1.76;

            double lv = biitkon + dollar;
            double euro = lv / 1.95;
            double commi = euro * commision/100;
            double result = euro - commi;
            Console.WriteLine("{0:F2}", result);

        }
    }
}
