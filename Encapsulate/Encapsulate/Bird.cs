using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
 public class Bird : Animal
    {

        public int SingingDb { get; set; }

        public Bird():base() { }

        public Bird( bool iscarnivore, int age, string species,int singingDB):base (iscarnivore,age,species)
        {
            SingingDb = singingDB;
        }

    }
}
