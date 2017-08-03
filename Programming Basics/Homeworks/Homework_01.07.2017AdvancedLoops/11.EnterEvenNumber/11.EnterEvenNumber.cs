using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EnterEvenNumber
{
    class Program
    {
        static void Main()
        {
            int n = 0;

            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());

                    try
                    {
                        if (n % 2 == 0)
                        {
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("The number is not even.");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            Console.WriteLine("Even number entered: {0}", n);


        }
    }
}
