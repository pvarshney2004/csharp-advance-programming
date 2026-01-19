using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexQuestions
{
    public class ExtractValidPhoneEmail
    {
        /*
         Regex + Collections
Q8: Valid Phone and Email Extraction
Given a List<string> containing:
random text
numbers
emails
phone numbers
Task:
Extract all valid email IDs using Regex.
Extract all valid Indian phone numbers using Regex.
Store valid emails and valid phones in two separate lists.
Print both lists.
No LINQ.
        */

        public void Execute()
        {
            List<string> data = new List<string>
            {
                "hello world",
                "invalid@mail",
                "contact me at user@gmail.com",
                "Phone: 9876543210",
                "Call on +91 9123456789",
                "Random text 12345",
                "Mobile: 1234567890",
                "Email: admin@company.org",
            };

            List<string> validEmails = new List<string>();
            List<string> validPhones = new List<string>();

            string patternForEmail = @"[a-zA-Z0-9._]+@[a-zA-Z]+\.[a-zA-Z]{2,}";
            string patternForPhone = @"(\+91\s?)?[6-9]\d{9}"; // \s for whitespace character after +91

            foreach (string item in data)
            {
                // extracting emails
                MatchCollection emailMatches = Regex.Matches(item, patternForEmail);
                foreach (Match match in emailMatches)
                {
                    validEmails.Add(match.Value);
                }

                // extracting phone numbers
                MatchCollection phoneMatches = Regex.Matches(item, patternForPhone);
                foreach (Match match in phoneMatches)
                {
                    validPhones.Add(match.Value);
                }
            }

            Console.WriteLine("Valid Email IDs:");
            foreach (string email in validEmails)
            {
                Console.WriteLine(email);
            }

            Console.WriteLine();

            Console.WriteLine("Valid Indian Phone Numbers:");
            foreach (string phone in validPhones)
            {
                Console.WriteLine(phone);
            }
        }
    }
}