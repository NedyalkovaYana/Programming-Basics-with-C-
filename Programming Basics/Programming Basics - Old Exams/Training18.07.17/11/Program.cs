using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            double fail = 0;
            double good = 0;
            double veryGood = 0;
            double exellent = 0;
            double sumGrade = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                sumGrade += grade;
                if (grade >= 5.00)
                {
                    exellent++;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    veryGood++;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    good++;
                }
                else if (grade < 3.00)
                {
                    fail++;
                }

            }
            double failResult = (fail / studentsCount) * 100;
            double goodResult = (good / studentsCount) * 100;
            double veryGoodResult = (veryGood / studentsCount) * 100;
            double exellentResult = (exellent / studentsCount) * 100;
            double averageResult = sumGrade / studentsCount;
            Console.WriteLine($"Top students: {exellentResult:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {veryGoodResult:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {goodResult:f2}%");
            Console.WriteLine($"Fail: {failResult:f2}%");
            Console.WriteLine($"Average: {averageResult:f2}");
        }
    }
}
