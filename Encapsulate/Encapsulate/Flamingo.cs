using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Flamingo:Bird
    {


        public int NrOfLifePartners { get; set; }

        public Flamingo() : base()
        { }

        public Flamingo(bool iscarnivore, int age, string species, int singingdb, int nroflifepartners) : base(iscarnivore, age, species, singingdb)
        {
            NrOfLifePartners = nroflifepartners;
        }
    }
}
