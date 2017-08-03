﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Vector01Generator
{
    class Program
    {
        static void Main()
        {
            Console.Write("n = ");
            int number = int.Parse(Console.ReadLine());

            int[] vector = new int[number];
            Gen01(number - 1, vector);
        }
        static void Gen01(int index, int[] vector)
        {
            if (index == -1)
            {
                Print(vector);
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    vector[index] = i;
                    Gen01(index - 1, vector);
                }
            }
        }
        static void Print(int[] vector)
        {
            foreach (int i in vector)
            {
                Console.Write("{0}", i);
            }
            Console.WriteLine();
        }
    }
}
