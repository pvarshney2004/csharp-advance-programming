using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lambda
{
    public class SortStringsUsingLINQ
    {
        /*
        Use of a lambda expression within the LINQ OrderBy method to sort a list of strings based on their length in ascending order. The resulting sorted list is then printed to the console.
        */
        public static void Execute()
        {
            List<string> ll = new List<string>{"Apple","Hello","Bye","Good","Banana","Elephant","Ice"};
            var sortedWords = ll.OrderBy(word => word.Length).ToList();
            Console.WriteLine("Strings sorted by length in Ascending Order:\n");
            foreach (string word in sortedWords)
            {
                Console.WriteLine($"{word} --> Length: {word.Length}");
            }
        }
    }
}