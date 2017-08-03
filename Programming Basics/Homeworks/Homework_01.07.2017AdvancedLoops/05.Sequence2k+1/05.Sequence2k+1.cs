using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence2k_1
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            while (num <=n)
            {
                Console.WriteLine(num);
                num = 2 * num + 1;
            }
        }
    }
}
