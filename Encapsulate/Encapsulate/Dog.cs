using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    class Dog:Animal
    {
        public int TailWagsPerSecound { get; set; }

        public Dog() : base() { }
        
            public Dog(bool iscarnivore, int age, string species, int tailWagsPerSecond):base(iscarnivore, age, species)
        {
            TailWagsPerSecound = tailWagsPerSecond;
        }
        
    }
}
