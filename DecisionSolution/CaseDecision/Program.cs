using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            string gradeLetter = "A";
            string percentageRange;

            //a case structure can be used when you have a  single argument value compared to a series of literal value
            //the structure begin with the switch(argument value) {...}
            //within the switch structure you have quote "cases"
            //a case represents on "if" test against argument values
            //the case must enter with a "break;" command
            //the "break" sends your exececution the the end of the switch structure
            //the last case in your switch is the special case called "default"
            //"default" does not test again a literal value
            //default executes if none of the previous cases were executed 
            //you can have multiple case statements coded for a particular case coding block
            //multiple case statement for a partiple case coding block are implied logical OR (||) tests
            //the case test is a relational equal (==) test

            switch (gradeLetter)
            {
                case "a":
                case "A":
                    {
                        //logic for this particular case 
                        percentageRange = "85-100";
                        break;
                    }
                case "b":
                case "B":
                    {
                        //logic for this particular case 
                        percentageRange = "70-84";
                        break;
                    }
                case "c":
                case "C":
                    {
                        //logic for this particular case 
                        percentageRange = "55-69";
                        break;
                    }
                case "d":
                case "D":
                    {
                        //logic for this particular case 
                        percentageRange = "40-54";
                        break;
                    }
                case "f":
                case "F":
                    {
                        //logic for this particular case 
                        percentageRange = "0-39";
                        break;
                    }
                default:
                    {
                        //the implied test on this case is "None of the above"
                        percentageRange = "Invalid letter grade";
                        break;
                    }
            }//eos

            Console.WriteLine($"your grade letter ({gradeLetter}) is {percentageRange}");
            Console.ReadLine(); //when using debbuging to stop the auto close 


            //example 2: Print out the month name

            int monthNumber = 2;

            //There is a single argument varialble. 
            //This single argument variable will be tested against mutiple constant values
            //The case test is an == test


            switch (monthNumber)
            {
                case 1:
                    {
                        //do any logic that is require when monthNumber is 1
                        //this could be a one line of code or 100000 lines of code
                        Console.WriteLine("The name of the month is January.");
                        break;
                    }
                case 2:
                    {
                        //do any logic that is require when monthNumber is 1
                        //this could be a one line of code or 100000 lines of code
                        Console.WriteLine("The name of the month is Febuary.");
                        break;
                    }
                case 3:
                    {
                        //do any logic that is require when monthNumber is 1
                        //this could be a one line of code or 100000 lines of code
                        Console.WriteLine("The name of the month is March.");
                        break;
                    }
                case 4:
                    {
                        //do any logic that is require when monthNumber is 1
                        //this could be a one line of code or 100000 lines of code
                        Console.WriteLine("The name of the month is April.");
                        break;
                    }
                case 5:
                    {
                        //do any logic that is require when monthNumber is 1
                        //this could be a one line of code or 100000 lines of code
                        Console.WriteLine("The name of the month is May.");
                        break;
                    }
                case 6:
                    {
                        //do any logic that is require when monthNumber is 1
                        //this could be a one line of code or 100000 lines of code
                        Console.WriteLine("The name of the month is June.");
                        break;
                    }
                case 7:
                    {
                        //do any logic that is require when monthNumber is 1
                        //this could be a one line of code or 100000 lines of code
                        Console.WriteLine("The name of the month is July.");
                        break;
                    }
                case 8:
                    {
                        //do any logic that is require when monthNumber is 1
                        //this could be a one line of code or 100000 lines of code
                        Console.WriteLine("The name of the month is August.");
                        break;
                    }
                case 9:
                    {
                        //do any logic that is require when monthNumber is 1
                        //this could be a one line of code or 100000 lines of code
                        Console.WriteLine("The name of the month is September.");
                        break;
                    }
                case 10:
                    {
                        //do any logic that is require when monthNumber is 1
                        //this could be a one line of code or 100000 lines of code
                        Console.WriteLine("The name of the month is October.");
                        break;
                    }
                case 11:
                    {
                        //do any logic that is require when monthNumber is 1
                        //this could be a one line of code or 100000 lines of code
                        Console.WriteLine("The name of the month is November.");
                        break;
                    }
                case 12:
                    {
                        //do any logic that is require when monthNumber is 1
                        //this could be a one line of code or 100000 lines of code
                        Console.WriteLine("The name of the month is December.");
                        break;
                    }
                default:
                    {
                        //this logic is done is one of the previous cascs was not executed
                        Console.WriteLine("too late in the year to think anymore");
                        break;
                    }
            }

        }
    }
}
