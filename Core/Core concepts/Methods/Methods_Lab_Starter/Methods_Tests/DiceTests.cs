using NUnit.Framework;
using System;
using Methods_Lib;

namespace Methods_Tests
{
    public class DiceTests
    {

        Random rng = new Random(100);
        //Random rng2 = new Random(50);
        [TestCase(7)]

        public void _RollDice_MustReturnRandomNumber(int expected)
        {
            Assert.That(() => Methods.RollDice(rng), Is.EqualTo(expected));

        }
        [TestCase(13)]
        public void _RollDice_ReturnedValueMustBeUnder13(int expected)
        {
            Assert.That(() => Methods.RollDice(rng), Is.LessThan(expected));

        }
        [TestCase(0)]
        public void _RollDice_ReturnedValueMustBeOver0(int expected)
        {
            Assert.That(() => Methods.RollDice(rng), Is.GreaterThan(expected));

        }

        //public void _RollDice_MustThrow()
        //{
        //    Assert.That(() => Methods.RollDice(rng), Throws.TypeOf<ArgumentException>().With.Message.Contain("Values should be between 1-12."));
        //}
    }
}

