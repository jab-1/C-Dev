using CodeToTest;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        
        [TestCase(5)]
        [TestCase(8)]
        [TestCase(12)]
        [Ignore("Test method incomplete")]
        public void GivenAtimeBetween5and12Inclusive_Greeting_ReturnsGoodMorning(int time)
        {
            Assert.That("Good morning!", Is.EqualTo(Program.Greeting(time)));
        }

        [Category("Edge case")]
        [TestCase(12, "Good morning!")]
        [TestCase(13, "Good afternoon!")]
        public void GivenATime_Greeting_ReturnsCorrectMessage(int time, string expected)
        {
            Assert.That(expected, Is.EqualTo(Program.Greeting(time)));
        }
    }
}