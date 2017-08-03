using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.EqualPairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            var numbers = int.Parse(Console.ReadLine());
            var currentSum = 0;
            var previousSum = 0;
            var difference = 0;
            var maxDifference = 0;

            for (int i = 0; i < numbers; i++)
            {
                previousSum = currentSum;
                currentSum = 0;
                currentSum += int.Parse(Console.ReadLine());
                currentSum += int.Parse(Console.ReadLine());
                if (i != 0)
                {
                    difference = Math.Abs(currentSum - previousSum);
                    if (difference != 0 && difference > maxDifference)
                    {
                        maxDifference = difference;
                    }
                }

            }
            if (previousSum == currentSum || numbers == 1)
            {
                Console.WriteLine("Yes, value={0}", currentSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDifference);
            }
        }
    }
}
