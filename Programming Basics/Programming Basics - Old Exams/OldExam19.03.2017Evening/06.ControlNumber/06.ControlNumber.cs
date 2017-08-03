using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ControlNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentSum = 0;
            int count = 0;

            for (int i = 1; i <=n; i++)
            {
                for (int j = m; j >=1; j--)
                {
                    count++;
                    currentSum = i * 2 + j * 3;
                    sum += currentSum;
                    if (sum >= controlNumber)
                    {
                        Console.WriteLine("{0} moves", count);
                        Console.WriteLine("Score: {0} >= {1}", sum, controlNumber);
                        return;
                    }
                }
               
            }
            Console.WriteLine("{0} moves", count);
        }
    }
}
