using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double higthRoom= double.Parse(Console.ReadLine());
            double widghRoom = double.Parse(Console.ReadLine());
            double wallGarderob = double.Parse(Console.ReadLine());

            double roomArea = (higthRoom * 100) * (widghRoom * 100);
            double peikaArea = roomArea / 10;
           
            double garderobArea = (wallGarderob * 100) * (wallGarderob * 100);
            double freeSpace = roomArea - garderobArea - peikaArea;

            double numberDancer = Math.Floor(freeSpace / (40 + 7000));
            Console.WriteLine(numberDancer);
        }
    }
}
