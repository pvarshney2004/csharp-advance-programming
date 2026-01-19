using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexQuestions.UserRegistrationSystem
{
    /*
    Create a User class:
UserId
Name
PhoneNumber
Email
Password
    */
    public class User
    {
        public int UserId { get; set; }
        public string? Name;
        public string? Phone;
        public string? Email;
        public string? Password { get; set; }

        public void Validate()
        {
            string phonePattern = @"^[6-9]\d{9}$";
            string emailPattern = @"^[a-zA-Z0-9._]+@[a-zA-Z]+\.[a-zA-Z]{2,}$";
            string passwordPattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,}$";

            if (!Regex.IsMatch(Email, emailPattern))
            {
                throw new ValidationException("Invalid Email ID");
            }
            if (!Regex.IsMatch(Phone, phonePattern))
            {
                throw new ValidationException("Invalid Phone Number");
            }
            if (!Regex.IsMatch(Password, passwordPattern))
            {
                throw new ValidationException("Invalid Password");
            }
        }

    }
}