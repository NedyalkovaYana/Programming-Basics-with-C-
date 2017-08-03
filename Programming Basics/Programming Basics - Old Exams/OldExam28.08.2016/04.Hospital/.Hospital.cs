using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hospital
{
    class Program
    {
        static void Main()
        {
            int period = int.Parse(Console.ReadLine());
            long treatedPatients = 0;
            long untreadPatients = 0;
            int doctor = 7;

            for (int i = 1; i <= period; i++)
            {
                if ((i % 3 == 0) && (untreadPatients > treatedPatients))
                {
                    doctor++;
                }

                long patient = long.Parse(Console.ReadLine());
                if (patient == doctor)
                {
                    treatedPatients += doctor;
                }
                else if (patient > doctor)
                {
                    treatedPatients += doctor;
                    patient -= doctor;
                    untreadPatients += patient;
                }
                else
                {
                    treatedPatients += patient;
                }
            }
            Console.WriteLine("Treated patients: {0}.", treatedPatients);
            Console.WriteLine("Untreated patients: {0}.", untreadPatients);
        }
    }
}
