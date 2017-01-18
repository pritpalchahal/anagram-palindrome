using System;
using System.Collections.Generic;

namespace Palindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("supply input string!");
                return;
            }
            if (args.Length > 1)
            {
                Console.WriteLine("supply only one input string!");
                return;
            }
            string input = args[0];

            Console.WriteLine("AofP - "+isAnagramOfPalindrome(input));
            Console.WriteLine("P - " + isPalindrome(input));

            bool result = isPalindromeOrAnagramOfPalindrome(input);
            Console.WriteLine("Result: " + result);

            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();
        }

        public static bool isPalindromeOrAnagramOfPalindrome(string input)
        {
            List<char> vals = new List<char>();
            bool isP = true;
            for (int i = 0, j = input.Length - 1; i <= j; i++, j--)
            {
                char a = input[i];
                char b = input[j];
                if (a != b)
                {
                    isP = false;//not a palindrome

                    if (vals.Contains(a)) vals.Remove(a);
                    else vals.Add(a);
                    if (vals.Contains(b)) vals.Remove(b);
                    else vals.Add(b);
                }
                if (a == b)
                {
                    if (vals.Contains(a)) vals.Remove(a);
                }
            }

            if (isP)
            {
                Console.WriteLine(String.Format("\"{0}\" is a Palindrome.",input));
                return true;
            }
            else if (vals.Count <= 1)
            {
                Console.WriteLine(String.Format("\"{0}\" is an Anagram of a Palindrome.",input));
                return true;
            }
            else
            {
                Console.WriteLine("Neither a Palindrome nor an Anagram of a Palindrome.");
                return false;
            }
        }

        public static bool isPalindrome(string input)
        {
            for (int i = 0, j = input.Length - 1; i < j; i++, j--)
            {
                char a = input[i];
                char b = input[j];
                if (a != b)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool isAnagramOfPalindrome(string input)
        {
            List<char> vals = new List<char>();
            foreach(char c in input)
            {
                if (vals.Contains(c))
                {
                    vals.Remove(c);
                }
                else
                {
                    vals.Add(c);
                }
            }

            if (vals.Count <= 1) return true;

            return false;
        }
    }
}
