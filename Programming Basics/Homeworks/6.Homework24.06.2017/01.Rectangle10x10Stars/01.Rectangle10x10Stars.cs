using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Rectangle10x10Stars
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i <=10; i++)
            {
                for (int j = 1; j <=10; j++)
                {
                    Console.Write("*",j);
                }
                Console.WriteLine();
            }
        }
    }
}
