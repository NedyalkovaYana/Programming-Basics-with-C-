using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DrawFort
{
    class DrawFort
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int border = 2 * n;
            int weight = 2*n - ((n/2)+2)*2;
            if ( border == weight)
            {
                Console.WriteLine("/{0}\\/{0}\\",
                new string('^', n / 2));
             
            }
            else
            {
                Console.WriteLine("/{0}\\{1}/{0}\\",
                new string('^', n / 2),
                new string('_', (2 * n - ((n / 2) + 2) * 2)),
                 new string('^', n / 2));
            }
            for (int i = 0; i < n-3; i++)
            {
                Console.WriteLine("|{0}|",
                    new string(' ', (2*n -2)));
               
            }
            if (border == weight)
            {
                Console.WriteLine("\\{0}/\\{0}/",
                new string(' ', n / 2));
            }
            else
            {
                Console.WriteLine("|{0}{1}{0}|",
                new string(' ', ((n / 2 + 1))),
                new string('_', (2 * n - ((n / 2) + 2) * 2)));
            }
            

            if (border == weight)
            {
                Console.WriteLine("\\{0}/\\{0}/",
                new string('_', n / 2));

            }
            else
            {
                Console.WriteLine("\\{0}/{1}\\{0}/",
                new string('_', n / 2),
                new string(' ', (2 * n - ((n / 2) + 2) * 2)));
                 
            }
        }
    }
}
