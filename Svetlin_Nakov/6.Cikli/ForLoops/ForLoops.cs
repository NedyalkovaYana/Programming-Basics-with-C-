using System;


namespace ForLoops
{
    class ForLoops
    {
        static void Main()
        {
            //for (int num = 0; num < 10; num++)
            //{
            //    Console.Write(num + "");
            //}
            //Console.WriteLine();
            //Console.WriteLine();


            //for (decimal i = -1.5m; i <= 9.5m; i+=0.5m)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            //Console.WriteLine();


            //Console.WriteLine("Enter n:");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter m:");
            //int m = int.Parse(Console.ReadLine());
            //decimal result = 1;
            //for (int i = 1; i < m; i++)
            //{
            //    result *= n;
            //}
            //Console.WriteLine("n^m = "+ result);

            //Console.WriteLine();
            //Console.WriteLine();

            //odd numbers

            //Console.WriteLine("Enter a:");
            //int a = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 0; i < a; i+=2)
            //{
            //    if (i % 7 == 0)
            //    {
            //        continue;
            //    }
            //    sum += i;

            //}
            //Console.WriteLine("sum = {0}", sum);

            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            foreach (var day in days)
            {
                Console.WriteLine(day);
            }
        }
    }
}
