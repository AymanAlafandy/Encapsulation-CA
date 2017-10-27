using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Swan : Bird
    {
        public int LevelOfRange { get; set; }

        public Swan():base()
        {

        }

        public Swan(bool isCarnivor, int age, string species, int singingDB, int levelOfRange)
            :base(isCarnivor,age,species,singingDB)
        {
            LevelOfRange = levelOfRange;
        }

    }
}
