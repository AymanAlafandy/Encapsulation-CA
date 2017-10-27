using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Horse:Animal
    {
     public bool IsFireBreathing { get; set; }        //prop tab+tab will help us to bring syntax of the property

        public Horse() : base()
        { }

        public Horse(bool iscarnivore, int age, string species, bool Isfirebreathing) : base(iscarnivore, age, species)
        {
            IsFireBreathing = Isfirebreathing;
        }

    }
}
