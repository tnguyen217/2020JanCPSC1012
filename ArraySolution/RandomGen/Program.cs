using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGen
{
    class Program
    {
        //if declared outside of a method, add the keyword static infront of your declartion
        //if declared outside of a method BUT within the class 
        //THEN the variable is known to ALL methods WITHOUT having to pass the value as a parameter
        //static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Random is a datatype of class (object)
            //Random is just the definition of the object (describe the of object)
            //Random is NOT a physical instance of the object
            //to get the physical instance of the object, use the keyword new
            //new is used by any object to create an instance of that object 
            //to identify the object instance datatype, add the class name after the keyword new 
            //Random is datatype 
            //rnd is the variable name of the object instance 
            //new is the command keyword to create an object instance 
            //Random() is type of object instance, new is to create 
            Random rnd = new Random();
            int[] myArray = new int[10];
            for(int i = 0; i < 10; i++)
            {
                myArray[i] = rnd.Next(1, 100);
                Console.WriteLine($"index {i} has value of {myArray[i]}");
            }

            //What is the highest random number generated and the lowest random number generated
            int highest = 0;
            int lowest = 100;

            int loopcounter = 0;
            while (loopcounter < 10)
            {
                if (highest < myArray[loopcounter])
                {
                    highest = myArray[loopcounter];
                }
                if (lowest > myArray[loopcounter])
                {
                    lowest = myArray[loopcounter];
                }
                loopcounter++;
            }
            Console.WriteLine($"highest value is {highest}");
            Console.WriteLine($"lowest value is {lowest}");
        }
    }
}
