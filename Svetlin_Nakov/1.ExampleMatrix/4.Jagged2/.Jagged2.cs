using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Jagged2
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 0, 1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2 };
            Console.WriteLine(numbers.Average());
            int n = 3;
        
            List<int>[] result = new List<int>[n];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new List<int>();
            }
            foreach (var num in numbers)
            {
                int remainder = num % n;
                result[remainder].Add(num);
            }
            for (int row = 0; row < result.Length; row++)
            {
                foreach (var num in result[row])
                {
                    Console.Write(num + " " );
                }
                Console.WriteLine();
            }
        }
    }
}
