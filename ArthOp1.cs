using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_1
{
    class ArthOp1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multilpy");
            Console.WriteLine("4. Devide");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter 1st number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter 2nd number: ");
                double num2 = double.Parse(Console.ReadLine());
                
                double result = num1 + num2;

                Console.WriteLine("Result : " + result);
            }
            else if (choice == 2)
            {
                Console.Write("Enter 1st number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter 2nd number: ");
                double num2 = double.Parse(Console.ReadLine());
               
                double result = num1 - num2;

                Console.WriteLine("Result : " + result);
            }
            else if (choice == 3)
            {
                Console.Write("Enter 1st number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter 2nd number: ");
                double num2 = double.Parse(Console.ReadLine());
               
                double result = num1 * num2;

                Console.WriteLine("Result : " + result);
            }
            else if (choice == 4)
            {
                Console.Write("Enter 1st number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter 2nd number: ");
                double num2 = double.Parse(Console.ReadLine());

                
                if (num2 != 0)
                {
                    double result = num1 / num2;
                    Console.WriteLine("Result : " + result);
                }
                else
                {
                    Console.WriteLine("Error");
                    
                }

            }
            else
            {
                Console.WriteLine("Invalid choice.");
               
            }
        }
    }
}
