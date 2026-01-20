using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringTesting
{
    public class StringUtils
    {
        /*
        2. Testing String Utility Methods
Problem:
Create a StringUtils class with the following methods:
● Reverse(string str): Returns the reverse of a given string.
● IsPalindrome(string str): Returns true if the string is a palindrome.
● ToUpperCase(string str): Converts a string to uppercase.
Write NUnit or MSTest test cases to verify that these methods work correctly.
        */
        // method to reverse a string
        public static string Reverse(string str)
        {
            char[] arr = str.ToCharArray();
            int i = 0;
            int j = arr.Length - 1;
            while (i < j)
            {
                char temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
            return new string(arr);
        }

        // method to check if a string is palindrome or not
        public static bool IsPalindrome(string str)
        {
            char[] arr = str.ToCharArray();
            int i = 0;
            int j = arr.Length - 1;
            while (i < j)
            {
                if (arr[i] != arr[j]) return false;
                i++;
                j--;
            }
            return true;
        }

        // method to convert a string to uppercase
        public static string ToUpperCase(string str)
        {
            return str.ToUpper();
        }
    }
}