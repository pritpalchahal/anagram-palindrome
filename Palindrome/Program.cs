using System;
using System.Text.RegularExpressions;

namespace Palindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            //if no input supplied
            if(args.Length == 0)
            {
                Console.WriteLine("Error: supply input string!");
                return;
            }
            //if too many inputs
            if (args.Length > 1)
            {
                Console.WriteLine("Error: supply only one input string!");
                return;
            }
            //if input does not meet assumptions
            if(!Regex.IsMatch(args[0], "^[a-z]+$"))
            {
                Console.WriteLine("Error: Invalid input string. Make sure: "
                    +"\n\t1. There will be no whitespace in the string."
                    +"\n\t2. All characters in the string will be lower case."
                    +"\n\t3. The string will only contain alpha characters a-z");
                return;
            }

            string input = args[0];
            bool result = isPalindromeOrAnagramOfPalindrome(input);
            Console.WriteLine("Result: " + result);
        }

        /**
         * Method takes an input string and returns true if it is a palindrome
         * or an anagram of a palindrome, false otherwise.
         * @param input
         * */
        public static bool isPalindromeOrAnagramOfPalindrome(string input)
        {
            int[] vals = new int[26];//min required space is 26 because of assumptions
            bool isP = true;
            //traverse from both sides
            for(int i = 0, j = input.Length - 1; i <= j; i++, j--)
            {
                char a = input[i];
                char b = input[j];
                if (a != b)
                {
                    isP = false;//not a palindrome
                    vals[a - 'a']++;
                    vals[b - 'a']++;
                }
                if(i == j)//middle value in case of odd length
                {
                    vals[a - 'a']--;
                }
            }
            if (isP)
            {
                Console.WriteLine(String.Format("\"{0}\" is a Palindrome.", input));
                return true;
            }

            int count = 0;
            foreach(int i in vals)
            {
                if(i % 2 == 1)
                {
                    count++;//chars which occured odd no of times in input
                }
            }
            //is an anagram if odd chars are either 1 or none
            if (count <= 1)
            {
                Console.WriteLine(String.Format("\"{0}\" is an Anagram of a Palindrome.", input));
                return true;
            }

            Console.WriteLine("Neither a Palindrome nor an Anagram of a Palindrome.");
            return false;
        }
    }
}
