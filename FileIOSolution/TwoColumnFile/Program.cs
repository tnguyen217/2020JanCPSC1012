using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace TwoColumnFile
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string Full_Path_File_Name = "";

            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            Full_Path_File_Name = fd.FileName;

            string readValue = "";

            int counter = 0;
            StreamReader reader = null;

            try
            {
                //in the try is the code you will attempt to execute 
                //if an error happens during the execution of the code, an Exception is thrown by the system
                //any Exception thrown by the system is passed to the catch{} coding for processing 

                //to test the try/catch I will introduce a BAD path name
                //Full_Path_File_Name = @"c:\Users\Tnguyen217\Documents\GitHub\2020JanCPSC1012\bob.txt";

                //add the .Net Framework classthat contains the code that will do the read of the file
                //the required I/O for reading is StreamReader located in the namespace System.IO
                //To attach the reader to the file you need to pass the full path file name (fully qualified file name) as an argument to the class while it is being created 
                //the reader is refer as to an instance of the class
                //the instance is physically created when the new command is used in conjuction with the class name
                reader = new StreamReader(Full_Path_File_Name);

                //gets a single row of the file
                readValue = reader.ReadLine();

                //if your line that was "red" is null, you have reach the end of the file or (eof)

                while (readValue != null) //stop when you reach the end of the file 
                {
                    counter++;
                    // Console.WriteLine($"File line {counter} has a value of {readValue}\n");

                    //You must know how the indivudial valies are separted on the file line (record)
                    //Manytimes this is done using a comma (,)
                    //Files that use a comma are  generally referred to as comma separated values (csv)
                    //Each record that is read is processed through a loop to extract each value .
                    //A system method exist which allows one to split the valies apart 
                    //this method is .Split('delimiter')
                    //the delimiter is the character used to separate the valies ont eh file record

                    int columncounter = 0;
                    foreach(var columnitems in readValue.Split(','))
                    {
                        columncounter++;
                        Console.WriteLine($"Row {counter} Column {columncounter} has a value of {columnitems}");
                    }

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

            Console.ReadKey();
        }
    }
}
