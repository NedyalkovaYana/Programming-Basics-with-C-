using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.JaggedArray
{
    class JaggedArray
    {
        static void Main()
        {
            int[] numbers = { 0, 1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2};
            int[] sizes = new int[3];
            int[] offsets = new int[3];

            //Calculate the size of each reminder (0, 1 and 2)
            foreach (var number in numbers)
            {
                int remainder = number % 3;
                sizes[remainder]++;
            }
            int[][] numbersByRemainder = new int[3][]
            {
                new int[sizes[0]], new int[sizes[1]], new int[sizes[2]]
            };
            foreach (var number in numbers)
            {
                int remainder = number % 3;
                int index = offsets[remainder];
                numbersByRemainder[remainder][index] = number;
                offsets[remainder]++;
            }

            //Print the result Jagged array
            for (int row = 0; row < numbersByRemainder.GetLength(0); row++)
            {
                foreach (var num in numbersByRemainder)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
