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

        public Flamingo(bool isCarnevore, int age, 
            string species, int singingDb, 
            int nrOfLifePartners):
            base(isCarnevore, age, species, singingDb)
        {
            NrOfLifePartners = nrOfLifePartners;
        }
    }
}
