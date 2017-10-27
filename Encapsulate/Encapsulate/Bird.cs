using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Bird : Animal
    {
        public int SingingDb { get; set; }

        public Bird():base() { } //good to have an empty constractur
        public Bird(bool isCanivore, int age, string species, int singingDb) : 
            base (isCanivore, age, species)
        {
            SingingDb = singingDb;
        }
    }
}
