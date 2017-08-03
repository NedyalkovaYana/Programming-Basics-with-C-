using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            string inputcurrency = Console.ReadLine().ToLower();
            string outputcurrency = Console.ReadLine().ToLower();

            var currencies = new Dictionary<string, double>()
            {
                {"m", 1},
                {"mm", 1000 },
                {"cm", 100 },
                {"mi", 0.000621371192},
                {"in", 39.3700787},
                {"km", 0.001},
                {"ft", 3.2808399},
                {"yd", 1.0936133}
            };
            double result = amount / currencies[inputcurrency] * currencies[outputcurrency];

            Console.WriteLine("{0:F8} {1}", result, outputcurrency);
        }
    }
}
