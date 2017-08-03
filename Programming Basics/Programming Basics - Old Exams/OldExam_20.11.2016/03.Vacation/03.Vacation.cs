using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main()
        {
            double oldPeople = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());
            double nights = double.Parse(Console.ReadLine());
            string transport = Console.ReadLine().ToLower();
            double group = oldPeople + students;
            double sumTransport;
            double sumNights;
            double totalSum;
            double commision;

            if (transport == "train")
            {
                if (group >= 50)
                {
                    oldPeople *= 24.99;
                    students *= 14.99;
                    sumTransport = oldPeople + students;
                    sumNights = nights * 82.99;
                    commision = (sumNights + sumTransport) * 0.10;
                    totalSum = sumTransport + sumNights + commision;

                    Console.WriteLine("{0:f2}", totalSum);
                    
                }
                else
                {
                    oldPeople *= 2 * 24.99;
                    students *= 2 * 14.99;
                    sumTransport = oldPeople + students;
                    sumNights = nights * 82.99;
                    commision = (sumNights + sumTransport) * 0.10;
                    totalSum = sumTransport + sumNights + commision;
                    Console.WriteLine("{0:f2}", totalSum);
                }
            }
            else if (transport == "bus")
            {
                oldPeople *= 2 * 32.50;
                students *= 2 * 28.50;
                sumTransport = oldPeople + students;
                sumNights = nights * 82.99;
                commision = (sumNights + sumTransport) * 0.10;
                totalSum = sumTransport + sumNights + commision;
                Console.WriteLine("{0:f2}", totalSum);
            }
            else if (transport == "boat")
            {
                oldPeople *= 2 * 42.99;
                students *= 2 * 39.99;
                sumTransport = oldPeople + students;
                sumNights = nights * 82.99;
                commision = (sumNights + sumTransport) * 0.10;
                totalSum = sumTransport + sumNights + commision;
                Console.WriteLine("{0:f2}", totalSum);
            }
            else if (transport =="airplane")
            {
                oldPeople *= 2 * 70.00;
                students *= 2 * 50.00;
                sumTransport = oldPeople + students;
                sumNights = nights * 82.99;
                commision = (sumNights + sumTransport) * 0.10;
                totalSum = sumTransport + sumNights + commision;
                Console.WriteLine("{0:f2}", totalSum);
            }
          
        }
    }
}
