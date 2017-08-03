using System;
using System.Text;


namespace OutputEncoding
{
    class OutputEncoding
    {
        static void Main()
        {
            char copyCaracter = '\u00A9';
            Console.OutputEncoding = Encoding.UTF8;
            for (int verticalCount = 0; verticalCount < 3; verticalCount++)
            {
                for (int horizontalCount = 1; horizontalCount < 6; horizontalCount++)
                {
                    Console.Write("{0}", Math.Abs(3 - horizontalCount) > verticalCount ? ' ' : copyCaracter);
                }
                Console.WriteLine();
            }
        }
    }
}
