using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] tokens = str.Split(' ');
            int[] array = new int[tokens.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(tokens[i]);

            }
        }
    }
}
