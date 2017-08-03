using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hexadecimal: ");
            string hexValue = Console.ReadLine();

            int decAgain = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("Decimal representation: " + decAgain);
        }
    }
}
