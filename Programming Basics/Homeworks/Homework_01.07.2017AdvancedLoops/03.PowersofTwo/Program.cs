using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PowersofTwo
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
         
            int num = 1;
            for (var i = 0; i <= n; i++)
            {
                Console.WriteLine(num);
                num = num * 2;
            }
        }
    }
}
