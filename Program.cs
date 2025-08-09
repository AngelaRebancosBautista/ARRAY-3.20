using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[5];

            Console.WriteLine("Enter 5 words");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Word {i + 1}: ");
                words[i] = Console.ReadLine();
            }

            Console.WriteLine("\nPalindrome Check Results:");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("| Word            | Status                        |");
            Console.WriteLine("---------------------------------------------------");

            foreach (string word in words)
            {
                string status = IsPalindrome(word) ? "Palindrome" : "Not a Palindrome";
                Console.WriteLine($"| {word,-15} | {status,-30} |");
            }
        }
        static bool IsPalindrome(string word)
        {
            string normalizedWord = word.Replace(" ", "").ToLower();

            char[] charArray = normalizedWord.ToCharArray();
            Array.Reverse(charArray);
            string reversedWord = new string(charArray);

            return normalizedWord == reversedWord;
        }
    }
}
        
    

