using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp003a.assignment_6
{
    public abstract class Animal
    {
        private string _name;
        private string _species;

        public string Name
        {

            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(_name))//check is name is empty
                {
                    Console.WriteLine("Name cannot be empty or null ");
                }
                _name = value;
            }
        }

        public string Species
        {
            get{ return _species; }
            set
            {
                if (string.IsNullOrEmpty(_species))
                {
                    Console.WriteLine("Name cannot be empty or null ");
                }
                _species = value;
            }
        }

        public abstract void MakeSound();

    }
}
