using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Hourse : Animal
    {
        public bool IsFrieBreathingBool { set; get; }

        public Hourse(bool isCarnivore, int age,
            string species, bool isFiresBreathing):
            base (isCarnivore,age,species)
        {
            IsFrieBreathingBool = isFiresBreathing;
        }

    }
}
