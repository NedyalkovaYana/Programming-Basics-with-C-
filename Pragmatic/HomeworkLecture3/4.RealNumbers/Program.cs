using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.RealNumbers
{
    class Program
    {
        private static int i;

        static void Main()
        {
            int number;
            for (int enteredValue = 0; enteredValue < 10; enteredValue++)
            {
                
                Console.WriteLine("Enter 0 to stop the program:");
                if (Console.ReadLine()[0] == 0)
                {
                    break;
                }
                Console.WriteLine("Enter number to continue");
                number = int.Parse(Console.ReadLine());
                if (Console.ReadLine()[0] == number)
                {
                    continue;
                }

                break;
            }

            
            }

           
        }

    }

