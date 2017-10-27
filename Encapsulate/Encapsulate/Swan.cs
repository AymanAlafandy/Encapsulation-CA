using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    class Swan:Bird
    {
        public  int Levelofrage { get; set; }

        public Swan() : base() { }

        public Swan(bool iscarnivore, int age, string species, int singingDB,int levelofrage):base (iscarnivore,age,species,singingDB)

        {
            Levelofrage = levelofrage;
                }

    }
}
