using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_PerfectDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}*{0}",
                new string(' ',n-1 ));
            int blanckSpace = n - 2;
            int inside = 1;

            for (int i = 1; i < n; i++)
            {
                Console.Write(new string(' ',blanckSpace));
                Console.Write("*");
                Console.Write("{0}", GenerateFrom("-*", inside));
                Console.Write(new string(' ', blanckSpace));
                Console.WriteLine();
                blanckSpace--;
                inside++;
            }
            blanckSpace = 1;
            inside= n-2;
            for (int i = 1; i < n; i++)
            {
                Console.Write(new string(' ', blanckSpace));
                Console.Write("*");
                Console.Write("{0}", GenerateFrom("-*", inside));
                Console.Write(new string(' ', blanckSpace));
                Console.WriteLine();
                blanckSpace++;
                inside--;

            }


        }
        private static string GenerateFrom(string input, int times)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < times; i++)
            {
                builder.Append(input);
            }

            return builder.ToString();
        }
    }
} 
