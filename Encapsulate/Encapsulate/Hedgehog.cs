using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
  public  class Hedgehog  : Animal
    {

        public int NoOfSpikes { get; set; }
        public Hedgehog() : base() { }

        public  Hedgehog(bool iscarnivore,int age, string species,int noofspikes):base (iscarnivore,age, species)
       {
                     NoOfSpikes = noofspikes;
        }

    }
}
