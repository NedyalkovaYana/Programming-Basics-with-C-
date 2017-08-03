using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char operatori = char.Parse(Console.ReadLine());
            double result = 0;
            if (n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
                return;
            }
            switch (operatori)
            {
                case '+': result = n1 + n2; break;
                case '-': result = n1 - n2; break;
                case '*': result = n1 * n2; break;
                case '/': result = n1 / n2; break;
                case '%': result = n1 % n2; break;       
            }
            if (operatori == '+' || operatori == '-' || operatori == '*')
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {operatori} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {operatori} {n2} = {result} - odd");
                }
            }
            else if (operatori == '/')
            {
                Console.WriteLine($"{n1} / {n2} = {result:f2}");
            }
            else if (operatori == '%')
            {
                Console.WriteLine($"{n1} % {n2} = {result}");
            }
        }
    }
}
