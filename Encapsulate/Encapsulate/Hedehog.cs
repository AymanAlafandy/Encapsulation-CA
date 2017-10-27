using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Hedehog: Animal
    {
        public int NrOfRings { get; set; }
        //
        public Hedehog() : base() { }

        public Hedehog(bool isCarivor, int age, string species, int nrOfRings):
            base(isCarivor, age, species)
        {
            NrOfRings = nrOfRings;
        }

    }
}
