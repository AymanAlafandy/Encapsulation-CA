using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Pelican: Bird
    {
        public int IsCementMixer { get; set; }

        public Pelican() : base() { }
        public Pelican(bool isCarnivore, int age,
            string species, int singingDb, int isCementMixer) : 
            base(isCarnivore, age, species, singingDb)
        {
            IsCementMixer = isCementMixer;
        }
}
}
