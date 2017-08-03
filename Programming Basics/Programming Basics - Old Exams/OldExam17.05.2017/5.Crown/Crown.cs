using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Crown
{
    class Crown
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int height = (n / 2) + 4;
            int weight = (2 * n) - 1;

            Console.WriteLine("@{1}@{1}@", 
                new string('@', 1), 
                new string(' ', (weight - 3) / 2));

            Console.WriteLine("**{0}*{0}**",
                new string(' ', (weight - 5) / 2));

            for (int i = 0; i < height - 6; i++)
            {
                Console.WriteLine("*.{0}* {1}*{2}.{2}*{1} *{0}.*",
                    new string('.', i),
                    new string(' ', (weight - 9 - 1 - (4 * i)) / 2), 
                    new string('.', i));
            }
            Console.WriteLine("*{0}*{1}.{1}*{0}*", 
                new string('.', (n / 2) - 1), 
                new string('.', (n / 2) - 2));
            Console.WriteLine("*{0}{1}.{1}{0}*", 
                new string('.', n / 2), 
                new string('*', ((weight - 3) - n) / 2));
            Console.WriteLine("{0}",
                new string('*', weight));
            Console.WriteLine("{0}", 
                new string('*', weight));
        }
    
    }
}
