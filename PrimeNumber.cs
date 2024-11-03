using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter lower bound to get the prime numbers: ");
            string low = Console.ReadLine();

            int lower;
            if (!int.TryParse(low, out lower))
            {
                Console.WriteLine("Enter a valid number");
                return;
            }

            Console.Write("Enter upper bound to get the prime numbers: ");
            string up = Console.ReadLine();

            int upper;
            if (!int.TryParse(up, out upper))
            {
                Console.WriteLine("Enter a valid number");
                return;
            }

            Console.Write("Prime numbers within " + lower + " to " + upper + ": ");

            for (int i = lower; i <= upper; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
        }

        static bool IsPrime(int n)
        {
            if(n==1)
            {
                return false;
            }
            if(n==2)
            {
                return true;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
