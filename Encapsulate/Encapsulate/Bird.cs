using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Bird : Animal
    {
        public int SingingDb { get; set; }

        public Bird():base() { }

        public Bird (bool isCarnivore, int age,
            string species, int singingDb ) :
            base(isCarnivore, age, species)
        {
            SingingDb = singingDb;
        }
        public override string Stats()
        {
            return base.Stats() +"Is Carnivore:" + IsCarnivore +
                "\nAge: " + Age +
                "\nSingingDb" + SingingDb;

        }
    }
}
