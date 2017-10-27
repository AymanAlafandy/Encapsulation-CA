using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Flamingo: Bird
    {
        public int NrOfLifePartner { get; set; }

        public Flamingo():base()
        {

        }

        public Flamingo(bool isCarnivor, int age, string species, int singingDB, int nrOfLifePartner)
            :base(isCarnivor,age,species,singingDB)
        {
            NrOfLifePartner = nrOfLifePartner;
        }

    }
}
