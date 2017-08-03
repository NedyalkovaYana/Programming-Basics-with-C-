﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int countTempLongest = 0;
            int countLongest = 0;
            int a = 0;
            int aPrev = 0;

            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a > aPrev)
                {
                    countTempLongest++;
                }
                else
                {
                    countTempLongest = 1;
                }
                aPrev = a;

                if (countTempLongest > countLongest)
                {
                    countLongest = countTempLongest;
                }
                aPrev = a;
            }
            Console.WriteLine(countLongest);
        }
    }
}
