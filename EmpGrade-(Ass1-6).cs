using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_programs
{
    class EmpGrade
    {
        static void Main()
        {
            string answer;

            do
            {
                // Accept employee details
                Console.Write("Enter Employee Number: ");
                int empNo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Employee Name: ");
                string empName = Console.ReadLine();

                //double salary;
                char grade;

                // Loop until a valid grade is entered
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
                        Console.WriteLine("Error: Invalid grade entered. Please enter a valid grade (A, B, or C).");
                    }
                }

                Console.Write("Enter Salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());

                // Apply increment based on grade
                if (grade == 'A')
                {
                    salary += 300;
                }
                else if (grade == 'B')
                {
                    salary += 200;
                }
                else if (grade == 'C')
                {
                    salary += 100;
                }

                // Display employee details
                Console.WriteLine("\nEmployee Details:");
                Console.WriteLine("Employee Number: " + empNo);
                Console.WriteLine("Employee Name: " + empName);
                Console.WriteLine("Grade: " + grade);
                Console.WriteLine("Updated Salary: " + salary);

                // Ask if user wants to continue
                Console.Write("Do you want to continue? (yes/no): ");
                answer = Console.ReadLine().ToLower();

            } while (answer == "yes");

            Console.WriteLine("Program ended.");
        }
    }

}
