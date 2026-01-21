using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Problems;

namespace Tests
{
    public class PasswordValidatorTest
    {
        PasswordValidator pv;
        [SetUp]
        public void Setup()
        {
            pv = new PasswordValidator();
        }

        // test cases
        [Test]
        public void Test_For_Correct_Password()
        {
            Assert.That(pv.ValidatePassword("Pvcjb56523"), Is.True);
        }
        [Test]
        public void Test_For_Wrong_Password()
        {
            Assert.That(pv.ValidatePassword("jb56523"), Is.False);
        }
    }
}