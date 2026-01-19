using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexQuestions
{
    public class ExtractCurrency
    {
        /*
        13. Extract Currency Values from a Text
Example Text: "The price is $45.99, and the discount is $ 10.50."
Expected Output:
● $45.99, 10.50
        */

        //optional $ with optional space, digits with optional decimal
        string pattern = @"\$?\d+(\.\d{2})?";
        public void ExtractCurrencyValues(string input)
        {
            MatchCollection matches = Regex.Matches(input, pattern);
            Console.WriteLine("Currency Values:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value.Trim());
            }
        }
    }
}