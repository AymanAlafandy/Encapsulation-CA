using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
  public class Horse : Animal
    {
        public bool isFireBreathing { get; set; }

        public Horse() : base() { }

        public Horse(bool iscarnivore, int age, string species,bool isfirebreathing):base (iscarnivore,age,species)
        {
            isFireBreathing = isfirebreathing;

        }
    }
}
