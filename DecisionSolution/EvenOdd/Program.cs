using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            const int Two = 2;
            string inputValue;

            Console.Write("Enter your number: ");
            inputValue = Console.ReadLine();
            number = int.Parse(inputValue);

            if ((number % Two) == 0)
            {
                Console.WriteLine($"Your number {number} is even"); 
            }
            else
            {
                Console.WriteLine($"Your number {number} is odd");
            }
        }
    }
}
