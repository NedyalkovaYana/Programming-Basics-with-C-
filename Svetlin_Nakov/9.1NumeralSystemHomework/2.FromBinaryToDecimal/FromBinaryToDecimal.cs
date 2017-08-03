using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.FromBinaryToDecimal
{
    class FromBinaryToDecimal
    {
        static void Main()
        {
            Console.Write("Enter binary: ");
            string n = Console.ReadLine();

            int b = Convert.ToInt32(n, 2);
            Console.WriteLine("Decimal = " + b);
            
        }
    }
}
