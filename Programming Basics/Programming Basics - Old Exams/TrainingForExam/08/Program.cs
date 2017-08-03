using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int count = 0;
            int volume = 0;
 
            for (int i = -n; i < n; i++)
            {
                for (int j = -n; j < n; j++)
                {
                    for (int k = i + 1; k <= n; k++)
                    {
                        for (int l = j + 1; l <= n; l++)
                        {
                            volume = Math.Abs(k - i) * Math.Abs(l - j);
                            if (volume >= m)
                            {
                                Console.WriteLine($"({i}, {j}) ({k}, {l}) -> {volume}");
                                count++;
                            }
                            
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }

        }
    }
}
