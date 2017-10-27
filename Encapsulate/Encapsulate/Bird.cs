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
        
        //empty constructor. Its good practice to always add one even if not asked.
        public Bird() : base() { }

        public Bird ( bool isCarnivore, int age,string species, int singingDb) :
            base (isCarnivore, age, species) //this order of fields is important
        {
            SingingDb = singingDb;
        }

    }
}
