using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Enumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[,]
            {
                {1, 2, 3},
                {1, 2, 3},
                {1, 2, 3},
                {1, 2, 3},
                {1, 2, 3},
            };
            foreach (var item in m)
            {
                Console.WriteLine(item);
            }

        }
    }
}
