using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.IncreasingElements
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int incrElem = 0;
            int start = 0;
            int maxLenght = 0;

            for (int i = 1; i <=n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > start || i == 0)
                {
                    incrElem += 1;
                }
                else
                {
                    incrElem = 1;
                }
                if (incrElem > maxLenght)
                {
                    maxLenght = incrElem;
                }
                start = number;
            }
            Console.WriteLine(maxLenght);
        }
    }
}
