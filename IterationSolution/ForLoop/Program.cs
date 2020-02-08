using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample of pre-testloops
            //while loop
            //for loop

            //code a while loop that breaks the components of a for loop into visible individual items 
            //counter: this will count the number of times through the loop
            //while condition: counter is less than my stop value
            //     (stop value is either an upper limit or lower limit)

            //go through the loop 7 times
            //count the number of even numbers number of odd numbers
            //after the loop print out the even and odd number running totals

            int evenNumbers = 0;
            int oddNumbers = 0;
            int loopCounter = 1;

            while (loopCounter <= 7)
            {
                Console.Write("Enter your number: ");
                string numberInput = Console.ReadLine();
                int number = int.Parse(numberInput);

                if (number % 2 == 0)
                {
                    //evenNumber = evenNumbers + 1
                    evenNumbers++;      //running total
                }

                else
                {
                    oddNumbers += 1;        //running total
                }//eof

                //increment
                loopCounter++;
            }

            Console.WriteLine($"\nYour even number count is {evenNumbers}.");
            Console.WriteLine($"Your odd number count is {oddNumbers}.");

            //for loop
            //the for loop is a pre-test loop structure

            evenNumbers = 0;    //reset totals
            oddNumbers = 0;     //reset totals

            for (int forCounter = 1; forCounter < 8; forCounter++)
            {
                Console.Write("\nEnter your number: ");
                string numberInput = Console.ReadLine();
                int number = int.Parse(numberInput);

                if (number % 2 == 0)
                {
                    //evenNumber = evenNumbers + 1
                    evenNumbers++;      //running total
                }

                else
                {
                    oddNumbers += 1;        //running total
                }//eof
            }//eol

            Console.WriteLine($"\nYour even number count is {evenNumbers}.");
            Console.WriteLine($"Your odd number count is {oddNumbers}.");


        }
    }
}
