using System;


namespace _12.CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main()
        {
            double amount = double.Parse(Console.ReadLine());
            string inputcurrency = Console.ReadLine().ToLower();
            string outputcurrency = Console.ReadLine().ToLower();

            if (inputcurrency == "usd" && outputcurrency == "bgn")
            {
                double dollarsTobgn = (amount * 1.79549) / 1;
                Console.WriteLine(Math.Round(dollarsTobgn, 2));
            }
            if (inputcurrency == "usd" && outputcurrency == "eur")
            {
                double usdtoeur = (amount * 1.79549) / 1.95583;
                Console.WriteLine(Math.Round(usdtoeur, 2));
            }
            if (inputcurrency == "usd" && outputcurrency == "gbr")
            {
                double usdtogbr = (amount * 1.79549) / 2.53405;
                Console.WriteLine(Math.Round(usdtogbr, 2));
            }
            if (inputcurrency == "bgn" && outputcurrency == "usd")
            {
                double bgnTousd = (amount * 1) / 1.79549;
                Console.WriteLine(Math.Round(bgnTousd, 2));
            }
            if (inputcurrency == "bgn" && outputcurrency == "eur")
            {
                double bgnToeur = (amount * 1) / 1.95583;
                Console.WriteLine(Math.Round(bgnToeur, 2));
            }
            if (inputcurrency == "bgn" && outputcurrency == "gbr")
            {
                double bgnTogbr = (amount * 1) / 2.53405;
                Console.WriteLine(Math.Round(bgnTogbr, 2));
            }
            if (inputcurrency == "eur" && outputcurrency == "bgn")
            {
                double eurTobgn = (amount * 1.95583) / 1;
                Console.WriteLine(Math.Round(eurTobgn, 2));
            }
            if (inputcurrency == "eur" && outputcurrency == "usd")
            {
                double eurTousd = (amount * 1.95583) / 1.79549;
                Console.WriteLine(Math.Round(eurTousd, 2));
            }
            if (inputcurrency == "eur" && outputcurrency == "gbp")
            {
                double eurTogbp = (amount * 1.95583) / 2.53405;
                Console.WriteLine(Math.Round(eurTogbp, 2));
            }
            if (inputcurrency == "gbp" && outputcurrency == "bgn")
            {
                double gbpTobgn = (amount * 2.53405) / 1;
                Console.WriteLine(Math.Round(gbpTobgn, 2));
            }
            if (inputcurrency == "gbp" && outputcurrency == "usd")
            {
                double gbpTousd = (amount * 2.53405) / 1.79549;
                Console.WriteLine(Math.Round(gbpTousd, 2));
            }
            if (inputcurrency == "gbr" && outputcurrency == "eur")
            {
                double gbrToeur = (amount * 2.53405) / 1.95583;
                Console.WriteLine(Math.Round(gbrToeur, 2));
            }
        }
    }
}
