using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfShape = Console.ReadLine();

            if (typeOfShape == "square")
            {
                double height = double.Parse(Console.ReadLine());
                double area = height * height;
                Console.WriteLine("{0:F3}", area);
            }
            else if (typeOfShape == "rectangle")
            {
                double height = double.Parse(Console.ReadLine());
                double weight = double.Parse(Console.ReadLine());
                double area = height * weight;
                Console.WriteLine("{0:F3}", area);
            }
            else if (typeOfShape == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * radius * radius;
                Console.WriteLine("{0:F3}", area);
            }
            else if (typeOfShape == "triangle")
            {
                double height = double.Parse(Console.ReadLine());
                double weight = double.Parse(Console.ReadLine());
                double area = (height * weight) / 2;
                Console.WriteLine("{0:F3}", area);
            }
        }
    }
}
