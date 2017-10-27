using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Dog : Animal
    {
        public int TailWagsPerSecond { get; set; }

        public Dog() : base()
        { }
        public Dog(bool iscarnivore, int age, string species, int tailwagspersec) : base(iscarnivore, age, species)
        {
            TailWagsPerSecond = tailwagspersec;
        }



    }
}
