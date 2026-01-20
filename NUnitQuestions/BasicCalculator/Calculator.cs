using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCalculator
{
    public class Calculator
    {
        /*
        1. Basic NUnit Test: Testing a Calculator Class
Problem:
Create a Calculator class with methods:
● Add(int a, int b)
● Subtract(int a, int b)
● Multiply(int a, int b)
● Divide(int a, int b)
Write NUnit or MSTest test cases for each method.
👉 Bonus: Test for division by zero and handle exceptions properly
        */
        // method to add two numbers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // method to subtract b from a
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        // method to multiply two number
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        // method to divide a by b and handling zero division exception
        public int Division(int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("Cannot divide by zoer");
            }
            return a / b;
        }
    }
}