using System;

namespace PrimeNumberExample
{
    class Program
    {
        static void Main(string[] args)
        {
            bool  isPrime = true;
            Console.WriteLine("Show Prime Numbers Numbers between 1 to 1000   = ");
            for (int i = 2; i <= 1000; i++)
            {
                for (int j = 2; j <= 1000; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        
                    }

                }
                if (isPrime)
                {
                    Console.WriteLine(" " + i);
                }
                isPrime = true;

                
            }
            
        }
    }
}
