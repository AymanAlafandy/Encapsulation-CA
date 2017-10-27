using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    class Flamingo : Bird
    {
        public bool NrOfLifePartners { get; set; }

        public Flamingo() : base() { }

        public Flamingo(bool iscarnivore, int age, string species, int singingDb, bool nrOfLifePartners) : base(iscarnivore, age, species, singingDb)
        {
            NrOfLifePartners = nrOfLifePartners;
        }
    }
    
    }

