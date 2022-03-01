using CodeToTest;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        //Greeting
        [TestCase(0)]
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

        [Category("Extreme cases")]
        [TestCase(0, "U & PG films are available.")]
        [TestCase(1000, "All films are available.")]


        public void GivenAnAge_AvailableClassifications_ReturnsCorrectClassification(int ageOfViewer, string result)
        {
                Assert.That(result,Is.EqualTo(Program.AvailableClassifications(ageOfViewer)));
                    
        }
    
        // -------------------------------------------------------
        // Exception handling tests

        [TestCase(-23)]
        [TestCase(-40)]
        public void WhenTimeIsOutOfBounds_Greeting_ThrowsTimeNotApplicableException(int time) {
            Assert.That(() => Program.Greeting(time), Throws.TypeOf<TimeNotApplicableException>().With.Message.Contains("Time is out of bounds. Please enter a time between 0-24."));
        }
        
        [TestCase(-2)]
        [TestCase(-100)]
        public void WhenAgeIsOutOfBounds_AvailableClassifications_ClassificationException(int age) {
            Assert.That(() => Program.AvailableClassifications(age), Throws.TypeOf<ClassificationException>().With.Message.Contains("Viewer cannot be less than 0 years of age."));
        }
    
    
    
    
    }   
}