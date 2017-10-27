using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
   public class Swan:Bird
    {
        public bool LevelOfRage{ get; set; }

        public Swan() : base() { }

        public Swan(bool iscarnivore, int age, string species, int singingDb, bool levelOfRage) : base(iscarnivore, age, species,singingDb)
        {
            LevelOfRage = levelOfRage;
        }
    }
}
