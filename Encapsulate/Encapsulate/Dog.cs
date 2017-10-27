using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Dog: Animal
    {
        public int TailWagsperSecond { set; get; }

        public Dog() : base() { }
        public Dog(bool isCarnivore, int age, string species, int tailwagsPerSecond):
            base(isCarnivore, age, species)
        {
            TailWagsperSecond = tailwagsPerSecond;
        }
    }
}
