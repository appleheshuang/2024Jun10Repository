using NUnit.Framework;
using TechTalk.SpecFlow;
using System;
using Serilog;

[Binding]
[TestFixture]
public class Plus
{
private TestFixture _testFixture;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _testFixture = new TestFixture();
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        _testFixture.Dispose();
    }

    [Test]
    public void ExampleTest()
    {
        Log.Information("This is a test log message.");
        Assert.Pass();
    }
[Test]
[Given("Test Plus Two Numbers")]
public void PlusTwoNumber()
{
    int a = 10;
    int b = 20;
    int c = a + b;
    Console.WriteLine("cNew = " + c);
    Log.Information("This is a test log message.");
    Assert.Pass();
}
}