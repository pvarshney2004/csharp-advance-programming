using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Problems;

namespace Tests
{
    public class NumberCheckTest
    {
        /*
    6. Testing Parameterized Tests
Problem:
Create a method IsEven(int number) that returns true if a number is even.
Use NUnit [TestCase] or MSTest [DataRow] to test this method with multiple
values like 2, 4, 6, 7, 9
    */

        [TestCase(2, true)]
        [TestCase(4, true)]
        [TestCase(6, true)]
        [TestCase(7, true)]
        [TestCase(9, true)]
        public void IsEven_TestCases(int input, bool exp)
        {
            NumberCheck nc = new NumberCheck();
            Assert.That(nc.IsEven(input), Is.EqualTo(exp));
        }
    }
}