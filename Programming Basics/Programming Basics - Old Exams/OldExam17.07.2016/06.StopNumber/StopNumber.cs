using System;


namespace _06.StopNumber
{
    class StopNumber
    {
        static void Main()
        {
            int startNumber = int.Parse(Console.ReadLine());
            int stopNumber = int.Parse(Console.ReadLine());
            int specialNumber = int.Parse(Console.ReadLine());

            for (int i = stopNumber; i >= startNumber; i--)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    if (i == specialNumber)
                    {
                       
                        break;
                    }
                    Console.Write("{0} ", i);
                   
                }
            }

        }
    }
}
