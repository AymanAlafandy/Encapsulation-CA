using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Animal
    {   //3.2.2 only creating properties, no fields because our fields don't require additional processing.
        public bool IsCarnivore { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }

        //3.2.3 Constructor for Animal
        public Animal() { }

        public Animal (bool isCarnivore, int age, string species)
        {
            IsCarnivore = isCarnivore;
            Age = age;
            Species = species;
        }

    }
}
