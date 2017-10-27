using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Flamingo: Bird
    {
        public int NrOfLifePartners { get; set; }
        public Flamingo() : base() { }
        public Flamingo (bool IsCarnivore, int age, string species, int singingDB, int nrOfLifePartners):
            base (carnivore, age, species, singingDB)
        {
            NrOfLifePartners = NrOfLifePartners;
        }
    }
}
