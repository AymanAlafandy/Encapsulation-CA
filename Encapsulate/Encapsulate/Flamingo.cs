using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Flamingo : Bird
    {
        public int NrOfLifePartners { get; set; }
        public Flamingo() : base() { }
        public Flamingo(bool isCarnivore, int age,
            string species, int singingDb,
            int nrOfLifePartners):
            base(isCarnivore, age,species, singingDb)
        {
            NrOfLifePartners = nrOfLifePartners;
        }

        public override string Stats()
        {
            return base.Stats() + "\n nrOfLifePartners:" + NrOfLifePartners;
        }
    }
}
