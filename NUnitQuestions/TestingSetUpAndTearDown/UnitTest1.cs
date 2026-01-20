namespace TestingSetUpAndTearDown;

public class Tests
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
