using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Pelican : Bird
    {
        public bool IsCementMixer { get; set; }

        public Pelican():Base() { }

        public Pelican(bool isCarnivore, int age, string species, int singingDb, bool isCementMixer):
            base(isCarnivore, age, species, singingDb)
        {
            IsCementMixer = isCementMixer
        }
    }

}
