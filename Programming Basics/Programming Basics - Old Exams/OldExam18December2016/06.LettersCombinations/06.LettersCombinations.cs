using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.LettersCombinations
{
    class Program
    {
        static void Main()
        {
            char start = char.Parse(Console.ReadLine());
            char stop = char.Parse(Console.ReadLine());
            char notPrint = char.Parse(Console.ReadLine());
            int count = 0;

            for (char i = start; i <= stop; i++)
            {
                for (char j = start; j <= stop; j++)
                {
                    for (char k = start; k <= stop; k++)
                    {
                        
                        if (i == notPrint || j == notPrint || k == notPrint)
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write("{0}{1}{2} ", i,j,k);
                            count++;
                        }
                    }
                }

            }
            Console.Write(count);
            Console.WriteLine();

        }
    }
}
