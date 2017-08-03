﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DayAfterFiveDays
{
    class DayAfterFiveDays
    {
        static void Main()
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());

            var date = new DateTime(2017, month, day);
            date = date.AddDays(5);

            var dayy = date.Day.ToString("0");
            var monthh = date.Month.ToString("00");

            Console.WriteLine("{0}.{1}", dayy, monthh);

        }
    }
}
