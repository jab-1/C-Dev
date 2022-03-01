using HelloWorld;
using NUnit.Framework;


namespace myConsoleAppTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //arrange
            var val = 10;
            var expected = 100;
            //act
            var actual = Program.NestedForLoopSquared(val);
            //assert
            Assert.That(actual, Is.EqualTo(expected));

        }
    }
}