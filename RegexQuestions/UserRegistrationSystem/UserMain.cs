using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegexQuestions.UserRegistrationSystem
{
    /*
    OOP + Custom Exception + Regex
Q5: User Registration System
Create a User class:
UserId
Name
PhoneNumber
Email
Password
Task:
Validate:
Phone using Regex (starts with 6–9, 10 digits)
Email using Regex
Password using Regex: At least 1 uppercase, 1 lowercase, 1 number, min length 8
Throw a Custom Exception if validation fails.
Store valid users in List<User>.
    */
    public class UserMain
    {
        public static void Execute()
        {
            List<User> users = new List<User>();
            try
            {
                User u1 = new User
                {
                    UserId = 1,
                    Name = "Alice",
                    Phone = "9876543210",
                    Email = "alice@gmail.com",
                    Password = "Password1"
                };
                u1.Validate(); // validating user
                users.Add(u1); // add only if user is valid
                Console.WriteLine("User Registered Successfully");
            }
            catch (ValidationException ex)
            {
                Console.WriteLine("Registration Failed: " + ex.Message);
            }

            Console.WriteLine("Valid Users List:");
            foreach (User u in users)
            {
                Console.WriteLine($"{u.UserId} | {u.Name} | {u.Email}");
            }
        }


    }
}