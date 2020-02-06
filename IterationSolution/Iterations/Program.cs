using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //the loop structure demonstrated in this sample is a Pre-Test
            //Pre-Test is also known as Do while
            //Pre-test checks to see if the conditions is true Before executing the code
            //after the code has executed, the Pretest condition is still true
            //if the ocndition is still true the code is re-executed
            //if the condition is fase the loop termintates and execution  continues with the remainder of the program

            Console.Write("Do you wish to play the Even or Odd game? ");
            string answer =Console.ReadLine();

            //the loop constrution

            while(answer.ToUpper().Equals("Y"))
            {
                //within this coding block you are inside your loop
                //this loop will terminate is answer is not Y y

                //TODO: place your loop logic here

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

                //ask if the user wishes to continue to play the game
                //give the user the opportunity to acces the loop
                Console.Write("\n\nDo you wish to play the Even or Odd game? ");
                answer = Console.ReadLine();
            }//eow

            Console.Write("\n\nYou terminated the loop with your last answer.");
            Console.ReadKey();
        }
    }
}
