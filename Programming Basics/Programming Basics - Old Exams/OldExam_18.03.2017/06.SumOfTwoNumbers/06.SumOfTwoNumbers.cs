using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumOfTwoNumbers
{
    class Program
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int magickNumber = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = start; i <= stop; i++)
            {
                for (int j = start; j <= stop; j++)
                {
                    count++;
                    if (i + j == magickNumber)
                    {
                        
                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3}) ", count,i,j, magickNumber);
                        return;
                    }
                }
            }
            Console.WriteLine("{0} combinations - neither equals {1}", count, magickNumber);
        }
    }
}
