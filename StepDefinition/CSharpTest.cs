using NUnit.Framework;
using TechTalk.SpecFlow;
using System;

[Binding]
public class Plus
{
[Given("Test Plus Two Numbers")]

public void PlusTwoNumber()
{
    int a = 10;
    int b = 20;
    int c = a + b;
    Console.WriteLine("cNew = " + c);
}
}