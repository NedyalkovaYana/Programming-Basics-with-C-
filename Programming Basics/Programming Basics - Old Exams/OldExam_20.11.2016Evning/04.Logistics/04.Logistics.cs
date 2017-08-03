using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics
{
    class Program
    {
        static void Main()
        {
            int numberPrevoz = int.Parse(Console.ReadLine());
            int countMicrobus = 0;
            int countKamion = 0;
            int countVlak = 0;
            double sumAllTovari = 0;
            double sumSrednaStoinost = 0;

            for (int i = 1; i <= numberPrevoz; i++)
            {
                int tonaj = int.Parse(Console.ReadLine());

                if (tonaj <=3)
                {
                    countMicrobus += tonaj;
                }
                else if (tonaj >=4 && tonaj <= 11)
                {
                    countKamion += tonaj;
                }
                else if (tonaj >= 12)
                {
                    countVlak += tonaj;
                }

            }
            sumAllTovari = countMicrobus + countKamion + countVlak;
            sumSrednaStoinost = (countMicrobus * 200 + countKamion * 175 + countVlak * 120) / sumAllTovari;
            double microbusProcent = countMicrobus / sumAllTovari * 100;
            double kamionProcent = countKamion / sumAllTovari * 100;
            double vlakProcent = countVlak / sumAllTovari * 100;
            Console.WriteLine("{0:f2}", sumSrednaStoinost);
            Console.WriteLine("{0:f2}%", microbusProcent);
            Console.WriteLine("{0:f2}%", kamionProcent);
            Console.WriteLine("{0:f2}%", vlakProcent);


        }
    }
}
