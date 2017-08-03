﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sunglasses
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}",
                new string('*', 2*n),
                new string(' ', n));

            for (int i = 0; i < n-2; i++)
            {
                Console.Write("*{0}*",
                    new string('/', 2*n - 2));

                if (i ==(n-1)/2-1)
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }
                Console.Write("*{0}*",
                   new string('/', 2 * n - 2));
                Console.WriteLine();
            }
      
            Console.WriteLine("{0}{1}{0}",
               new string('*', 2 * n),
               new string(' ', n));

        }
    }
}
