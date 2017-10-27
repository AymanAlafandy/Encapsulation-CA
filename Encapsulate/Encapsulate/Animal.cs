using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Animal
    {
        //when it is compiled we'll have 2 methods and a priviTE FIELD, so it's not neccesary to have a private field for properties!
        public bool IsCarnivore { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }

        public Animal() { }

        public Animal(bool isCarnivore, int age, string species)
        {
            IsCarnivore = isCarnivore;
            Age = age;
            Species = species;
            //if (IsCarnivore)
            //{

            //}
        }
    }
}
