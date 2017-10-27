using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Bird : Animal
    {
        public int Singingdb { get; set; }

        public Bird():base()
        { }


        public Bird(bool iscarnivore, int age, string species, int singingdb) : base(iscarnivore, age, species)   //here base()fields are imp to place correcttlyi n a order  
        {
            Singingdb = singingdb;
        }

    }
}
