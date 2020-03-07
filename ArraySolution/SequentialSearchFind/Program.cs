using Microsoft.Win32;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequentialSearchFind
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //declare an integer array of 25 elements
            int[] myArray = new int[25];
            //integer variable to indicate the logical size of the array
            //the logical size refer to the number of elements in the array
            //the declare size (25) is refer to as a physical size
            int logicalsize = 0;
            int physicalsize = 25;

            string Full_Path_File_Name = "";
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            Full_Path_File_Name = fd.FileName;
            string readValue = "";
            StreamReader reader = null;

            try
            {
                reader = new StreamReader(Full_Path_File_Name);
                readValue = reader.ReadLine();

                while (readValue != null && logicalsize < physicalsize)
                {
                    myArray[logicalsize] = int.Parse(readValue);
                    logicalsize++;
                    //get the next line
                    readValue = reader.ReadLine();
                }
            }//eot
            catch (Exception ex)
            {
                //.Message holds the error that occured during the processing of the code in your try{...}
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }

            Console.WriteLine($"The number of elements in the array is {logicalsize}");
            for (int loopcounter = 0; loopcounter < logicalsize; loopcounter++)
            {
                Console.WriteLine($"At array index {loopcounter} there is a value of {myArray[loopcounter]}");
            }

            //Sequential Search
            //is it there
            Console.Write("Enter a number:\t");
            int searcharg = int.Parse(Console.ReadLine());

            bool found = false;
            int searchcounter = 0;

            //codition expression 
            //  a)continue to look until you looked at everything 
            //  b)continue if not found 
            //searchcounter is an index (0 based)
            //logical size is a natural count (1 based)
            while (searchcounter < logicalsize && !found)
            {
                if(myArray[searchcounter] == searcharg)
                {
                    //item was found 
                    //stop
                    //searchcounter will be the index of the array location where the searcharg was first found 
                    found = true;
                }
                else
                {
                    //increment to look at the next element in the array
                    searchcounter++;
                }               
            }

            if (found)
            {
                Console.WriteLine($"{searcharg} was found at index {searchcounter}");
            }
            else
            {
                Console.WriteLine($"{searcharg} was not found in the {logicalsize} array elements");
            }


            //count the number of occurances in the loop
            searchcounter = 0;
            int foundcount = 0;
            found = false;
            //this could also be coded using a for loop BECAUSE you are looking at the elements (actual count0
            //for(int searchindex = 0; searchindex < logicalsize; searchindex++)
            //I DO NOT want to stop when I found the first occurance in the loop 
            //Is there another way to terminate the loop instead of using logicalsize 

            while (searchcounter < logicalsize)
            {
                if (myArray[searchcounter] == searcharg)
                {
                    //item was found 
                    //stop
                    //searchcounter will be the index of the array location where the searcharg was first found 
                    found = true;
                    foundcount++;
                }

                //increment to look at the next element in the array
                searchcounter++;
                
            }
            //if (foundcount > 0) then you would not need the boolean found flag 
            if (found)
            {
                Console.WriteLine($"{foundcount} items of {searcharg} were located in the array");
            }
            else
            {
                Console.WriteLine($"{searcharg} was not found in the {logicalsize} array elements");
            }

            Console.ReadKey();
        }
    }
}
