/*
Author: Alejandro Sanchez
Date: 1/24/2023
Description: C# Console Application for calculating letter grades
 */
    using System;
using System.Linq.Expressions;

namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a numeric grade:");

                decimal grade = decimal.Parse(Console.ReadLine());

                string letter;

                if (grade >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your expected letter grade for ISM300 is: " + letter);
                }
                else if (grade is >= 80 && grade is < 90)
                {
                    letter = "B";
                    Console.WriteLine("Your expected letter grade for ISM300 is: " + letter);
                }
                else if (grade is >= 70 && grade is < 80)
                {
                    letter = "C";
                    Console.WriteLine("Your expected letter grade for ISM300 is: " + letter);
                }
                else if (grade is >= 60 && grade is < 70)
                {
                    letter = "D";
                    Console.WriteLine("Your expected letter grade for ISM300 is: " + letter);
                }
                else if (grade is >= 0 && grade is < 60)
                {
                    letter = "F";
                    Console.WriteLine("Your expected letter grade for ISM300 is: " + letter);
                }
            }
            catch
            {
                Console.WriteLine("Enter a numeric value");
            }
        }
    }
}

