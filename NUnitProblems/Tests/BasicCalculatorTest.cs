using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Problems;

namespace Tests
{
    public class BasicCalculatorTest
    {
        BasicCalculator calc;
        // run once before all tests
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            calc = new BasicCalculator();
        }

        // Test cases
        [Test]
        public void Test1()
        {
            Assert.That(calc.Add(2, 3), Is.EqualTo(5));
        }
        [Test]
        public void Test2()
        {
            Assert.That(calc.Subtract(8, 3), Is.EqualTo(5));
        }
        [Test]
        public void Test3()
        {
            Assert.That(calc.Multiply(2, 3), Is.EqualTo(5));
        }
        [Test]
        public void Test4()
        {
            Assert.That(calc.Division(25, 5), Is.EqualTo(5));
        }
    }
}