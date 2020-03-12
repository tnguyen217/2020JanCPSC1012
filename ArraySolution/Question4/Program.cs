using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace Question4
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            int[] driverArray = new int[25];
            int logicalsize = ReadandLoadArray(driverArray, 25);
            int sum = 0;
            for (int index = 0; index < logicalsize; index++)
            {
                sum += driverArray[index];
            }

            if (logicalsize > 0)
            {
                string name = "bob";
                Console.WriteLine($"Quiz Total: {logicalsize}");
                Console.WriteLine($"Student     Mark");
                Console.WriteLine($"_______     ____");
                int index = 0;
                while (index < logicalsize)
                {
                    Console.Write($"{name,-7}");
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

        static int ReadandLoadArray(int[] myArray, int physicalsize)
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
