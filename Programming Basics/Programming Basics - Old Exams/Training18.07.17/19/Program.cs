using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int maxCombinations= int.Parse(Console.ReadLine());
            int countCombination = 0;
            for (int i = start; i <= stop; i++)
            {
                for (int j = start; j <= stop; j++)
                {
                    countCombination++;
                    if (countCombination > maxCombinations)
                    {
                        return;
                    }
                    else
                    {
                        Console.Write($"<{i}-{j}>");
                        
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
