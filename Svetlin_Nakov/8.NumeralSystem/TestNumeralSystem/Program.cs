using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumeralSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0xFE;
            Console.WriteLine(value);

            int valie1 = 16;
            Console.WriteLine(valie1);

            unchecked
            {
                sbyte number = (sbyte)0xFE;
                Console.WriteLine(number);
            }

            byte num = (byte)0xFE;
            Console.WriteLine(num);

            int x = 500;
            while (x>0)
            {
                Console.Write(x % 2);
                x = x / 2;
            }
            Console.WriteLine();

            string s = "1FA";
            int d = s[2] - '0';
            if (d >10)
            {
                d = s[2] - 'A' + 10;
            }
            Console.WriteLine(d);



        }
    }
}
