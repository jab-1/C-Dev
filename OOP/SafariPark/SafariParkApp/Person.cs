using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Person : IMoveable
    {
        private String _firstName;
        private String _lastName;
        //public int Age { get;  set; }
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Cannot have age less than 0");

                }
                else
                {
                    _age = value;
                }
            }
        }

        public Person(String firstName, String lastName, int age = 0)
        {
            _firstName = firstName;
            _lastName = lastName;
            Age = age;
        }
        
        public Person(String firstName)
        {
            _firstName = firstName;
        }

        public String GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

        public string Move()
        {
            return $"Walking along";
        }

        public string Move(int times)
        {
            return $"Walking along {times} times";
        }
    }
}
