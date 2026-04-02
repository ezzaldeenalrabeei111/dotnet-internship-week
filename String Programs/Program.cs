using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program 1: Common String Methods
            string message = "  Hello C# Programming  ";

            Console.WriteLine($"Original: '{message}'");
            Console.WriteLine($"Trimmed:  '{message.Trim()}'"); // إزالة الفراغات من الأطراف
            Console.WriteLine($"Upper:    {message.ToUpper()}"); // تحويل لكبير
            Console.WriteLine($"Lower:    {message.ToLower()}"); // تحويل لصغير
            Console.WriteLine($"Length:   {message.Length}");    // طول النص





            // Program 2: Simple Word Counter
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            // تقسيم النص بناءً على المسافات وإزالة الفراغات الزائدة
            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"Number of words: {words.Length}");



            // Program 3: Search within String
            string text = " Learning C# is fun ? ";

            Console.WriteLine($"\nText: {text}");
            Console.Write("Enter a word to search for: ");
            string searchTerm = Console.ReadLine();

            // استخدام Contains للبحث (مع تحويل الاثنين لصغير لتجاهل حالة الأحرف)
            bool found = text.ToLower().Contains(searchTerm.ToLower());

            if (found)
            {
                Console.WriteLine($"Success! '{searchTerm}' was found in the text.");
            }
            else
            {
                Console.WriteLine($"Sorry, '{searchTerm}' was not found.");
            }


        }
    }
}
