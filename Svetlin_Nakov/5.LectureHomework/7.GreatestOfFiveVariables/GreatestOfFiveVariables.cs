using System;


namespace _7.GreatestOfFiveVariables
{
    class GreatestOfFiveVariables
    {
        static void Main()
        {

            
            Console.WriteLine("Type number a: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Tyoe number b: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Type number c: ");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine("Type number d: ");
            float d = float.Parse(Console.ReadLine());
            Console.WriteLine("Type number e");
            float e = float.Parse(Console.ReadLine());
            double max = a;

            if (a >= b && a >= c && a >= d && a >= e)
            {
                max = a;
            }
            else
            {
                if (b >= a && b >= c && b >= d && b >= e)
                {
                    max = b;
                }
                else
                {
                    if (c >= a && c >= b && c >= d && c >= e)
                    {
                        max = c;
                    }
                    else
                    {
                        if (d >= a && d >= b && d >= c && d >= e)
                        {
                            max = d;

                        }
                        else
                        {
                            if (e >= a && e >= b && e >= c && e >= d)
                            {
                                max = e;
                            }
                        }
                    }
                }



            }
            Console.WriteLine("Max is: " + max);

        }


    }
}



