using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Horse: Animal
    {
        public bool IsFireBreathing { get; set; }

        public Horse() : base()
        {

        }

        public Horse(bool isCarnivor, int age, string species, bool isFireBreathing)
            :base(isCarnivor,age,species)
        {
            IsFireBreathing = isFireBreathing;
        }
    }
}
