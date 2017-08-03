using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a + b == c)
            {
                if (b > a)
                {
                    Console.WriteLine($"{a} + {b} = {c}");
                }
                else
                {
                    Console.WriteLine($"{b} + {a} = {c}");
                }
                
            }
            else if (a + c == b)
            {
                if (c > a)
                {
                    Console.WriteLine($"{a} + {c} = {b}");
                }
                else
                {
                    Console.WriteLine($"{c} + {a} = {b}");
                }
                
            }
            else if (c + b  == a)
            {
                if (b > c)
                {
                    Console.WriteLine($"{c} + {b} = {a}");
                }
                else
                    Console.WriteLine($"{b} + {c} = {a}");
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
