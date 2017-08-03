using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.TestMyFunction
{
    class TestMyFunction
    {
        static int Min(params int[] sequence)
        {
            int min = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] > 0)
                {
                    min = sequence[i];
                    break;
                }
            }
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] < min && sequence[i] > 0)
                {
                    min = sequence[i];
                }
            }
            return min;
        }
        static int Max(params int[] sequence)
        {
            int max = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] > 0)
                {
                    max = sequence[i];
                    break;
                }
            }
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] > max && sequence[i] > 0)
                {
                    max = sequence[i];
                }
            }
            return max;
        }
        static int Sum(params int[] sequence)
        {
            int sum = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                sum += sequence[i];
            }
            return sum;
        }
        static int Average(params int[] sequence)
        {
            int sum =0;
            int sequenceLength = sequence.GetLength(0);
            foreach  ( int x in sequence)
            {
                sum += x;
            }
            return sum / sequenceLength;
        }
        static int Product(params int[] sequence)
        {
            int product = 1;
            for (int i = 0; i < sequence.Length; i++)
            {
                product *= sequence[i];
            }
            return product;
        }
        static void Main()
        {
            int min = Min(6, 3, 2);
            int max = Max(6, 3, 2);
            int sum = Sum(6, 3, 2);
            int average = Average(6, 3, 2);
            int product = Product(6, 3, 2);

            Console.WriteLine("Min: {0}\nMax: {1}\nSum: {2}\nAverage: {3}\nProduct: {4}", min, max, sum, average, product);

        }
    }
}
