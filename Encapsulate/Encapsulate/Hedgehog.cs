using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Hedgehog : Animal
    {
        public int NrOfRings { get; set; }

        public Hedgehog() : base() { }

        public Hedgehog(bool isCarivore, int age,
            string species, int nrOfRings) :
            base(isCarivore, age, species)
        {
            NrOfRings = nrOfRings;
        }

        public override string stats()
        {
            return base.stats() + "\n Number of rings:" + NrOfRings;
        }
    }
}
