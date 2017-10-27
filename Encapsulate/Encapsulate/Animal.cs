using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Animal
    {



        //prop without Fields
        public bool IsCarnivore { set; get; }
        //
        public int Age { set; get; }
        //
        public string Species { set; get; }

        //Struct
        public Animal()
        {

        }
        //
        public Animal(bool CarnivoreStruct, int ageStruct, string speciesStruct)
        {
            IsCarnivore = CarnivoreStruct;
            Age = ageStruct;
            Species = speciesStruct;
        }
    }
}
