using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    class Flamingo:Bird
    {
        public  int Nooflifepartners { get; set; }

        public Flamingo() : base() { }

        public Flamingo(bool iscarnivore, int age, string species, int singingDB,int nooflifepartners):base (iscarnivore,age,species,singingDB)

        {
            Nooflifepartners = nooflifepartners;
        }

    }
}
