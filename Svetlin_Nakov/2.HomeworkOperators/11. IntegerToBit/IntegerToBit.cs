using System;


namespace _11.IntegerToBit
{
    class IntegerToBit
    {
        static void Main()
        {
            Console.WriteLine("Please enter the number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the bit position:");
            int bitPosition = int.Parse(Console.ReadLine());
            int mask = 1;
            mask = mask << bitPosition;
            int addMask = number & mask;

            if (addMask !=0)
            {
                Console.WriteLine("The bit in position {0} is 1.", bitPosition);
            }
            else
            {
                Console.WriteLine("The position {0} is 0.", bitPosition);
            }

        }
    }
}
