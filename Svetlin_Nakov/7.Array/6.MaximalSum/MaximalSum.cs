using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            int n = 3;
            int k = 6;
            int sum = 0;
            int bestSum = int.MinValue;
            int tmpindex = 0;
            int endIndexOfMax = 0;

            Console.Write("N = ");
            string strN = Console.ReadLine();
            Console.Write("K = ");
            string strK = Console.ReadLine();

            if (!int.TryParse(strN, out n) || (!int.TryParse(strK, out k) || k > n))
            {
                Console.WriteLine("Invalid numbers!");
            }

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter array elements {0}", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < (n - k + 1); j++)
            {
                for (int p = j; p < k + j; p++)
                {
                    sum += array[p];
                    tmpindex = p;
                }
                if (sum > bestSum)
                {
                    bestSum = sum;
                    endIndexOfMax = tmpindex;
                }
                sum = 0;

            }
            Console.WriteLine("The maximal sum of {0} sequent element is: {1}", k, bestSum);
            Console.Write("{");
            for (int i = (endIndexOfMax - k + 1); i <= endIndexOfMax; i++)
            {
                if (i == endIndexOfMax)
                {
                    Console.Write("{0}", array[i]);
                }
                else
                {
                    Console.Write("{0}, ", array[i]);
                }
            }
            Console.WriteLine("}");
            
        }
    }
}
