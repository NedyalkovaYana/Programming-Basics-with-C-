using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main()
        {
            Console.Write("Enter decimal: ");
            int n = int.Parse(Console.ReadLine());

            string hexValue = n.ToString("X");
            Console.WriteLine("Hexadecimal representation: " + hexValue);
        }
    }
}
