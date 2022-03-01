using NUnit.Framework;
using Op_CtrlFlow;
using System.Collections.Generic;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {
        // write unit test(s) for MyMethod here
        [Category("Same numbers")]
        [TestCase(0, 0, false)]
        [TestCase(3, 3, false)]
        [TestCase(4, 4, false)]

        [Category("Not divisible")]
        [TestCase(3, 2, false)]
        [TestCase(3, 6, false)]
        [TestCase(9, 4, false)]

        [Category("Different number and divisble")]
        [TestCase(4, 2, true)]
        [TestCase(6, 3, true)]
        [TestCase(5, 1, true)]

        public void ReturnTrueIfDivisibleAndDifferentNumbers(int num1, int num2, bool expected) {
            Assert.That(Exercises.MyMethod(num1, num2), Is.EqualTo(expected));
        }


        [Test]
        public void Average_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }

        [Test]
        public void WhenListIsEmpty_Average_ReturnsZero()
        {
            var myList = new List<int>() { };
            Assert.That(Exercises.Average(myList), Is.EqualTo(0));
        }

        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void TicketTypeTest(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Category("Edge cases")]
        [TestCase(75, "Pass with Distinction")]
        [TestCase(100, "Pass with Distinction")]
        [TestCase(60, "Pass with Merit")]
        [TestCase(74, "Pass with Merit")]
        [TestCase(40, "Pass")]
        [TestCase(59, "Pass")]
        [TestCase(39, "Fail")]
        [TestCase(0, "Fail")]


        public void GradeTest(int mark, string expected) { 
            Assert.That(Exercises.Grade(mark), Is.EqualTo(expected));
        }
        [Category("0-4 normal values")]
        [TestCase(0,200)]
        [TestCase(1,100)]
        [TestCase(2,50)]
        [TestCase(3,50)]
        [TestCase(4,20)]

        [Category("Out of bounds")]
        [TestCase(-4, -1)]
        [TestCase(6, -1)]

        public void ReturnCorrectAttendees(int level, int expected) {
            Assert.That(Exercises.GetScottishMaxWeddingNumbers(level), Is.EqualTo(expected));       
            
        }

    }
}
