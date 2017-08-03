using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.PrintYourName
{
    class PrintYourName
    {   
        
        static void Main()
        {
            PrintThisName();
        }

        static void PrintThisName()
        {
            Console.Write("Please, enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello, {0}", name);
            Console.WriteLine();
        }
    }
}
