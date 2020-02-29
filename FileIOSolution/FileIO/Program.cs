using Microsoft.Win32; //required for the OpenFileDialog
using System;
using System.Collections.Generic;
using System.IO; //required to do file i/o
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class Program
    {
        //this is required for your code when using OpenFileDialog
        [STAThread]
        static void Main(string[] args)
        {
            string Full_Path_File_Name = "";

            //the file will always be in the same location
            //you can prompt for the file name

            //location

            //set up the path name
            //string FolderPath = @"c:\Users\Tnguyen217\Documents\GitHub\2020JanCPSC1012\";

            //use methods within the sofware to access the general special folders of your Windows file system
            //Documents, Downloads, Pictures, Music 

            //this GetFolderPath will return C:\Users\xxxx\the special foldername 
            //for the following statement C:\Users\Tnguyen217\Documents
            //string specialpathname = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //Now, you must add any additional path structure to get to the specific folder within the special folder 
            //string FolderPath = specialpathname + @"\GitHub\2020JanCPSC1012\";
            
            
            //**********************


            //I will assume that the require fill always be found at the root of the course class repository

            //Console.Write("Enter the file name ex myfile.txt\t");
            //string FileName = Console.ReadLine();

            //Full_Path_File_Name = FolderPath + FileName;

            //Is there a way to browse for a file
            //Yes, you can call the OpenFileDialog
            //This is the dialog you see on the system when you go browsing for a file within an application 
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            Full_Path_File_Name = fd.FileName; 


            //set up for reading a file
            //a string variable is required to recieve the data from the file.
            //the string will be filled with one row from your file on each file read.

            string readValue = "";

            //use a variable to count the row in the file (optional)
            int counter = 0;

            //inclide what is refer to as "User Friendly error handling"
            //this is your try/catch/finally structure
            //the finally portion is only needed if you need to close a connection to a data source
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
                    Console.WriteLine($"File line {counter} has a value of {readValue}\n");

                    //get the next line
                    readValue = reader.ReadLine();

                }
            }//eot
            catch(Exception ex)
            {
                //.Message holds the error that occured during the processing of the code in your try{...}
                Console.WriteLine($"Error: {ex.Message}"); 
            }
            finally
            {
                //this used if you need to close a data source such as an open file 
                reader.Close();
            }
                                
            Console.ReadKey();
        }
    }
}
