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
        //12.
        public virtual string Stats()
        { 
            return "\nIs Carnivore: " + IsCarnivore + "\nAge: " + Age + "\nSpecies: " + Species;
        }  
    }
}
