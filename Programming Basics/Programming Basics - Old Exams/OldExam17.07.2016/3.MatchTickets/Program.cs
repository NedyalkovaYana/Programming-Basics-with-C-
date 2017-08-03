using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string categories = Console.ReadLine().ToLower();
            int numberOfPeple = int.Parse(Console.ReadLine());

            if ((numberOfPeple >= 1) && (numberOfPeple <= 4))
            {
                double transportprocent = budget * 75 / 100;
                double leftMoney = budget - transportprocent;
               
                if (categories == "vip")
                {
                    double moneyForTickets = 499.99 * numberOfPeple;
                    if (leftMoney >= moneyForTickets)
                    {
                        double isinaf = leftMoney - moneyForTickets;
                        Console.WriteLine("Yes! You have {0:F2} leva left.", isinaf);
                    }
                    else if (leftMoney < moneyForTickets)
                    {
                        double neededMoney = moneyForTickets - leftMoney;
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", neededMoney);
                    }
                }
                else if (categories == "normal")
                {
                    double moneyForTickets = 249.99 * numberOfPeple;
   
                    if (leftMoney >= moneyForTickets)
                    {
                        double isinaf = leftMoney - moneyForTickets;
                        Console.WriteLine("Yes! You have {0:F2} leva left.", isinaf);
                    }
                    else if (leftMoney < moneyForTickets)
                    {
                        double neededMoney = leftMoney - moneyForTickets;
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", neededMoney);
                    }
                }
            }
            if ((numberOfPeple >= 5) && (numberOfPeple <= 9))
            {
                double transportprocent = budget * 60 / 100;
                double leftMoney = budget - transportprocent;

                if (categories == "vip")
                {
                    double moneyForTickets = 499.99 * numberOfPeple;
                   
                    if (leftMoney >= moneyForTickets)
                    {
                        double isinaf = leftMoney - moneyForTickets;
                        Console.WriteLine("Yes! You have {0:F2} leva left.", isinaf);
                    }
                    else if (leftMoney < moneyForTickets)
                    {
                        double neededMoney = moneyForTickets - leftMoney;
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", neededMoney);
                    }
                }
                else if (categories == "normal")
                {
                    double moneyForTickets = 249.99 * numberOfPeple;

                    if (leftMoney >= moneyForTickets)
                    {
                        double isinaf = leftMoney - moneyForTickets;
                        Console.WriteLine("Yes! You have {0:F2} leva left.", isinaf);
                    }
                    else if (leftMoney < moneyForTickets)
                    {
                        double neededMoney = leftMoney - moneyForTickets;
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", neededMoney);
                    }
                }
            }
            if ((numberOfPeple >= 10) && (numberOfPeple <= 24))
            {
                double transportprocent = budget * 50 / 100;
                double leftMoney = budget - transportprocent;

                if (categories == "vip")
                {
                    double moneyForTickets = 499.99 * numberOfPeple;

                    if (leftMoney >= moneyForTickets)
                    {
                        double isinaf = leftMoney - moneyForTickets;
                        Console.WriteLine("Yes! You have {0:F2} leva left.", isinaf);
                    }
                    else if (leftMoney < moneyForTickets)
                    {
                        double neededMoney = moneyForTickets - leftMoney;
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", neededMoney);
                    }
                }
                else if (categories == "normal")
                {
                    double moneyForTickets = 249.99 * numberOfPeple;

                    if (leftMoney >= moneyForTickets)
                    {
                        double isinaf = leftMoney - moneyForTickets;
                        Console.WriteLine("Yes! You have {0:F2} leva left.", isinaf);
                    }
                    else if (leftMoney < moneyForTickets)
                    {
                        double neededMoney = leftMoney - moneyForTickets;
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", neededMoney);
                    }
                }
            }
            if ((numberOfPeple >= 25) && (numberOfPeple <= 49))
            {
                double transportprocent = budget * 40 / 100;
                double leftMoney = budget - transportprocent;

                if (categories == "vip")
                {
                    double moneyForTickets = 499.99 * numberOfPeple;

                    if (leftMoney >= moneyForTickets)
                    {
                        double isinaf = leftMoney - moneyForTickets;
                        Console.WriteLine("Yes! You have {0:F2} leva left.", isinaf);
                    }
                    else if (leftMoney < moneyForTickets)
                    {
                        double neededMoney = moneyForTickets - leftMoney;
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", neededMoney);
                    }
                }
                else if (categories == "normal")
                {
                    double moneyForTickets = 249.99 * numberOfPeple;

                    if (leftMoney >= moneyForTickets)
                    {
                        double isinaf = leftMoney - moneyForTickets;
                        Console.WriteLine("Yes! You have {0:F2} leva left.", isinaf);
                    }
                    else if (leftMoney < moneyForTickets)
                    {
                        double neededMoney = leftMoney - moneyForTickets;
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", neededMoney);
                    }
                }
            }
            if (numberOfPeple >= 50)
            {
                double transportprocent = budget * 25 / 100;
                double leftMoney = budget - transportprocent;

                if (categories == "vip")
                {
                    double moneyForTickets = 499.99 * numberOfPeple;

                    if (leftMoney >= moneyForTickets)
                    {
                        double isinaf = leftMoney - moneyForTickets;
                        Console.WriteLine("Yes! You have {0:F2} leva left.", isinaf);
                    }
                    else if (leftMoney < moneyForTickets)
                    {
                        double neededMoney = moneyForTickets - leftMoney;
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", neededMoney);
                    }
                }
                else if (categories == "normal")
                {
                    double moneyForTickets = 249.99 * numberOfPeple;

                    if (leftMoney >= moneyForTickets)
                    {
                        double isinaf = leftMoney - moneyForTickets;
                        Console.WriteLine("Yes! You have {0:F2} leva left.", isinaf);
                    }
                    else if (leftMoney < moneyForTickets)
                    {
                        double neededMoney = leftMoney - moneyForTickets;
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", neededMoney);
                    }
                }
            }
        }
    }
}
