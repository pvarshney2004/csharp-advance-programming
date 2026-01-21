using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Problems;

namespace Tests
{
    public class GenerateExceptionTest
    {
        /*
    4. Testing Exception Handling
Problem:
Create a method Divide(int a, int b) that throws an ArithmeticException if b is
zero. Write a unit test to verify that the exception is thrown properly.
    */

        // unit test to verify exception
        [Test]
        public void Test1()
        {
            Assert.That(GenerateException.Division(23, 23), Is.EqualTo(1));
        }
    }
}