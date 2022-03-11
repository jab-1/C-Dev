using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Airplane : Vehicle
    {
        private string _airline = "";
        private int capacity;
        public int Altitude
        {
            get;

            private set;

        } = 0;
        public Airplane(int capacity)
        {
            this.capacity = capacity;
        }
        public Airplane(int capacity, int speed, string airline) : base(capacity, speed)
        {
            _airline = airline;
        }

        public void Ascend(int distance)
        {
            Altitude += distance;
        }
        public void Descend(int distance)
        {
            Altitude -= distance;
        }
        public override string Move()
        {
            _position += Speed;
            return $"Moving along at an altitude of {Altitude} meters";
        }

        public override string Move(int times)
        {
            _position += Speed * times;
            return $"Moving along {times} at an altitude {Altitude} meters";
        }

        public override string ToString()
        {
            return $"Thank you for flying {_airline}: {base.ToString()} capacity: {_capacity} passengers: {NumPassengers}: speed: {Speed} position: {Position} altitude: {Altitude}";
        }
    }
}
