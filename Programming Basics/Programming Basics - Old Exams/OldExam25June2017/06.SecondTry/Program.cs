using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SecondTry
{
    class Program
    {
        static void Main()
        {
            int controlNumber = int.Parse(Console.ReadLine());
            bool no = false;

            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        if (a+b+c == controlNumber)
                        {
                            if (a<b && b<c)
                            {
                                Console.WriteLine("{0} + {1} + {2} = {3}", a, b,c, controlNumber);
                                no = true;
                            }
                         
                        }

                        if (a * b * c == controlNumber)
                        {
                            if (a > b && b > c)
                            {
                                Console.WriteLine("{0} * {1} * {2} = {3}", a, b, c, controlNumber);
                                no = true;
                            }
                         
                        }
                       
                    }
                }
               
            }
            if (!no)
            {
                Console.WriteLine("No!");
            }

        }
        
    }
}
