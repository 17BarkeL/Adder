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

            Console.Write("Enter number 1: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 2: ");
            int number2 = int.Parse(Console.ReadLine());

            int sum = number1 + number2;

            Console.WriteLine($"Result: {sum}");

            Console.ReadLine();
        }
    }
}
