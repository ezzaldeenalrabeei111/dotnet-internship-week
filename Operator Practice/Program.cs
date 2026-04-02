using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program 1: Rectangle Area Calculator
            Console.WriteLine("--- Area Calculator ---");
            Console.Write("Enter Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter Width: ");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;  
            Console.WriteLine($"The Area of the rectangle is: {area}");


            // Program 2: Fahrenheit to Celsius
            Console.WriteLine("\n--- Temperature Converter ---");
            Console.Write("Enter temperature in Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            // المعادلة: (F - 32) * 5/9
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit}°F is equal to {celsius:F2}°C");


            // Program 3: Variable Swap
            int a = 5;
            int b = 10;

            Console.WriteLine($"\n--- Before Swap: a = {a}, b = {b} ---");

            // عملية التبديل
            int temp = a; // نضع قيمة a في مخزن مؤقت
            a = b;        // نضع قيمة b في a
            b = temp;     // نأخذ القيمة من المخزن المؤقت ونضعها في b

            Console.WriteLine($"--- After Swap:  a = {a}, b = {b} ---");


        }
    }
}
