﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace ParallelArrays
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //array sizing happens when you create the array 
            //an array is a collection
            int[] driverArray = new int[25];
            string[] nameArray = new string[25];

            //the call statment to your method must match the parameter list of your method 
            //ex: 3 parameters, 3 arguments 
            //arguments on the call statment are positional 
            int logicalsize = ReadandLoadArray(driverArray, 25, nameArray);
            int sum = 0;
            for (int index = 0; index < logicalsize; index++)
            {
                sum += driverArray[index];
            }

            if (logicalsize > 0)
            {

                Console.WriteLine($"Quiz Total: {logicalsize}");
                Console.WriteLine($"Student                    Mark");
                Console.WriteLine($"_______     ____");
                int index = 0;
                while (index < logicalsize)
                {
                    Console.Write($"{nameArray[index],-15}");
                    Console.WriteLine($"{driverArray[index]}".PadLeft(9));
                    index++;
                }

                FindHighandLow(driverArray, logicalsize);
                Console.WriteLine($"The average of the {logicalsize} numbers is {(double)sum / (double)logicalsize}");
            }
            else
            {
                Console.WriteLine("You have no numbers to calculate an average.");
            }
        }

        static int ReadandLoadArray(int[] myArray, int physicalsize, string[] nameArray)
        {
            //pass to your method the array reference address
            //change it to the array within this method will alter the ORIGINAL array in the Main() method. 
            // physicalsize is pass by Value  (a copy of the original value)
            //any change to the physicalsize REMAINS within this method and does not affect the original value in Main()
            int logicalsize = 0;

            string Full_Path_File_Name = "";
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            Full_Path_File_Name = fd.FileName;
            string readRecord = "";
            StreamReader reader = null;

            //recordDataColumn will be a counter indicating which column on the currently read record we are dealing with 
            //on the record, each column of data will be separated by a comma (,)
            //two column record Candy Kane, 44
            //threee column record Candy Kane, CPSC1012, 44
            int recordDataColumn = 0;
            try
            {
                reader = new StreamReader(Full_Path_File_Name);
                readRecord = reader.ReadLine();

                while (readRecord != null && logicalsize < physicalsize)
                {
                    //store the data into the program variables 
                    //how does one split the record into separate data columns 
                    //the record is a string 
                    //the data onthe string is separated by a comma(,)
                    //you can use the string class method called .Split(delimiter)
                    //the delimiter is the character used to separate the data values 
                    //.Split(',') returns an array of strings 

                    //pre-test loop: foreach()
                    //syntax: foreach(datatype placeholdername in collection)
                    //datatype can be a strongly declared datatype (int, double,...)
                    //or you can use the declaration of var 
                    //a var datatype is resolve at execution time
                    //placeholdername is your variable name that you will used in your code to reference 
                    //the current ocurrance of the data you are processing
                    //in is the keyword
                    //the collection is your original data collection 

                    //why use foreach?
                    //this method will
                    //  a. check if there is any need to process the loop
                    //  b. automatically moves to the next occurance in the collection 
                    //  c. automatically stops when it reaches the end of the collection 
                    //  d. this will process an unknown number of items 
                    //  e. starts at the begining of your collection and go to the end 
                    //  f. your collection can be any value datatype set

                    foreach (var items in readRecord.Split(','))
                    {
                        if(recordDataColumn == 0)
                        {
                            //name
                            nameArray[logicalsize] = items;
                        }
                        else
                        {
                            //mark
                            myArray[logicalsize] = int.Parse(items);
                        }
                        //switch the record data collection indicator
                        recordDataColumn++;
                    }
                    logicalsize++;
                    //to get ready for the next record, reset your record data column indicator back to 0
                    recordDataColumn = 0;
                    //get the next line
                    readRecord = reader.ReadLine();
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

            return logicalsize;
        }

        static void FindHighandLow(int[] myArray, int logicalsize)
        {
            int highest = 0;
            int lowest = 100;

            int loopcounter = 0;
            while (loopcounter < logicalsize)
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
