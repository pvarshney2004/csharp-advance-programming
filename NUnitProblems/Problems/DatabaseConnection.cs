using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problems
{
    /*
    5. Testing Setup and Teardown (NUnit: [SetUp] & [TearDown])
Problem:
Create a class DatabaseConnection with methods:
● Connect()
● Disconnect()
Use [SetUp] (NUnit) or [TestInitialize] (MSTest) to initialize a database
connection before each test.
Use [TearDown] (NUnit) or [TestCleanup] (MSTest) to close the connection after
each test.
Write test cases to verify that the connection is established and closed
correctly.
    */
    public class DatabaseConnection
    {
        // method to connect database
        public static void Connect()
        {
            System.Console.WriteLine("Database Connected");
        }
        // method to disconnect database
        public static void Disconnect()
        {
            System.Console.WriteLine("Database disconnected");
        }
    }
}