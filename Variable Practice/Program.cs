using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Program 1: Integer and Double
            //int apples = 10;
            //double pricePerApple = 1.5;
            //double total = apples * pricePerApple;

            //Console.WriteLine($"I have {apples} apples.");
            //Console.WriteLine($"Each apple costs ${pricePerApple}. Total: ${total}");


            //// Program 2: String and Char
            //string playerName = "Samer";
            //char rank = 'A';  

            //Console.WriteLine($"Player: {playerName}");
            //Console.WriteLine($"Rank: {rank}");


            //// Program 3: Boolean logic
            //bool isGameRunning = true;
            //bool isGameOver = false;

            //Console.WriteLine("Is the game running? " + isGameRunning);
            //Console.WriteLine("Is the game over? " + isGameOver);

            //// Program 4: Type Casting
            //double myGpa = 3.85;
            //int roundedGpa = (int)myGpa;

            //Console.WriteLine($"My real GPA: {myGpa}");
            //Console.WriteLine($"GPA as Integer: {roundedGpa}");


            //// Program 5: String to Int Conversion
            //string ageText = "25";
            //int ageNumber = Convert.ToInt32(ageText);  

            //Console.WriteLine("Next year you will be: " + (ageNumber + 1));

 
                Console.WriteLine("=== User Profile Creator ===\n");

                Console.Write("Enter your full name: ");
                string fullName = Console.ReadLine();

                 
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                 
                Console.Write("Enter your height (e.g., 1.75): ");
                double height = double.Parse(Console.ReadLine());

                 
                Console.Write("Enter your favorite character (e.g., #, A, !): ");
                char favChar = char.Parse(Console.ReadLine());

                 
                bool isActive = true;

                 
                Console.WriteLine("\n----------------------------");
                Console.WriteLine("      USER PROFILE");
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Name:      {fullName}");
                Console.WriteLine($"Age:       {age} years old");
                Console.WriteLine($"Height:    {height} meters");
                Console.WriteLine($"Symbol:    {favChar}");
                Console.WriteLine($"Active:    {isActive}");
                Console.WriteLine("----------------------------");

                 
                int roundedHeight = (int)height;  
                Console.WriteLine($"Note: Your height rounded is: {roundedHeight}");

                Console.WriteLine("\nProfile Created Successfully!");
            
        








        }
    }
}
