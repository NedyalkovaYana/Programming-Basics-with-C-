using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLecture4
{
    class Program1
    {
        static void ArrayAverage(double[] array)
        {

            double average1 = array.Average();
            Console.WriteLine(average1);

        }
        static void PrinElements(double[] array, number)
        {
            double average1;
           
        }

            static void Main()
            {
               
                Console.WriteLine("Enter 5 number of elements:");
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("arr[{0}]", i);
                    arr[i] = int.Parse(Console.ReadLine());
                }
                
            
                ArrayAverage(double[] array);
               Console.WriteLine("Enter number:");
               double number = double.Parse(Console.ReadLine());


                PrinElements();




            }
        
    }
}
