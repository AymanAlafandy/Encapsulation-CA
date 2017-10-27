using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Numericputerror : Usererror
    {
        public override string UEMessage()
        {
            return "You try to use a numeric....etc";
        }
    }
}
