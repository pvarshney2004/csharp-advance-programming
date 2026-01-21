using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Problems;

namespace Tests
{
    public class DatabaseConnectionTest
    {
        // runs before each test case
        [SetUp]
        public void Setup()
        {
            DatabaseConnection.Connect();
        }

        // test cases
        [Test]
        public void Test1()
        {
            System.Console.WriteLine("Testing case 1...");
        }
        [Test]
        public void Test2()
        {
            System.Console.WriteLine("Testing case 2...");
        }

        // runs after each test case
        [TearDown]
        public void TearDown()
        {
            DatabaseConnection.Disconnect();
        }
    }
}