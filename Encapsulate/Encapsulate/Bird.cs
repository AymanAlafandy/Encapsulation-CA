using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Bird: Animal
    {
        public int SingingDp { get; set; }

        public Bird() : base() { }

        public Bird(String speciesPara , int agePara, bool iscarnivorusPara, int singingDpPara ):
            base(iscarnivorusPara, agePara, speciesPara)
        {
            SingingDp = singingDpPara;
        }



    }
}
