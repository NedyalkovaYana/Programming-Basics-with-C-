using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OnTimeForTheExam
{
    class Program
    {
        static void Main()
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinute = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMinute;
            int arriveTime = arriveHour * 60 + arriveMinute;
            int minutesDifference = arriveTime - examTime;

            if (minutesDifference < -30)
            {
                Console.WriteLine("Early");
            }
            else if (minutesDifference <= 0)
            {
                Console.WriteLine("On time");
            }
            else
            {
                Console.WriteLine("Late");
            }

            if (minutesDifference != 0)
            {
                int hours = Math.Abs(minutesDifference / 60);
                int minutes = Math.Abs(minutesDifference % 60);
                if (hours > 0)
                {
                    if (minutes < 10)
                    {
                        Console.Write(hours + ":0" + minutes + " hours");
                    }
                    else
                    {

                        Console.Write(hours + ":" + minutes + " hours");
                    }
                }
                else
                {

                    Console.Write(minutes + " minutes");
                }
                if (minutesDifference < 0)
                {
                    Console.WriteLine(" before the start");
                }
                else
                {
                    Console.WriteLine(" after the start");
                }
                    
            }
        }
    }
}
