using System;


namespace _06
{
    class Program
    {
        static void Main()
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int specialNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
           
            for (int i = m; i >= 1; i--)
            {
                for (int j = n; j >= 1; j--)
                {
                    for (int k = l; k >= 1; k--)
                    {
                        double number = (i * 100) + (j * 10) + k;

                        if (number % 3 == 0)
                        {
                            specialNumber += 5;
                        }
                        else if (k == 5)
                        {
                            specialNumber -= 2;
                        }
                        else if (number % 2 == 0)
                        {
                            specialNumber *= 2;
                        }
                        if (specialNumber >= controlNumber)
                            break;
                    }
                    if (specialNumber >= controlNumber)
                        break;
                }
                if (specialNumber >= controlNumber)
                    break;
            }

            if (specialNumber >= controlNumber)
            {
                Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNumber}.");
            }
            else
            {
                Console.WriteLine($"No! {specialNumber} is the last reached special number.");
            }
        }
    }
}
