using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Swan:Bird
    {
        private int levelofrage;
        public int LevelOfRage
        {
            get
            { return levelofrage; }
            set
            {
                if (value > 10)
                {
                    levelofrage = 2;
                }
                else {
                    levelofrage = value;
                }
            }
        }
        public Swan() : base() { }
        public Swan(bool isCarnivore, int age,
            string species, int singingDb,
            int levelOfRage):
            base(isCarnivore,age,species,singingDb)
        {
            LevelOfRage = levelOfRage;
        }
        public override string stats()
        {
            return base.stats() + "\n on a scale of 1-10 how angry it is:" + LevelOfRage;
        }

    }
}
