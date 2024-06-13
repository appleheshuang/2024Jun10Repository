using NUnit.Framework;
using TechTalk.SpecFlow;
using System;

[Binding]
[TestFixture]
public class Plus
{
[Test]
[Given("Test Plus Two Numbers")]
public void PlusTwoNumber()
{
    int a = 10;
    int b = 20;
    int c = a + b;
    Console.WriteLine("Test Plus Two Log Eva Jun13 " + c);
    Assert.Pass();
}
}