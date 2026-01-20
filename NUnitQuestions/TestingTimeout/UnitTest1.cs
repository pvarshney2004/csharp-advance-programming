namespace TestingTimeout;

public class Tests
{
    [Test]
    [Timeout(2000)] // 2 seconds
    public void LongRunningTask_ShouldFail()
    {
        Timeout task = new Timeout();
        Assert.That(task.LongRunningTask(), Is.EqualTo("Completed"));
    }
}
