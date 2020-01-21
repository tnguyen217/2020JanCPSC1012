using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get Input
            Console.Write("Enter your number: ");
            string numberInput = Console.ReadLine();
            int number = int.Parse(numberInput);

            if (number % 2 == 0) 
            { 
                Console.WriteLine($"Your number {number} is an even number.");
            }

            else
            {
                Console.WriteLine($"Your number {number} is an odd number.");
            }
            Console.ReadLine();
        }
    }
}
