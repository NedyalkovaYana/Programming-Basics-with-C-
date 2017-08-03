using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            int obemNaBaseinaVLitri = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double p1Debit = p1 * h;
            double p2Debit = p2 * h;
            double totalDebit = p1Debit + p2Debit;
            double prelqli = totalDebit - obemNaBaseinaVLitri;
            if (totalDebit > obemNaBaseinaVLitri)
            {
                Console.WriteLine($"For {h} hours the pool overflows with {prelqli:f1} liters.");
            }
            else
            {
                double totalPersent = Math.Floor(totalDebit / obemNaBaseinaVLitri * 100);
                double p1Persent = Math.Floor(p1Debit / totalDebit * 100);
                double p2Persent = Math.Floor(p2Debit / totalDebit * 100);
                Console.WriteLine($"The pool is {totalPersent}% full. Pipe 1: {p1Persent}%. Pipe 2: {p2Persent}%.");
            }
        }
    }
}
