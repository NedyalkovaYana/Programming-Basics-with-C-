using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LatinLetters
{
    class LatinLetters
    {
        static void Main()
        {
            for (var letter = 'a'; letter <='z'; letter++)
            {
                Console.WriteLine(letter);
            }
            Console.WriteLine();
        }
    }
}
