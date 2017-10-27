using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Headgehog: Animal
    {
        public int NrOfRings { get; set; }

        public Headgehog() : base() { }
        public Headgehog(bool isCarnivore, int age,
            string species, int nrOfRings) : 
            base(isCarnivore, age, species)
        {
            NrOfRings = nrOfRings;
        }
    }
}
