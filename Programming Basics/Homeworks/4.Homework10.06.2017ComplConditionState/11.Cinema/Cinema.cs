using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Cinema
    {
        static void Main()
        {
            string progection = Console.ReadLine().ToLower();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            if (progection == "premiere")
            {
                double prihod = (row * col) * 12.00;
                Console.WriteLine("{0:f2} leva", prihod);
            }
            else if (progection == "normal")
            {
                double prihod = (row * col) * 7.50;
                Console.WriteLine("{0:f2} leva", prihod);
            }
            else if (progection == "discount")
            {
                double prihod = (row * col) * 5.00;
                Console.WriteLine("{0:f2} leva", prihod);
            }
        }
    }
}
