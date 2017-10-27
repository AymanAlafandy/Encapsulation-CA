using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
   public class Dog:Animal
    {
        public int TailWagPerSecond { get; set; }

        public Dog() : base() { }

        public Dog(bool iscarnivore, int age, string species,int tailwagpersecond):base (iscarnivore,age,species)
        {
                        TailWagPerSecond = tailwagpersecond;
        }


    }
}
