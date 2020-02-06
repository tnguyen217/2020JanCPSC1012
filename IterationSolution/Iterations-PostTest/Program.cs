using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations_PostTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //the loop structure demonstrated in this sample is a Post-Test
            //Post-Test is also known as Do Until
            //Post-test executes the code once before the loop condition is tested
            //after the code has executed, the Post-test condition is still for true
            //if the ocndition is still true the code is re-executed
            //if the condition is fase the loop termintates and execution continues with the remainder of the program

            string answer = "";

            do
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
            } while (answer.ToUpper().Equals("Y"));

            Console.Write("\n\nYou terminated the loop with your last answer.");
            Console.ReadKey();
        }
    }
}
