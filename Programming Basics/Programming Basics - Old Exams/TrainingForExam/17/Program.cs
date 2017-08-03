using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char exeption = char.Parse(Console.ReadLine());
            int count = 0;

            for (char i = start; i <= end; i++)
            {
                if (i != exeption)
                {
                    for (char j = start; j <= end; j++)
                    {
                        if (j != exeption)
                        {
                            for (char k = start; k <= end; k++)
                            {
                                if (k != exeption)
                                {
                                    Console.Write($"{i}{j}{k} ");
                                    count++;
                                }
                            }

                        }

                    }
                }

            }
            Console.WriteLine(count);
        }
    }
}
