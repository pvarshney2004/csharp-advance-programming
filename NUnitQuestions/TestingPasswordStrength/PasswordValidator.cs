using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestingPasswordStrength
{
    public class PasswordValidator
    {
        /*
        2. Testing Password Strength Validator
Problem:
Create a PasswordValidator class with:
● Passwords must have at least 8 characters, one uppercase letter, and one
digit.
✅ Write unit tests for valid and invalid passwords.
        */
        // method to validate password
        public bool ValidatePassword(string password)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*\d).{8,}$";
            return Regex.IsMatch(password, pattern);
        }
    }
}