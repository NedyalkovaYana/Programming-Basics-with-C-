using System;


namespace _4.ImplictAndExplictType
{
    class ImplictAndExplictType
    {
        static void Main()
        {
            float heightInMeters = 1.74f;
            double maxHeight = heightInMeters;
            double minHeight = (double)heightInMeters;
            float actualHeight = (float)maxHeight;
            double dd = 1.123456789012345;
            Console.WriteLine(dd);
            Console.WriteLine((float)dd);
            Console.WriteLine((int)dd);

        }


        
    }
}
