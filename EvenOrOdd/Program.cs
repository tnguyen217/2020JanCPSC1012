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
            string number = Console.ReadLine();
            int value = int.Parse(number);

            if {
                value % 2 = 0;
                Console.WriteLine($"Your number {value} is an even number");
            }

            else {
                Console.WriteLine($"Your number {value} is an odd number");
            }
            Console.ReadLine();
        }
    }
}
