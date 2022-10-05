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
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 + num2;

            Console.WriteLine($"Result: {result}");

            Console.ReadLine();
        }
    }
}
