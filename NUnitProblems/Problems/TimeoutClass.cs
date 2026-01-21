using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problems
{
    public class TimeoutClass
    {
        /*
        7. Performance Testing Using Timeout
Problem:
Create a method LongRunningTask() that sleeps for 3 seconds before returning
a result.
Use NUnit [Timeout(2000)] or MSTest [Timeout(2000)] to fail the test if the
method takes more than 2 seconds.
        */

        public string LongRunningTask()
        {
            Thread.Sleep(3000); // sleeps for 3 seconds
            return "Completed";
        }
    }
}