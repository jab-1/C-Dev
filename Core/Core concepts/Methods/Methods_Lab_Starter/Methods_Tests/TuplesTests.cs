using NUnit.Framework;
using Methods_Lib;
using System;

namespace Methods_Tests
{
    public class TuplesTests
    {
        [TestCase(25, 3, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(33, 4, 5)]
        public void GivenANumber_DaysAndWeeks_ReturnsCorrectTuple(
            int totalDays, int expectedWeeks, int expectedDays)
        {
            var answer = Methods.DaysAndWeeks(totalDays);
            Assert.That(answer.weeks, Is.EqualTo(expectedWeeks), "Weeks");
            Assert.That(answer.days, Is.EqualTo(expectedDays), "Days");
        }
        [Test]
        public void GivenANegativeNumber_DaysAndWeeks_ThrowsAnException()
        {
            Assert.That(() => Methods.DaysAndWeeks(-1), Throws.TypeOf<ArgumentOutOfRangeException>()
        .With.Message.Contain("totalDays must not be negative"));
        }
        [TestCase(2, 4, 8, 1.4142135623730951d)]
        [TestCase(4, 16, 64, 2)]
        public void _TuplesTests_MustReturnCorrectTuple(int num, int squared, int cubed, double squareRooted) {

            var ans = Methods.PowersRoot(num);
            Assert.That(ans.square, Is.EqualTo(squared));
            Assert.That(ans.cube, Is.EqualTo(cubed));
            Assert.That(ans.squareRoot, Is.EqualTo(squareRooted));


        }

    }
}