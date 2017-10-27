using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Swan:Bird
    {
        public int LevelOfRage { get; set; }

        public Swan() : base() { }
        public Swan(bool isCarnivore, int age,
            string species, int singingDb,
            int levelOfRage):
            base(isCarnivore,age,species,singingDb)
        {

            LevelOfRage = levelOfRage;
        }

        public override string Stats()
        {
            return base.Stats() + "\n Is Angry"+
            LevelOfRage;

        }
    }
}
