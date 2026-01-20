using NUnit.Framework;
using System.Collections.Generic;

namespace TestingListOperations;

public class Tests
{
    private ListManager lm;
    private List<int> list;

    // run before each test case
    [SetUp]
    public void Setup()
    {
        lm = new ListManager();
        list = new List<int> { 10, 20, 30 };
    }

    // test cases
    [Test]
    public void Test_For_Checking_Add()
    {
        lm.AddElement(list, 4);
        Assert.That(list.Contains(4), Is.True);
    }
    [Test]
    public void Test_For_Checking_Removal()
    {
        lm.RemoveElement(list, 2);
        Assert.That(list.Contains(2), Is.False);
    }

    [Test]
    public void Test_For_Checking_Size()
    {
        Assert.That(lm.GetSize(list), Is.EqualTo(5));
    }
}
