using System;

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your grade as a numeric value");

            try
            {
                string input = Console.ReadLine(); //takes the user inputs and records it

                int grade = int.Parse(input); //coverts the string input to an interger grade variable


                if (grade > 100) //in case the users get "clever" and decides to use a number over 100
                    Console.WriteLine("Grade entered is too high.");

                else if (grade > 98)
                {
                    Console.WriteLine("INCREDIBLE! Your grade is an A+");
                }
                else if (grade >= 97)
                    Console.WriteLine("Amazing! Your grade is an A");
                else if (grade >= 91)
                    Console.WriteLine("Well done! Your grade is an A-");
                else if (grade >= 89)
                    Console.WriteLine("Great Job! Your grade is an B+");
                else if (grade >= 87)
                    Console.WriteLine("Awesome! Your grade is an B");
                else if (grade >= 81)
                    Console.WriteLine("Exellent! Your grade is an B-");
                else if (grade >= 79)
                    Console.WriteLine("Doing well! Your grade is an C+");
                else if (grade >= 77)
                    Console.WriteLine("Great effort! Your grade is an C");
                else if (grade >= 71)
                    Console.WriteLine("Not bad! Your grade is an C-");
                else if (grade >= 69)
                    Console.WriteLine("NICE! Your grade is an D+");
                else if (grade >= 67)
                    Console.WriteLine("YIKES! Your grade is an D");
                else if (grade >= 61)
                    Console.WriteLine("OOF! Your grade is an D-");
                else if (grade > 60)
                    Console.WriteLine("Oh man, Your grade is an F");



            }

            catch
            {
                Console.WriteLine("Invalid Input use a number below 100 please"); // in case the user inputs something other than a number
            }
        }
    }
}
