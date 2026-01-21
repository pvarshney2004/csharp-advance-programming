using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Problems;

namespace Tests
{
    public class StringUtilsTest
    {
        // testcases
        [Test]
        public void Test1()
        {
            Assert.That(StringUtils.IsPalindrome("naman"), Is.EqualTo(true));
        }
        [Test]
        public void Test2()
        {
            Assert.That(StringUtils.Reverse("naman"), Is.EqualTo("naman"));
        }
        [Test]
        public void Test3()
        {
            Assert.That(StringUtils.ToUpperCase("naman"), Is.EqualTo("NAMAn"));
        }
    }
}