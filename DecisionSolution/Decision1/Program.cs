using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int first, second, highest = -99;
            int first;          //default to 0
            int second;         //default to 0
            int highest = -99;  //declare and set to -99
            string message;     //declare and default to null
            string inputValue;

            Console.Write("Enter first number: \t");
            inputValue = Console.ReadLine();
            first = int.Parse(inputValue);

            //reuse, inputValue because the previous contents
            // of inputValue has been store elsewhere
            Console.Write("Enter second number: \t");
            inputValue = Console.ReadLine();
            second = int.Parse(inputValue);

            if (first > second)
            {
                //true path coding block
                //the condition on the if statement is true
                highest = first;
                message = "first";

            }
            else
            {
                //false path coding block
                //the condition on the if statement is false
                highest = second;
                message = "second";
           }//eof
            Console.WriteLine($"First = {first}, Second = {second}" +
                $", the {message} number entered had the higher value: {highest}");
            Console.ReadKey();
        }//eom
    }//eoc
}//eon
