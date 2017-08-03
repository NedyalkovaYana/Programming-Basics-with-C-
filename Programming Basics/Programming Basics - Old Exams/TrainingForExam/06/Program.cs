using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int upperDownSide = n * 2;
            int leftRightSide = n + 1;

            if (n % 2 == 0)
            {
                for (int i = 0; i < n-1; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine(new string('%', upperDownSide));
                    }
                    if (i == (n - 1)/ 2)
                    {
                        Console.WriteLine("%{0}**{0}%",
                            new string(' ', n - 2));
                    }
                    else
                    {
                        Console.WriteLine("%{0}%", new string(' ', upperDownSide - 2));
                    }
                    
                    if (i == n - 2)
                    {
                        Console.WriteLine(new string('%', upperDownSide));
                    }
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine(new string('%', upperDownSide));
                    }
                    if (i == n / 2)
                    {
                        Console.WriteLine("%{0}**{0}%",
                            new string(' ', n - 2));
                    }

                    else
                    {
                        Console.WriteLine("%{0}%", new string(' ', upperDownSide - 2));
                    }
                    if (i == n -1)
                    {
                        Console.WriteLine(new string('%', upperDownSide));
                    }
                    
                    
                    
                }
            }


        }
    }
}
