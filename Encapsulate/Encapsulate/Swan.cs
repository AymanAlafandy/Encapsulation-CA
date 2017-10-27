using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Swan : Bird
    {
        public int LevelOfRage { get; set; }

        public Swan() : base()
        { }
        public Swan(bool iscarnivore, int age, string species, int singingdb, int levelofrage) : base(iscarnivore, age, species, singingdb)
        {
            LevelOfRage = levelofrage;
        }
    }
}
