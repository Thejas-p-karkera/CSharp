using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_programs
{
    internal class EmpDetails
    {
        static void Main()
        {
            int empNo;
            string empName;
            char grade;
            double basic, da, hra, net;

            // Accept and validate Employee Number
            while (true)
            {
                Console.Write("Enter Employee Number (between 100 and 200): ");
                empNo = Convert.ToInt32(Console.ReadLine());

                if (empNo >= 100 && empNo <= 200)
                {
                    break; // Valid empNo, exit the loop
                }
                else
                {
                    Console.WriteLine("Error: Employee Number should be between 100 and 200.");
                }
            }

            // Accept Employee Name
            Console.Write("Enter Employee Name: ");
            empName = Console.ReadLine();

            // Accept and validate Grade
            while (true)
            {
                Console.Write("Enter Grade (A, B, or C): ");
                grade = Convert.ToChar(Console.ReadLine().ToUpper());

                if (grade == 'A' || grade == 'B' || grade == 'C')
                {
                    break; // Valid grade, exit the loop
                }
                else
                {
                    Console.WriteLine("Error: Grade should be A, B, or C.");
                }
            }

            // Accept and validate Basic Salary
            while (true)
            {
                Console.Write("Enter Basic Salary (between 2000 and 7000): ");
                basic = Convert.ToDouble(Console.ReadLine());

                if (basic >= 2000 && basic <= 7000)
                {
                    break; // Valid basic, exit the loop
                }
                else
                {
                    Console.WriteLine("Error: Basic Salary should be between 2000 and 7000.");
                }
            }

            // Calculate DA and HRA
            da = basic * 0.10;  // Assuming DA is 10% of basic
            hra = basic * 0.05; // Assuming HRA is 5% of basic

            // Calculate Net Salary
            net = basic + da + hra;

            // Display all details
            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine("Employee Number: " + empNo);
            Console.WriteLine("Employee Name: " + empName);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Basic Salary: " + basic);
            Console.WriteLine("DA: " + da);
            Console.WriteLine("HRA: " + hra);
            Console.WriteLine("Net Salary: " + net);

        }
    }
}
