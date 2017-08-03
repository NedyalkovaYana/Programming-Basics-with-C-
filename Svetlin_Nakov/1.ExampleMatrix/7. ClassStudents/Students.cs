using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ClassStudents
{
    class Students
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Students[] students =
                {
                new Students() { FirstName = "Pesho", SecondName = "Ivanov", Age = 20},
                new Students() { FirstName = "Ivan", SecondName = "Popov", Age = 22},
                new Students() { FirstName = "Mitko", SecondName = "Dimitrov", Age = 18},
                };

            foreach (var s in students)
            {
                Console.WriteLine(s.FirstName + " " + s.SecondName + " " + s.Age);
            }

            Array.Sort(students, (s1, s2) => s1.Age.CompareTo(s2.Age));
            Console.WriteLine();
            Console.WriteLine();
            foreach (var s in students)
            {
                Console.WriteLine(s.FirstName + " " + s.SecondName + " " + s.Age);
            }
        }

    }
}
