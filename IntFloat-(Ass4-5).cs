using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_programs
{
    class IntFloat
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                // Check if the input is an integer
                if (int.TryParse(input, out _))
                {
                    throw new Exception("Input is an integer. Exception thrown.");
                }

                // Check if the input is a floating-point number
                if (double.TryParse(input, out double floatingNumber))
                {
                    Console.Write("Enter decimal places to round: ");
                    int decimals = int.Parse(Console.ReadLine());

                    // Round the floating-point number
                    double rounded = Math.Round(floatingNumber, decimals);
                    Console.WriteLine($"Rounded number: {rounded}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}