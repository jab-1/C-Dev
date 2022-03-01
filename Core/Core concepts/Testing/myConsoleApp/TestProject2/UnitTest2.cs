using Greeting;
using NUnit.Framework;

namespace Tests;

public class Tests
{
    // Testing for over 5
    [TestCase(5)]
    [TestCase(7)]
    [TestCase(11)]
    public void TimeBetween5and12(int time) 
    {
        Assert.That("It is the morning.", Is.EqualTo(Program.Greeting(time)));
    }
  
    [Test]
    public void TimeAt12() {
        Assert.That("It is the afternoon.", Is.EqualTo(Program.Greeting(13)));
    }


    
}
