using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number (lower bound): ");
            string num1 = Console.ReadLine();

            int lowerBound;
            if (!int.TryParse(num1, out lowerBound))
            {
                Console.WriteLine("Enter a valid number");
                return;
            }

            Console.Write("Enter second number (upper bound): ");
            string num2 = Console.ReadLine();

            int upperBound;
            if (!int.TryParse(num2, out upperBound))
            {
                Console.WriteLine("Enter a valid number");
                return;
            }

            int firstTerm = 0, secondTerm = 1;

            while (firstTerm <= upperBound)
            {
                if (firstTerm >= lowerBound)
                {
                    Console.WriteLine(firstTerm + " ");
                }

                int nextTerm = firstTerm + secondTerm;
                firstTerm = secondTerm;
                secondTerm = nextTerm;
            }
        }
    }
}
