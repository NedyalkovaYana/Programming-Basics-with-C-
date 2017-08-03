using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            long pregledaniPacienti = 0;
            long neoregledaniPacienti = 0;
            int doctor = 7;

            for (int i = 0; i < period; i++)
            {
                long pacientsCount = long.Parse(Console.ReadLine());

                if ((i % 3 == 0) && (neoregledaniPacienti > pregledaniPacienti)
                {
                    doctor++;
                }
                              
                if (pacientsCount > doctor)
                {
                    pregledaniPacienti += doctor;
                    
                    neoregledaniPacienti += pacientsCount - doctor;
                }
                else
                {
                    pregledaniPacienti += pacientsCount;
                }
            }
            Console.WriteLine($"Treated patients: {pregledaniPacienti}.");
            Console.WriteLine($"Untreated patients: {neoregledaniPacienti}.");

        }

    }
}
