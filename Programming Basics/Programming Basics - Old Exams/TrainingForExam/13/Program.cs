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
            int n = int.Parse(Console.ReadLine());
            int leftRight = 0;
            int middle = n - 2;
            int count = 0;
            

            for (int i = 0; i < n/2; i++)
            {
                if (middle <= 0)
                {
                    Console.WriteLine("{0}\\/{0}",
                         new string('.', leftRight));
                   
                }
                else
                {
                    Console.WriteLine("{0}\\{1}/{0}",
                        new string('.', leftRight),
                        new string('*', middle));
                    leftRight++;
                    middle -= 2;
                }

                count++;
            }
            if (n >= 12)
            {
                for (int i = 0; i < (n / 2) - 2; i++)
                {
                    Console.WriteLine("{0}||{0}",
                        new string('.', leftRight));
                    count++;
                }
            }
            else
            {
                for (int i = 0; i < (n / 2) - 1; i++)
                {
                    Console.WriteLine("{0}||{0}",
                        new string('.', leftRight));
                    count++;
                }
            }
            int restPiece = n - count;
            for (int i = 0; i < restPiece; i++)
            {
                Console.WriteLine(new string('-', n));
            }
        }
    }
}
