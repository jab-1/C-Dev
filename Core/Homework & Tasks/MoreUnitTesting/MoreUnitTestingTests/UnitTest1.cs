using MoreTesting;
using NUnit.Framework;



public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Category("Boundary testing")]
    [TestCase(64, "Fail")]
    [TestCase(65, "Pass")]
    [TestCase(84, "Pass")]
    [TestCase(85, "Distinction")]
    [TestCase(100, "Distinction")]

    [Category("Edge testing")]
    [TestCase(-1000, "Fail")]
    [TestCase(1000, "Distinction")]

    public void ReturnCorrectGrade(int grade, string expected)
    {
        Assert.That(Program.GetGrade(grade), Is.EqualTo(expected));
    }
}
