using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.StupidPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (char a = 'a'; a < (char)97+l; a++)
                    {
                        for (char b = 'a'; b < 'a'+l; b++)
                        {
                            for (int c =Math.Max(i,j)+1; c <=n; c++)
                            {
                                Console.WriteLine("{0}{1}{2}{3}{4}", i, j, a, b, c);
                            }
                        }
                    }
                }
            }
        }
    }
}
