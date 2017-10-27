using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Swan : Bird
    {
        public bool LevelOfRage { get; set; }


        public Swan() { }
        public Swan(bool isCarnivore, int age, string species, int singingDb, bool levelOfRage) :
                base(isCarnivore, age, species, singingDb)
        {
            LevelOfRage = levelOfRage;
        }
    }

}
