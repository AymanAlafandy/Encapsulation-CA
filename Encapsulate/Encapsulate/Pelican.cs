using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    class Pelican:Bird
    {
        public bool IsCementMixer { get; set; }

        public Pelican() : base() { }

        public Pelican(bool iscarnivore, int age, string species, int singingDb, bool isCementMixer) : base(iscarnivore, age, species,singingDb)
        {
            IsCementMixer = isCementMixer;
        }
    }
}

