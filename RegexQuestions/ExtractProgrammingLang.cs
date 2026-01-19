using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexQuestions
{
    public class ExtractProgrammingLang
    {
        /*
12. Extract Programming Language Names from a Text
Example Text: "I love Java, Python, and JavaScript, but I haven't tried Go yet."
Expected Output:
● Java, Python, JavaScript, Go
        */
        string pattern = @"\b(Java|Python|Go|JavaScript)\b";
        public void ExtractWords(string input)
        {
            MatchCollection matches = Regex.Matches(input,pattern);
            foreach(Match match in matches)
            {
                System.Console.Write(match.Value+" ");
            }
        }
    }
}