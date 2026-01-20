namespace TestingTemperatureConverter;

public class Tests
{
    TemperatureConverter tc;
    [SetUp]
    public void Setup()
    {
        tc = new TemperatureConverter();
    }

    // test cases
    [Test]
    public void Test_For_Cel_To_Farh()
    {
        Assert.That(tc.CelsiusToFahrenheit(0), Is.EqualTo(32));
    }
    [Test]
    public void Test_For_Farh_To_Cel()
    {
        Assert.That(tc.FahrenheitToCelsius(32), Is.EqualTo(0));
    }
}
