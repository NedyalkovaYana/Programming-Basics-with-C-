using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int specialNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
            double newNumber = 0;

            for (int i = m; i >= 1; i--)
            {
                for (int j = n; j >= 1; j--)
                {
                    for (int k = l; k >= 1; k--)
                    {
                        newNumber = i * 100 + j * 10 + k;
                        if (newNumber % 3 ==0)
                        {
                            specialNumber += 5;
                        }
                        else if (k == 5)
                        {
                            specialNumber -= 2;
                        }
                        else if (k % 2 == 0)
                        {
                            specialNumber *= 2;
                        }
                        if (specialNumber >= controlNumber)
                        {
                            Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNumber}.");
                            return;
                        }

                    }
                }
            }
                Console.WriteLine($"No! {specialNumber} is the last reached special number.");   
        }
    }
}
