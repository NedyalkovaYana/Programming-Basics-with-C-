using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.TimePlus15Minutes
{
    class TimePlus15Minutes
    {
       
        static void Main()
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            TimeSpan span = new TimeSpan(hour, minutes, 0);
            TimeSpan span2 = new TimeSpan(0, 15, 0);
            TimeSpan total = span + span2;
            Console.WriteLine("{0:h\\:mm}", total);
        }
    }
}
