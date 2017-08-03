using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SumSeconds
{
    class SumSeconds
    {
        static void Main()
        {
            int racer1 = int.Parse(Console.ReadLine());
            int racer2 = int.Parse(Console.ReadLine());
            int racer3 = int.Parse(Console.ReadLine());

          
            int sumTime = racer1 + racer2 + racer3;
           
            int mins = sumTime/ 60;
            int secs = sumTime % 60;
            string time = mins.ToString() + ":" + secs.ToString().PadLeft(2, '0');
            Console.WriteLine(time);

             




        }
    }
}
