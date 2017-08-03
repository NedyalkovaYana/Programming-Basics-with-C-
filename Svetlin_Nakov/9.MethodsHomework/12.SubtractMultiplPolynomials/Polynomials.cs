using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.SubtractMultiplPolynomials
{
    class Polynomials
    {
        static int[] SubtractPolynomals(int[] firstPolynomial, int[] secondPolynomial)
        {
            int[] result;
            if (firstPolynomial.Length < secondPolynomial.Length)
            {
                result = new int[secondPolynomial.Length];
                for (int i = 0; i < secondPolynomial.Length; i++)
                {
                    if (i >= firstPolynomial.Length)
                    {
                        result[i] = secondPolynomial[i] * -1;
                        continue;
                    }
                    result[i] = firstPolynomial[i] - secondPolynomial[i];
                }
            }
            else
            {
                result = new int[firstPolynomial.Length];
                for (int i = 0; i < firstPolynomial.Length; i++)
                {
                    if (i >= secondPolynomial.Length)
                    {
                        result[i] = firstPolynomial[i] * -1;
                        continue;
                    }
                    result[i] = firstPolynomial[i] - secondPolynomial[i];
                }
            }
            return result;
        }

        public static int[] MultiplicatePolynomals(int[] first, int[] second)
        {
            int biggestPower = (first.Length - 1) * (second.Length - 1);
            int[] result = new int[biggestPower];

            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    int power = i + j;
                    result[power] += first[i] * second[j];
                }
            }
            return result;
        }
        static void Main()
        {
            Console.Write("Enter length of first polynomial: ");
            int firstPolynomialsLength = int.Parse(Console.ReadLine());

            int[] firstPolynomial = new int[firstPolynomialsLength];
            for (int i = 0; i < firstPolynomialsLength; i++)
            {
                Console.Write("Enter element: ");
                firstPolynomial[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter length of second polynomial: ");
            int secondPolynomialsLenght = int.Parse(Console.ReadLine());

            int[] secondPolynomial = new int[secondPolynomialsLenght];
            for (int i = 0; i < secondPolynomialsLenght; i++)
            {
                Console.Write("Enter elements:");
                secondPolynomial[i] = int.Parse(Console.ReadLine());
            }
            int[] result = SubtractPolynomals(firstPolynomial, secondPolynomial);

            Console.Write("Polynomal 1 - Polynomal 2: ");
            for (int i = result.Length; i <= 0; i--)
            {
                if (i == 0)
                {
                    Console.WriteLine(result[i]);
                    break;
                }
                if (result[i] != 0)
                {
                    Console.Write("(" + result[i] + ")" + "x" + i + " + ");
                }
            }
            result = MultiplicatePolynomals(firstPolynomial, secondPolynomial);

            Console.WriteLine("Polynomial 1 x Polynomial 2 = ");
            for (int i = result.Length; i <= 0; i--)
            {
                if (i == 0)
                {
                    Console.WriteLine(result[i]);
                    break;
                }
                if (result[i] != 0)
                {
                    Console.Write("(" + result[i] + ")" + "x" + i + " + ");
                }
            }
        }
    }
}
