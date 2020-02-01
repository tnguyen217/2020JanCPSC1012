using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1

            Console.Write("Enter your number: ");
            string inputNumber = Console.ReadLine();
            int number = int.Parse(inputNumber);

            if (number > 0)
            {
                Console.WriteLine($"Your number {number} is positive");
            }
            else
            {
                Console.WriteLine($"Your number {number} is negative");
            }

            
            //Question 2

            Console.Write("Enter your age: ");
            string inputAge = Console.ReadLine();
            int age = int.Parse(inputAge);
            string msg;


            if (age < 7)
            {
                msg = "Your addmission is FREE";
            }
            else if (age <= 18)
            {
                msg = "Your addmission is $9.80";
            }
            else if (age < 55)
            {
                msg = "Your addmission is $11.35";
            }
            else
            {
                msg = "Your addmission is $10.00";
            }

            Console.WriteLine(msg);


            //Question 3

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your grade: ");
            string inputGrade = Console.ReadLine();
            double grade = double.Parse(inputGrade);
            string gradeLetter;

            if (grade <= 100)
            {
                gradeLetter = "A";
            }
            else if (grade >= 80)
            {
                gradeLetter = "B";
            }
            else if (grade >= 70)
            {
                gradeLetter = "C";
            }
            else if (grade >= 50)
            {
                gradeLetter = "D";
            }
            else if (grade >= 0)
            {
                gradeLetter = "F";
            }
            else
            {
                gradeLetter = "Invalid";
            }

            Console.WriteLine($"The Grade Letter of student {name} with grade {grade} is {gradeLetter}");


            //Question 4

            //using column alighed output
            //the syntax for formatting {variable,columnsize:formatstring}
            //variable is the data output
            //columnsize is the number of character spacing to be used for the column
            //positive columnsize is right aligned
            //negative columnsize is left aligned
            //fomastring is your string format
            //put our the tax table as a column formatted table
            //using a \t character will give column depending on the length of your output string (inconsistence)
            Console.WriteLine("Taxable Income \t Tax Calculation");

            Console.Write("Enter your income: ");
            string inputIncome = Console.ReadLine();
            double income = double.Parse(inputIncome);
            double taxDue;

            if (income <= 50000)
            {
                taxDue = 0 + 0.05 * income;
            }
            else if (income <= 100000)
            {
                taxDue = 2500 + 0.07 * (income - 50000);
            }
            else
            {
                taxDue = 6000 + 0.09 * (income - 100000);
            }

            Console.WriteLine($"The tax due of your ${income} is ${taxDue}");

            Console.WriteLine("Taxable Income \t Tax Calculation");
            Console.WriteLine("Up to $50,000 \t $0 + 5% of amount over $0");
            Console.WriteLine("Up to $100,000 \t $2,500 + 7% of amount over $50,000");
            Console.WriteLine("Up to $50,000 \t $6,000 + 9% of amount over $100,000");

            //output using columm printing
            Console.WriteLine("{0,6} {1,7}","income:", "taxDue:");
            Console.WriteLine($"{income,6:c} {taxDue,7:c}");

            Console.ReadKey();
        }
    }
}
