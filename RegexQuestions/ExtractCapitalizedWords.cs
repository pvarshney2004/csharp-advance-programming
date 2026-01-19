using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexQuestions
{
    public class ExtractCapitalizedWords
    {
        /*
        5. Extract All Capitalized Words from a Sentence
Example Text: "The Eiffel Tower is in Paris and the Statue of Liberty is in New
York."
Expected Output:
● The, Eiffel, Tower, Paris, Statue, Liberty, New, York
        */
        string pattern = "[A-Z][a-z]*";
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