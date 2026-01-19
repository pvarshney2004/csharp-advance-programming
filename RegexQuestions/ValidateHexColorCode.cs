using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexQuestions
{
    public class ValidateHexColorCode
    {
        /*
        3. Validate a Hex Color Code
A valid hex color:
● Starts with a #
● Followed by 6 hexadecimal characters (0-9, A-F, a-f).
Example Inputs & Outputs:
● ✅ "#FFA500" → Valid
● ✅ "#ff4500" → Valid
● ❌ "#123" → Invalid (too short)
        */
        string pattern = "^#[0-9a-fA-F]{6}";
        public void Validate(string input)
        {
            bool ans = Regex.IsMatch(input, pattern);
            if (ans)
            {
                System.Console.WriteLine("Valid Hexadecimal color code");
            }
            else
            {
                System.Console.WriteLine("Invalid Hexadecimal color code");
            }
        }
    }
}