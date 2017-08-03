using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.OperationBetweenNumbers
{
    class OperationBetNum
    {
        static void Main()
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string op = Console.ReadLine();

            double result = 0;
            if (num2 == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", num1);
            }
            else
            {
                bool isEven = false;

                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        isEven = result % 2 == 0;
                        Console.Write("{0} {1} {2} = {3} - ", num1, op, num2, result);

                        if (isEven)
                        {
                            Console.WriteLine("even");
                        }
                        else
                        {
                            Console.WriteLine("odd");
                        }
                        break;
                    case "-":
                        result = num1 - num2;
                        isEven = result % 2 == 0;
                        Console.Write("{0} {1} {2} = {3} - ", num1, op, num2, result);

                        if (isEven)
                        {
                            Console.WriteLine("even");
                        }
                        else
                        {
                            Console.WriteLine("odd");
                        }
                        break;
                    case "*":

                        result = num1 * num2;
                        isEven = result % 2 == 0;
                        Console.Write("{0} {1} {2} = {3} - ", num1, op, num2, result);

                        if (isEven)
                        {
                            Console.WriteLine("even");
                        }
                        else
                        {
                            Console.WriteLine("odd");
                        }
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.Write("{0} {1} {2} = {3:F2}", num1, op, num2, result);
                        break;
                    case "%":
                        result = num1 % num2;
                        Console.Write("{0} {1} {2} = {3}", num1, op, num2, result);
                        break;
                }
            }
        }
    }
}
