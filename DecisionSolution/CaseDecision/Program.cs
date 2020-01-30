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
        }
    }
}
