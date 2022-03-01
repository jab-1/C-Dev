using myConsoleApp;
using NUnit.Framework;


namespace Tests;
//tests must be fast, independent, reliable/repeatable, self-validating, timely
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }
    
    
    [Ignore]
    [Test]
    public void Test1()
    {
        //arrange
        var val = 10;
        var expected = 100;
        //act
        var actual = Program2.NestedForLoopSquared(val);
        //assert
        Assert.That(actual, Is.EqualTo(expected));

    }
}
