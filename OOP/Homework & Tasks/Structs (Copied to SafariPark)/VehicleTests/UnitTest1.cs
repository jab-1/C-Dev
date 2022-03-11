using NUnit.Framework;
using Structs;
namespace VehicleTests
{
    public class Tests
    {
        [Test]
        public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.AreEqual(20, v.Position);
            Assert.AreEqual("Moving along 2 times.", result);
        }
        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            Vehicle v = new Vehicle(5, 40);
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along", result);
        }
        [Test]
        public void WhenAVehicleWithSpeed100IsMovedThreeTimesItsPositionIs300()
        {
            Vehicle v = new Vehicle(5, 100);
            var result = v.Move(3);
            Assert.AreEqual(300, v.Position);
            
        }
        [TestCase(0,1,0)]
        [TestCase(5, 14, 0)]
        [TestCase(10, 11, 0)]
        [TestCase(2, 100, 0)]
        public void WhenCapacityIsLessThanTheNumPassengersItShouldRemain0(int capacity, int passengers, int expected)
        {
            Vehicle v = new Vehicle(capacity,10);
            v.NumPassengers = passengers;
            Assert.AreEqual(expected, v.NumPassengers);

            //Vehicle v = new Vehicle(capacity, 10);
            //if (v.NumPassengers <= capacity)
            //{
            //    Assert.Pass();
            //}
            //else if(v.NumPassengers > capacity)
            //{
            //    Assert.Equals(v.NumPassengers, 0);
            //}
            //else
            //{
            //    Assert.Fail("NumPassengers is more than the capacity limit.");
            //}
        }
        //REWRITE THIS TEST



        [Test]
        public void WhenMoving5Times_Move_ShouldReturnCorrectStatement()
        {
            Vehicle v = new Vehicle(0);
            string result = v.Move(5);
            Assert.AreEqual(result,"Moving along 5 times.");

        }

        [Test]
        public void TwoDifferentVehicleInstancesShouldMoveSameAmount()
        {
            var v = new Vehicle(5, 20);
            var y = new Vehicle();
            v.Move();y.Move(2);
            //y must move twice as speed default == 10;
            Assert.AreEqual(v.Position, y.Position);
        }
        //[Test]
        //public void WhenSpeedIsAlreadyInitialisedItCannotBeChanged()
        //{
        //    Vehicle v = new Vehicle(1, 30);
        //    v.Speed = 100;
        //    Assert.That(v.Speed, Is.EqualTo(30));
        //}


    }
}