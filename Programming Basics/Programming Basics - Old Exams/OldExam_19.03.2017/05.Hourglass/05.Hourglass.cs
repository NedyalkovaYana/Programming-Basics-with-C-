using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hourglass
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int shirinaVisochina = (2 * n) + 1;

            Console.WriteLine("{0}",
                new string('*', shirinaVisochina));

            for (int i = 1; i <=n; i++)
            {
                int emptySpace = shirinaVisochina - 4;
                int maimunka = shirinaVisochina - 2 * i - 2;
                if (i == 1)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('.', i),
                        new string(' ', emptySpace));
                }
                else if (maimunka == -1)
                {
                    Console.WriteLine("{0}*{0}",
                    new string('.', i));
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('.', i),
                        new string('@', maimunka));
                }
            }
            int dots = n - 1;
            int secondemptySpace = 1;
            int insideDot = dots;
           
            for (int i = 1; i <= n-1; i++)
            {
               
                
                if (i ==1)
                {
                    Console.WriteLine("{0}*@*{0}",
                    new string('.', insideDot));
                    insideDot--;
                   
                }
                else if (i >= 2 && i <= n-2)
                {
                    Console.WriteLine("{0}*{1}@{1}*{0}",
                    new string('.', insideDot),
                    new string(' ',secondemptySpace));
                    insideDot--;
                    secondemptySpace++;
                  
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{0}",
                    new string('.', insideDot),
                    new string('@', shirinaVisochina - 4));
                }
                
                
            }    

            Console.WriteLine("{0}",
                new string('*', shirinaVisochina));
            Console.WriteLine();
        }
    }
}
