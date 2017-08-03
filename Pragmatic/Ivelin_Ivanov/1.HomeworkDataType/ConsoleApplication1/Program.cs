using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"The ""quick brown\"" fox jumped/ over \\ the river.\n
""Another"" sentence on a new 'line".";
            Console.WriteLine(text);
        }
    }
}
