using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int body = n - 2;

            Console.WriteLine("{0}{1}{0}",
                new string('*', n*2));
            for (int i = 0; i < body; i++)
            {
                Console.WriteLine("*{0}*",
                    new string('/', 2*n-2));
            }
            Console.WriteLine(starsBase);


        }
        private static string GenerateFrom(string input, int times)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < times; i++)
            { builder.Append(input); }
            return builder.ToString();
        }
    }
}
