using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CallMethod
{
    class CallMethod
    {  static void PrintLogo()
        {
            Console.WriteLine("Telerik Corp.");
            Console.WriteLine("www.telerik.com");
        }
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                PrintLogo();
            }
            Console.WriteLine();
        }
    }
}
