using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());

            double totalResult = 0.0;
            double failStudents = 0.0;
            double averageStudents = 0.0;
            double goodStudents = 0.0;
           
            double topStudents = 0.0;

            for (int i = 1; i <= studentsCount; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                totalResult += grade;
                if (grade >= 5.0)
                {
                    topStudents++;
                }
                else if (grade >= 4.0)
                {
                    goodStudents++;
                }
                else if (grade >= 3.00)
                {
                    averageStudents++;
                }
                else
                {
                    failStudents++;
                }
                
            }

            double topStudentsPercent = (topStudents * 100) / studentsCount;
            double goodStudentsPercent = (goodStudents * 100) / studentsCount;
            double averageStudentsPercent = (averageStudents * 100) / studentsCount;
            double failStudentsPercent = (failStudents * 100) / studentsCount;

            double average = totalResult / studentsCount;

            Console.WriteLine($"Top students: {topStudentsPercent:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {goodStudentsPercent:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {averageStudentsPercent:f2}%");
            Console.WriteLine($"Fail: {failStudentsPercent:f2}%");
            Console.WriteLine($"Average: {average:f2}");

        }
    }
}
