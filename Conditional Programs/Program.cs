using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program 1: Positive, Negative, or Zero
            Console.Write("Enter a number: ");
            double num = double.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("The number is POSITIVE (+)");
            }
            else if (num < 0)
            {
                Console.WriteLine("The number is NEGATIVE (-)");
            }
            else
            {
                Console.WriteLine("The number is ZERO (0)");
            }


            // Program 2: Student Grade Classifier
            Console.Write("Enter your score (0-100): ");
            int score = int.Parse(Console.ReadLine());

            if (score >= 90) Console.WriteLine("Grade: A (Excellent!)");
            else if (score >= 80) Console.WriteLine("Grade: B (Very Good)");
            else if (score >= 70) Console.WriteLine("Grade: C (Good)");
            else if (score >= 60) Console.WriteLine("Grade: D (Pass)");
            else Console.WriteLine("Grade: F (Fail)");


            // Program 3: Days of the Week
            Console.Write("Enter day number (1-7): ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6: Console.WriteLine("Saturday"); break;
                case 7: Console.WriteLine("Sunday"); break;
                default: Console.WriteLine("Invalid day! Please enter 1 to 7."); break;
            }






        }
    }
}
