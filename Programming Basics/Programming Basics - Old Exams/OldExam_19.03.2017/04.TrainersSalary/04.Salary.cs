using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TrainersSalary
{
    class Program
    {
        static void Main()

        {

            int numberOfLectures = int.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());
            int jelev = 0;
            int roYal = 0;
            int roli = 0;
            int trofon = 0;
            int sino = 0;
            int others = 0;

            for (int i = 1; i <= numberOfLectures; i++)
            {
                string lektorName = Console.ReadLine().ToLower();
                if (lektorName == "jelev")
                {
                    jelev++;
                }
                else if (lektorName == "royal")
                {
                    roYal++;
                }
                else if (lektorName == "roli")
                {
                    roli++;
                }
                else if (lektorName == "trofon")
                {
                    trofon++;
                }
                else if (lektorName == "sino")
                {
                    sino++;
                }
                else 
                {
                    others++;
                }

            }
            decimal salaryForOneLecture = budget / numberOfLectures;
            decimal jelevSalary = jelev * salaryForOneLecture;
            decimal roYalSalary = roYal * salaryForOneLecture;
            decimal rolySalary = roli * salaryForOneLecture;
            decimal trofonSalary = trofon * salaryForOneLecture;
            decimal sinoSalary = sino * salaryForOneLecture;
            decimal othersSalary = others * salaryForOneLecture;

            Console.WriteLine("Jelev salary: {0:f2} lv", jelevSalary);
            Console.WriteLine("RoYaL salary: {0:f2} lv", roYalSalary);
            Console.WriteLine("Roli salary: {0:f2} lv", rolySalary);
            Console.WriteLine("Trofon salary: {0:f2} lv", trofonSalary);
            Console.WriteLine("Sino salary: {0:f2} lv", sinoSalary);
            Console.WriteLine("Others salary: {0:f2} lv", othersSalary);
        }
    }
}
