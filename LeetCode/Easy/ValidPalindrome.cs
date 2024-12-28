using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /// <summary>
    /// Grind 75
    /// </summary>
    public static class ValidPalindrome
    {
        //  A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward.Alphanumeric characters include letters and numbers.
        //  Given a string s, return true if it is a palindrome, or false otherwise.

        //Example 1:

        //Input: s = "A man, a plan, a canal: Panama"
        //Output: true
        //Explanation: "amanaplanacanalpanama" is a palindrome.
        public static void ExampleOne()
        {
            Console.WriteLine(IsPalindrome("\"A man, a plan, a canal: Panama\""));
        }

        public static void ExampleTwo()
        {
            Console.WriteLine(IsPalindrome("race a car"));
        }

        public static void ExampleThree() 
        {
            Console.WriteLine(IsPalindrome("0P"));
        }

        public static bool IsPalindromeTwoPointer(string s)
        {
            var left = 0;
            var right = s.Length - 1;

            while (left != right)
            {
                while (!Char.IsLetter(s[left]))
                    left++;
                while (!Char.IsLetter(s[right]))
                    right--;
            
                if (Char.ToLower(s[left]) != Char.ToLower(s[right]))
                    return false;
            
                left++;
                right--;
            }

            return true;
        }

        public static bool IsPalindrome(string s)
        {
            var newString = new String(s.ToLower().Where(c => Char.IsLetter(c) || Char.IsNumber(c)).ToArray());

            if (string.IsNullOrEmpty(newString))
                return true;

            var length = newString.Length-1;
            var toCheck = newString.Length / 2;
            for (int i = 0; i < toCheck; i++) 
            {                
                if (newString[i] != newString[length-i])
                    return false;
            }

            return true;
        }
    }
}
