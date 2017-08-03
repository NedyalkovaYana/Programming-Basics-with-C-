using System;


namespace _7.CheckPrimeNumber
{
    class CheckPrimeNumber
    {
        static void Main()
        {
            bool isPrime = true;
           
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {
                    if (i != j && i % j == 0) // ако не намерим число което не е равно на 2 (Пр) и в същото време не остава никакъв остатък при деление - втория loop свършва и принтираме, че числото е PRIME
                    {                         // ако намерим такова число - тогава прекъсваме вторичния цикъл и започваме да проверяваме следващото число, понеже вече знаем, че това число не е PRIME
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("Prime:" + i);
                }
                isPrime = true;
            }
        }
    }
}
