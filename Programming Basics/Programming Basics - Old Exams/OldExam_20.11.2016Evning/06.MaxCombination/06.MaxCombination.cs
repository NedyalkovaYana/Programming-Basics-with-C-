using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxCombination
{
    class Program
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int maxInterval = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = start; i <=stop; i++)
            {
                for (int j = start; j <=  stop; j++)
                {
                    count++;
                    Console.Write("<{0}-{1}>", i, j);
                    if (count == maxInterval)
                    {
                        return;
                    }
                    
                }
                
            }
          
        }
    }
}
