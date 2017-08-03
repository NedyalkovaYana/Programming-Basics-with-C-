using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.BinaryToHexadecimal
{
    class BinaryToHexadecimal
    {
        static void Main()
        {
            Console.Write("Enter binary: ");
            string bin = Console.ReadLine();

            string hex = Convert.ToInt32(bin, 2).ToString("X");
            Console.WriteLine("Hexadecimal representation: " + hex);
        }
    }
}
