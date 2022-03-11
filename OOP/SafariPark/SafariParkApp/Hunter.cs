using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    internal class Hunter : Person, IShootable
    {
        private string _name;
        public IShootable Shooter { get; set; }
        public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName)
        {
            _name = fName;
            Shooter = shooter;
        }

        public string Shoot()
        {
            return$"{_name} has an object! {Shooter.Shoot()}";
        }

        public override string ToString()
        {
            return $"{_name} shot with {Shooter}";
        }
    }
}
