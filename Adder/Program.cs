using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adder:\n");

            int sum = AddTwoNumbers();

            Console.WriteLine($"Result: {sum}");

            Console.ReadLine();
        }

        /// <summary>
        /// Gets 2 integer numbers from user and adds them together
        /// </summary>
        /// <returns>The sum of the two numbers from the user</returns>
        static int AddTwoNumbers()
        {
            Console.Write("Enter number 1: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 2: ");
            int number2 = int.Parse(Console.ReadLine());

            return number1 + number2;
        }
    }
}
