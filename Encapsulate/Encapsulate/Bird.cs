using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Bird: Animal
    {
        public int SingingDb { get; set; }

        public Bird():base()
        {

        }

        public Bird(bool isCarnivor, int age, string species, int singingDB)
            :base(isCarnivor,age,species)
        {
            SingingDb = singingDB;
        }
    }
}
