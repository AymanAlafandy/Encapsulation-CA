using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Bird: Animal
    {
        public int SingingDb { get; set; }

        // it is good to have an empty constructor in our class, and have an empty instance
        public Bird():base() { }

        public Bird ( bool isCarnivore, int age, 
            string species, int singingDb) :
            base(isCarnivore, age, species)
        {
            SingingDb = singingDb;
        }

    }
}
