using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_2
{
    class TransposeMatrix
    {
        static void Main(String[] args)
        {
            Console.Write("Enter the value for N: ");
            int n;
            if(!int.TryParse(Console.ReadLine(),out n))
            {
                Console.WriteLine("Enter a valid number");
            }

            Console.Write("Enter the value for M: ");
            int m;
            if(!int.TryParse(Console.ReadLine(),out m))
            {
                Console.WriteLine("Enter a valid number");
            }

            int[,] arr = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Enter " + j + "th element for " + i + "th row: ");
                    arr[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
