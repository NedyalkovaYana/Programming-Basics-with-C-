using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.FromDecimalToBinary
{
    class FromDecimalToBinary
    {
       

        static void Main()
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());

            int value = n;
            string binary = Convert.ToString(value, 2);
            Console.WriteLine(binary);

            //while (n > 0)
            //{
            //    Console.Write(n % 2);
            //    n = n / 2;
            //}
            //Console.WriteLine();

        }
    }
}
