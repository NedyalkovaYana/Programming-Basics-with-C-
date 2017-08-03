using System;


namespace GoTo
{
    class GoTo
    {
        static void Main()
        {
            insideInnerLoop;
            for (int i = 0; i < 100; i++)
            {
                startInnerLoop:
                for (int j = 0; j < 50; j++)
                {
                    Console.WriteLine("{0} {1}", i, j);
                    if (j+i == 100)
                    {
                        goto startInnerLoop;
                    }
                }
                if (i>56)
                {
                    goto insideInnerLoop;
                }
            }
        }
    }
}
