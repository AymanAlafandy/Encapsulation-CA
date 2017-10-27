using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Dog: Animal
    {
        public int TailWagsPerSecond { get; set; }
        public Dog() : base()
        {

        }

        public Dog(bool isCarnivor, int age, string species, int tailWagsPerSecond)
            :base(isCarnivor,age,species)
        {
            TailWagsPerSecond = tailWagsPerSecond;
        }
    }
}
