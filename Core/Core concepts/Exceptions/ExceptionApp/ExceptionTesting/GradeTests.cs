using NUnit.Framework;
using ExceptionApp;

namespace ExceptionTesting
{
    public class GradeTests
    {
        [TestCase(34)]
        [TestCase(1)]
        public void WhenMarkIsLessThanZero_Grade_ThrowsArgumentOutOfRangeException(int mark) {
            //Assert.That(() => Program.Grade(mark),Throws.TypeOf(<ArgumentOutOfRangeException>());
            Assert.That(() => Program.Grade(mark), Throws.TypeOf<GradeException>().With.Message.Contains("allowed range = 0-100"));
        }


        [TestCase(101)]

        public void WhenMarkIsGreaterThanOneHundred_Grade_ThrowsArgumentGreaterThanMaxValue(int mark) { 
        
        }
    }
}