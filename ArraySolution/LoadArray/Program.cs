using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadArray
{
    class Program
    {
        static void Main(string[] args)
        {

            //arrays are a fixed size collection of a single datatype 
            //array names hold a internal address to the actual physical memory location of the array storage area 
            //a single item in the array is called the array element 

            //declaring an array requires knowing 
            //  a) physical size
            //  b) the elements to initialize the array

            //a) declared by physical size
            int[] physicallyDeclare = new int[7];

            //b) the elements to initialize the array
            //  the number of values specifies the physical array size
            //  each supplied value is place within the array consecutively
            int[] diceValue = new int[] { 11, 2, 333, 44, 5, 56 };

            //the physically declared array has an initial default value for each element depending on the system default value of the array datatype
            int pDsize = 7;
            for (int index = 0; index < pDsize; index++)
            {
                Console.WriteLine($"pDsize array element {index + 1} located at index {index} has a value of {physicallyDeclare[index]}");
            }
            int dVsize = diceValue.Length;
            for (int index = 0; index < 6; index++)
            {
                Console.WriteLine($"diceValue array element {index + 1} located at index {index} has a value of {diceValue[index]}");
            }

            Console.ReadKey();
        }
    }
}
