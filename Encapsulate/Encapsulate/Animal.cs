using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Animal
    {
        public bool IsCarnivore { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }

        public Animal() { }

        public Animal (bool isCarnivore, int age, string species)
        {
            IsCarnivore = isCarnivore;
            Age = age;
            Species = species;
        }
        public virtual string Stats()
        {
            return "\n Species: " + Species +"\n IsCarnivore: " + IsCarnivore + "\n Age: " + Age ;
        }

    }
}
