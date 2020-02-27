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
                Console.WriteLine("A) Even or Odd");
                Console.WriteLine("B) Head or Tail");
                Console.WriteLine("C) Calculate Sum of Squares");
                Console.WriteLine("X) Exit\n");
                Console.Write("Enter your menu option:\t");
                menuOption = Console.ReadLine();

                switch (menuOption.ToUpper())
                {
                    case "A":
                        {
                            EvenOrOdd();
                            break;
                        }
                    case "B":
                        {
                            //Create a method that holds the actual code for this case
                            //the B case will CALL the method to execute 
                            //this action is referred to the calling statement 
                            //calling requires your code to use the method name
                            //your program will breanch to the requested mehtod 
                            //when the method has finised, your program will return to the next executable statement AFTER the method call.

                            HeadsOrTailsGame();
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

                            //create a shared input method to obtain an integer value

                            int number = GetIntegerInput("Enter a number greater than 0");
                            
                            if (number < 1)
                            {
                                Console.WriteLine($"{number} is not greater than 0. Unable to do sum of squares.");
                            }
                            else
                            {
                                int sumofsquares = 0;
                                sumofsquares = SumofSquares(number);
                                Console.WriteLine($"{sumofsquares} is the sum of squares for {number}");
                            }

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
        }//eom Main

        //the syntax for a method requires
        //  axxesstype returndatatype MethodName ([list of parameters])
        //  {
        //      your method code
        //  }

        //accesstype:   public or private
        //              protected, internal, have static reference
        //returndatatupe:   if you are returning nothing use the key work void
        //                  otherwise, return a single value such as int, double, decimal, DateTime, etc.
        //MethodName:   countinuous string of characters which will be used within your program code to reference this coding block
        //              it is best to use a meaningful name
        //[list of parameters]  this is a set of local variables that will be used to receive values rom the calling statement
        //                      a parameter is a set of datatype variablename parameters are separated by using a comma ,



        static public void HeadsOrTailsGame()
        {
            string inputString = "";
            int headcount = 0, tailcount = 0;
            do
            {
                //validation
                do
                {
                    Console.Write("Enter a H (head) or T (tail) or Q (quit)");
                    inputString = Console.ReadLine();
                } while (!inputString.ToUpper().Equals("H") && !inputString.ToUpper().Equals("T") && !inputString.ToUpper().Equals("Q"));

                if (inputString.ToUpper().Equals("H") || inputString.ToUpper().Equals("T"))
                {
                    //heads or tails
                    if (inputString == "H")
                    {
                        headcount++;
                        Console.WriteLine($"\n{inputString.ToUpper()} is heads");
                    }
                    else
                    {
                        tailcount++;
                        Console.WriteLine($"\n{inputString.ToUpper()} is tails");
                    }
                }
                else
                {
                    if (headcount > tailcount)
                    {
                        Console.WriteLine($"Head wins over Tail: {headcount} to {tailcount}");
                    }
                    else if (headcount < tailcount)
                    {
                        Console.WriteLine($"Tail wins over Head: {tailcount} to {headcount}");
                    }
                    else
                    {
                        Console.WriteLine($"Head ties Tail: {tailcount} to {headcount}");
                    }
                    //quit
                    Console.WriteLine("\n\nThank you. Hope you enjoy the game.");
                }
            } while (inputString.ToUpper().Equals("Q"));


            Console.WriteLine("\n\nI reach my method for option B\n\n");
        }//eom HeadsOrTailsGame()

        static public void EvenOrOdd()
        {
            int number = -1;

            while (number != 0)
            {
                //do
                //{
                //    Console.Write("Enter a positive whole number OR enter 0 to quit.");
                //    inputString = Console.ReadLine();
                //}

                number = GetIntegerInput("Enter a positive whole number OR enter 0 to quit.");

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
        }//subroutine (does not return) //eom EvenOrOdd()

        static public int SumofSquares(int seednumber) //function (do return)
        {
            //loop n times where is the integer number (1 to n)
            //within the loop your calculation is += n * n
            //after the loop display your integer number and its sum of square
            //entered 4
            //loop 4 times 1) 1 * 2) 2 * 2 3) 3 * 3 4) 4 * 4 final total = 30

            int finalsquare = 0;
            for(int loopcounter = 1; loopcounter <= seednumber; loopcounter++)
            {
                finalsquare += loopcounter * loopcounter;
            }

            return finalsquare;
        }

        static public int GetIntegerInput(string promptline)
        {
            bool validFlag = false;
            string inputString = "";
            int number = 0;
            do
            {
                Console.Write(promptline);
                
                inputString = Console.ReadLine();
                if (int.TryParse(inputString, out number))
                {
                    validFlag = true;
                }
            }
            while (validFlag == false);

            //if your method indicates that a return datatype is specified
            //you must have at least one return statement in your method code

            return 0;
        }
    }
}
