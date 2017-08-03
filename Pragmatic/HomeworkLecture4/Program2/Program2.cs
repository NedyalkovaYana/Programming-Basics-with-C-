using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program2
    {
        static void numbersInput(List<int> numbersInput)
        {
            for (int i = 0; i < input; i++)
            {

                if (Console.ReadLine()[0] == 0)
                {
                    break;
                }
                Console.WriteLine("Please enter another integer: ");

                int input = 0;
                numbersInput.Add(input);

                if (Console.ReadLine()[0] != 0)
                {
                    continue;
                }

                break;
            }
        }
        static void Main(string[] args)
        {
            List<int> numbersInput = new List<int>();

            Console.WriteLine("Please enter an integer");
            int input = int.Parse(Console.ReadLine());
            numbersInput.Add(input);
            





        }
    }
}
