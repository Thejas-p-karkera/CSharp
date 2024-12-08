using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_programs
{
    class Commission
    {
        static void Main()
        {
            // Accept amount from the user
            Console.Write("Enter the amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            double commission = 0;

            // Calculate commission if amount is greater than 20000
            if (amount > 20000)
            {
                commission = amount * 0.03;
            }

            // Display amount and commission
            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("Commission: " + commission);
        }
    }

}
