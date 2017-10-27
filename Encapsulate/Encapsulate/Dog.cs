using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Dog : Animal
    {
        public int TailWagsPerSecod { get; set; }

        public Dog () : base (){ }

        public Dog(bool isCarnivore, int age, string species, int tailWagsPersecond):
            base(isCarnivore, age, species)
        {
            TailWagsPerSecod = tailWagsPersecond;
        }
    }
}
