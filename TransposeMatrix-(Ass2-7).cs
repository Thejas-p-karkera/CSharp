using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_programs
{
    internal class TransposeMatrix
    {
        static void Main(String[] args)
        {
            Console.Write("Enter the value for N: ");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Enter a valid number");
            }

            Console.Write("Enter the value for M: ");
            int m;
            if (!int.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("Enter a valid number");
            }

            int[,] arr1 = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Enter " + j + "th element for " + i + "th row: ");
                    arr1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("The Original matrix is: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr1[i, j]+" ");
                }
                Console.WriteLine();
            }

            //Transpose the matrix
            int[,] arr2 = new int[m, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr2[j, i] = arr1[i, j];
                }
            }

            Console.WriteLine("The transpose of the Matrix is: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }

            if(symmetricCheck(arr1, arr2,  n,  m))
            {
                Console.WriteLine("Matrix is symmetric");
            }
            else
            {
                Console.WriteLine("Matrix is not symmetric");
            }
        }

        static bool symmetricCheck(int[,] arr1, int[,] arr2, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (arr1[j, i] == arr2[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
