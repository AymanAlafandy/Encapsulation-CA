using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
  public  class Flamingo: Bird
    {
        public bool NrOfLifePartners { get; set; }
        public Flamingo() : base() { }

        public Flamingo(bool isCarnivore,int age,string species,int singingDb,bool nrOfLifePartners) : base(isCarnivore, age, species, singingDb)
        {
            NrOfLifePartners = nrOfLifePartners;
        }

    }
}
