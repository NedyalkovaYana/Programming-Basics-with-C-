﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ReturnsWord
{
    class LastDigitOfGivenInteger
    {

            static void LastDigit(int number)
            {
                number = number % 10;
                switch (number)
                {
                    case 1:
                        Console.WriteLine("One");
                        break;
                    case 2:
                        Console.WriteLine("Two");
                        break;
                    case 3:
                        Console.WriteLine("Three");
                        break;
                    case 4:
                        Console.WriteLine("Four");
                        break;
                    case 5:
                        Console.WriteLine("Five");
                        break;
                    case 6:
                        Console.WriteLine("Six");
                        break;
                    case 7:
                        Console.WriteLine("Seven");
                        break;
                    case 8:
                        Console.WriteLine("Eigth");
                        break;
                    case 9:
                        Console.WriteLine("Nine");
                        break;
                    case 0:
                        Console.WriteLine("Zero");
                        break;
                    default:
                        Console.WriteLine("There is no such number. Try again...");
                        Main();
                        break;
                }
            }
            static void Main()
            {
                Console.Write("Enter number: ");
                int number = int.Parse(Console.ReadLine());

                LastDigit(number);
            }
    }
}
