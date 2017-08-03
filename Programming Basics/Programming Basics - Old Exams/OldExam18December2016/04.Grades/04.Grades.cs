using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grades
{
    class Program
    {
        static void Main()
        {
            int studentsForExam = int.Parse(Console.ReadLine());
            double countExellent = 0.0;
            double countGood = 0.0;
            double countLow = 0.0;
            double countFail = 0.0;
            double average = 0.0;
            double sum = 0.0;

            for (int i = 1; i <= studentsForExam; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                sum += grade;

                if (grade >= 5.00)
                {
                    countExellent++;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    countGood++;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    countLow++;
                }
                else if (grade < 3.00)
                {
                    countFail++;
                }
            }
            average = sum / studentsForExam;
            double topStudent = (countExellent / studentsForExam) * 100;
            double goodStudents = (countGood / studentsForExam) * 100;
            double middleStudents = (countLow / studentsForExam) * 100;
            double failStudents = (countFail / studentsForExam) * 100;

            Console.WriteLine("Top students: {0:f2}%", topStudent);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", goodStudents);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", middleStudents);
            Console.WriteLine("Fail: {0:f2}%", failStudents);
            Console.WriteLine("Average: {0:f2}", average);
        }
    }
}
