using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Program 1: Multiplication Table
            Console.Write("Enter a number to see its multiplication table: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }


            // Program 2: FizzBuzz (1 to 20)
            Console.WriteLine("\n--- FizzBuzz Challenge ---");
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }




            // Program 3: Sum of First N Numbers
            Console.Write("\nEnter a number (N) to calculate the sum from 1 to N: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= number; i++)
            {
                sum += i; // إضافة القيمة الحالية لـ  
            }

            Console.WriteLine($"The total sum from 1 to {number} is: {sum}");

        }
    }
}
