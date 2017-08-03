using System;


namespace _12.OperatorsModifiedValue
{
    class OperatorsModifiedValue
    {
        static void Main()
        {
            Console.WriteLine("Please enter the number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the bit position:");
            int bitPosition = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value to change (0 or 1):");
            byte v = byte.Parse(Console.ReadLine());
            int mask = 1;
            mask = mask << bitPosition;

            if (v == 0)
            {
                int newNumber = (~(mask) & number);
                Console.WriteLine("nThe result is {0} - desimal {1}n", Convert.ToString(newNumber, 2), newNumber);
            }
            else
            {
                int newNumber = (mask | number);
                Console.WriteLine("The result is {0} - desimal {1}", Convert.ToString(newNumber, 2), newNumber);

            }
        }
    }
}
