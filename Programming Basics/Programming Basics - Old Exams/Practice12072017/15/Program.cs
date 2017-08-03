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
            string season = Console.ReadLine().ToLower();
            double kmForMonth = double.Parse(Console.ReadLine());
            double price = 0;

            switch (season)
            {
                case "spring":
                case "autumn":
                   if       (kmForMonth <= 5000)   price = 0.75;
                   else if (kmForMonth <= 10000)   price = 0.95;
                   else if (kmForMonth <= 20000)   price = 1.45; break;

                case "summer":
                    if      (kmForMonth <= 5000)   price = 0.9;
                    else if (kmForMonth <= 10000)  price = 1.1;
                    else if (kmForMonth <= 20000)  price = 1.45; break;
                  
                case "winter":                   
                    if      (kmForMonth <= 10000)   price = 1.25;
                    else if (kmForMonth <= 5000)    price = 1.05;
                    else if (kmForMonth <= 20000)   price = 1.45; break; 
           

            }

            double salary = (kmForMonth * price) * 4;
            salary -= salary * 0.1;
            Console.WriteLine($"{salary:f2}");
        }
    }
}
