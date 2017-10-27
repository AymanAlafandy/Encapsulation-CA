using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    class Hedgehog:Animal
    {
        public int NrOfRings { get; set; }
        public Hedgehog() : base() { }
        public Hedgehog(bool iscarnivore, int age, string species, int nrOfRings) : base(iscarnivore, age, species)
        {
            NrOfRings = nrOfRings;
        }
    }
}
