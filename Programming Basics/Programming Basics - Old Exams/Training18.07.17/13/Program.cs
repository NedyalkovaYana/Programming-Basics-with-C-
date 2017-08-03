using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char stop = char.Parse(Console.ReadLine());
            char exeption = char.Parse(Console.ReadLine());
            int count = 0;
            for (char i = start; i <= stop; i++)
            {
                for (char j = start; j <= stop; j++)
                {
                    for (char k = start; k <= stop; k++)
                    {
                        

                        if (i == exeption || j == exeption || k == exeption)
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write($"{i}{j}{k} ");
                            count++;
                        }
                    }
                }
            }
            Console.Write(count);
            Console.WriteLine();
        }
    }
}
