using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = a; i <=b; i++)
            {
                for (int j = i+1; j <= b; j++)
                {
                    for (int k = j+1; k <= b; k++)
                    {
                        for (int c = k + 1; c <= b; c++)
                        {
                            Console.WriteLine($"{i} {j} {k} {c}");
                            count++;
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }


        }
    }
}
