using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic Menu Setup
            //loop: post-loop
            //loop contents
            //      prompt for the menu options
            //      switch with case for each option, default is bad entry
            //      within the case we will simply output a message
            //decide how to terminate your loop

            string menuOption = "";

            do
            {
                //prompts
                Console.WriteLine("Select the option from the following menu:");
                Console.WriteLine("A) Do case A");
                Console.WriteLine("B) Do case B");
                Console.WriteLine("C) Do case C");
                Console.WriteLine("X) Exit\n");
                Console.Write("Enter your menu option:\t");
                menuOption = Console.ReadLine();

                switch (menuOption.ToUpper())
                {
                    case "A":
                        {
                            int number = -1;
                            string inputString = "";

                            while (number != 0)
                            {
                                //do
                                //{
                                //    Console.Write("Enter a positive whole number OR enter 0 to quit.");
                                //    inputString = Console.ReadLine();
                                //}
                                //condition flag
                                //NOTE: it MUST be reset on EACH pass of the OUTER loop
                                bool validFlag = false;

                                do
                                {
                                    Console.Write("Enter a positive whole number OR enter 0 to quit.");
                                    inputString = Console.ReadLine();
                                    //need a test to approriate set your loop exit test
                                    if (int.TryParse(inputString, out number))
                                    {
                                        //set the flag to an approriate value to work with our logic
                                        validFlag = true;
                                    }
                                }
                                while (validFlag == false);

                                if (number > 0)
                                {
                                    if (number % 2 == 0)
                                    {
                                        Console.WriteLine($"{number} is an even value. \n\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{number} is an odd value. \n\n");
                                    }
                                }
                                else
                                {
                                    if (number == 0)
                                    {
                                        Console.WriteLine($"Thank you. Come again. \n\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{number} is invalid. Try again. \n\n");
                                    }
                                }
                            }//eow
                            Console.WriteLine($"");
                            Console.WriteLine("You enter the menu option of A.\n\n");
                            break;
                        }
                    case "B":
                        {
                            int counter = -1;
                            
                            while (counter != 0)
                            {
                                int head = 0, tail = 0;
                                string coinFace = "";
                                int coinValue = 0;
                                bool validFlag = true;
                                do
                                {
                                    Console.Write("\nEnter what is your coin side (H or T): ");
                                    coinFace = Console.ReadLine();
                                    
                                    if (int.TryParse(coinFace, out coinValue))
                                    {
                                        validFlag = true;
                                    }
                                }

                                while (validFlag == true)   

                                switch (coinFace.ToUpper())
                                {
                                    case "H":
                                        {
                                            head++;
                                            break;
                                        }
                                    case "T":
                                        {
                                            tail++;
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Invalid. Please enter again.");
                                            break;
                                        }
                                }
                            }                           
                            

                            Console.WriteLine($"\nYour number of head count is {head}.");
                            Console.WriteLine($"Your number of tail count is {tail}.");
                            //place the head and tail game in this case
                            //validate that an H or T was entered, if not repeat  query for input
                            Console.WriteLine("You enter the menu option of B.\n\n");
                            break;
                        }
                    case "C":
                        {
                            //the sum of squares
                            //tnter positive integer number (validate)
                            //loop n times where is the integer number (1 to n)
                            //within the loop your calculation is += n * n
                            //after the loop display your integer number and its sum of square
                            //entered 4
                            //loop 4 times 1) 1 * 2) 2 * 2 3) 3 * 3 4) 4 * 4 final total = 30
                            Console.WriteLine("You enter the menu option of C.\n\n");
                            break;
                        }
                    case "X":
                        {
                            Console.WriteLine("Thank you. Come again.\n\n");
                            break;
                        }
                    default:
                        {
                            //this case acts as a validation for the proper value of a menuOption
                            Console.WriteLine($"Your menu option choice of {menuOption} is incorrect. Try again.\n\n");
                            break;
                        }
                }

            }
            while (menuOption.ToUpper() != "X");
            Console.ReadKey();
        }
    }
}
