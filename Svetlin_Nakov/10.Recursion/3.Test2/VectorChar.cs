using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Vector01Generator
{
    class Program
    {
        static int n = 2;
        static string[] names = { "Pesho", "Ivan", "Petka" };
        static void Main()
        {
        
            int[] vector = new int[n];
            Gen01(n - 1, vector, 0);
        }
        static void Gen01(int index, int[] vector, int start)
        {
            if (index == -1)
            {
                Print(vector);
            }
            else
            {
                for (int i = start; i <= names.Length; i++)
                {
                    vector[index] = i;
                    Gen01(n - 1, vector, i+1);
                }
            }
        }
        static void Print(int[] vector)
        {
            foreach (int i in vector)
            {
                Console.Write("{0}", names[i]);
            }
            Console.WriteLine();
        }
    }
}
