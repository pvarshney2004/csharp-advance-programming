using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexQuestions
{
    public class LicensePlateNumberValidation
    {
        /*
        2. Validate a License Plate Number
License plate format: Starts with two uppercase letters, followed by four digits.
Example: "AB1234" is valid, but "A12345" is invalid.
        */
        string pattern = "^[A-Z]{2}[0-9]{4}$";
        public void Validate(string input)
        {
            bool ans = Regex.IsMatch(input,pattern);
            if (ans)
            {
                System.Console.WriteLine("Valid License Plate");
            }
            else
            {
                System.Console.WriteLine("Invalid License Plate");
            }
        }
    }
}