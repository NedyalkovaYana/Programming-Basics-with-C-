using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.EvenOROdd
{
    class EvenOROdd
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            

            if (number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else if (number % 2 != 0)
            {
                Console.WriteLine("odd");
            }
        }
    }
}
