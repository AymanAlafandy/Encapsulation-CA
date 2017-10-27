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

        public Dog() : base() { }
        public Dog(bool isCarnivore, int age,
            string species, int tailWagsPerSecond) :
            base(isCarnivore, age, species)
        {
            TailWagsPerSecond = tailWagsPerSecond;
        }
        public override string Stats()
        {
            return base.Stats() + "\nTailwags per second: " + TailWagsPerSecond;
        }

        //3.3.12 
        public string Speak()
        {
            return "Woff!";
        }

    }
}
