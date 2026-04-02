using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program 1: Student Names List
            string[] students = { "Ahmed", "Sara", "Khalid", "Noor", "Omar" ,"ezz"};

            Console.WriteLine("--- Student List ---");
            foreach (string name in students)
            {
                Console.WriteLine("- " + name);
            }


            // Program 2: Max Number Finder
            int[] numbers = { 15, 42, 7, 89, 23, 56 };
            int max = numbers[0]; // نفترض أن أول رقم هو الأكبر

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i]; // تحديث القيمة إذا وجدنا رقماً أكبر
                }
            }

            Console.WriteLine($"The numbers are: {string.Join(", ", numbers)}");
            Console.WriteLine($"The largest number is: {max}");


            // Program 3: Reverse Order
            int[] original = { 1, 2, 3, 4, 5 };

            Console.WriteLine("\nOriginal: " + string.Join(", ", original));

            // استخدام الدالة الجاهزة لعكس المصفوفة
            Array.Reverse(original);

            Console.WriteLine("Reversed: " + string.Join(", ", original));



        }
    }
}
