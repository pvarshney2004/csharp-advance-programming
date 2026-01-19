using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexQuestions
{
    public class ExtractEmailAddresses
    {
        /*
        4. Extract All Email Addresses from a Text
Example Text: "Contact us at support@example.com and info@company.org"
Expected Output:
● support@example.com
● info@company.org
        */

        string pattern = @"[a-zA-Z0-9._]+@[a-zA-Z]+\.[a-zA-Z]{2,}";
        public void ValidateEmails(string input)
        {
            MatchCollection ans = Regex.Matches(input,pattern);
            foreach (Match match in ans)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}