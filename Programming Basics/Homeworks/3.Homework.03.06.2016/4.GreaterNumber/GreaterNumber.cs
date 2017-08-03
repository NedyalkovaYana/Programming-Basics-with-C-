using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.GreaterNumber
{
    class GreaterNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int anothernumber = int.Parse(Console.ReadLine());

            if (number > anothernumber)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine(anothernumber);
            }
        }
    }
}
