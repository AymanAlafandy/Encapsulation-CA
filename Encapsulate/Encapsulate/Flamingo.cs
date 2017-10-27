using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Flamingo: Bird
    {
        public int NrOfLifePartners { set; get; }

        public Flamingo(): base() { }
        public Flamingo(bool isCarnivore, int age, string species, int singingDb, int nrOfLifePartners):
            base(species,age,isCarnivore,singingDb)
        {
            SingingDp = singingDb;
        }

    }
}
