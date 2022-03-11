using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Vehicle : IMoveable
    {
        protected int _capacity;
        private int _numPassengers;
        protected int _position;

        public int NumPassengers
        {
            get { return _numPassengers; }
            set { _numPassengers = value <= _capacity ? _numPassengers = value : _numPassengers = 0; }
        }


        public int Position
        {
            get { return _position; }
            private set { _position = value; }
        }

        public int Speed
        {
            get;
            init;

        } = 10;

        public Vehicle()
        {

        }

        public Vehicle(int capacity, int speed = 10)
        {

            Speed = speed;
            _capacity = capacity;
        }

        public virtual string Move()
        {
            Position += Speed;
            return "Moving along";
        }

        public virtual string Move(int times)
        {
            Position += (Speed * times);
            return $"Moving along {times} times.";
        }

        //public override string ToString()
        //{
        //    return base.ToString() + $" capacity: {_capacity} passengers: {_numPassengers} speed: {Speed} position: {_position}";
        // }

    }
}