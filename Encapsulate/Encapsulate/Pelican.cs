using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Pelican: Bird
    {
        public bool IsCementMixer { get; set; }

        public Pelican():base()
        {

        }

        public Pelican(bool isCarnivor, int age, string species, int singingDB, bool isCementMixer)
            :base(isCarnivor,age,species,singingDB)
        {
            IsCementMixer = isCementMixer;
        }

    }
}
