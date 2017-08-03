using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
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
                    for (char a = 'a'; a <'a'+ l; a++)
                    {
                        for (char b = 'a'; b <'a' + l; b++)
                        {
                            for (int c = Math.Max(i, j) + 1; c <= n; c++)
                            {
                                Console.Write($"{i}{j}{a}{b}{c} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
