using CodeToTest;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        //Greeting
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
        [Ignore("Only testing classifications")]
        public void GivenATime_Greeting_ReturnsCorrectMessage(int time, string expected)
        {
            Assert.That(expected, Is.EqualTo(Program.Greeting(time)));
        }

        // AvailableClassifications
        [Category("Boundary cases")]
        [TestCase(11, "U & PG films are available.")]
        [TestCase(12, "U, PG & 12 films are available.")]
        [TestCase(14, "U, PG & 12 films are available.")]
        [TestCase(15, "U, PG, 12 & 15 films are available.")]
        [TestCase(17, "U, PG, 12 & 15 films are available.")]
        [TestCase(18, "All films are available.")]
        [TestCase(19, "All films are available.")]

        [Category("Edge cases")]
        [TestCase(0, "U & PG films are available.")]
        [TestCase(1000, "All films are available.")]


        public void GivenAnAge_AvailableClassifications_ReturnsCorrectClassification(int ageOfViewer, string result)
        {
                Assert.That(result,Is.EqualTo(Program.AvailableClassifications(ageOfViewer)));
                    
        }
    
    
    
    
    
    }   
}