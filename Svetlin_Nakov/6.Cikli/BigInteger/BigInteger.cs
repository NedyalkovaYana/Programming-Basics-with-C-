using System;




namespace BigInteger
{
    class BigInteger
    {
        static void Main()
        {

            Console.WriteLine("Enter n value:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter m value: ");
            int m = int.Parse(Console.ReadLine());
            int number = n;
            decimal product = 1;
            
            do
            {
                product *= number;
                number++;

            } while (product <=m);
            Console.WriteLine("Product [n...m] = "+ product);

        }
    }
}
