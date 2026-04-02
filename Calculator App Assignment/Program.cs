using System;
using System.Collections.Generic;  
using System.Linq;  
class CalculatorApp
{
    // قائمة لتخزين سجل العمليات
    static List<string> history = new List<string>();

    static void Main()
    {
        string exitChoice;

        do
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("    Welcome to Pro Console Calculator   ");
            Console.WriteLine("========================================\n");

            // خيار عرض السجل في البداية
            Console.WriteLine("Type 'h' to view history, or any other key to start calculation.");
            if (Console.ReadLine().ToLower() == "h") ShowHistory();

            // 1. إدخال الرقم الأول
            double num1 = GetValidNumber("Enter the first number: ");

            // 2. اختيار العملية
            string operation = GetValidOperation();

            // 3. إدخال الرقم الثاني
            double num2 = GetValidNumber("Enter the second number: ");

            // 4. إجراء الحساب وتخزين النتيجة في السجل
            Console.WriteLine("\n----------------------------------------");
            PerformCalculation(num1, num2, operation);
            Console.WriteLine("----------------------------------------");

            // 5. خيار الإعادة
            Console.Write("\nDo you want to perform another calculation? (y/n): ");
            exitChoice = Console.ReadLine().ToLower();

        } while (exitChoice == "y" || exitChoice == "yes");

        Console.WriteLine("\nThank you for using the Calculator! Goodbye.");
    }

    static double GetValidNumber(string message)
    {
        double number;
        Console.Write(message);
        while (!double.TryParse(Console.ReadLine(), out number))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input! Please enter a number.");
            Console.ResetColor();
            Console.Write(message);
        }
        return number;
    }

    static string GetValidOperation()
    {
        string[] validOps = { "+", "-", "*", "/", "%", "^" };
        while (true)
        {
            Console.Write("Choose operation (+, -, *, /, %, ^): ");
            string op = Console.ReadLine();
            if (Array.Exists(validOps, e => e == op)) return op;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid operator!");
            Console.ResetColor();
        }
    }

    static void PerformCalculation(double n1, double n2, string op)
    {
        double result = 0;
        bool hasError = false;

        switch (op)
        {
            case "+": result = n1 + n2; break;
            case "-": result = n1 - n2; break;
            case "*": result = n1 * n2; break;
            case "/":
                if (n2 != 0) result = n1 / n2;
                else { Console.WriteLine("Error: Cannot divide by zero!"); hasError = true; }
                break;
            case "%":
                if (n2 != 0) result = n1 % n2;
                else { Console.WriteLine("Error: Modulo by zero!"); hasError = true; }
                break;
            case "^": result = Math.Pow(n1, n2); break;
        }

        if (!hasError)
        {
            string entry = $"{n1} {op} {n2} = {result}";
            history.Add(entry); // إضافة العملية للسجل

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Result: {entry}");
            Console.ResetColor();
        }
    }

    static void ShowHistory()
    {
        Console.WriteLine("\n--- Last 5 Operations ---");
        // جلب آخر 5 عمليات فقط
        var lastItems = history.Skip(Math.Max(0, history.Count - 5)).ToList();

        if (lastItems.Count == 0)
            Console.WriteLine("No operations found.");
        else
            lastItems.ForEach(i => Console.WriteLine(i));

        Console.WriteLine("------------------------\n");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}

