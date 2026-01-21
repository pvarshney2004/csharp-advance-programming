using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Problems;

namespace Tests
{
    public class TimeoutTest
    {
        [Test]
        [Timeout(2000)] // 2 seconds
        public void LongRunningTask_ShouldFail()
        {
            TimeoutClass task = new TimeoutClass();
            Assert.That(task.LongRunningTask(), Is.EqualTo("Completed"));
        }
    }
}