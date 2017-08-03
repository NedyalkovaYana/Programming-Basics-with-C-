using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.ExpressionForPointInCircle
{
    class ExpressionForPointInCircle
    {
        static void Main()
        {
            bool check = false;
            double X, Y;
            Console.WriteLine("Enter X:");
            bool Xcheck = double.TryParse(Console.ReadLine(), out X);
            Console.WriteLine("Enter Y:");
            bool Ycheck = double.TryParse(Console.ReadLine(), out Y);
            if (Xcheck && Ycheck)
            {
                if ((X * X + Y * Y) <= 25)
                {
                    check = true;
                }
                Console.WriteLine("Is the point ({0}, {1}) is within the circle? {2}", X, Y, check);
            }
            else

            {
                Console.WriteLine("Not a valid entry!");
            }
            }

        }
    }

