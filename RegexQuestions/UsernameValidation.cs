using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexQuestions
{
    public class UsernameValidation
    {
        /*
        1. Validate a Username
A valid username:
● Can only contain letters (a-z, A-Z), numbers (0-9), and underscores (_)
● Must start with a letter
● Must be between 5 to 15 characters long
Example Inputs & Outputs:
● ✅ "user_123" → Valid
● ❌ "123user" → Invalid (starts with a number)
● ❌ "us" → Invalid (too short)
        */
        string pattern = "^[a-zA-Z][a-zA-Z0-9_]{4,14}$";
        public void Validate(string input)
        {
            bool ans = Regex.IsMatch(input,pattern);
            if(ans) System.Console.WriteLine("Input string matched the regex pattern.");
            else System.Console.WriteLine("Input string not matched the regex pattern.");
        }
    }
}