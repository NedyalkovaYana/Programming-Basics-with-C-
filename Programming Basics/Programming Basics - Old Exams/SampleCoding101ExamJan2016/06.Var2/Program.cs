using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Var2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int one = first + second;
            int two = first + third;
            int three = second + third;

            if (one == third)
            {
                Console.WriteLine("{0} + {1} = {3}", first, second, third);
            }
             else if (two == second)
            {
                Console.WriteLine("{0} + {1} = {3}", first, third, second);
            }
            else if (three == first)
            {
                Console.WriteLine("{0} + {1} = {3}", second, third, first);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
