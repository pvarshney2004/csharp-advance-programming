using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexQuestions
{
    public class ValidateSSN
    {
        /*
        15. Validate a Social Security Number (SSN)
Example Input: "My SSN is 123-45-6789."
Expected Output:
● ✅ "123-45-6789" is valid
● ❌ "123456789" is invalid
        */
        string pattern = @"(\d{3})-(\d{2})-(\d{4})";
        public void Validate(string input)
        {
            if (Regex.IsMatch(input, pattern))
            {
                System.Console.WriteLine("Valid SSN number");
            }
            else
            {
                System.Console.WriteLine("Invalid SSN number");
            }
        }
    }
}