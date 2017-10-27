using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
   public class Bird : Animal
    {
        public int SingingDB { get; set; }
        public Bird() { } 
        public Bird(bool carnivore, int age, string species, bool singingDB) : base (carnivore,age,species)
        {
            SingingDB = SingingDB;
        }
    }
}
