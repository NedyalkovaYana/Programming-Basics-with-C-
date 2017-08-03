using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.InvalidNumber
{
    class InvalidNumber
    {
        static void Main()
        {

            int number = int.Parse(Console.ReadLine());
            if (number != 0 && number < 100 || number > 200)
            {
                Console.WriteLine("invalid");
            }
            
        }
    }
}
