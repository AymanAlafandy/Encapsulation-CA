using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    class Swan : Bird
    {
        public int LevelOfRage { get; set; }
        public Swan() : base() { }
        public Swan(bool isCarnivore, int age, string species, int singingDb, int levelOfrage) : 
            base(isCarnivore, age, species, singingDb)
        {
            LevelOfRage = levelOfrage;
        }
    }
}
