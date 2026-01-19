using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lambda
{
    public class SortStrings
    {
        /*
        Sorting + Lambda (but NOT LINQ)
Q2: Sort String List by Length Using Lambda in Sort()
Given a List<string>:
        */
        public static void Execute()
        {
            List<string> ll = new List<string>{"Apple","Hello","Bye","Good","Banana","Elephant","Ice"};
            ll.Sort((a,b)=>a.Length.CompareTo(b.Length));
            Console.WriteLine("Strings sorted by length in ascending Order:\n");
            foreach (string word in ll)
            {
                Console.WriteLine($"{word} (Length: {word.Length})");
            }
        }
    }
}