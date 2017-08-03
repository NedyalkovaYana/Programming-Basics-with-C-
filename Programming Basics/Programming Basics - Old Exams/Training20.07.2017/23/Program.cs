using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int doctor = 7;
            int treatedPatients = 0;
            int untreatedPatients = 0;

            for (int i = 1; i <= period; i++)
            {
                int patients = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && untreatedPatients > treatedPatients) doctor++;
                if (patients > doctor)
                {
                    treatedPatients += doctor;
                    untreatedPatients += patients - doctor;
                }
                else
                {
                    treatedPatients += patients;
                }

            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
