using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexQuestions
{
    public class ValidateCreditcardNumber
    {
        /*
        11. Validate a Credit Card Number (Visa, MasterCard, etc.)
● A Visa card number starts with 4 and has 16 digits.
● A MasterCard starts with 5 and has 16 digits.
        */
        string pattern = @"^(4\d{15}|5\d{15})$";
        public void ValidateCards(string input)
        {
            bool ans = Regex.IsMatch(input,pattern);
            if (ans)
            {
                Console.WriteLine("Valid Credit Card Number");
            }
            else
            {
                Console.WriteLine("Invalid Credit Card Number");
            }
        }
    }
}