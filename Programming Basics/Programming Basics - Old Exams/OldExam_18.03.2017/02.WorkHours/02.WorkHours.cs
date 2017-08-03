using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.WorkHours
{
    class Program
    {
        static void Main()
        {
            int neededHours = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());

            double hoursForWork = workers * workingDays * 8;
            if (hoursForWork >= neededHours)
            {
                double leftHours = hoursForWork - neededHours;
                Console.WriteLine("{0} hours left", leftHours);
            }
            else
            {
                double overtime = neededHours - hoursForWork;
                double neustoiki = overtime * workingDays;
                Console.WriteLine("{0} overtime", overtime);
                Console.WriteLine("Penalties: {0}", neustoiki);
            }
        }
    }
}
