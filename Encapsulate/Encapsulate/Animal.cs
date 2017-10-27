using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Animal
    {
        public bool IsCarnivor { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }

        public Animal()
        {

        }

        public Animal(bool isCarnivor, int age, string species)
        {
            IsCarnivor = isCarnivor;
            Age = age;
            Species = species;
        }
    }
}
