using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_programs
{
    class Student
    {
        // Fields
        private int rollNo;
        private string name;
        private double marks1, marks2, marks3;
        private string grade;

        // Properties
        public int RollNo
        {
            get { return rollNo; }
            set { rollNo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Marks1
        {
            get { return marks1; }
            set { marks1 = value; }
        }

        public double Marks2
        {
            get { return marks2; }
            set { marks2 = value; }
        }

        public double Marks3
        {
            get { return marks3; }
            set { marks3 = value; }
        }

        public string Grade
        {
            get { return grade; } // Read-only
        }

        // Method to calculate grade
        public void CalculateGrade()
        {
            double average = (marks1 + marks2 + marks3) / 3;
            if (average >= 35 && average < 60)
                grade = "C";
            else if (average >= 60 && average < 80)
                grade = "B";
            else if (average >= 80)
                grade = "A";
            else
                grade = "F";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of students: ");
            int numStudents = int.Parse(Console.ReadLine());

            Student[] students = new Student[numStudents];

            for (int i = 0; i < numStudents; i++)
            {
                students[i] = new Student();

                Console.WriteLine($"\nEnter details for Student {i + 1}:");
                Console.Write("Roll No: ");
                students[i].RollNo = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                students[i].Name = Console.ReadLine();

                Console.Write("Marks 1: ");
                students[i].Marks1 = double.Parse(Console.ReadLine());

                Console.Write("Marks 2: ");
                students[i].Marks2 = double.Parse(Console.ReadLine());

                Console.Write("Marks 3: ");
                students[i].Marks3 = double.Parse(Console.ReadLine());

                students[i].CalculateGrade();
            }

            Console.WriteLine("\nStudent Details:");
            foreach (Student student in students)
            {
                Console.WriteLine($"\nRoll No: {student.RollNo}");
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Marks 1: {student.Marks1}");
                Console.WriteLine($"Marks 2: {student.Marks2}");
                Console.WriteLine($"Marks 3: {student.Marks3}");
                Console.WriteLine($"Grade: {student.Grade}");
            }
        }
    }
}