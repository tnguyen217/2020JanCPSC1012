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


            if (age <= 6)
            {
                msg = "Your addmission is FREE";
            }
            else if (age > 6 && age <= 17)
            {
                msg = "Your addmission is $9.80";
            }
            else if (age > 17 && age <= 54)
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

            if (grade <= 100 && grade>=90)
            {
                gradeLetter = "A";
            }
            else if (grade < 90 && grade >= 80)
            {
                gradeLetter = "B";
            }
            else if (grade < 80 && grade >=70)
            {
                gradeLetter = "C";
            }
            else if (grade < 70 && grade >= 50)
            {
                gradeLetter = "D";
            }
            else
            {
                gradeLetter = "F";
            }

            Console.WriteLine($"The Grade Letter of student {name} with grade {grade} is {gradeLetter}");


            //Question 4

            Console.Write("Enter your income: ");
            string inputIncome = Console.ReadLine();
            double income = double.Parse(inputIncome);
            double taxDue;

            if (income <= 50000)
            {
                taxDue = 0 + 5 / 100 * income;
            }
            else if (income <= 100000)
            {
                taxDue = 2500 + 7 / 100 * income;
            }
            else
            {
                taxDue = 6000 + (9 / 100 * income);
            }

            Console.WriteLine($"The tax due of your ${income} is ${taxDue}");

            Console.ReadKey();
        }
    }
}
