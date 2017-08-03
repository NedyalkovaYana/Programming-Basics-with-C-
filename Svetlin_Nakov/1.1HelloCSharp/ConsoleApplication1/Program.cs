using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int cnt = 2; cnt < 101; cnt++)
            {
                Console.Write(cnt % 2 == 0 ? "{0}" : "{1}", cnt, -cnt);
                Console.Write(cnt != 101 ? ", " : ";\r\n");
            }
    }
}
}
