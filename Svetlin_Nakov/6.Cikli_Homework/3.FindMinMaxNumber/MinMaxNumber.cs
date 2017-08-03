using System;


namespace _3.FindMinMaxNumber
{
    class MinMaxNumber
    {
        static void Main()
        {
            int n;
            string[] numbers;
            bool isInteger = true;
            int minimal = int.MaxValue;
            int maximal = int.MinValue;
            Console.Write("Enter a sequence of numbers delimited with \",\":");
            numbers = Console.ReadLine().Split(',');
            int[] intnumbers = new int[numbers.Length];

            for (int i = 0; i < (numbers.Length); i++)
            {
                isInteger = int.TryParse(numbers[i], out intnumbers[i]);
                if (isInteger==false)
                {
                    break;
                }
            }
            if (isInteger)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (intnumbers[i] < minimal)
                       
                    {
                        minimal = intnumbers[i];
                    }
                    if (intnumbers[i] > maximal)
                    {
                        maximal = intnumbers[i];
                    }
                }
                Console.WriteLine("minimal = {0}", minimal);
                Console.WriteLine("maximal = {0}", maximal);
            }
            else
            {
                Console.WriteLine("Not a valid entry! Some of the entries are not integer!");
            }
        }
                 
                
        }
    }

