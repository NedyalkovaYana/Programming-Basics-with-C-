using System;
using System.Globalization;
using System.Threading;


namespace _8.UserInputType
{
    class UserInputType
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double doubleNumber = 0;
            int intNumber = 0;
            string stringInput;
            byte entryType;
            Console.Write("Please do the data entry:");
            stringInput = Console.ReadLine();
            bool isDouble = double.TryParse(stringInput, out doubleNumber);
            if (isDouble)
            {
                if (doubleNumber % 1 == 0)
                {
                    intNumber = (int)doubleNumber;
                    entryType = 1;//Integer entry
                }
                else
                {
                    entryType = 2;//Double entry
                }
            }
            else
            {
                entryType = 3;//String entry
            }
            switch (entryType)
            {
                case 1: Console.WriteLine("Integer input. The output is:{0}", intNumber + 1); break;
                case 2: Console.WriteLine("Double input. The output is:{0}", doubleNumber + 1); break;
                case 3: Console.WriteLine("String input. The output is:{0}", stringInput + "*"); break;
            }
        }
        }
    }

