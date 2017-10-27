using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Pelican: Bird
    {
        public bool IsVementMixer { set; get; }

        public Pelican(): base() { }
        public Pelican(bool iscarnivore, int age, string spiceis, int siningnDb ,bool isCementMixer):
            base(spiceis, age, iscarnivore, siningnDb)
        {

        }

    }
}
