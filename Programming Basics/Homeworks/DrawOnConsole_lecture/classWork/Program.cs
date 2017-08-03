using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classWork
{
    class Program
    {
        static void Main()
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            for (int i = hour; i < 24; i++)
            {
                for (int j = minute; j < 60; j++)
                {
                    for (int k = second; k < 60; k++)
                    {
                        Console.WriteLine("{0:00}:{0:00}:{0:00}", i, j, k);
                    }
                }
            }
            
        }
    }
}
