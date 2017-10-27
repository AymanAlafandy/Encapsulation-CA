using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
     public class Animal
    {
        public bool Carnivore { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }

        public Animal (bool carnivore, int age, string species)
        {
            Carnivore = carnivore;
            Age = age;
            Species = species; 
        }
    }
}
