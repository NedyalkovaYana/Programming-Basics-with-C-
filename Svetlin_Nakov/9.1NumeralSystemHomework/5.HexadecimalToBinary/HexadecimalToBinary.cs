using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.HexadecimalToBinary
{
    class HexadecimalToBinary
    {
        static void Main()
        {
            Console.Write("Enter hexadecimal: ");
            string hexValue = Console.ReadLine();

            var s = String.Join("",
                      hexValue.Select(x => Convert.ToString(Convert.ToInt32(x + "", 16), 2).PadLeft(4, '0')));
            Console.WriteLine("Binary representation: " + s);
        }
    }
}
