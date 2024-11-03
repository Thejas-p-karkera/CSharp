using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to find its factorial: ");
            string num = Console.ReadLine();

            int num1;
            if(!int.TryParse(num, out num1))
            {
                Console.WriteLine("Enter a valid number");
                return;
            }

            int result = fact(num1);
            Console.WriteLine("The factorial of " + num + " is: " + result); 
        }

            static int fact(int n)
            {
                if(n == 0 || n == 1)
                {
                    return 1;
                }
                else
                {
                    return n * fact(n - 1);
                }

            }
    }
}
