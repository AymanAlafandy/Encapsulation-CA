using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    class Pelican:Bird
    {
        public  bool isCementMixer { get; set; }

        public Pelican() : base() { }

        public Pelican(bool iscarnivore, int age, string species, int singingDB,bool iscementmixer):base (iscarnivore,age,species,singingDB)

        {
            isCementMixer = iscementmixer;
        }

    }
}
