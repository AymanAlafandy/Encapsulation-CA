using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Animal
    {
        //private fileds are not necessary required exept we want to add extra code to be sure about something.
        //extra clear to see what is happening.
        public bool IsCarnivore { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }

        //creating constractur.
        public Animal() { }
        public Animal (bool isCarnivore, int age, string species)
        {
            IsCarnivore = isCarnivore;    //the value from carnivore copy to the Carnivore
            Age = age;
            Species = species;
        }
    }
}
