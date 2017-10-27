using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Animal
    {
        // no private files because we dont need to access
        public bool IsCanivore { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }

        public Animal() { }
        //animal constructor to take in
        public Animal(bool iscanivore, int age, string species) //instance animal object
        {   
            //value always assign from right and then left
            IsCanivore = iscanivore;
            Age = age;
            Species = species;
        }
    }
}
