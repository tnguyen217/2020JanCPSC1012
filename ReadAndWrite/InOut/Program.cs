using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOut
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * implement a temperature converter from Celsius to Fahrenheit
             * 
             * Jan 15 2020
             */

            //input : Celsius temperature 
            //          string inputTemp
            //          double  theCelsiusTeperature

            //output : Fahrenheit teperature
            //          double theFahrenheitTemperature

            //expression: (ct * 9/5) + 32 =ft
            //check with ct = 0 expect ft = 32
            //check with ct = -40 expect ft = -40
            //check with ct = 100 expect ft = 212

            //promp for a temperature
            //.Write keeps your cusor on the same line
            Console.Write("enter a Celsius temperature:\t");

            //to obtain the key strokes that the users type (input)
            //  use .Readline()
            //data comes into the program as a string

            string inputTemp = Console.ReadLine();

            //convert the string to a double
            //to do this you will use parsing 
            //  syntax: datatypeTo.Parse(string)

            double theCelsiusTemperature = double.Parse(inputTemp);

            //calculation using the conversion expersion
            double theFahrenheitTemperature = theCelsiusTemperature * 9.0 / 5.0 + 32;

            //output 
            //.Writeline() automatically goes to the next line
            Console.WriteLine($"The Celsius temperature of{theCelsiusTemperature} in " + 
                $"Fahrenheit {theFahrenheitTemperature} is");

            //to ensure that your display stays whether you run without debugging Ctrl + F5
            //or running with debugging (F5 or the start button at the top)
            //add a .Readline
            Console.ReadLine();

      
        }
    }
}
